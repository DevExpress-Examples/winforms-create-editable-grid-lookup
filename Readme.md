<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628408/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3078)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - How to create an editable GridLookUpEdit with PopupContainerEdit

The WinForms [GridLookUpEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.GridLookUpEdit) does not support editing in its dropdown grid. This example demonstrates how to implement a custom Grid-based Lookup that allows you to edit data within grid cells.

Follow the steps below:

* Create a [PopupContainerEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PopupContainerEdit)
* Assign a panel to the [PopupContainerEdit.Properties.PopupControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit.PopupControl) property
* Add the `GridControl` to the panel.
* Handle [PopupContainerEdit.QueryResultValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit.QueryResultValue) and [PopupContainerEdit.QueryDisplayText](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit.QueryDisplayText) events to synchronize the value and display text of the `PopupContainerEdit` with the state of controls displayed within the dropdown.</p>


## Files to Review

* [Form1.cs](./CS/PopupContainerEditSelection/Form1.cs) (VB: [Form1.vb](./VB/PopupContainerEditSelection/Form1.vb))

## Documentation

* [Lookup Editors](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors)
* [Lookup Main Settings](https://docs.devexpress.com/WindowsForms/116029/controls-and-libraries/editors-and-simple-controls/lookup-editors/lookup-editors-and-main-settings)
