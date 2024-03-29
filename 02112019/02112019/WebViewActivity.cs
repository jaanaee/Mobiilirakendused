﻿using System;
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
    [Activity(Label = "WebViewActivity")]
    public class WebViewActivity : Activity
    {
        WebView _webView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.webview_layout);
            _webView = FindViewById<WebView>(Resource.Id.webView1);

            _webView.Settings.JavaScriptEnabled = true;
            _webView.SetWebViewClient(new SimpleWebviewClient());
            _webView.LoadUrl("https://www.google.com");
                        
        }

        public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            if(keyCode == Keycode.Back && _webView.CanGoBack())
            {
                _webView.GoBack();
                return true;
            }

            return base.OnKeyDown(keyCode, e);
        }
    }
}