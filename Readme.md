<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628408/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3078)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PopupContainerEditSelection/Form1.cs) (VB: [Form1.vb](./VB/PopupContainerEditSelection/Form1.vb))
* [Program.cs](./CS/PopupContainerEditSelection/Program.cs) (VB: [Program.vb](./VB/PopupContainerEditSelection/Program.vb))
<!-- default file list end -->
# How to emulate an editable GridLookUpEdit with PopupContainerEdit


<p><strong> </strong></p>
<p><strong>GridLookUpEdit</strong> does not support editing in its grid residing within a popup window. This example illustrates how to implement an equivalent to <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsGridLookUpEdittopic">GridLookUpEdit</a> that allows editing <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridGridControltopic">GridControl</a> data. <br><br>The following approach is used

* create a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsPopupContainerEdittopic">PopupContainerEdit</a> instead of <strong>GridLookUpEdit;</strong><br>- assign a panel to <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsPopupContainerControltopic">PopupContainerControl</a> by setting the<strong> PopupContainerEdit.Properties.PopupControl</strong> property and then add <strong>GridControl</strong> to it;<br>- handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsPopupContainerEdit_QueryResultValuetopic">PopupContainerEdit.QueryResultValue</a> and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsPopupContainerEdit_QueryDisplayTexttopic">PopupContainerEdit.QueryDisplayText</a> events to synchronize <strong>PopupContainerEdit's</strong> value and display text with the state of controls residing within the popup window.</p>

<br/>


