using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace SkyReg.Common.Extensions
{
    public sealed class FormsOpened<TFrom> where TFrom : class
    {
        public static void OpenForm(TFrom form, params object[] ctorParams)
        {
            var newForm = new KryptonForm();

            if (form == default(TFrom))
                form = (TFrom)Activator.CreateInstance(typeof(TFrom), ctorParams);

            newForm = (form as KryptonForm);
            newForm.WindowState = FormWindowState.Normal;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.TopLevel = true;
            newForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            newForm.ShowIcon = false;
            newForm.FormClosed += (s, e) =>
            {
                newForm = null;
            };

            newForm.BringToFront();
            newForm.Activate();
            newForm.ShowDialog();

        }

        public static void OpenMDIForm(TFrom form, KryptonForm parent, params object[] ctorParams)
        {
            var newForm = new KryptonForm();

            if (form == default(TFrom))
                form = (TFrom)Activator.CreateInstance(typeof(TFrom), ctorParams);

            newForm = (form as KryptonForm);
            newForm.MdiParent = parent;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
            newForm.BringToFront();
            newForm.Activate();
            newForm.FormClosed += (s, e) =>
            {
                newForm = null;
            };

            newForm.BringToFront();
            newForm.Activate();
            newForm.Show();
        }
    }
}
