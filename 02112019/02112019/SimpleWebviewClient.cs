using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace _02112019
{
    public class SimpleWebviewClient : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)  //vt. Android.Webkit doku
        {
            view.LoadUrl(request.Url.ToString());  //sebview vahetab lehte ilma välisesse browserisse minemast

            return base.ShouldOverrideUrlLoading(view, request);
        }
    }
}