﻿namespace AACMAToolkit.Forms
{
    partial class ExtensionConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtensionConfigForm));
            this.btnReloadAllowlist = new System.Windows.Forms.Button();
            this.txtAllowlistExtension = new System.Windows.Forms.TextBox();
            this.btnAddToAllowlist = new System.Windows.Forms.Button();
            this.btnReloadExtensions = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvExtensions = new System.Windows.Forms.ListView();
            this.Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabelExtentionListMS = new System.Windows.Forms.LinkLabel();
            this.lbAllowlist = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearAllowlist = new System.Windows.Forms.Button();
            this.btnRemoveFromAllowlist = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReloadAllowlist
            // 
            this.btnReloadAllowlist.Location = new System.Drawing.Point(361, 32);
            this.btnReloadAllowlist.Name = "btnReloadAllowlist";
            this.btnReloadAllowlist.Size = new System.Drawing.Size(93, 23);
            this.btnReloadAllowlist.TabIndex = 1;
            this.btnReloadAllowlist.Text = "Reload allowlist";
            this.btnReloadAllowlist.UseVisualStyleBackColor = true;
            this.btnReloadAllowlist.Click += new System.EventHandler(this.btnReloadAllowlist_Click);
            // 
            // txtAllowlistExtension
            // 
            this.txtAllowlistExtension.Location = new System.Drawing.Point(361, 6);
            this.txtAllowlistExtension.Name = "txtAllowlistExtension";
            this.txtAllowlistExtension.Size = new System.Drawing.Size(324, 20);
            this.txtAllowlistExtension.TabIndex = 3;
            // 
            // btnAddToAllowlist
            // 
            this.btnAddToAllowlist.Location = new System.Drawing.Point(361, 119);
            this.btnAddToAllowlist.Name = "btnAddToAllowlist";
            this.btnAddToAllowlist.Size = new System.Drawing.Size(93, 23);
            this.btnAddToAllowlist.TabIndex = 4;
            this.btnAddToAllowlist.Text = "Add";
            this.btnAddToAllowlist.UseVisualStyleBackColor = true;
            this.btnAddToAllowlist.Click += new System.EventHandler(this.btnAddCustomExtension_Click);
            // 
            // btnReloadExtensions
            // 
            this.btnReloadExtensions.Location = new System.Drawing.Point(293, 251);
            this.btnReloadExtensions.Name = "btnReloadExtensions";
            this.btnReloadExtensions.Size = new System.Drawing.Size(122, 23);
            this.btnReloadExtensions.TabIndex = 6;
            this.btnReloadExtensions.Text = "Reload extension list";
            this.btnReloadExtensions.UseVisualStyleBackColor = true;
            this.btnReloadExtensions.Click += new System.EventHandler(this.buttonReloadInstalledExtentions_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 306);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvExtensions);
            this.tabPage1.Controls.Add(this.btnReloadExtensions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Installed extentions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvExtensions
            // 
            this.lvExtensions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Extension,
            this.Version,
            this.Path,
            this.State});
            this.lvExtensions.HideSelection = false;
            this.lvExtensions.Location = new System.Drawing.Point(6, 7);
            this.lvExtensions.Name = "lvExtensions";
            this.lvExtensions.Size = new System.Drawing.Size(699, 238);
            this.lvExtensions.TabIndex = 7;
            this.lvExtensions.UseCompatibleStateImageBehavior = false;
            this.lvExtensions.View = System.Windows.Forms.View.Details;
            // 
            // Extension
            // 
            this.Extension.Text = "Extension";
            this.Extension.Width = 210;
            // 
            // Version
            // 
            this.Version.Text = "Version";
            this.Version.Width = 70;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 330;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 80;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Allowlist/blocklist";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(699, 268);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.linkLabelExtentionListMS);
            this.tabPage4.Controls.Add(this.lbAllowlist);
            this.tabPage4.Controls.Add(this.btnSave);
            this.tabPage4.Controls.Add(this.btnClearAllowlist);
            this.tabPage4.Controls.Add(this.btnReloadAllowlist);
            this.tabPage4.Controls.Add(this.btnAddToAllowlist);
            this.tabPage4.Controls.Add(this.btnRemoveFromAllowlist);
            this.tabPage4.Controls.Add(this.txtAllowlistExtension);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(691, 242);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Manage Allowlist";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkLabelExtentionListMS
            // 
            this.linkLabelExtentionListMS.AutoSize = true;
            this.linkLabelExtentionListMS.Location = new System.Drawing.Point(364, 174);
            this.linkLabelExtentionListMS.Name = "linkLabelExtentionListMS";
            this.linkLabelExtentionListMS.Size = new System.Drawing.Size(88, 13);
            this.linkLabelExtentionListMS.TabIndex = 9;
            this.linkLabelExtentionListMS.TabStop = true;
            this.linkLabelExtentionListMS.Text = "List of extensions";
            this.linkLabelExtentionListMS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExtentionListMS_LinkClicked);
            // 
            // lbAllowlist
            // 
            this.lbAllowlist.FormattingEnabled = true;
            this.lbAllowlist.Location = new System.Drawing.Point(6, 6);
            this.lbAllowlist.Name = "lbAllowlist";
            this.lbAllowlist.Size = new System.Drawing.Size(349, 225);
            this.lbAllowlist.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearAllowlist
            // 
            this.btnClearAllowlist.Location = new System.Drawing.Point(361, 61);
            this.btnClearAllowlist.Name = "btnClearAllowlist";
            this.btnClearAllowlist.Size = new System.Drawing.Size(93, 23);
            this.btnClearAllowlist.TabIndex = 7;
            this.btnClearAllowlist.Text = "Clear";
            this.btnClearAllowlist.UseVisualStyleBackColor = true;
            this.btnClearAllowlist.Click += new System.EventHandler(this.btnClearAllowlist_Click);
            // 
            // btnRemoveFromAllowlist
            // 
            this.btnRemoveFromAllowlist.Location = new System.Drawing.Point(361, 90);
            this.btnRemoveFromAllowlist.Name = "btnRemoveFromAllowlist";
            this.btnRemoveFromAllowlist.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveFromAllowlist.TabIndex = 5;
            this.btnRemoveFromAllowlist.Text = "Remove";
            this.btnRemoveFromAllowlist.UseVisualStyleBackColor = true;
            this.btnRemoveFromAllowlist.Click += new System.EventHandler(this.btnRemoveFromAllowlist_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(691, 242);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Manage Blocklist";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(516, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "PREVIEW/TESTING STAGE";
            // 
            // ExtensionConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExtensionConfigForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extension manager";
            this.Shown += new System.EventHandler(this.ExtensionConfigForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReloadAllowlist;
        private System.Windows.Forms.TextBox txtAllowlistExtension;
        private System.Windows.Forms.Button btnAddToAllowlist;
        private System.Windows.Forms.Button btnReloadExtensions;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvExtensions;
        private System.Windows.Forms.ColumnHeader Extension;
        private System.Windows.Forms.ColumnHeader Version;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.Button btnRemoveFromAllowlist;
        private System.Windows.Forms.ListBox lbAllowlist;
        private System.Windows.Forms.Button btnClearAllowlist;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.LinkLabel linkLabelExtentionListMS;
        private System.Windows.Forms.Label label1;
    }
}