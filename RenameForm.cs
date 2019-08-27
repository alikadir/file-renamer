using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AKBRename
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtHedef.Text == "" || TxtKaynak.Text == "")
            {
                MessageBox.Show("Hedef veya Kaynak boş olamaz!");

            }
            else 
            {
                DirectoryInfo Kaynak = new DirectoryInfo(TxtKaynak.Text);
              
                List<FileInfo> Dosyalar = new List<FileInfo>();
                if (ChkBoxDahil.Checked)
                    Dosyalar.AddRange(Kaynak.GetFiles(TxtTip.Text, SearchOption.AllDirectories));
                else
                    Dosyalar.AddRange(Kaynak.GetFiles(TxtTip.Text, SearchOption.TopDirectoryOnly));


                progressBar1.Minimum = 1;
                progressBar1.Maximum = Dosyalar.Count;
                progressBar1.Step = 1;
                int indx = 1;

                foreach (FileInfo item in Dosyalar)
                {
                    File.Copy(item.FullName, Path.Combine(TxtHedef.Text, indx.ToString() + item.Extension),true);
                    indx++;
                    progressBar1.Value = indx - 1;
                    Application.DoEvents();
                    LblDurum.Text = item.FullName;

                }


                MessageBox.Show("Tamamlandı");

            }

                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            TxtKaynak.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            TxtHedef.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
