using SkiaSharp;
using SkiaSharp.Views.Maui;
using SkiaSharp.Views.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.CustomControls
{
    public class CustomProgressBar : SKCanvasView
    {
        // actual canvas instance to draw on
        private SKCanvas _canvas;

        // rectangle which will be used to draw the Progress Bar
        private SKRect _drawRect;

        // holds information about the dimensions, etc.
        private SKImageInfo _info;

        public float Progress
        {
            get => (float)GetValue(ProgressProperty);
            set => SetValue(ProgressProperty, value);
        }

        public Color ProgressColor
        {
            get => (Color)GetValue(ProgressColorProperty);
            set => SetValue(ProgressColorProperty, value);
        }

        public Color BaseColor
        {
            get => (Color)GetValue(BaseColorProperty);
            set => SetValue(BaseColorProperty, value);
        }

        public static readonly BindableProperty ProgressProperty = BindableProperty.Create(
            nameof(Progress), typeof(float), typeof(ProgressBar), 0.0f, propertyChanged: OnBindablePropertyChanged);

       
        public static readonly BindableProperty ProgressColorProperty = BindableProperty.Create(
            nameof(ProgressColor), typeof(Color), typeof(ProgressBar), Colors.Orange, propertyChanged: OnBindablePropertyChanged);

        public static readonly BindableProperty BaseColorProperty = BindableProperty.Create(
            nameof(BaseColor), typeof(Color), typeof(ProgressBar), Colors.LightGray, propertyChanged: OnBindablePropertyChanged);

        private static void OnBindablePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((CustomProgressBar)bindable).InvalidateSurface();
        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);

            _canvas = e.Surface.Canvas;
            _canvas.Clear(); // clears the canvas for every frame
            _info = e.Info;
            _drawRect = new SKRect(0, 0, _info.Width, _info.Height);

            DrawBase();
        }

        private void DrawBase()
        {
            using var basePath = new SKPath();

            basePath.AddRect(_drawRect);

            _canvas.DrawPath(basePath, new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = BaseColor.ToSKColor(),
                IsAntialias = true
            });
        }

        private void DrawProgress()
        {
            using var progressPath = new SKPath();

            var progressRect = new SKRect(0, 0, _info.Width * Progress, _info.Height);

            progressPath.AddRect(progressRect);

            _canvas.DrawPath(progressPath, new SKPaint
            {
                Style = SKPaintStyle.Fill,
                IsAntialias = true,
                Color = ProgressColor.ToSKColor()
            });
        }

    }
}
