namespace AKBRename
{
    partial class RenameForm
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
            this.TxtKaynak = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHedef = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LblDurum = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtTip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkBoxDahil = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // TxtKaynak
            // 
            this.TxtKaynak.Location = new System.Drawing.Point(13, 32);
            this.TxtKaynak.Name = "TxtKaynak";
            this.TxtKaynak.Size = new System.Drawing.Size(322, 20);
            this.TxtKaynak.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ":::";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hedef Klasor Yolu";
            // 
            // TxtHedef
            // 
            this.TxtHedef.Location = new System.Drawing.Point(13, 91);
            this.TxtHedef.Name = "TxtHedef";
            this.TxtHedef.Size = new System.Drawing.Size(322, 20);
            this.TxtHedef.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = ":::";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kaynak Klasor Yolu";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 256);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(349, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(15, 237);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(0, 13);
            this.LblDurum.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 73);
            this.button3.TabIndex = 5;
            this.button3.Text = "BAŞLA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtTip
            // 
            this.TxtTip.Location = new System.Drawing.Point(15, 148);
            this.TxtTip.Name = "TxtTip";
            this.TxtTip.Size = new System.Drawing.Size(55, 20);
            this.TxtTip.TabIndex = 6;
            this.TxtTip.Text = "*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ayraç";
            // 
            // ChkBoxDahil
            // 
            this.ChkBoxDahil.AutoSize = true;
            this.ChkBoxDahil.Location = new System.Drawing.Point(18, 188);
            this.ChkBoxDahil.Name = "ChkBoxDahil";
            this.ChkBoxDahil.Size = new System.Drawing.Size(108, 17);
            this.ChkBoxDahil.TabIndex = 7;
            this.ChkBoxDahil.Text = "Alt Klasorler Dahil";
            this.ChkBoxDahil.UseVisualStyleBackColor = true;
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 299);
            this.Controls.Add(this.ChkBoxDahil);
            this.Controls.Add(this.TxtTip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtHedef);
            this.Controls.Add(this.TxtKaynak);
            this.Name = "RenameForm";
            this.Text = "AKB-Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKaynak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHedef;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LblDurum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkBoxDahil;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}