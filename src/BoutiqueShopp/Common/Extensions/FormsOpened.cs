using ComponentFactory.Krypton.Toolkit;
using System;

namespace SkyReg.Common.Extensions
{
    public sealed class FormsOpened<TFrom> where TFrom : class
    {
        public static TFrom IsOpened(TFrom form)
        {
            if (form == default(TFrom))
                return Activator.CreateInstance<TFrom>();
                
            return form;
        }

        public static TFrom IsShowDialog(TFrom form, params object[] ctorParams)
        {
            if (form == default(TFrom))
            {
                form = (TFrom)Activator.CreateInstance(typeof(TFrom), ctorParams);
                var newForm = (form as KryptonForm);
                newForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
                newForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                newForm.TopLevel = true;
                newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                newForm.ShowIcon = false; 
                newForm.BringToFront();
                return newForm as TFrom;
            }
            
            return form; 
        }
    }
}
