using System;
using System.Linq;

namespace Simple_Injector.Etc
{
    // Shellcode referenced from https://github.com/vmcall/loadlibrayy/blob/master/Shellcodes/threadhijack_loadlibrary_x64.asm
    
    public static class Shellcode
    {
        private static byte[] ReplaceBytes(byte[] sourceArray, int offset, params byte[] bytes)
        {
            foreach (var index in Enumerable.Range(0, bytes.Length - 1))
            {
                sourceArray[offset + index] = bytes[index];
            }

            return sourceArray;
        }
        
        public static byte[] LoadLibrary(ulong imagePathPointer, ulong loadLibraryPointer)
        {
            // Build the shellcode
            
            var shellcode = new byte[]
            {
                0x9C, 0x50, 0x53, 0x51, 0x52, 0x41, 0x50, 0x41, 0x51, 0x41, 0x52, 0x41, 0x53, // push     Registers
                0x48, 0x83, 0xEC, 0x28,                                                       // sub      RSP, 0x28
                0x48, 0xB9, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,                   // movabs   RCX, 0x0000000000000000 (Image path)
                0x48, 0xB8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,                   // movabs   RAX, 0x0000000000000000 (LoadLibrary)
                0xFF, 0xD0,                                                                   // call     RAX
                0x48, 0x83, 0xC4, 0x28,                                                       // add      RSP, 0x28
                0x41, 0x5B, 0x41, 0x5A, 0x41, 0x59, 0x41, 0x58, 0x5A, 0x59, 0x5B, 0x58,0x9D,  // pop      Registers
                0xC3                                                                          // ret
            };
            
            // Write the pointers into the shellcode

            shellcode = ReplaceBytes(shellcode, 19, BitConverter.GetBytes(imagePathPointer));
            
            shellcode = ReplaceBytes(shellcode, 29, BitConverter.GetBytes(loadLibraryPointer));

            return shellcode; 
        }
    }
}