using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FuturixRu
{
    public partial class MainForm : Form
    {
        private bool ShiftPressed = false;

        private string sAbout = "About";
        private string sAreYouSure = "Are you sure?";

        public const string AppName = "Futurix i18n";
        public const string RegPath = @"\SOFTWARE\Futurix\i18n";

        public MainForm()
        {
            InitializeComponent();
        }

        private void InsertText(string txt)
        {
            int sel = txtMain.SelectionStart;
            txtMain.Text = txtMain.Text.Insert(sel, txt);
            txtMain.SelectionStart = sel + txt.Length;
        }

        private void buttonLetter_Click(object sender, EventArgs e)
        {
            string txt = (sender as Button).Text;

            if (ShiftPressed)
                txt = txt.ToUpper();
            else
                txt = txt.ToLower();

            InsertText(txt);

            txtMain.Focus();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (txtMain.SelectionLength > 0)
                txtMain.SelectedText = "";
            else if (txtMain.Text.Length > 0)
            {
                int sel = txtMain.SelectionStart;

                if (sel > 0)
                {
                    txtMain.Text = txtMain.Text.Remove(sel - 1, 1);
                    txtMain.SelectionStart = sel - 1;
                }
                else
                    txtMain.Text = txtMain.Text.Remove(txtMain.Text.Length - 1, 1);
            }

            txtMain.Focus();
        }

        private void buttonShift_Click(object sender, EventArgs e)
        {
            ShiftPressed = !ShiftPressed;

            button26.Text = ShiftPressed ? "ЗГЛ" : "згл";

            txtMain.Focus();
        }

        private void miCut_Click(object sender, EventArgs e)
        {
            if (txtMain.SelectionLength > 0)
            {
                Clipboard.SetDataObject(txtMain.SelectedText);
                
                txtMain.SelectedText = "";
            }

            txtMain.Focus();
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtMain.Text);
        }

        private void miPaste_Click(object sender, EventArgs e)
        {
            IDataObject temp = Clipboard.GetDataObject();
            string txt = temp.GetData("Text") as string;

            if (txt != null)
                InsertText(txt);

            txtMain.Focus();
        }

        private void miClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(sAreYouSure, AppName, 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                txtMain.Text = "";
            }

            txtMain.Focus();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dlgOpen.FileName))
                {
                    using (StreamReader sr = new StreamReader(dlgOpen.FileName, Encoding.Unicode, true))
                    {
                        txtMain.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outfile = new StreamWriter(dlgSave.FileName, false, Encoding.Unicode))
                {
                    outfile.Write(txtMain.Text);
                }
            }
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppName + "\n\n" + "http://fximage.com/", sAbout,
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // localization
            switch (CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
            {
	            case "ru":
                    mEdit.Text = "Правка";
                    miCut.Text = "Вырезать";
                    miCopy.Text = "Копировать";
                    miPaste.Text = "Вставить";
                    miClear.Text = "Очистить";
                    miOpen.Text = "Открыть";
                    miSave.Text = "Закрыть";

                    mTools.Text = "Сервис";
                    miAbout.Text = "О программе";
                    miClose.Text = "Выход";

                    sAbout = "О программе";
                    sAreYouSure = "Вы уверены?";

                    dlgOpen.Filter = "Текстовые файлы" + "|*.txt";
                    dlgSave.Filter = "Текстовые файлы" + "|*.txt";
                    break;

                case "de":
                    mEdit.Text = "Bearbeiten";
                    miCut.Text = "Ausschneiden";
                    miCopy.Text = "Kopieren";
                    miPaste.Text = "Einfügen";
                    miClear.Text = "Löschen";
                    miOpen.Text = "Öffnen";
                    miSave.Text = "Speichern";

                    mTools.Text = "Werkzeuge";
                    miAbout.Text = "Über";
                    miClose.Text = "Beenden";

                    sAbout = "Über";
                    sAreYouSure = "Sind Sie sicher?";

                    dlgOpen.Filter = "Text" + "|*.txt";
                    dlgSave.Filter = "Text" + "|*.txt";
                    break;

                case "fr":
                    mEdit.Text = "Editer";
                    miCut.Text = "Couper";
                    miCopy.Text = "Copier";
                    miPaste.Text = "Coller";
                    miClear.Text = "Effacer";
                    miOpen.Text = "Ouvrir";
                    miSave.Text = "Sauver";

                    mTools.Text = "Outils";
                    miAbout.Text = "A Propos";
                    miClose.Text = "Sortir";

                    sAbout = "Outils";
                    sAreYouSure = "Etes-vous sûr?";

                    dlgOpen.Filter = "Texte" + "|*.txt";
                    dlgSave.Filter = "Texte" + "|*.txt";
                    break;
            }

            // loading saved data back-up (if any)
            try
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(RegPath);

                string temp = reg.GetValue("Data") as string;

                if (temp != null)
                    txtMain.Text = temp;
            }
            catch
            {
            }
        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            // saving data back-up
            try
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(RegPath);

                reg.SetValue("Data", txtMain.Text, RegistryValueKind.String);
            }
            catch
            {
            }
        }
    }
}