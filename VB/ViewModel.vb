Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI
Imports System

Namespace ValidateEditingFields_MVVM
	Public Class ViewModel
		Inherits ViewModelBase

		Public ReadOnly Property Report() As XtraReport
		Public Sub New()
			Report = New XtraReport1()
		End Sub

		<Command>
		Public Sub OnShowingEditingFieldEditor(ByVal args As ShowingEditingFieldEditorEventArgs)
			If args.EditingField.ID = "CheckField" OrElse args.EditingField.ID = "ImageField" Then
				args.Cancel = True
			End If
		End Sub

		<Command>
		Public Sub OnValidateEditingField(ByVal args As EditingFieldValidationEventArgs)
			If args.EditingField.ID = "DateField" Then
				ValidateDateTimeEditingField(args)
			End If
		End Sub

		Private Sub ValidateDateTimeEditingField(ByVal args As EditingFieldValidationEventArgs)
			Dim value As Date = Date.MinValue
			Try
				value = Convert.ToDateTime(args.Value)
			Catch e As Exception
				args.IsValid = False
				args.ErrorMessage = e.Message
				args.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
			End Try

			Dim now As Date = Date.Now
			args.IsValid = value.Year = now.Year AndAlso value.Month = now.Month
		End Sub
	End Class
End Namespace
