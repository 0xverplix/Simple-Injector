using System;
using System.Runtime.InteropServices;

namespace Simple_Injector.Etc
{
    public static class Native
    {
        #region Api Imports
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(ProcessPrivileges dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, MemoryAllocation flAllocationType, MemoryProtection flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
        
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern IntPtr WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr handle);
        
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, MemoryAllocation dwFreeType);

        #endregion
        

        #region Permissions

        public enum ProcessPrivileges
        {
            CreateThread = 0x02,
            QueryInformation = 0x0400,
            VmOperation = 0x08,
            VmWrite = 0x0020,
            VmRead = 0x0010,
            AllAccess = CreateThread | QueryInformation | VmOperation | VmWrite | VmRead
            
        }
        
        public enum MemoryAllocation
        {
            Commit = 0x1000,
            Reserve = 0x2000,
            Release = 0x8000,
            AllAccess = Commit | Reserve
            
        }

        public enum MemoryProtection
        {
            ReadWrite = 0x04  
        }
        

        #endregion
    }
}