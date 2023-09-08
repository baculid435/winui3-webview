using System;
using System.Runtime.InteropServices;

namespace WinUIDesktop
{
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("912b34a7-d10b-49c4-af18-7cb7e604e01a")]
    public interface ICoreWebView2Interop
    {
        // IDL: HRESULT AddHostObjectToScript([in] LPCWSTR name, [in] VARIANT* object);
        void AddHostObjectToScript([In] string name, [In] ref object obj);
    }
}
