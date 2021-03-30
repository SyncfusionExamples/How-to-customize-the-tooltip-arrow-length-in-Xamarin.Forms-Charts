using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ChartSample
{
   public class ChartExt :SfChart
    {
        public int PointerLength
        {
            get { return (int)GetValue(PointerLengthProperty); }
            set { SetValue(PointerLengthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PointerLength.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty PointerLengthProperty =
            BindableProperty.Create("PointerLength", typeof(int), typeof(ChartExt), 8,BindingMode.Default);

    }

}
