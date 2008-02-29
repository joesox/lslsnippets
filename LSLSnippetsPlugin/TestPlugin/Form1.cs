// LSLSnippetsPlugin v1.1.0
// by Seneca Taliaferro/Joseph P. Socoloski III (Minoa)
// Copyright 2008. All Rights Reserved.
// http://lslsnippets.googlecode.com
// NOTE:   Add your own LSL snippets to an existing script.
// WHAT'S NEW: 	
//          - Bug Fix issue#1: Added state_entry to dropdown list
// LIMITS:  
// TODO:    -Right side of form not sizing correctly
//          -
//LICENSE
//BY DOWNLOADING AND USING, YOU AGREE TO THE FOLLOWING TERMS:
//If it is your intent to use this software for non-commercial purposes, 
//such as in academic research, this software is free and is covered under 
//the GNU GPL License, given here: <http://www.gnu.org/licenses/gpl.txt> 
////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using lslSnippetsLib;
using System.IO;
using System.Text;

namespace TestPlugin
{
    public partial class Form1 : Form
    {
        private string m_FilePath;
        private RichTextBox m_RichTextBox;
        lslSnippetsLib.LSLSnippet Snippet = new LSLSnippet("");

        public Form1(params object[] args)
        {
            InitializeComponent();

            if (args.Length > 1)
            {
                m_FilePath = args[0].ToString();
                m_RichTextBox = args[1] as RichTextBox;
            }
            else
            {
                m_FilePath = "";
                m_RichTextBox = new RichTextBox();
            }

            //Set cBoxEvents
            cBoxEvents.SelectedIndex = 0;

            //Populate the textbox
            tbXMLFile.Clear();
            tbXMLFile.Text = LSLSnippet.Getblankxml().ToString();

            //
            rboxLSLScript.Text = m_RichTextBox.SelectedText;
        }

        /// <summary>
        /// Set the title of the xml snippet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSetTitle_Click(object sender, EventArgs e)
        {
            if (tbSnippetTitle.Text != "")
            {
                //Read the TextBox
                StringBuilder sb = new StringBuilder();
                sb.Append(tbXMLFile.Text);
                //Replace 
                string titlevalue = LSLSnippet.GetTitlevalue(sb.ToString());
                sb.Replace(titlevalue, tbSnippetTitle.Text);

                //Now update tbXMLFile.Text
                tbXMLFile.Clear();
                tbXMLFile.AppendText(sb.ToString());

                //Clear Textbox
                tbSnippetTitle.Text = "";
            }
            else
            {
                MessageBox.Show("No title text to set.", "SetTitle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAddSnippet_Click(object sender, EventArgs e)
        {
            string eventname = "";

            if (cBoxEvents.SelectedItem.ToString() != "Choose a Method...")
            {
                eventname = cBoxEvents.SelectedItem.ToString().Trim();

                if (tbSnippetCode.Text != "")
                {
                    //Read the TextBox
                    //Add.... 
                    StringBuilder sb = new StringBuilder();
                    sb = LSLSnippet.AddSnippet(tbXMLFile.Text, eventname, tbSnippetCode.Text);

                    //Now update tbXMLFile.Text
                    tbXMLFile.Clear();
                    tbXMLFile.AppendText(sb.ToString());

                    //Clear Textbox
                    tbSnippetCode.Text = "";
                }
                else
                {
                    MessageBox.Show("No code for event.", "AddSnippet", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No Event choosen.", "AddSnippet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btSaveXMLSnippet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Common.snippetsFolder);//DEBUG ONLY
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            sfd.InitialDirectory = Common.snippetsFolder;
            sfd.Title = "Save Snippet XML As...";
            sfd.ShowDialog();

            if (sfd.FileName != string.Empty)
            {
                File.WriteAllText(sfd.FileName, tbXMLFile.Text);
            }
        }

        private void btDoInsert_Click(object sender, EventArgs e)
        {
            if ((tbXMLFile.Text != "") && (rboxLSLScript.Text != ""))
            {
                string newscript = "";

                //Make sure Snippet has current Script
                Snippet.LSLScript = rboxLSLScript.Text;
                //Make sure the Snippet has current XML
                this.Snippet.xmlDoc.LoadXml(tbXMLFile.Text);
                //Do the insert
                Snippet.DoInsert(out newscript);
                //Show the new script
                rboxLSLScript.Clear();
                rboxLSLScript.AppendText(newscript);
            }
            else
            {
                if(rboxLSLScript.Text == "")
                {
                    MessageBox.Show("No script in script textbox.\r\nCopy and Paste a script into the textbox or close\r\nthis tab, select the text in another open script, then open LSLSnippets.", "Insert Snippet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btOpenXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            //ofd.InitialDirectory = Application.StartupPath + "\\scripts";
            ofd.InitialDirectory = Common.snippetsFolder;
            ofd.ShowDialog();

            if (ofd.FileName != string.Empty)
            {
                tbXMLFile.Clear();
                tbXMLFile.AppendText(File.ReadAllText(ofd.FileName));
            }
        }

        private void btOpenLSL_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "lsl files (*.lsl)|*.lsl|All files (*.*)|*.*";
            //ofd.InitialDirectory = Application.StartupPath + "\\scripts";
            ofd.InitialDirectory = Common.scriptsFolder;
            ofd.ShowDialog();

            if (ofd.FileName != string.Empty)
            {
                rboxLSLScript.Clear();
                rboxLSLScript.AppendText(File.ReadAllText(ofd.FileName));
            }
        }
    }

    public class Common
    {
        #region Remote locations
        /// <summary>
        /// http://joeswammi.com/sl/se
        /// </summary>
        public static string url_SE = "http://joeswammi.com/sl/se";

        /// <summary>
        /// http://code.google.com/p/lslsnippets/w/list
        /// </summary>
        public static string url_help = "http://code.google.com/p/lslsnippets/w/list";

        /// <summary>
        /// http://code.google.com/p/lslsnippets/issues/list
        /// </summary>
        public static string url_bugs = "http://code.google.com/p/lslsnippets/issues/list";
        #endregion

        #region Local Application Folders and files
        /// <summary>
        /// Application.StartupPath + "\\snippets"
        /// </summary>
        public static string snippetsFolder = Application.StartupPath + "\\plugins\\snippets";

        /// <summary>
        /// Application.StartupPath + "\\scripts"
        /// </summary>
        public static string scriptsFolder = Application.StartupPath + "\\plugins\\scripts";
        #endregion
    }
}