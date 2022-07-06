# How to Validate the Editing Field Value in the Document Preview

This example demonstrates how to validate the [EditingField](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.EditingField) value before closing the [Editing Field editor](https://docs.devexpress.com/XtraReports/119221/wpf-reporting/wpf-reporting-document-preview/gui/document-preview-interactivity#content-editing), and how to prevent the editor from opening for certain fields.

Analyze the field value in the [DocumentPreviewControl.ValidateEditingField](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentPreviewControl.ValidateEditingField) event handler. If validation fails, set the [IsValid](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.EditingFieldValidationEventArgs.IsValid) property to **false** and specify the [ErrorType](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.EditingFieldValidationEventArgs.ErrorType) and [ErrorMessage](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.EditingFieldValidationEventArgs.ErrorMessage) property values.

Handle the [DocumentPreviewControl.ShowingEditingFieldEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentPreviewControl.ShowingEditingFieldEditor) event, determine the field by checking the [EditingField](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.ShowingEditingFieldEditorEventArgs.EditingField) property, and set the [Cancel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.ShowingEditingFieldEditorEventArgs.Cancel) property to **true** to prevent the editor for that field from being displayed.


<!-- default file list -->
## Files to Look At

- [MainWindow.xaml](./CS/MainWindow.xaml) ([MainWindow.xaml](./VB/MainWindow.xaml))
- [ViewModel.cs](./CS/ViewModel.cs) ([ViewModel.vb](./VB/ViewModel.vb))

<!-- default file list end -->

## Documentation

- [Edit Content in Print Preview](https://docs.devexpress.com/XtraReports/117343/detailed-guide-to-devexpress-reporting/provide-interactivity/edit-content-in-print-preview)
- [Quick Guide to Print Preview Customization](https://docs.devexpress.com/XtraReports/119228/wpf-reporting/wpf-reporting-document-preview/api-and-customization/quick-guide-to-print-preview-customization)

## More Examples

- [How to use custom controls for editing report content in Print Preview](https://github.com/DevExpress-Examples/Reporting_how-to-use-custom-controls-for-editing-report-content-in-print-preview-t456791)
