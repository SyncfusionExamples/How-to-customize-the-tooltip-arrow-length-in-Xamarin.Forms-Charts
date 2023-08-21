# How to customize the tooltip arrow length in Xamarin.Forms Charts

You can customize the appearance of the tooltip with your own template by using the TooltipTemplate property of Series. The BindingContext in the data template will be the respective underlying object from ItemsSource.
## Customizing appearance

You can customize the tooltip label. For customizing, you need to add an instance of ChartTooltipBehavior to the ChartBehaviors collection property of SfChart. Following properties are used to customize the tooltip label which are available in ChartTooltipBehavior.

* BorderColor – used to change the label border color
* BorderWidth – used to change the label border width
* BackgroundColor – used to change the label background color
* Margin – used to change label border thickness
* TextColor – used to change the text color.
* Font – used to change the text size, font family, and font weight. (This is deprecated API. Use FontSize, FontFamily, and 
  FontAttributes properties instead of this.)
* FontFamily- used to change the font family for the tooltip text.
* FontAttributes - used to change the font style for the tooltip text.
* FontSize - used to change the font size for the tooltip text.
* LabelFormat – used to format the label
* Duration – used to set the visible duration of label
* OffsetX – used to move the label horizontally
* OffsetY – used to move the label vertically
  
[Xamarin.Forms Charts](https://www.syncfusion.com/xamarin-ui-controls/xamarin-charts) Tooltip appears with information about the datapoint when it is hovered. Size of the tooltip arrowhead can be customized in iOS and Android by using extended chart with its custom renderer. To know more about this, please refer this article.

![](https://github.com/SyncfusionExamples/How-to-customize-the-tooltip-arrow-length-in-Xamarin.Forms-Charts/blob/main/Tooltip-Customized-ArrowHead-Length.gif)
