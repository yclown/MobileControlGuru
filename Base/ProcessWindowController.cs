using MobileControlGuru.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace MobileControlGuru.Base
{
    public class ProcessWindowController
    {
        [DllImport("user32.dll")]
        public static extern bool SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")]
        public static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        [DllImport("user32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        public static extern bool UnhookWinEvent(IntPtr hWinEventHook); 
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left; //最左坐标
            public int Top; //最上坐标
            public int Right; //最右坐标
            public int Bottom; //最下坐标
        }

        public const uint WINEVENT_OUTOFCONTEXT = 0;
        public const uint EVENT_SYSTEM_FOREGROUND = 3;
        public const int SW_MINIMIZE = 6;
        public const uint EVENT_OBJECT_LOCATIONCHANGE = 0x800B;
        public const uint EVENT_SYSTEM_DESKTOPSWITCH = 0x0020;

        public delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);


      

        public static void MinimizeProcessWindow(int processId)
        {
            // 获取进程的主窗口句柄
            IntPtr hWnd = Process.GetProcessById(processId).MainWindowHandle;

            // 如果找到了窗口句柄
            if (hWnd != IntPtr.Zero)
            {
                // 将窗口最小化
                ShowWindow(hWnd, SW_MINIMIZE);
            }
            else
            {
                Console.WriteLine($"无法找到进程ID {processId} 的主窗口");
            }
        }
        public static string GetWindowTitle(int processId)
        {
            // 获取进程的主窗口句柄
            IntPtr hWnd = Process.GetProcessById(processId).MainWindowHandle;

            // 创建一个StringBuilder来存储窗口标题
            var sb = new StringBuilder(256);

            // 如果找到了窗口句柄
            if (hWnd != IntPtr.Zero)
            {
                // 获取窗口标题
                int length = GetWindowText(hWnd, sb, sb.Capacity);
                if (length > 0)
                {
                    return sb.ToString();
                }
                else
                {
                    Console.WriteLine("无法获取窗口标题");
                }
            }
            else
            {
                Console.WriteLine($"无法找到进程ID {processId} 的主窗口");
            }

            return null;
        }

        

        

    }
}
