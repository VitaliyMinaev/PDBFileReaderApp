namespace PDBFileReader
{
    partial class PDBForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pdbFileDateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdbFileDateRichTextBox
            // 
            this.pdbFileDateRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdbFileDateRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.pdbFileDateRichTextBox.Name = "pdbFileDateRichTextBox";
            this.pdbFileDateRichTextBox.Size = new System.Drawing.Size(490, 466);
            this.pdbFileDateRichTextBox.TabIndex = 0;
            this.pdbFileDateRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chooseFileButton);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Location = new System.Drawing.Point(508, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 466);
            this.panel1.TabIndex = 1;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(45, 74);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(174, 51);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(12, 12);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(237, 32);
            this.chooseFileButton.TabIndex = 1;
            this.chooseFileButton.Text = "Choose pdb file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // PDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pdbFileDateRichTextBox);
            this.Name = "PDBForm";
            this.Text = "PDB file reader";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox pdbFileDateRichTextBox;
        private Panel panel1;
        private Button loadButton;
        private Button chooseFileButton;
    }
}