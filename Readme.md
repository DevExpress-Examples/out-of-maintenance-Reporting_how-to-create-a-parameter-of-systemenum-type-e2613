<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599580/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2613)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataObjects.cs](./CS/DataObjects.cs) (VB: [DataObjects.vb](./VB/DataObjects.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to create a parameter of System.Enum type


<p>This example demonstrates how you can define an enumeration as a report parameter of a custom type.<br />
 <br />
To make this parameter type (in addition to standard <strong>System.Type</strong> types) available for your end-users in the Designer, simply inherit from the <strong>ReportDesignExtension</strong> class, instantiate your custom object and override the <strong>AddParameterTypes()</strong> method. And, register the custom extension, by calling the <strong>ReportDesignExtension.RegisterExtension()</strong> method.</p><p>Then, after an end-user assigns this type for a parameter, an appropriate parameter value editor is auto-created, in accordance with the parameter type.<br />
 <br />
And, after specifying this parameter in the report's FilterString, this editor is shown in the report's Print Preview.<br />
 <br />
See also: <a href="https://www.devexpress.com/Support/Center/p/E3186">How to serialize parameters of custom types</a> <br />
 </p>

<br/>


