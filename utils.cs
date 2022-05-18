using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using IWshRuntimeLibrary;

using System;
namespace mw.utils {
    public class base64 { 
        public static string decode(string input) {
            byte[] encodedBytes = System.Convert.FromBase64String(input);
            return System.Text.Encoding.UTF8.GetString(encodedBytes);
        }
        public static string encode(string input) {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return System.Convert.ToBase64String(bytes);
        }
        [return: MaybeNull]
        public static string encodedBytes(string input) {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return bytes.ToString();
        }

        public static byte[] decodedBytes(string input) {
            byte[] bytes = System.Convert.FromBase64String(input);
            return bytes;
        }
    }

    public class util_functions {
        public static string GetCurrentPath()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }
        public static void makeShortcut(string path, string target) {
            var shell = new WshShell();
            var windowsApplicationShortcut = (IWshShortcut)shell.CreateShortcut(path);
            windowsApplicationShortcut.Description = "How to create short for application example";
            windowsApplicationShortcut.TargetPath = path;
            windowsApplicationShortcut.Save();
        }

    }
    
}