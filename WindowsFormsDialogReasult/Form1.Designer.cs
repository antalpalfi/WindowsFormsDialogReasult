namespace WindowsFormsDialogReasult
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxCredit = new System.Windows.Forms.ListBox();
            this.btnOversc = new System.Windows.Forms.Button();
            this.btnNiewR = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antal Bank";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxCredit
            // 
            this.listBoxCredit.FormattingEnabled = true;
            this.listBoxCredit.Location = new System.Drawing.Point(192, 53);
            this.listBoxCredit.Name = "listBoxCredit";
            this.listBoxCredit.Size = new System.Drawing.Size(120, 95);
            this.listBoxCredit.TabIndex = 4;
            this.listBoxCredit.SelectedIndexChanged += new System.EventHandler(this.listBoxCredit_SelectedIndexChanged);
            // 
            // btnOversc
            // 
            this.btnOversc.Location = new System.Drawing.Point(318, 53);
            this.btnOversc.Name = "btnOversc";
            this.btnOversc.Size = new System.Drawing.Size(75, 23);
            this.btnOversc.TabIndex = 7;
            this.btnOversc.Text = "Overschrijven";
            this.btnOversc.UseVisualStyleBackColor = true;
            this.btnOversc.Click += new System.EventHandler(this.btnOversc_Click);
            // 
            // btnNiewR
            // 
            this.btnNiewR.Location = new System.Drawing.Point(82, 82);
            this.btnNiewR.Name = "btnNiewR";
            this.btnNiewR.Size = new System.Drawing.Size(75, 23);
            this.btnNiewR.TabIndex = 8;
            this.btnNiewR.Text = "New";
            this.btnNiewR.UseVisualStyleBackColor = true;
            this.btnNiewR.Click += new System.EventHandler(this.btnNiewR_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(189, 151);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 285);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnNiewR);
            this.Controls.Add(this.btnOversc);
            this.Controls.Add(this.listBoxCredit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxCredit;
        private System.Windows.Forms.Button btnOversc;
        private System.Windows.Forms.Button btnNiewR;
        private System.Windows.Forms.Label labelInfo;
    }
}

