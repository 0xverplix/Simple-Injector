﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using static Simple_Injector.Logger;

namespace Simple_Injector
{
    public class Injector
    {
        // DLL imports

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        // Privileges 

        private const int ProcessCreateThread = 0x0002;
        private const int ProcessQueryInformation = 0x0400;
        private const int ProcessVmOperation = 0x0008;
        private const int ProcessVmWrite = 0x0020;
        private const int ProcessVmRead = 0x0010;
        private const int ProcessAllAccess = ProcessCreateThread | ProcessQueryInformation | ProcessVmOperation | ProcessVmWrite | ProcessVmRead;

        // Memory Allocation

        private const uint MemoryCommit  = 0x00001000;
        private const uint MemoryReserve  = 0x00002000;
        private const uint PageReadWrite  = 4;

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
            
            var processHandle = OpenProcess(ProcessAllAccess, false, processId);

            if (processHandle == IntPtr.Zero)
            {
                _statusLogger.LogStatus("Failed to get process handle");
            }
            
            else
            {
                _statusLogger.LogStatus("Successfully found process handle");
            }    
            
            // Allocate memory in the process
            
            var memoryPointer = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)(dllPath.Length + 1), MemoryCommit | MemoryReserve, PageReadWrite);
            
            if (memoryPointer == IntPtr.Zero)
            {
                _statusLogger.LogStatus("Failed to allocate memory");
            }

            else
            {
                _statusLogger.LogStatus("Successfully allocated memory");
            }
            
            // Write memory in the process
            
            if (WriteProcessMemory(processHandle, memoryPointer, Encoding.Default.GetBytes(dllPath), (uint)(dllPath.Length + 1), 0) == 0)
            {
                _statusLogger.LogStatus("Failed to write memory");
            }

            else
            {
                _statusLogger.LogStatus("Successfully wrote memory");
            }

            // Create a thread to call LoadLibraryA in the process
            
            if (CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryA, memoryPointer, 0, IntPtr.Zero) == IntPtr.Zero)
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
