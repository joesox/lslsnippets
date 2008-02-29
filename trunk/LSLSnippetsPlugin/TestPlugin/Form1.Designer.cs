namespace TestPlugin
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
            this.gBoxSnippetTitle = new System.Windows.Forms.GroupBox();
            this.btSetTitle = new System.Windows.Forms.Button();
            this.tbSnippetTitle = new System.Windows.Forms.TextBox();
            this.gBoxAddSnippet = new System.Windows.Forms.GroupBox();
            this.tbSnippetCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxEvents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddSnippet = new System.Windows.Forms.Button();
            this.gBoxXMLFile = new System.Windows.Forms.GroupBox();
            this.rboxLSLScript = new System.Windows.Forms.RichTextBox();
            this.btOpenLSL = new System.Windows.Forms.Button();
            this.btOpenXML = new System.Windows.Forms.Button();
            this.btDoInsert = new System.Windows.Forms.Button();
            this.btSaveXMLSnippet = new System.Windows.Forms.Button();
            this.tbXMLFile = new System.Windows.Forms.TextBox();
            this.gBoxSnippetTitle.SuspendLayout();
            this.gBoxAddSnippet.SuspendLayout();
            this.gBoxXMLFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSnippetTitle
            // 
            this.gBoxSnippetTitle.Controls.Add(this.btSetTitle);
            this.gBoxSnippetTitle.Controls.Add(this.tbSnippetTitle);
            this.gBoxSnippetTitle.Location = new System.Drawing.Point(10, 17);
            this.gBoxSnippetTitle.Name = "gBoxSnippetTitle";
            this.gBoxSnippetTitle.Size = new System.Drawing.Size(322, 57);
            this.gBoxSnippetTitle.TabIndex = 10;
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
            this.tbSnippetTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSnippetTitle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSnippetTitle.Location = new System.Drawing.Point(7, 20);
            this.tbSnippetTitle.Name = "tbSnippetTitle";
            this.tbSnippetTitle.Size = new System.Drawing.Size(228, 20);
            this.tbSnippetTitle.TabIndex = 0;
            // 
            // gBoxAddSnippet
            // 
            this.gBoxAddSnippet.Controls.Add(this.tbSnippetCode);
            this.gBoxAddSnippet.Controls.Add(this.label2);
            this.gBoxAddSnippet.Controls.Add(this.cBoxEvents);
            this.gBoxAddSnippet.Controls.Add(this.label1);
            this.gBoxAddSnippet.Controls.Add(this.btAddSnippet);
            this.gBoxAddSnippet.Location = new System.Drawing.Point(10, 80);
            this.gBoxAddSnippet.Name = "gBoxAddSnippet";
            this.gBoxAddSnippet.Size = new System.Drawing.Size(322, 402);
            this.gBoxAddSnippet.TabIndex = 11;
            this.gBoxAddSnippet.TabStop = false;
            this.gBoxAddSnippet.Text = "Add Snippet...";
            // 
            // tbSnippetCode
            // 
            this.tbSnippetCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSnippetCode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSnippetCode.Location = new System.Drawing.Point(10, 86);
            this.tbSnippetCode.Multiline = true;
            this.tbSnippetCode.Name = "tbSnippetCode";
            this.tbSnippetCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSnippetCode.Size = new System.Drawing.Size(306, 310);
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
            "state_entry",
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
            // gBoxXMLFile
            // 
            this.gBoxXMLFile.Controls.Add(this.rboxLSLScript);
            this.gBoxXMLFile.Controls.Add(this.btOpenLSL);
            this.gBoxXMLFile.Controls.Add(this.btOpenXML);
            this.gBoxXMLFile.Controls.Add(this.btDoInsert);
            this.gBoxXMLFile.Controls.Add(this.btSaveXMLSnippet);
            this.gBoxXMLFile.Controls.Add(this.tbXMLFile);
            this.gBoxXMLFile.Location = new System.Drawing.Point(339, 17);
            this.gBoxXMLFile.Name = "gBoxXMLFile";
            this.gBoxXMLFile.Size = new System.Drawing.Size(360, 465);
            this.gBoxXMLFile.TabIndex = 9;
            this.gBoxXMLFile.TabStop = false;
            this.gBoxXMLFile.Text = "XML Snippet File...";
            // 
            // rboxLSLScript
            // 
            this.rboxLSLScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rboxLSLScript.Location = new System.Drawing.Point(6, 247);
            this.rboxLSLScript.Name = "rboxLSLScript";
            this.rboxLSLScript.Size = new System.Drawing.Size(348, 183);
            this.rboxLSLScript.TabIndex = 6;
            this.rboxLSLScript.Text = "";
            // 
            // btOpenLSL
            // 
            this.btOpenLSL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOpenLSL.Location = new System.Drawing.Point(6, 436);
            this.btOpenLSL.Name = "btOpenLSL";
            this.btOpenLSL.Size = new System.Drawing.Size(133, 23);
            this.btOpenLSL.TabIndex = 5;
            this.btOpenLSL.Text = "Open LSL Script...";
            this.btOpenLSL.UseVisualStyleBackColor = true;
            this.btOpenLSL.Click += new System.EventHandler(this.btOpenLSL_Click);
            // 
            // btOpenXML
            // 
            this.btOpenXML.Location = new System.Drawing.Point(6, 218);
            this.btOpenXML.Name = "btOpenXML";
            this.btOpenXML.Size = new System.Drawing.Size(133, 23);
            this.btOpenXML.TabIndex = 4;
            this.btOpenXML.Text = "Open XMLSnippet...";
            this.btOpenXML.UseVisualStyleBackColor = true;
            this.btOpenXML.Click += new System.EventHandler(this.btOpenXML_Click);
            // 
            // btDoInsert
            // 
            this.btDoInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btDoInsert.Location = new System.Drawing.Point(195, 436);
            this.btDoInsert.Name = "btDoInsert";
            this.btDoInsert.Size = new System.Drawing.Size(159, 23);
            this.btDoInsert.TabIndex = 3;
            this.btDoInsert.Text = "Insert this LSLSnippet";
            this.btDoInsert.UseVisualStyleBackColor = true;
            this.btDoInsert.Click += new System.EventHandler(this.btDoInsert_Click);
            // 
            // btSaveXMLSnippet
            // 
            this.btSaveXMLSnippet.Location = new System.Drawing.Point(255, 218);
            this.btSaveXMLSnippet.Name = "btSaveXMLSnippet";
            this.btSaveXMLSnippet.Size = new System.Drawing.Size(99, 23);
            this.btSaveXMLSnippet.TabIndex = 1;
            this.btSaveXMLSnippet.Text = "Save XML As...";
            this.btSaveXMLSnippet.UseVisualStyleBackColor = true;
            this.btSaveXMLSnippet.Click += new System.EventHandler(this.btSaveXMLSnippet_Click);
            // 
            // tbXMLFile
            // 
            this.tbXMLFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXMLFile.Location = new System.Drawing.Point(6, 19);
            this.tbXMLFile.Multiline = true;
            this.tbXMLFile.Name = "tbXMLFile";
            this.tbXMLFile.ReadOnly = true;
            this.tbXMLFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXMLFile.Size = new System.Drawing.Size(348, 193);
            this.tbXMLFile.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 499);
            this.Controls.Add(this.gBoxSnippetTitle);
            this.Controls.Add(this.gBoxAddSnippet);
            this.Controls.Add(this.gBoxXMLFile);
            this.Name = "Form1";
            this.Text = "XML LSLSnippets Creator";
            this.gBoxSnippetTitle.ResumeLayout(false);
            this.gBoxSnippetTitle.PerformLayout();
            this.gBoxAddSnippet.ResumeLayout(false);
            this.gBoxAddSnippet.PerformLayout();
            this.gBoxXMLFile.ResumeLayout(false);
            this.gBoxXMLFile.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox gBoxSnippetTitle;
        private System.Windows.Forms.Button btSetTitle;
        private System.Windows.Forms.TextBox tbSnippetTitle;
        private System.Windows.Forms.GroupBox gBoxAddSnippet;
        private System.Windows.Forms.TextBox tbSnippetCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddSnippet;
        private System.Windows.Forms.GroupBox gBoxXMLFile;
        private System.Windows.Forms.RichTextBox rboxLSLScript;
        private System.Windows.Forms.Button btOpenLSL;
        private System.Windows.Forms.Button btOpenXML;
        private System.Windows.Forms.Button btDoInsert;
        private System.Windows.Forms.Button btSaveXMLSnippet;
        private System.Windows.Forms.TextBox tbXMLFile;



    }
}

