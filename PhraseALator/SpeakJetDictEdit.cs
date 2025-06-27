using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PhraseALator
{
    internal partial class frmDictEdit : Form
    {

        public frmDictEdit()
            : base()
        {
            if (m_vb6FormDefInstance == null)
            {
                if (m_InitializingDefInstance)
                {
                    m_vb6FormDefInstance = this;
                }
                else
                {
                    try
                    {
                        if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                        {
                            m_vb6FormDefInstance = this;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            InitializeComponent();
        }


        private void frmDictEdit_Activated(Object eventSender, EventArgs eventArgs)
        {
            if (Globals.ActiveForm != eventSender)
            {
                Globals.ActiveForm = (Form)eventSender;
            }
        }

        private void btnDone_Click(Object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void btnEraseBlank_Click(Object eventSender, EventArgs eventArgs)
        {
            int LocationOfEqual = 0;

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            txtDictionary.Text = File.ReadAllText(Path.Combine(Application.StartupPath, "PhraseALator.Dic"));

            int xLine = txtDictionary.GetLineFromCharIndex(txtDictionary.Text.Length);
            string[] Lines = new string[xLine + 2];
            string[] LineArray = File.ReadAllLines(Path.Combine(Application.StartupPath, "PhraseALator.Dic"));
            xLine = 0;

            foreach (string Line in LineArray)
            {
                xLine++;
                Lines[xLine] = Line;
                LocationOfEqual = ((Lines[xLine] + "=").IndexOf('=') + 1);
                int tempForEndVar = LocationOfEqual - 1;
                for (int xChar = 1; xChar <= tempForEndVar; xChar++)
                {
                    Lines[xLine] = Strings.Mid(Lines[xLine], xChar, 1, Lines[xLine].Substring(xChar - 1, Math.Min(1, Lines[xLine].Length - (xChar - 1))).ToLower());
                }
            };
            StringBuilder SortedText = new StringBuilder();
            SortedText.Append("[words]" + Environment.NewLine);
            int tempForEndVar2 = Lines.GetUpperBound(0);
            for (xLine = 1; xLine <= tempForEndVar2; xLine++)
            {
                if (String.CompareOrdinal(Lines[xLine].Trim(), "") > 0)
                {
                    LocationOfEqual = ((Lines[xLine] + "=").IndexOf('=') + 1);
                    if (String.CompareOrdinal(Lines[xLine].Substring(LocationOfEqual).Trim(), "") > 0)
                    {
                        SortedText.Append(Lines[xLine] + Environment.NewLine);
                    }
                }
            }
            txtDictionary.Rtf = SortedText.ToString();

            this.Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void btnFind_Click(Object eventSender, EventArgs eventArgs)
        {
            string a = Interaction.InputBox("Find:", "Find", "");
            txtDictionary.Find(a);
        }

        private void btnSaveChanges_Click(Object eventSender, EventArgs eventArgs)
        {
            txtDictionary.Text = File.ReadAllText(Path.Combine(Application.StartupPath, "PhraseALator.Dic"));
            //Call txtDictionary.SaveFile(App.Path + "\PhraseALator.Dic")
        }

        private void btnSort_Click(Object eventSender, EventArgs eventArgs)
        {
            StringBuilder SortedText = new StringBuilder();
            int LocationOfEqual = 0;

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            txtDictionary.Text = File.ReadAllText(Path.Combine(Application.StartupPath, "PhraseALator.Dic"));

            int xLine = txtDictionary.GetLineFromCharIndex(txtDictionary.Text.Length);
            string[] Lines = new string[xLine + 1];
            string[] LineArray = File.ReadAllLines(Path.Combine(Application.StartupPath, "PhraseALator.Dic"));
            xLine = 0;

            foreach (string Line in LineArray)
            {
                xLine++;
                Lines[xLine] = Line;
                LocationOfEqual = ((Lines[xLine] + "=").IndexOf('=') + 1);
                int tempForEndVar = LocationOfEqual - 1;
                for (int xChar = 1; xChar <= tempForEndVar; xChar++)
                {
                    Lines[xLine] = Strings.Mid(Lines[xLine], xChar, 1, Lines[xLine].Substring(xChar - 1, Math.Min(1, Lines[xLine].Length - (xChar - 1))).ToLower());
                }
            };
            Module1.QuickSortVariants(Lines, 1, Lines.GetUpperBound(0));
            int tempForEndVar2 = Lines.GetUpperBound(0);
            for (xLine = 1; xLine <= tempForEndVar2; xLine++)
            {
                if (String.CompareOrdinal(Lines[xLine].Trim(), "") > 0)
                {
                    SortedText.Append(Lines[xLine] + Environment.NewLine);
                }
            }
            txtDictionary.Rtf = SortedText.ToString();

            this.Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void Form_Load()
        {
            txtDictionary.Text = File.ReadAllText(Path.Combine(Application.StartupPath, "PhraseALator.Dic"));
        }

        private void btnReadTerms_Click(Object eventSender, EventArgs eventArgs)
        {
            StringBuilder aWord = new StringBuilder();
            string LineOfText = "";
            string Spelling = "";
            int WordsAdded = 0;

            btnReadTerms.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            string[] LineArray = File.ReadAllLines(Path.Combine(Application.StartupPath, "ImportWords.txt"));

            foreach (string Line in LineArray)
            {
                // Get a line of text
                LineOfText = Line;
                LineOfText = LineOfText + " ";
                // Remove all but letters.
                int tempForEndVar = LineOfText.Length;
                for (int xChar = 1; xChar <= tempForEndVar; xChar++)
                {
                    string switchVar = LineOfText.Substring(xChar - 1, Math.Min(1, LineOfText.Length - (xChar - 1)));
                    if (String.CompareOrdinal(switchVar, "A") >= 0 && String.CompareOrdinal(switchVar, "Z") <= 0)
                    {
                    }
                    else if (String.CompareOrdinal(switchVar, "a") >= 0 && String.CompareOrdinal(switchVar, "z") <= 0)
                    {
                    }
                    else
                    {
                        LineOfText = Strings.Mid(LineOfText, xChar, 1, " ");
                    }
                }
                // Find words.
                int tempForEndVar2 = LineOfText.Length;
                for (int xChar = 1; xChar <= tempForEndVar2; xChar++)
                {
                    string switchVar_2 = LineOfText.Substring(xChar - 1, Math.Min(1, LineOfText.Length - (xChar - 1)));
                    if (String.CompareOrdinal(switchVar_2, "A") >= 0 && String.CompareOrdinal(switchVar_2, "Z") <= 0)
                    {
                        aWord.Append(LineOfText.Substring(xChar - 1, Math.Min(1, LineOfText.Length - (xChar - 1))));
                    }
                    else if (String.CompareOrdinal(switchVar_2, "a") >= 0 && String.CompareOrdinal(switchVar_2, "z") <= 0)
                    {
                        aWord.Append(LineOfText.Substring(xChar - 1, Math.Min(1, LineOfText.Length - (xChar - 1))));
                    }
                    else
                    {
                        //Mid$(LineOfText, xChar, 1) = " "
                        aWord = new StringBuilder(aWord.ToString().ToLower());
                        if (String.CompareOrdinal(aWord.ToString().Trim(), "") > 0)
                        {
                            Spelling = Module1.ReadDict("Words", aWord.ToString().Trim(), "NoEntry").Trim();
                            if (Spelling == "NoEntry")
                            {
                                txtDictionary.SelectionStart = txtDictionary.Text.Length + 1;
                                txtDictionary.SelectedText = aWord.ToString() + "=" + Environment.NewLine;
                                WordsAdded++;
                            }
                            aWord = new StringBuilder("");
                        }
                    }
                }
            };
            btnReadTerms.Enabled = true;
            Cursor = Cursors.Default;
            Application.DoEvents();

            MessageBox.Show(WordsAdded.ToString() + " Words added", "Import Status");
        }

        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
        }
    }
}