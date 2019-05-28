namespace Ksu.Cis300.TextEditor
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
            this.uxEditorMenu = new System.Windows.Forms.MenuStrip();
            this.uxFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextBox1 = new System.Windows.Forms.TextBox();
            this.uxOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.uxEditorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxEditorMenu
            // 
            this.uxEditorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileButton});
            this.uxEditorMenu.Location = new System.Drawing.Point(0, 0);
            this.uxEditorMenu.Name = "uxEditorMenu";
            this.uxEditorMenu.Size = new System.Drawing.Size(624, 24);
            this.uxEditorMenu.TabIndex = 0;
            this.uxEditorMenu.Text = "menuStrip1";
            // 
            // uxFileButton
            // 
            this.uxFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenButton,
            this.uxSaveAsButton});
            this.uxFileButton.Name = "uxFileButton";
            this.uxFileButton.Size = new System.Drawing.Size(37, 20);
            this.uxFileButton.Text = "File";
            // 
            // uxOpenButton
            // 
            this.uxOpenButton.Name = "uxOpenButton";
            this.uxOpenButton.Size = new System.Drawing.Size(180, 22);
            this.uxOpenButton.Text = "Open";
            this.uxOpenButton.Click += new System.EventHandler(this.UxOpenButton_Click);
            // 
            // uxSaveAsButton
            // 
            this.uxSaveAsButton.Name = "uxSaveAsButton";
            this.uxSaveAsButton.Size = new System.Drawing.Size(180, 22);
            this.uxSaveAsButton.Text = "Save As";
            this.uxSaveAsButton.Click += new System.EventHandler(this.UxSaveAsButton_Click);
            // 
            // uxTextBox1
            // 
            this.uxTextBox1.Location = new System.Drawing.Point(12, 55);
            this.uxTextBox1.Multiline = true;
            this.uxTextBox1.Name = "uxTextBox1";
            this.uxTextBox1.Size = new System.Drawing.Size(589, 416);
            this.uxTextBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 517);
            this.Controls.Add(this.uxTextBox1);
            this.Controls.Add(this.uxEditorMenu);
            this.MainMenuStrip = this.uxEditorMenu;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.uxEditorMenu.ResumeLayout(false);
            this.uxEditorMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxEditorMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFileButton;
        private System.Windows.Forms.ToolStripMenuItem uxOpenButton;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAsButton;
        private System.Windows.Forms.TextBox uxTextBox1;
        private System.Windows.Forms.OpenFileDialog uxOpenFile;
        private System.Windows.Forms.SaveFileDialog uxSaveFile;
    }
}

