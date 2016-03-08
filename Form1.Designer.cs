namespace tx_applying_master_templates
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
            this.buttonBar1 = new TXTextControl.ButtonBar();
            this.statusBar1 = new TXTextControl.StatusBar();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.rulerBar2 = new TXTextControl.RulerBar();
            this.textControl1 = new TXTextControl.TextControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyMasterTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBar1
            // 
            this.buttonBar1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBar1.Location = new System.Drawing.Point(0, 24);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(788, 28);
            this.buttonBar1.TabIndex = 1;
            this.buttonBar1.Text = "buttonBar1";
            // 
            // statusBar1
            // 
            this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 527);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(788, 22);
            this.statusBar1.TabIndex = 2;
            // 
            // rulerBar1
            // 
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar1.Location = new System.Drawing.Point(0, 52);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(788, 25);
            this.rulerBar1.TabIndex = 3;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // rulerBar2
            // 
            this.rulerBar2.Alignment = TXTextControl.RulerBarAlignment.Left;
            this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.rulerBar2.Location = new System.Drawing.Point(0, 77);
            this.rulerBar2.Name = "rulerBar2";
            this.rulerBar2.Size = new System.Drawing.Size(25, 450);
            this.rulerBar2.TabIndex = 4;
            this.rulerBar2.Text = "rulerBar2";
            // 
            // textControl1
            // 
            this.textControl1.ButtonBar = this.buttonBar1;
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(25, 77);
            this.textControl1.Name = "textControl1";
            this.textControl1.RulerBar = this.rulerBar1;
            this.textControl1.Size = new System.Drawing.Size(763, 450);
            this.textControl1.StatusBar = this.statusBar1;
            this.textControl1.TabIndex = 0;
            this.textControl1.VerticalRulerBar = this.rulerBar2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.applyMasterTemplateToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // applyMasterTemplateToolStripMenuItem
            // 
            this.applyMasterTemplateToolStripMenuItem.Name = "applyMasterTemplateToolStripMenuItem";
            this.applyMasterTemplateToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.applyMasterTemplateToolStripMenuItem.Text = "Apply Master Template";
            this.applyMasterTemplateToolStripMenuItem.Click += new System.EventHandler(this.applyMasterTemplateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 549);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.rulerBar2);
            this.Controls.Add(this.rulerBar1);
            this.Controls.Add(this.buttonBar1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TX Text Control Sample: Apply Master Templates";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TXTextControl.ButtonBar buttonBar1;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.RulerBar rulerBar1;
        private TXTextControl.RulerBar rulerBar2;
        private TXTextControl.TextControl textControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyMasterTemplateToolStripMenuItem;
    }
}

