using System;
using System.Diagnostics;
using System.Text;
using static Simple_Injector.Logger;
using static Simple_Injector.Etc.Native;

namespace Simple_Injector
{
    public class Injector
    {
        private readonly IStatusLogger _statusLogger;

        public Injector(IStatusLogger statusLogger)
        {
            _statusLogger = statusLogger;
        }

        public void Inject(string processName, string dllPath)
        {           
            // Get the process id
            
            var processId = Process.GetProcessesByName(processName)[0].Id;    
                
            // Get the Load Library Pointer
            
            var loadLibraryA = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            if (loadLibraryA == IntPtr.Zero)
            {
                _statusLogger.LogStatus("Failed to find kernel32.dll");
            }

            else
            {
                _statusLogger.LogStatus("Successfully loaded kernel32.dll");
            }
                        
            // Get the handle for the process
            
            var processHandle = OpenProcess(ProcessPrivileges.AllAccess, false, processId);

            if (processHandle == IntPtr.Zero)
            {
                _statusLogger.LogStatus("Failed to get process handle");
            }
            
            else
            {
                _statusLogger.LogStatus("Successfully found process handle");
            }    
            
            // Allocate memory in the process
            
            var memoryPointer = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)(dllPath.Length + 1), MemoryAllocation.AllAccess, MemoryProtection.ReadWrite);
            
            if (memoryPointer == IntPtr.Zero)
            {
                _statusLogger.LogStatus("Failed to allocate memory");
            }

            else
            {
                _statusLogger.LogStatus("Successfully allocated memory");
            }

            // Write memory in the process

            if (!WriteProcessMemory(processHandle, memoryPointer, Encoding.Default.GetBytes(dllPath), (uint)(dllPath.Length + 1), 0))
            {
                _statusLogger.LogStatus("Failed to write memory");
            }

            else
            {
                _statusLogger.LogStatus("Successfully wrote memory");
            }

            // Create a thread to call LoadLibraryA in the process

            var threadHandle = CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryA, memoryPointer, 0, IntPtr.Zero);
            
            if (threadHandle == IntPtr.Zero)
            {
                _statusLogger.LogStatus("Failed to create remote thread");
            }

            else
            {
                _statusLogger.LogStatus("Successfully created remote thread");
                
                _statusLogger.LogStatus("Successfully injected DLL");
            }
        }
    }
}
