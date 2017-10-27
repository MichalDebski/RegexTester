namespace RegexTester
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BN = new System.Windows.Forms.Button();
            this.MLCB = new System.Windows.Forms.CheckBox();
            this.GBCB = new System.Windows.Forms.CheckBox();
            this.SLCB = new System.Windows.Forms.CheckBox();
            this.ICCB = new System.Windows.Forms.CheckBox();
            this.TB = new System.Windows.Forms.TextBox();
            this.SS = new System.Windows.Forms.StatusStrip();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.SLAB = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SS.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SS);
            this.splitContainer1.Panel2.Controls.Add(this.rtb);
            this.splitContainer1.Size = new System.Drawing.Size(844, 321);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BN);
            this.panel1.Controls.Add(this.MLCB);
            this.panel1.Controls.Add(this.GBCB);
            this.panel1.Controls.Add(this.SLCB);
            this.panel1.Controls.Add(this.ICCB);
            this.panel1.Controls.Add(this.TB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 98);
            this.panel1.TabIndex = 0;
            // 
            // BN
            // 
            this.BN.Location = new System.Drawing.Point(733, 24);
            this.BN.Name = "BN";
            this.BN.Size = new System.Drawing.Size(75, 23);
            this.BN.TabIndex = 2;
            this.BN.Text = "Match";
            this.BN.UseVisualStyleBackColor = true;
            this.BN.Click += new System.EventHandler(this.BN_Click);
            // 
            // MLCB
            // 
            this.MLCB.AutoSize = true;
            this.MLCB.Location = new System.Drawing.Point(620, 48);
            this.MLCB.Name = "MLCB";
            this.MLCB.Size = new System.Drawing.Size(67, 17);
            this.MLCB.TabIndex = 1;
            this.MLCB.Text = "Multi line";
            this.MLCB.UseVisualStyleBackColor = true;
            // 
            // GBCB
            // 
            this.GBCB.AutoSize = true;
            this.GBCB.Location = new System.Drawing.Point(620, 14);
            this.GBCB.Name = "GBCB";
            this.GBCB.Size = new System.Drawing.Size(56, 17);
            this.GBCB.TabIndex = 1;
            this.GBCB.Text = "Global";
            this.GBCB.UseVisualStyleBackColor = true;
            // 
            // SLCB
            // 
            this.SLCB.AutoSize = true;
            this.SLCB.Location = new System.Drawing.Point(521, 48);
            this.SLCB.Name = "SLCB";
            this.SLCB.Size = new System.Drawing.Size(74, 17);
            this.SLCB.TabIndex = 1;
            this.SLCB.Text = "Single line";
            this.SLCB.UseVisualStyleBackColor = true;
            // 
            // ICCB
            // 
            this.ICCB.AutoSize = true;
            this.ICCB.Location = new System.Drawing.Point(521, 14);
            this.ICCB.Name = "ICCB";
            this.ICCB.Size = new System.Drawing.Size(82, 17);
            this.ICCB.TabIndex = 1;
            this.ICCB.Text = "Ignore case";
            this.ICCB.UseVisualStyleBackColor = true;
            // 
            // TB
            // 
            this.TB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB.Location = new System.Drawing.Point(43, 12);
            this.TB.Multiline = true;
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(425, 66);
            this.TB.TabIndex = 0;
            this.TB.TextChanged += new System.EventHandler(this.TB_TextChanged);
            // 
            // SS
            // 
            this.SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SLAB});
            this.SS.Location = new System.Drawing.Point(0, 204);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(844, 22);
            this.SS.TabIndex = 1;
            this.SS.Text = "statusStrip1";
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb.Location = new System.Drawing.Point(0, 3);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(844, 198);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // SLAB
            // 
            this.SLAB.Name = "SLAB";
            this.SLAB.Size = new System.Drawing.Size(118, 17);
            this.SLAB.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 321);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BN;
        private System.Windows.Forms.CheckBox MLCB;
        private System.Windows.Forms.CheckBox GBCB;
        private System.Windows.Forms.CheckBox SLCB;
        private System.Windows.Forms.CheckBox ICCB;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.StatusStrip SS;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.ToolStripStatusLabel SLAB;
    }
}

