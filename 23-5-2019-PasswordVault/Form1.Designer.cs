namespace PasswordVault
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSpecialDSte = new System.Windows.Forms.CheckBox();
            this.cbLetterDSte = new System.Windows.Forms.CheckBox();
            this.cbNumDSte = new System.Windows.Forms.CheckBox();
            this.cbCapitalsDSte = new System.Windows.Forms.CheckBox();
            this.btnGenerateDSte = new System.Windows.Forms.Button();
            this.txbOutputDSte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Length";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(108, 11);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSpecialDSte);
            this.groupBox1.Controls.Add(this.cbLetterDSte);
            this.groupBox1.Controls.Add(this.cbNumDSte);
            this.groupBox1.Controls.Add(this.cbCapitalsDSte);
            this.groupBox1.Location = new System.Drawing.Point(16, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characters";
            // 
            // cbSpecialDSte
            // 
            this.cbSpecialDSte.AutoSize = true;
            this.cbSpecialDSte.Location = new System.Drawing.Point(109, 44);
            this.cbSpecialDSte.Name = "cbSpecialDSte";
            this.cbSpecialDSte.Size = new System.Drawing.Size(91, 17);
            this.cbSpecialDSte.TabIndex = 3;
            this.cbSpecialDSte.Text = "Special Chars";
            this.cbSpecialDSte.UseVisualStyleBackColor = true;
            this.cbSpecialDSte.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // cbLetterDSte
            // 
            this.cbLetterDSte.AutoSize = true;
            this.cbLetterDSte.Checked = true;
            this.cbLetterDSte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLetterDSte.Location = new System.Drawing.Point(7, 44);
            this.cbLetterDSte.Name = "cbLetterDSte";
            this.cbLetterDSte.Size = new System.Drawing.Size(94, 17);
            this.cbLetterDSte.TabIndex = 2;
            this.cbLetterDSte.Text = "Normal Letters";
            this.cbLetterDSte.UseVisualStyleBackColor = true;
            this.cbLetterDSte.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // cbNumDSte
            // 
            this.cbNumDSte.AutoSize = true;
            this.cbNumDSte.Checked = true;
            this.cbNumDSte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumDSte.Location = new System.Drawing.Point(109, 20);
            this.cbNumDSte.Name = "cbNumDSte";
            this.cbNumDSte.Size = new System.Drawing.Size(68, 17);
            this.cbNumDSte.TabIndex = 1;
            this.cbNumDSte.Text = "Numbers";
            this.cbNumDSte.UseVisualStyleBackColor = true;
            this.cbNumDSte.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // cbCapitalsDSte
            // 
            this.cbCapitalsDSte.AutoSize = true;
            this.cbCapitalsDSte.Checked = true;
            this.cbCapitalsDSte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCapitalsDSte.Location = new System.Drawing.Point(7, 20);
            this.cbCapitalsDSte.Name = "cbCapitalsDSte";
            this.cbCapitalsDSte.Size = new System.Drawing.Size(63, 17);
            this.cbCapitalsDSte.TabIndex = 0;
            this.cbCapitalsDSte.Text = "Capitals";
            this.cbCapitalsDSte.UseVisualStyleBackColor = true;
            this.cbCapitalsDSte.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // btnGenerateDSte
            // 
            this.btnGenerateDSte.Location = new System.Drawing.Point(16, 189);
            this.btnGenerateDSte.Name = "btnGenerateDSte";
            this.btnGenerateDSte.Size = new System.Drawing.Size(252, 37);
            this.btnGenerateDSte.TabIndex = 3;
            this.btnGenerateDSte.Text = "Generate";
            this.btnGenerateDSte.UseVisualStyleBackColor = true;
            this.btnGenerateDSte.Click += new System.EventHandler(this.btnGenerateDSte_Click);
            // 
            // txbOutputDSte
            // 
            this.txbOutputDSte.Location = new System.Drawing.Point(16, 250);
            this.txbOutputDSte.Multiline = true;
            this.txbOutputDSte.Name = "txbOutputDSte";
            this.txbOutputDSte.ReadOnly = true;
            this.txbOutputDSte.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbOutputDSte.Size = new System.Drawing.Size(252, 20);
            this.txbOutputDSte.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbOutputDSte);
            this.Controls.Add(this.btnGenerateDSte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSpecialDSte;
        private System.Windows.Forms.CheckBox cbLetterDSte;
        private System.Windows.Forms.CheckBox cbNumDSte;
        private System.Windows.Forms.CheckBox cbCapitalsDSte;
        private System.Windows.Forms.Button btnGenerateDSte;
        private System.Windows.Forms.TextBox txbOutputDSte;
    }
}

