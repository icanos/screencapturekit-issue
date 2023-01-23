// This is the main entry point of the application.

using System;
using AppKit;
using ScreenCaptureKit;

NSApplication.Init();

Console.WriteLine("Nu kör vi!");

var test = await SCShareableContent.GetShareableContentAsync(false, true);
foreach (var w in test.Windows)
    Console.WriteLine("Window: " + w.Title);