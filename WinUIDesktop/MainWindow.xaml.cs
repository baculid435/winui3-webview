using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT;

namespace WinUIDesktop
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            InitiliazeWebView2Async();
        }

        private async void InitiliazeWebView2Async()
        {
            await WebView2.EnsureCoreWebView2Async();

            WebView2.Source = new Uri("https://google.com");
            var coreWebView2 = WebView2.CoreWebView2;

            //var interop = coreWebView2.As<ICoreWebView2Interop>();
            //interop.AddHostObjectToScript("Bridge", new Bridge());

            var bridge = new BridgeComponent.Bridge();
            //bridge.MyProperty = 2;

            var dispatchAdapter = new WinRTAdapter.DispatchAdapter();
            coreWebView2
                .AddHostObjectToScript("Windows",
                    dispatchAdapter.WrapNamedObject("Windows", dispatchAdapter));
            coreWebView2
                .AddHostObjectToScript("Bridge",
                    dispatchAdapter.WrapObject(bridge, dispatchAdapter));

            coreWebView2.OpenDevToolsWindow();
        }
    }
}
