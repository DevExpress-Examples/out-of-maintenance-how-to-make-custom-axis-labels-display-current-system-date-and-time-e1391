<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575129/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1391)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/CustomLabelsText/Form1.cs) (VB: [Form1.vb](./VB/CustomLabelsText/Form1.vb))**
<!-- default file list end -->
# How to make custom axis labels display current system date and time

This example demonstrates how to change a text of custom [axis labels](https://docs.devexpress.com/WindowsForms/5804/controls-and-libraries/chart-control/axes/axis-labels?p=netframework) at runtime. In particular, it demonstrates how to make them display the current system date and time.

Note that to access the custom labels collection, you should first access its parent [axis](https://docs.devexpress.com/WindowsForms/5779/controls-and-libraries/chart-control/diagram/axes). That can be done only if you cast your chart's [diagram](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Diagram?p=netframework) object to the appropriate diagram type.
