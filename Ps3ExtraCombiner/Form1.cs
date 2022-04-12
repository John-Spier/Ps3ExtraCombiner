using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ps3ExtraCombiner
{
    public partial class frmPs3Ren : Form
    {
        public frmPs3Ren()
        {
            InitializeComponent();
        }

        private void btnOutputSelect_Click(object sender, EventArgs e)
        {
            if (browseFolder.ShowDialog() == DialogResult.OK)
            {
                txtOutputDir.Text = browseFolder.SelectedPath;
            }
        }

        private void btnInputSelect_Click(object sender, EventArgs e)
        {
            if (browseFolder.ShowDialog() == DialogResult.OK)
            {
                txtInputDir.Text = browseFolder.SelectedPath;
            }
        }

        private void btnStartNonRecursive_Click(object sender, EventArgs e)
        {
            if (txtOutputDir.Text != "" && txtInputDir.Text != "" && txtOutputDir.Text != txtInputDir.Text)
            {
                RenDirSearch(txtInputDir.Text, SearchOption.TopDirectoryOnly, txtOutputDir.Text);
            }
            else
            {
                MessageBox.Show("Enter an input and output directory!");
            }
        }

        private void btnStartRecursive_Click(object sender, EventArgs e)
        {
            if (txtOutputDir.Text != "" && txtInputDir.Text != "" && txtOutputDir.Text != txtInputDir.Text)
            {
                RenDirSearch(txtInputDir.Text, SearchOption.AllDirectories, txtOutputDir.Text);
            }
            else
            {
                MessageBox.Show("Enter an input and output directory!");
            }
        }

        int RecDirSearch(string sDir, SearchOption SearchAll)
        {
            int HighestDir = 0;
            int di = -1;
            try
            {
                foreach (string d in Directory.GetDirectories(sDir, @"D???", SearchAll))
                {
                    di = Convert.ToInt32(d.Substring(d.Length - 3));
                    if (di > HighestDir)
                    {
                        HighestDir = di;
                    }
                    
                }
            }
            catch (System.Exception excpt)
            {
                listLogger.Items.Add("Input directory exception: " + excpt.Message);
            }
            return di;
        }

        int RenDirSearch(string sDir, SearchOption SearchAll, string outDir)
        {
            int HighestDir = RecDirSearch(outDir, SearchOption.TopDirectoryOnly);
            try
            {
                foreach (string d in Directory.GetDirectories(sDir, @"D???", SearchAll))
                {
                    if (HighestDir < 999 && File.Exists(Path.Combine(d, @"PARAM.SFX")))
                    {
                        HighestDir++;
                        listLogger.Items.Add(d + " Moving to " + Path.Combine(outDir, "D" + HighestDir.ToString("D3")));
                        Directory.Move(d, Path.Combine(outDir, "D" + HighestDir.ToString("D3")));
                    }

                }
            }
            catch (System.Exception excpt)
            {
                listLogger.Items.Add("Output directory exception: " + excpt.Message);
            }
            return HighestDir;
        }

    }
}
