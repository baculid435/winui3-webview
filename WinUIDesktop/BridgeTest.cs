using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinUIDesktop
{
    // The.NET version of CoreWebView2.AddHostObjectToScript currently relies on the host object
    // implementing IDispatch and so uses the deprecated ClassInterfaceType.AutoDual feature of.NET.
    // This may change in the future, see https://github.com/MicrosoftEdge/WebView2Feedback/issues/517
    // for more information
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class BridgeTest
    {
        public BridgeTest() { }

        public string CallHandler(string args)
        {
            return string.Empty;
        }

        // Sample property.
        public string Prop { get; set; } = "Example property from host object";

    }
}
