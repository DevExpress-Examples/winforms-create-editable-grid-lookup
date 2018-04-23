# How to emulate an editable GridLookUpEdit with PopupContainerEdit


<p><strong> </strong></p>
<p><strong>GridLookUpEdit</strong> does not support editing in its grid residing within a popup window. This example illustrates how to implement an equivalent to <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsGridLookUpEdittopic">GridLookUpEdit</a> that allows editing <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridGridControltopic">GridControl</a> data. <br><br>The following approach is used

* create a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsPopupContainerEdittopic">PopupContainerEdit</a> instead of <strong>GridLookUpEdit;</strong><br>- assign a panel to <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsPopupContainerControltopic">PopupContainerControl</a> by setting the<strong> PopupContainerEdit.Properties.PopupControl</strong> property and then add <strong>GridControl</strong> to it;<br>- handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsPopupContainerEdit_QueryResultValuetopic">PopupContainerEdit.QueryResultValue</a> and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsPopupContainerEdit_QueryDisplayTexttopic">PopupContainerEdit.QueryDisplayText</a> events to synchronize <strong>PopupContainerEdit's</strong> value and display text with the state of controls residing within the popup window.</p>

<br/>


