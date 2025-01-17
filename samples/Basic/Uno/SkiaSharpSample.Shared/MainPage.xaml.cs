﻿using Windows.Graphics.Display;
#if WINUI
using Microsoft.UI.Xaml.Controls;
#else
using Windows.UI.Xaml.Controls;
#endif
using SkiaSharp;
using SkiaSharp.Views.UWP;

namespace SkiaSharpSample
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
		{
			// the the canvas and properties
			var canvas = e.Surface.Canvas;

			// make sure the canvas is blank
			canvas.Clear(SKColors.White);

			// draw some text
			var paint = new SKPaint
			{
				Color = SKColors.Black,
				IsAntialias = true,
				Style = SKPaintStyle.Fill,
				TextAlign = SKTextAlign.Center,
				TextSize = 24
			};
			var coord = new SKPoint(e.Info.Width / 2, (e.Info.Height + paint.TextSize) / 2);
			canvas.DrawText("SkiaSharp", coord, paint);
		}
	}
}
