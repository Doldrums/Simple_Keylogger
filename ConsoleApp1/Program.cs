using System;
using System.Windows;
using System.Diagnostics;
//using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Threading;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Permissions;


namespace ConsoleApplication1
{
    class Program
    {
        // инициализируем параметры

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_SYSKEYUP = 0x0105;
        private const int WM_SYSKEYDOWN = 0x0104;
        public const int KF_REPEAT = 0X40000000;
        private const int VK_SHIFT = 0x10;	// SHIFT
        private const int VK_CONTROL = 0x11;	// CONTROL
        private const int VK_MENU = 0x12; // ALT
        private const int VK_CAPITAL = 0x14; // CAPS LOCK

        //private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public static string mss;
        public static int myi = 0;

        [STAThread]
        static void Main(string[] args) {
            var handle = GetConsoleWindow();
        }
    }
}
