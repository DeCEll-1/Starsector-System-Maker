namespace StarsectorSystemMaker
{
    partial class BaseForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_Info});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Info
            // 
            this.TSMI_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Help});
            this.TSMI_Info.Name = "TSMI_Info";
            this.TSMI_Info.Size = new System.Drawing.Size(40, 20);
            this.TSMI_Info.Text = "Info";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Export,
            this.TSMI_Import});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(37, 20);
            this.TSMI_File.Text = "File";
            // 
            // TSMI_Export
            // 
            this.TSMI_Export.Name = "TSMI_Export";
            this.TSMI_Export.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_Export.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Export.Text = "Export";
            // 
            // TSMI_Import
            // 
            this.TSMI_Import.Name = "TSMI_Import";
            this.TSMI_Import.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.TSMI_Import.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Import.Text = "Import";
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.Name = "TSMI_Help";
            this.TSMI_Help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.TSMI_Help.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Help.Text = "Help";
            this.TSMI_Help.Click += new System.EventHandler(this.TSMI_Help_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 458);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Name = "BaseForm";
            this.Text = "Starsector System Generation Tool by turkos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Export;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Import;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Info;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
    }
}