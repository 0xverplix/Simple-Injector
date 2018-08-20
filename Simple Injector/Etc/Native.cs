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

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint SuspendThread(IntPtr hThread);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetThreadContext(IntPtr hThread, ref Context lpContext);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetThreadContext(IntPtr hThread, ref Context lpContext);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint ResumeThread(IntPtr hThread);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        #endregion
        
        #region Context
        
        // Referenced from https://www.pinvoke.net/default.aspx/kernel32.GetThreadContext

        [StructLayout(LayoutKind.Explicit, Size = 1232)]
        public struct Context
        {
            // Register Parameter Home Addresses
            
            [FieldOffset(0x0)] ulong P1Home;
 
            [FieldOffset(0x8)] ulong P2Home;
 
            [FieldOffset(0x10)] ulong P3Home;
 
            [FieldOffset(0x18)] ulong P4Home;
 
            [FieldOffset(0x20)] ulong P5Home;
 
            [FieldOffset(0x28)] ulong P6Home;
 
            // Control Flags
            
            [FieldOffset(0x30)] uint ContextFlags;
 
            [FieldOffset(0x34)] uint MxCsr;
 
            // Segment Registers and Processor Flags
            
            [FieldOffset(0x38)] ushort SegCs;
 
            [FieldOffset(0x3a)] ushort SegDs;
 
            [FieldOffset(0x3c)] ushort SegEs;
 
            [FieldOffset(0x3e)] ushort SegFs;
 
            [FieldOffset(0x40)] ushort SegGs;
 
            [FieldOffset(0x42)] ushort SegSs;
 
            [FieldOffset(0x44)] uint EFlags;
 
            // Debug Registers
            
            [FieldOffset(0x48)] ulong Dr0;
 
            [FieldOffset(0x50)] ulong Dr1;
 
            [FieldOffset(0x58)] ulong Dr2;
 
            [FieldOffset(0x60)] ulong Dr3;
 
            [FieldOffset(0x68)] ulong Dr6;
 
            [FieldOffset(0x70)] ulong Dr7;
 
            // Integer Registers
            
            [FieldOffset(0x78)] ulong Rax;
 
            [FieldOffset(0x80)] ulong Rcx;
 
            [FieldOffset(0x88)] ulong Rdx;
 
            [FieldOffset(0x90)] ulong Rbx;
 
            [FieldOffset(0x98)] ulong Rsp;
 
            [FieldOffset(0xa0)] ulong Rbp;
 
            [FieldOffset(0xa8)] ulong Rsi;
 
            [FieldOffset(0xb0)] ulong Rdi;
 
            [FieldOffset(0xb8)] ulong R8;
 
            [FieldOffset(0xc0)] ulong R9;
 
            [FieldOffset(0xc8)] ulong R10;
 
            [FieldOffset(0xd0)] ulong R11;
 
            [FieldOffset(0xd8)] ulong R12;
 
            [FieldOffset(0xe0)] ulong R13;
 
            [FieldOffset(0xe8)] ulong R14;
 
            [FieldOffset(0xf0)] ulong R15;
 
            // Program Counter
            
            [FieldOffset(0xf8)] ulong Rip;
 
            // Floating Point State
            
            [FieldOffset(0x100)] ulong FltSave;
 
            [FieldOffset(0x120)] ulong Legacy;
 
            [FieldOffset(0x1a0)] ulong Xmm0;
 
            [FieldOffset(0x1b0)] ulong Xmm1;
 
            [FieldOffset(0x1c0)] ulong Xmm2;
 
            [FieldOffset(0x1d0)] ulong Xmm3;
 
            [FieldOffset(0x1e0)] ulong Xmm4;
 
            [FieldOffset(0x1f0)] ulong Xmm5;
 
            [FieldOffset(0x200)] ulong Xmm6;
 
            [FieldOffset(0x210)] ulong Xmm7;
 
            [FieldOffset(0x220)] ulong Xmm8;
 
            [FieldOffset(0x230)] ulong Xmm9;
 
            [FieldOffset(0x240)] ulong Xmm10;
 
            [FieldOffset(0x250)] ulong Xmm11;
 
            [FieldOffset(0x260)] ulong Xmm12;
 
            [FieldOffset(0x270)] ulong Xmm13;
 
            [FieldOffset(0x280)] ulong Xmm14;
 
            [FieldOffset(0x290)] ulong Xmm15;
 
            // Vector Registers
            
            [FieldOffset(0x300)] ulong VectorRegister;
 
            [FieldOffset(0x4a0)] ulong VectorControl;
 
            // Special Debug Control Registers
            
            [FieldOffset(0x4a8)] ulong DebugControl;
 
            [FieldOffset(0x4b0)] ulong LastBranchToRip;
 
            [FieldOffset(0x4b8)] ulong LastBranchFromRip;
 
            [FieldOffset(0x4c0)] ulong LastExceptionToRip;
 
            [FieldOffset(0x4c8)] ulong LastExceptionFromRip;
        }

        public enum ContextFlags : uint
        {
            Contexti386 = 0x10000,
            ContextControl = Contexti386 | 0x01,
            ContextInteger = Contexti386 | 0x02,
            ContextSegments = Contexti386 | 0x04,
            ContextFull = ContextControl | ContextInteger | ContextSegments
        }
        
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
            AllAccess = Commit | Reserve
            
        }

        public enum MemoryProtection
        {
            ReadWrite = 0x04  
        }
        

        #endregion
    }
}