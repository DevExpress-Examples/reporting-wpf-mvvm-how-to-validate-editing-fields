Namespace ValidateEditingFields_MVVM
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrPictureBox1, Me.xrCheckBox1, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.HeightF = 226.0417F
			Me.Detail.Name = "Detail"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Multiline = True
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(157.2917F, 23F)
			Me.xrLabel1.Text = "Date Editing Field:"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel2.EditOptions.EditorName = "Date"
			Me.xrLabel2.EditOptions.Enabled = True
			Me.xrLabel2.EditOptions.ID = "DateField"
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(178.6458F, 10.00001F)
			Me.xrLabel2.Multiline = True
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(160.9375F, 23F)
			Me.xrLabel2.StylePriority.UseBorders = False
			Me.xrLabel2.Text = ControlChars.CrLf
			' 
			' xrCheckBox1
			' 
			Me.xrCheckBox1.EditOptions.Enabled = True
			Me.xrCheckBox1.EditOptions.ID = "CheckField"
			Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(9.999943F, 44.47918F)
			Me.xrCheckBox1.Name = "xrCheckBox1"
			Me.xrCheckBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(329.5834F, 23F)
			Me.xrCheckBox1.Text = "Check Editing Field"
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPictureBox1.EditOptions.Enabled = True
			Me.xrPictureBox1.EditOptions.ID = "ImageField"
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(178.6458F, 80.20834F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(160.9375F, 100F)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			Me.xrPictureBox1.StylePriority.UseBorders = False
			' 
			' xrLabel3
			' 
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 80.20834F)
			Me.xrLabel3.Multiline = True
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(157.2917F, 23F)
			Me.xrLabel3.Text = "Image Editing Field:"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail})
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Version = "21.2"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
