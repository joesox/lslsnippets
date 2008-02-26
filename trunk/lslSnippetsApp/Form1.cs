// lslSnippetsApp v1.0.0
// by Seneca Taliaferro/Joseph P. Socoloski III (Minoa)
// Copyright 2008. All Rights Reserved.
// http://lslsnippets.googlecode.com
// NOTE:   Add your own LSL snippets to an existing script.
// WHAT'S NEW: 	
//          - First Release
// LIMITS:  
// TODO:    -Fix refreshing of snippets diectory combobox
//          -
//LICENSE
//BY DOWNLOADING AND USING, YOU AGREE TO THE FOLLOWING TERMS:
//If it is your intent to use this software for non-commercial purposes, 
//such as in academic research, this software is free and is covered under 
//the GNU GPL License, given here: <http://www.gnu.org/licenses/gpl.txt> 
////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Joe.Utils;
using System.Xml;
using lslSnippetsLib;

namespace lslSnippetsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Assembly Gathering
        /// <summary>
        /// Gets the Product name from Assembly Information
        /// </summary>
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        /// <summary>
        /// Gets the AssemblyVersion string from Assembly Information
        /// </summary>
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        #endregion

        #region Menustrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutDlg = new AboutBox1();
            AboutDlg.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFiletoTab();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Controls[0].Focus();//need to focus before selecting so it gets highlighted
            ((TextBox)tabControl1.SelectedTab.Controls[0]).SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((TextBox)tabControl1.SelectedTab.Controls[0]).Copy();
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTab();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        /// <summary>
        /// Opens Official LSLSnippets url from Help Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onlineHelpWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Common.url_help);
        }

        /// <summary>
        /// Opens Official LSLSnippets issues url from Help Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bugSubmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Common.url_bugs);
        }

        /// <summary>
        /// Open a tabPageXML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.Visible == false)
            {
                tabControl1.Visible = true;
                tabControl1.TabPages[0].Dispose();
                tabControl1.SelectedTab = tabControl1.TabPages["tabPageXML"];
                //This new tab may be closed now
                closeTabToolStripMenuItem.Enabled = true;
                toolStripCloseTab.Enabled = true;
            }
            else
            {
                //Tabs are already open, is tabPageXML already open?
                if (!IstabPageXMLOpen())
                {
                    //tabControl1.TabPages.Insert(tabControl1.TabPages.Count, "tabPageXML");
                    tabControl1.TabPages.Add(tabPageXML);
                    tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                }
                else
                {
                    //Already open, just select it
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPageXML"];
                }
            }

            //Populate the textbox
            tbXMLFile.Clear();
            tbXMLFile.Text = LSLSnippet.Getblankxml().ToString();

            //Choose first cBoxEvents item
            cBoxEvents.SelectedIndex = 0;
        }

        #endregion

        #region toolStrip
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFiletoTab();
        }

        private void toolStripCloseTab_Click(object sender, EventArgs e)
        {
            CloseTab();
        }

        /// <summary>
        /// Selectall
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Controls[0].Focus();//need to focus before selecting so it gets highlighted
            ((TextBox)tabControl1.SelectedTab.Controls[0]).SelectAll();
        }
        /// <summary>
        /// Copy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ((TextBox)tabControl1.SelectedTab.Controls[0]).Copy();
        }

        private void toolStripSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        /// <summary>
        /// Insert a snippet that was choosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripcBoxSnippets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripcBoxSnippets.Enabled)
            {
                //Load the selected Snippet...
                //Take in the current lslscript
                lslSnippetsLib.LSLSnippet Snippet = new LSLSnippet(tabControl1.SelectedTab.Controls[0].Text);
                //Load the selected snippet's xml
                Snippet.xmlDoc.Load(Common.snippetsFolder + "//" + toolStripcBoxSnippets.SelectedItem.ToString());

                //Do the insert of the snippet
                string newlslscript;
                Snippet.DoInsert(out newlslscript);

                //Update the TextBox...
                tabControl1.SelectedTab.Controls[0].Text = newlslscript;

                //Select all of the text in textbox
                tabControl1.SelectedTab.Controls[0].Focus();

                //Exit the dropdownlist
                toolStripcBoxSnippets.PerformClick();
            }
        }

        #endregion

        #region Global Variables

        string[] snippetsFiles;//Holds the file names found in the snippetsFolder

        #endregion

        /// <summary>
        /// Create the application's folders if they do not exist
        /// if files are found populate string[] snippetsFiles
        /// </summary>
        /// <returns>true if Setup is needed</returns>
        private bool InitAppFolders()
        {
            bool exists = false;
            //Is something in \xml?
            if (!Directory.Exists(Common.snippetsFolder))
            {
                //folder does not exist so create it
                Directory.CreateDirectory(Common.snippetsFolder);
                //obviously nothing there
            }
            else
            {
                //Are there files in the directory?
                string[] dirFiles = Directory.GetFiles(Common.snippetsFolder);
                if (dirFiles.Length >= 1)
                {
                    //Start Reading the snippets into the application!!!!
                    //Are there files in the directory?
                    snippetsFiles = Directory.GetFiles(Common.snippetsFolder);
                    exists = true;
                }
            }

            return exists;
        }

        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = AssemblyProduct + " v" + AssemblyVersion;
            tabControl1.Visible = false;

            //Disable SelectAll and Copy since nothing is open
            selectAllToolStripMenuItem.Enabled = false;
            toolStripButton2.Enabled = false;

            copyToolStripMenuItem.Enabled = false;
            toolStripButton3.Enabled = false;

            closeTabToolStripMenuItem.Enabled = false;
            toolStripCloseTab.Enabled = false;

            saveAsToolStripMenuItem.Enabled = false;
            toolStripSaveAs.Enabled = false;

            insertToolStripMenuItem.Enabled = false;
            toolStripcBoxSnippets.Enabled = false;

            //Create the snippets directory if it doesn't exit
            // If files are found in //snippets then return true
            if (InitAppFolders())
            {
                //Start Reading the snippets into the application!!!!
                //snippetsFiles to Combobox?
                //Populate the Decks combobox
                if (snippetsFiles.Length > 0)
                {
                    //Load all of the Names of the decks in the dropdownbox
                    foreach (string file in snippetsFiles)
                    {
                        toolStripcBoxSnippets.Items.Add(Joe.Utils.Helper.GetFileNameFromFullPath(file));
                    }
                    toolStripcBoxSnippets.SelectedIndex = 0;
                }
            }
        }
        #endregion

        #region TabControl Events
        /// <summary>
        /// Is tabPageXML already open?
        /// </summary>
        /// <returns>true if found in tabControl1.TabPages</returns>
        private bool IstabPageXMLOpen()
        {
            bool bFound = false;
            foreach (TabPage item in tabControl1.TabPages)
            {
                if (item.Name == "tabPageXML")
                    bFound = true;
            }

            return bFound;
        }

        /// <summary>
        /// If one is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabPageXML"])
                {
                    //make sure the save buttons are disabled
                    saveAsToolStripMenuItem.Enabled = false;
                    toolStripSaveAs.Enabled = false;
                    //make sure insert buttons are disable
                    insertToolStripMenuItem.Enabled = false;
                    toolStripcBoxSnippets.Enabled = false;
                    //Select All buttons...
                    selectAllToolStripMenuItem.Enabled = false;
                    toolStripButton2.Enabled = false;
                    //Copy buttons...
                    toolStripButton3.Enabled = false;
                    copyToolStripMenuItem.Enabled = false;

                }
                else
                {
                    //should be lsl tabs so enable the save buttons
                    saveAsToolStripMenuItem.Enabled = true;
                    toolStripSaveAs.Enabled = true;
                    //should be lsl tabs so enable the insert buttons
                    insertToolStripMenuItem.Enabled = true;
                    toolStripcBoxSnippets.Enabled = true;
                    //Select All buttons...
                    selectAllToolStripMenuItem.Enabled = true;
                    toolStripButton2.Enabled = true;
                    //Copy buttons...
                    toolStripButton3.Enabled = true;
                    copyToolStripMenuItem.Enabled = true;
                }
            }
        }
        #endregion

        /// <summary>
        /// Save the current SelectedTab's TextBox.Text to a new file
        /// </summary>
        void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "lsl files (*.lsl)|*.lsl|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.InitialDirectory = Application.StartupPath;
            sfd.ShowDialog();

            if (sfd.FileName != string.Empty)
            {
                File.WriteAllText(sfd.FileName, tabControl1.SelectedTab.Controls[0].Text);
            }
        }

        /// <summary>
        /// Close the current SelectedTab and perform other duties
        /// </summary>
        void CloseTab()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPageXML"])
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            else
            {
                tabControl1.SelectedTab.Dispose();
            }

            if (tabControl1.TabPages.Count <= 0)
            {
                closeTabToolStripMenuItem.Enabled = false;
                toolStripCloseTab.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                toolStripSaveAs.Enabled = false;
                insertToolStripMenuItem.Enabled = false;
                toolStripcBoxSnippets.Enabled = false;
                //Select All buttons...
                selectAllToolStripMenuItem.Enabled = false;
                toolStripButton2.Enabled = false;
                //Copy buttons...
                toolStripButton3.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Browse to a file and open it in a new tab
        /// </summary>
        void OpenFiletoTab()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "lsl files (*.lsl)|*.lsl|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //ofd.InitialDirectory = Application.StartupPath + "\\scripts";
            ofd.InitialDirectory = Common.scriptsFolder;
            ofd.ShowDialog();
            try
            {
                if (ofd.FileName != string.Empty)
                {
                    //Enable the tabs
                    if (tabControl1.Visible != true)
                    {
                        //Update the first one
                        //Set the text to display on the tab
                        tabControl1.TabPages[0].Text = Joe.Utils.Helper.GetFileNameFromFullPath(ofd.FileName);
                        //Set the tag to remember fullfilepath
                        tabControl1.TabPages[0].Controls[0].Tag = ofd.FileName;
                        //Set the text inside the Richbox
                        tabControl1.TabPages[0].Controls[0].Text = File.ReadAllText(ofd.FileName);

                        //Do not show XML Creator
                        tabControl1.TabPages.RemoveByKey("tabPageXML");
                        tabControl1.Visible = true;
                    }
                    else
                    {
                        //The tabs were already enabled so add this new one to a new tab
                        tabControl1.TabPages.Add(Joe.Utils.Helper.GetFileNameFromFullPath(ofd.FileName), Joe.Utils.Helper.GetFileNameFromFullPath(ofd.FileName));
                        //Create and add the TextBox
                        TextBox tbox = new TextBox();
                        tbox.Location = this.textBox1.Location;
                        tbox.Anchor = this.textBox1.Anchor;
                        tbox.Size = this.textBox1.Size;
                        tbox.Font = this.textBox1.Font;
                        tbox.ReadOnly = this.textBox1.ReadOnly;
                        tbox.Multiline = this.textBox1.Multiline;
                        //Set the tag to remember fullfilepath
                        tbox.Tag = ofd.FileName;
                        //Set the text inside the Richbox
                        tbox.Text = File.ReadAllText(ofd.FileName);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(tbox);

                        //Make this new one the active tab
                        tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                    }
                    //This new tab may be closed now
                    closeTabToolStripMenuItem.Enabled = true;
                    toolStripCloseTab.Enabled = true;
                    saveAsToolStripMenuItem.Enabled = true;
                    toolStripSaveAs.Enabled = true;
                    insertToolStripMenuItem.Enabled = true;
                    toolStripcBoxSnippets.Enabled = true;
                    //Select All buttons...
                    selectAllToolStripMenuItem.Enabled = true;
                    toolStripButton2.Enabled = true;
                    //Copy buttons...
                    toolStripButton3.Enabled = true;
                    copyToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region XML Snippets tab
        private void btSaveXMLSnippet_Click(object sender, EventArgs e)
        {
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
        #endregion

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

        private void tabControl1_Leave(object sender, EventArgs e)
        {

        }
        /*
        /// <summary>
        /// Entering the Insert lsl toolStripcBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPageXML"])
            {
                //Update the .xml dropdownlist from dir.
                //Create the snippets directory if it doesn't exit
                // If files are found in //snippets then return true
                snippetsFiles = null;//clear
                toolStripcBoxSnippets.Items.Clear();
                if (InitAppFolders())
                {
                    //Start Reading the snippets into the application!!!!
                    //snippetsFiles to Combobox?
                    //Populate the Decks combobox
                    if (snippetsFiles.Length > 0)
                    {
                        //Load all of the Names of the decks in the dropdownbox
                        foreach (string file in snippetsFiles)
                        {
                            toolStripcBoxSnippets.Items.Add(Joe.Utils.Helper.GetFileNameFromFullPath(file));
                        }
                        toolStripcBoxSnippets.SelectedIndex = 0;
                    }
                }
            }
         */

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
        public static string snippetsFolder = Application.StartupPath + "\\snippets";

        /// <summary>
        /// Application.StartupPath + "\\scripts"
        /// </summary>
        public static string scriptsFolder = Application.StartupPath + "\\scripts";
        #endregion
    }
}
