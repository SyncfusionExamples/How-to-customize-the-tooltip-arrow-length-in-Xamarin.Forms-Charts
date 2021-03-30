using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ChartSample;
using Com.Syncfusion.Charts;
using Syncfusion.SfChart.XForms.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ChartExt), typeof(ChartSample.Droid.ChartCustomRenderer))]

namespace ChartSample.Droid
{
    public class ChartCustomRenderer : SfChartRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.SfChart.XForms.SfChart> e)
        {
            base.OnElementChanged(e);
            var formsChart = e.NewElement as ChartExt;
            if (Control != null)
            {
                foreach (var behavior in Control.Behaviors)
                {
                    if (behavior is Com.Syncfusion.Charts.ChartTooltipBehavior)
                        (behavior as Com.Syncfusion.Charts.ChartTooltipBehavior).PointerLength = (float)formsChart.PointerLength;
                }
            }
        }
    }
}