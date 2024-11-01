﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

public class StringAddress
{
    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll")]
    public static extern IntPtr VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public uint AllocationProtect;
        public IntPtr RegionSize;
        public uint State;
        public uint Protect;
        public uint Type;
    }

    public static void Change(string addressIP)
    {
        string processName = "process_name_here";
        string searchString = addressIP; // this value is the user server-ip value at the GUI screen
        string replaceString = "127.0.0.1";

        Process targetProcess = Process.GetProcessesByName(processName).FirstOrDefault();

        if (targetProcess == null)
        {
            Console.WriteLine("No process with the name found.");
            return;
        }

        IntPtr processHandle = OpenProcess(0x001F0FFF, false, targetProcess.Id);

        if (processHandle == IntPtr.Zero)
        {
            Console.WriteLine("Failed to open process.");
            return;
        }

        IntPtr address = IntPtr.Zero;
        MEMORY_BASIC_INFORMATION memoryInfo;

        while (true)
        {
            while (VirtualQueryEx(processHandle, address, out memoryInfo, (uint)Marshal.SizeOf(typeof(MEMORY_BASIC_INFORMATION))) != IntPtr.Zero)
            {
                if (memoryInfo.State == 0x1000 && (memoryInfo.Protect == 0x04 || memoryInfo.Protect == 0x40 || memoryInfo.Protect == 0x02 || memoryInfo.Protect == 0x08 || memoryInfo.Protect == 0x10))
                {
                    byte[] buffer = new byte[(int)memoryInfo.RegionSize];
                    int bytesRead = 0;

                    if (ReadProcessMemory(processHandle, memoryInfo.BaseAddress, buffer, (uint)memoryInfo.RegionSize, out bytesRead))
                    {
                        int index = FindBytes(buffer, Encoding.ASCII.GetBytes(searchString));
                        while (index != -1)
                        {
                            byte[] replaceBuffer = Encoding.ASCII.GetBytes(replaceString.PadRight(searchString.Length, '\0'));
                            WriteProcessMemory(processHandle, IntPtr.Add(memoryInfo.BaseAddress, index), replaceBuffer, (uint)replaceBuffer.Length, out int bytesWritten);
                            index = FindBytes(buffer, Encoding.ASCII.GetBytes(searchString), index + replaceBuffer.Length);
                        }
                    }
                }

                address = IntPtr.Add(memoryInfo.BaseAddress, (int)memoryInfo.RegionSize);
            }

            // Sleep for a short interval before checking again
            Thread.Sleep(1000);
            address = IntPtr.Zero; // Reset address for next iteration
        }
    }

    private static int FindBytes(byte[] haystack, byte[] needle, int startIndex = 0)
    {
        for (int i = startIndex; i <= haystack.Length - needle.Length; i++)
        {
            bool found = true;
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                return i;
            }
        }
        return -1;
    }
}
