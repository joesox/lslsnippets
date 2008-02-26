namespace lslSnippetsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snippetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripcBoxSnippets = new System.Windows.Forms.ToolStripComboBox();
            this.createXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugSubmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageXML = new System.Windows.Forms.TabPage();
            this.gBoxAddSnippet = new System.Windows.Forms.GroupBox();
            this.tbSnippetCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxEvents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddSnippet = new System.Windows.Forms.Button();
            this.gBoxSnippetTitle = new System.Windows.Forms.GroupBox();
            this.btSetTitle = new System.Windows.Forms.Button();
            this.tbSnippetTitle = new System.Windows.Forms.TextBox();
            this.gBoxXMLFile = new System.Windows.Forms.GroupBox();
            this.btSaveXMLSnippet = new System.Windows.Forms.Button();
            this.tbXMLFile = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripCloseTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageXML.SuspendLayout();
            this.gBoxAddSnippet.SuspendLayout();
            this.gBoxSnippetTitle.SuspendLayout();
            this.gBoxXMLFile.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.snippetsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeTabToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeTabToolStripMenuItem.Image")));
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // snippetsToolStripMenuItem
            // 
            this.snippetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.createXMLToolStripMenuItem});
            this.snippetsToolStripMenuItem.Name = "snippetsToolStripMenuItem";
            this.snippetsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.snippetsToolStripMenuItem.Text = "Snippets";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripcBoxSnippets});
            this.insertToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("insertToolStripMenuItem.Image")));
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // toolStripcBoxSnippets
            // 
            this.toolStripcBoxSnippets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripcBoxSnippets.Enabled = false;
            this.toolStripcBoxSnippets.Name = "toolStripcBoxSnippets";
            this.toolStripcBoxSnippets.Size = new System.Drawing.Size(121, 21);
            this.toolStripcBoxSnippets.SelectedIndexChanged += new System.EventHandler(this.toolStripcBoxSnippets_SelectedIndexChanged);
            // 
            // createXMLToolStripMenuItem
            // 
            this.createXMLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createXMLToolStripMenuItem.Image")));
            this.createXMLToolStripMenuItem.Name = "createXMLToolStripMenuItem";
            this.createXMLToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.createXMLToolStripMenuItem.Text = "Create XML";
            this.createXMLToolStripMenuItem.Click += new System.EventHandler(this.createXMLToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpWikiToolStripMenuItem,
            this.bugSubmissionToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // onlineHelpWikiToolStripMenuItem
            // 
            this.onlineHelpWikiToolStripMenuItem.Name = "onlineHelpWikiToolStripMenuItem";
            this.onlineHelpWikiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.onlineHelpWikiToolStripMenuItem.Text = "Online Help Wiki";
            this.onlineHelpWikiToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpWikiToolStripMenuItem_Click);
            // 
            // bugSubmissionToolStripMenuItem
            // 
            this.bugSubmissionToolStripMenuItem.Name = "bugSubmissionToolStripMenuItem";
            this.bugSubmissionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bugSubmissionToolStripMenuItem.Text = "Bug Submission";
            this.bugSubmissionToolStripMenuItem.Click += new System.EventHandler(this.bugSubmissionToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageXML);
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 445);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LSL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(691, 407);
            this.textBox1.TabIndex = 0;
            // 
            // tabPageXML
            // 
            this.tabPageXML.Controls.Add(this.gBoxAddSnippet);
            this.tabPageXML.Controls.Add(this.gBoxSnippetTitle);
            this.tabPageXML.Controls.Add(this.gBoxXMLFile);
            this.tabPageXML.Location = new System.Drawing.Point(4, 22);
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.Size = new System.Drawing.Size(705, 419);
            this.tabPageXML.TabIndex = 1;
            this.tabPageXML.Text = "XML Creator";
            this.tabPageXML.UseVisualStyleBackColor = true;
            // 
            // gBoxAddSnippet
            // 
            this.gBoxAddSnippet.Controls.Add(this.tbSnippetCode);
            this.gBoxAddSnippet.Controls.Add(this.label2);
            this.gBoxAddSnippet.Controls.Add(this.cBoxEvents);
            this.gBoxAddSnippet.Controls.Add(this.label1);
            this.gBoxAddSnippet.Controls.Add(this.btAddSnippet);
            this.gBoxAddSnippet.Location = new System.Drawing.Point(9, 67);
            this.gBoxAddSnippet.Name = "gBoxAddSnippet";
            this.gBoxAddSnippet.Size = new System.Drawing.Size(322, 346);
            this.gBoxAddSnippet.TabIndex = 2;
            this.gBoxAddSnippet.TabStop = false;
            this.gBoxAddSnippet.Text = "Add Snippet...";
            // 
            // tbSnippetCode
            // 
            this.tbSnippetCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSnippetCode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSnippetCode.Location = new System.Drawing.Point(10, 86);
            this.tbSnippetCode.Multiline = true;
            this.tbSnippetCode.Name = "tbSnippetCode";
            this.tbSnippetCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSnippetCode.Size = new System.Drawing.Size(306, 254);
            this.tbSnippetCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code:";
            // 
            // cBoxEvents
            // 
            this.cBoxEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEvents.FormattingEnabled = true;
            this.cBoxEvents.Items.AddRange(new object[] {
            "Choose a Method...",
            "at_rot_target",
            "at_target",
            "attach",
            "changed",
            "collision",
            "collision_end",
            "collision_start",
            "control",
            "dataserver",
            "email",
            "http_response",
            "land_collision",
            "land_collision_end",
            "land_collision_start",
            "link_message",
            "listen",
            "lslstart",
            "lslend",
            "money",
            "moving_end",
            "moving_start",
            "no_sensor",
            "not_at_rot_target",
            "not_at_target",
            "object_rez",
            "on_rez",
            "remote_data",
            "run_time_permissions",
            "sensor",
            "state_exit",
            "timer",
            "touch",
            "touch_start",
            "touch_end"});
            this.cBoxEvents.Location = new System.Drawing.Point(7, 37);
            this.cBoxEvents.Name = "cBoxEvents";
            this.cBoxEvents.Size = new System.Drawing.Size(209, 21);
            this.cBoxEvents.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "InsertToEvent:";
            // 
            // btAddSnippet
            // 
            this.btAddSnippet.Location = new System.Drawing.Point(241, 20);
            this.btAddSnippet.Name = "btAddSnippet";
            this.btAddSnippet.Size = new System.Drawing.Size(75, 23);
            this.btAddSnippet.TabIndex = 1;
            this.btAddSnippet.Text = "Add >";
            this.btAddSnippet.UseVisualStyleBackColor = true;
            this.btAddSnippet.Click += new System.EventHandler(this.btAddSnippet_Click);
            // 
            // gBoxSnippetTitle
            // 
            this.gBoxSnippetTitle.Controls.Add(this.btSetTitle);
            this.gBoxSnippetTitle.Controls.Add(this.tbSnippetTitle);
            this.gBoxSnippetTitle.Location = new System.Drawing.Point(9, 4);
            this.gBoxSnippetTitle.Name = "gBoxSnippetTitle";
            this.gBoxSnippetTitle.Size = new System.Drawing.Size(322, 57);
            this.gBoxSnippetTitle.TabIndex = 1;
            this.gBoxSnippetTitle.TabStop = false;
            this.gBoxSnippetTitle.Text = "Snippet Title...";
            // 
            // btSetTitle
            // 
            this.btSetTitle.Location = new System.Drawing.Point(241, 20);
            this.btSetTitle.Name = "btSetTitle";
            this.btSetTitle.Size = new System.Drawing.Size(75, 23);
            this.btSetTitle.TabIndex = 1;
            this.btSetTitle.Text = "Set Title >";
            this.btSetTitle.UseVisualStyleBackColor = true;
            this.btSetTitle.Click += new System.EventHandler(this.btSetTitle_Click);
            // 
            // tbSnippetTitle
            // 
            this.tbSnippetTitle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSnippetTitle.Location = new System.Drawing.Point(7, 20);
            this.tbSnippetTitle.Name = "tbSnippetTitle";
            this.tbSnippetTitle.Size = new System.Drawing.Size(228, 20);
            this.tbSnippetTitle.TabIndex = 0;
            // 
            // gBoxXMLFile
            // 
            this.gBoxXMLFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxXMLFile.Controls.Add(this.btSaveXMLSnippet);
            this.gBoxXMLFile.Controls.Add(this.tbXMLFile);
            this.gBoxXMLFile.Location = new System.Drawing.Point(337, 3);
            this.gBoxXMLFile.Name = "gBoxXMLFile";
            this.gBoxXMLFile.Size = new System.Drawing.Size(360, 410);
            this.gBoxXMLFile.TabIndex = 0;
            this.gBoxXMLFile.TabStop = false;
            this.gBoxXMLFile.Text = "XML Snippet File...";
            // 
            // btSaveXMLSnippet
            // 
            this.btSaveXMLSnippet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveXMLSnippet.Location = new System.Drawing.Point(16, 369);
            this.btSaveXMLSnippet.Name = "btSaveXMLSnippet";
            this.btSaveXMLSnippet.Size = new System.Drawing.Size(99, 23);
            this.btSaveXMLSnippet.TabIndex = 1;
            this.btSaveXMLSnippet.Text = "Save XML As...";
            this.btSaveXMLSnippet.UseVisualStyleBackColor = true;
            this.btSaveXMLSnippet.Click += new System.EventHandler(this.btSaveXMLSnippet_Click);
            // 
            // tbXMLFile
            // 
            this.tbXMLFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXMLFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXMLFile.Location = new System.Drawing.Point(6, 19);
            this.tbXMLFile.Multiline = true;
            this.tbXMLFile.Name = "tbXMLFile";
            this.tbXMLFile.ReadOnly = true;
            this.tbXMLFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXMLFile.Size = new System.Drawing.Size(348, 331);
            this.tbXMLFile.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripCloseTab,
            this.toolStripSaveAs,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(713, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripCloseTab
            // 
            this.toolStripCloseTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCloseTab.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCloseTab.Image")));
            this.toolStripCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCloseTab.Name = "toolStripCloseTab";
            this.toolStripCloseTab.Size = new System.Drawing.Size(23, 22);
            this.toolStripCloseTab.Text = "Close Tab";
            this.toolStripCloseTab.Click += new System.EventHandler(this.toolStripCloseTab_Click);
            // 
            // toolStripSaveAs
            // 
            this.toolStripSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveAs.Image")));
            this.toolStripSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveAs.Name = "toolStripSaveAs";
            this.toolStripSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveAs.Text = "Save As...";
            this.toolStripSaveAs.Click += new System.EventHandler(this.toolStripSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Select All";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Copy";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripExit
            // 
            this.toolStripExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 499);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageXML.ResumeLayout(false);
            this.gBoxAddSnippet.ResumeLayout(false);
            this.gBoxAddSnippet.PerformLayout();
            this.gBoxSnippetTitle.ResumeLayout(false);
            this.gBoxSnippetTitle.PerformLayout();
            this.gBoxXMLFile.ResumeLayout(false);
            this.gBoxXMLFile.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripCloseTab;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripSaveAs;
        private System.Windows.Forms.ToolStripMenuItem snippetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripcBoxSnippets;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bugSubmissionToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageXML;
        private System.Windows.Forms.ToolStripMenuItem createXMLToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxXMLFile;
        private System.Windows.Forms.TextBox tbXMLFile;
        private System.Windows.Forms.Button btSaveXMLSnippet;
        private System.Windows.Forms.TextBox tbSnippetTitle;
        private System.Windows.Forms.Button btSetTitle;
        private System.Windows.Forms.GroupBox gBoxAddSnippet;
        private System.Windows.Forms.Button btAddSnippet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxEvents;
        private System.Windows.Forms.TextBox tbSnippetCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBoxSnippetTitle;
    }
}

