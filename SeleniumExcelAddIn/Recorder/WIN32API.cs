﻿// <auto-generated />
// Copyright (c) 2014 Takashi Yoshizawa

using System;
using System.Runtime.InteropServices;
using System.Text;
using Accessibility;

namespace SeleniumExcelAddIn.Recorder
{
    internal static class WIN32API
    {
        #region Constants

        public const int URLMON_OPTION_USERAGENT = 0x10000001;
        public const int BM_CLICK = 0x00F5;
        public const int CHILD_ID_SELF = 0;
        public const int IE_ACTIVE_TAB = 2097154;
        public const int SC_CLOSE = 0xF060;
        public const int SMTO_ABORTIFHUNG = 0x2;
        public const int SRCCOPY = 13369376;
        public const int SW_RESTORE = 9;
        public const int WM_SETTEXT = 0x000c;
        public const int WM_SYSCOMMAND = 0x0112;
        public const uint SWP_NOMOVE = 0x0002;
        public const uint SWP_NOSIZE = 0x0001;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;

        #endregion

        #region Delegates

        public delegate int EnumWindowsDelegate(IntPtr hWnd, int lParam);

        #endregion

        #region Enums

        /// <summary>
        /// Object Identifiers
        /// http://msdn.microsoft.com/en-us/library/windows/desktop/dd373606(v=vs.85).aspx
        /// </summary>
        public enum OBJID : uint
        {
            /// <summary>
            /// The window itself rather than a child object.
            /// </summary>
            OBJID_WINDOW = 0x00000000,
        }

        /// <summary>
        /// The relationship between the specified window and the window whose handle is to be retrieved.
        /// http://msdn.microsoft.com/en-us/library/windows/desktop/ms633515(v=vs.85).aspx
        /// </summary>
        public enum GetWindow_Cmd : uint
        {
            /// <summary>
            /// The retrieved handle identifies the window of the same type that is highest in the Z order.
            /// </summary>
            GW_HWNDFIRST = 0,

            /// <summary>
            /// The retrieved handle identifies the window of the same type that is lowest in the Z order.
            /// </summary>
            GW_HWNDLAST = 1,

            /// <summary>
            /// The retrieved handle identifies the window below the specified window in the Z order.
            /// </summary>
            GW_HWNDNEXT = 2,

            /// <summary>
            /// The retrieved handle identifies the window above the specified window in the Z order.
            /// </summary>
            GW_HWNDPREV = 3,

            /// <summary>
            /// The retrieved handle identifies the specified window's owner window, if any.
            /// </summary>
            GW_OWNER = 4,

            /// <summary>
            /// The retrieved handle identifies the child window at the top of the Z order, if the specified window is a parent window; otherwise, the retrieved handle is NULL.
            /// </summary>
            GW_CHILD = 5,

            /// <summary>
            /// The retrieved handle identifies the enabled popup window owned by the specified window (the search uses the first such window found using GW_HWNDNEXT);
            /// </summary>
            GW_ENABLEDPOPUP = 6
        }

        #endregion

        #region Public Methods

        [DllImport("User32.dll")]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        public static extern int UrlMkSetSessionOption(int dwOption, string str, int nLength, int dwReserved);

        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        public static extern int UrlMkGetSessionOption(int dwOption, StringBuilder pBuffer, int dwBufferLength, ref int pdwBufferLength, int dwReserved);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint flags);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("gdi32.dll")]
        public static extern int BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hwnd);

        public static int AccessibleObjectFromWindow(IntPtr hwnd, OBJID idObject, ref IAccessible acc)
        {
            Guid guid = new Guid("{618736e0-3c3d-11cf-810c-00aa00389b71}"); // IAccessible

            object obj = null;
            int num = AccessibleObjectFromWindow(hwnd, (uint)idObject, ref guid, ref obj);
            acc = (IAccessible)obj;
            return num;
        }

        [DllImport("oleacc.dll")]
        public static extern int AccessibleObjectFromWindow(IntPtr hwnd, uint id, ref Guid iid, [In, Out, MarshalAs(UnmanagedType.IUnknown)] ref object ppvObject);

        [DllImport("oleacc.dll")]
        public static extern int AccessibleChildren(IAccessible paccContainer, int iChildStart, int cChildren, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] object[] rgvarChildren, out int pcObtained);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int SetActiveWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern int EnumWindows(EnumWindowsDelegate lpEnumFunc, int lparam);

        [DllImport("user32.dll")]
        public static extern int EnumChildWindows(IntPtr hWndParent, EnumWindowsDelegate enumFunc, int lparam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        [DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string lclassName, string windowTitle);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindow(IntPtr hWnd, GetWindow_Cmd uCmd);

        [DllImport("user32")]
        public static extern int GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        public static extern bool IsWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("User32.Dll", CharSet = CharSet.Unicode)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder s, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessageTimeoutA")]
        public static extern int SendMessageTimeout(IntPtr hwnd, int msg, int wParam, int lParam, int fuFlags, int uTimeout, out int lpdwResult);

        [DllImport("user32.dll", EntryPoint = "RegisterWindowMessageA")]
        public static extern int RegisterWindowMessage(string lpString);

        [DllImport("OLEACC.dll")]
        public static extern int ObjectFromLresult(int lResult, ref Guid riid, int wParam, ref mshtml.IHTMLDocument2 ppvObject);

        [DllImport("User32.Dll", EntryPoint = "SetWindowText")]
        public static extern void SetWindowText(IntPtr hwnd, string text);

        #endregion

        #region Structs

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        #endregion
    }
}
