using ChartSample;
using Foundation;
using Syncfusion.SfChart.iOS;
using Syncfusion.SfChart.XForms;
using Syncfusion.SfChart.XForms.iOS.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ChartExt), typeof(ChartSample.iOS.ChartCustomRenderer))]

namespace ChartSample.iOS
{
   public class ChartCustomRenderer:SfChartRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SfChart> e)
        {
            base.OnElementChanged(e);
            var formsChart = e.NewElement as ChartExt;
            if (Control != null)
            {
                Control.Delegate = new CustomDelegate(e.NewElement as ChartExt);
            }
        }
    }

    public class CustomDelegate : SFChartDelegate
    {
        ChartExt formsChart;

        public CustomDelegate(ChartExt chart)
        {
            this.formsChart = chart;
        }
        public override void WillShowTooltip(SFChart chart, SFChartTooltip tooltipView)
        {
            base.WillShowTooltip(chart, tooltipView);
            tooltipView.PointerLength = (nfloat)formsChart.PointerLength;
        }
    }
}