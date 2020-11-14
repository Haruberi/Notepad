using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class notepad : Form
    {
        string filename = "";
        public notepad()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void oppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Öppna en textfil";
            openFileDialog1.Filter = "Text(*.txt)|Info filer(*.nfo)";
            openFileDialog1.FileName = filename;
            openFileDialog1.ShowDialog();
            string fil = openFileDialog1.FileName;
            if (File.Exists(fil))
            {
                textBox1.Text = File.ReadAllText(fil);
                filename = fil;
            }

        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var diag = new SaveFileDialog();
            diag.Title = "Spara fil";
            diag.Filter = "text(*.txt)|Info filer(*.nfo)";
            diag.DefaultExt = "*.txt";
            diag.FileName = filename;
            diag.ShowDialog();
            File.WriteAllText(diag.FileName, textBox1.Text);
        }
    }
}
