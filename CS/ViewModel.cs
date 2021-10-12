using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using System;

namespace ValidateEditingFields_MVVM {
    public class ViewModel : ViewModelBase {
        public XtraReport Report { get; }
        public ViewModel() {
            Report = new XtraReport1();
        }
        
        [Command]
        public void OnShowingEditingFieldEditor(ShowingEditingFieldEditorEventArgs args) {
            if(args.EditingField.ID == "CheckField" || args.EditingField.ID == "ImageField")
                args.Cancel = true;
        }
        
        [Command]
        public void OnValidateEditingField(EditingFieldValidationEventArgs args) {
            if(args.EditingField.ID == "DateField")
                ValidateDateTimeEditingField(args);
        }

        void ValidateDateTimeEditingField(EditingFieldValidationEventArgs args) {
            DateTime value = default(DateTime);
            try {
                value = Convert.ToDateTime(args.Value);
            } catch (Exception e) {
                args.IsValid = false;
                args.ErrorMessage = e.Message;
                args.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
            
            DateTime now = DateTime.Now;
            args.IsValid = value.Year == now.Year && value.Month == now.Month;
        }
    }
}
