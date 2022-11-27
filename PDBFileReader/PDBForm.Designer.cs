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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDBForm));
            this.dataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pdbFileTypeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pdbGuidTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataRichTextBox
            // 
            this.dataRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRichTextBox.BackColor = System.Drawing.Color.White;
            this.dataRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataRichTextBox.Location = new System.Drawing.Point(12, 31);
            this.dataRichTextBox.Name = "dataRichTextBox";
            this.dataRichTextBox.ReadOnly = true;
            this.dataRichTextBox.Size = new System.Drawing.Size(470, 447);
            this.dataRichTextBox.TabIndex = 0;
            this.dataRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pathTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Location = new System.Drawing.Point(488, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 172);
            this.panel1.TabIndex = 1;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathTextBox.Location = new System.Drawing.Point(12, 13);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(260, 30);
            this.pathTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose file";
            this.label1.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 51);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 106);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(174, 36);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pdbFileTypeTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pdbGuidTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(488, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 269);
            this.panel2.TabIndex = 2;
            // 
            // pdbFileTypeTextBox
            // 
            this.pdbFileTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pdbFileTypeTextBox.Location = new System.Drawing.Point(12, 134);
            this.pdbFileTypeTextBox.Name = "pdbFileTypeTextBox";
            this.pdbFileTypeTextBox.ReadOnly = true;
            this.pdbFileTypeTextBox.Size = new System.Drawing.Size(260, 30);
            this.pdbFileTypeTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pdb file type:";
            // 
            // pdbGuidTextBox
            // 
            this.pdbGuidTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pdbGuidTextBox.Location = new System.Drawing.Point(12, 69);
            this.pdbGuidTextBox.Name = "pdbGuidTextBox";
            this.pdbGuidTextBox.ReadOnly = true;
            this.pdbGuidTextBox.Size = new System.Drawing.Size(260, 30);
            this.pdbGuidTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pdb guid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Additional info";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFormatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseFormatToolStripMenuItem
            // 
            this.chooseFormatToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.chooseFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexadecimalToolStripMenuItem,
            this.bytesToolStripMenuItem});
            this.chooseFormatToolStripMenuItem.Name = "chooseFormatToolStripMenuItem";
            this.chooseFormatToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.chooseFormatToolStripMenuItem.Text = "Choose format";
            this.chooseFormatToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.chooseFormatToolStripMenuItem_DropDownItemClicked);
            // 
            // hexadecimalToolStripMenuItem
            // 
            this.hexadecimalToolStripMenuItem.Name = "hexadecimalToolStripMenuItem";
            this.hexadecimalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hexadecimalToolStripMenuItem.Text = "Hexadecimal";
            // 
            // bytesToolStripMenuItem
            // 
            this.bytesToolStripMenuItem.Name = "bytesToolStripMenuItem";
            this.bytesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bytesToolStripMenuItem.Text = "Bytes";
            // 
            // PDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PDBForm";
            this.Text = "PDB file reader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox dataRichTextBox;
        private Panel panel1;
        private Button loadButton;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox pathTextBox;
        private Panel panel2;
        private Label label2;
        private TextBox pdbGuidTextBox;
        private Label label3;
        private TextBox pdbFileTypeTextBox;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chooseFormatToolStripMenuItem;
        private ToolStripMenuItem hexadecimalToolStripMenuItem;
        private ToolStripMenuItem bytesToolStripMenuItem;
    }
}