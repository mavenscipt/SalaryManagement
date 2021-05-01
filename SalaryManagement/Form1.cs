using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryManagement
{
    public partial class Form1 : Form
    {
        string fullpath;
        string ext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // addfile();
            
            DirectoryMaker("HarshadTretiya", "");
         }
        private void addfile()
        {
            //foldername = "images";
            string picname = "Abcd";

            string subpath = Application.StartupPath + "\\images\\" + "abcd" + "\\";

            bool extist = System.IO.Directory.Exists(subpath);

            if (!extist)
            {

                System.IO.Directory.CreateDirectory(subpath);
            }

           // File.Copy(fullpath, Application.StartupPath + "\\images\\" + "abcd" + "\\" + picname);
            File.Copy(@"D:\What is swift and its advantages.docx", @"D:\Skype\abcd");
            MessageBox.Show("Done");
        }
        public void addnew()
        {
            MessageBox.Show(Application.StartupPath.ToString());

            //string root = @"D:\Temp";
            string subdir = @"D:\Temp\Mahesh";
            // If directory does not exist, create it. 
            //Application.StartupPath.ToString() + "\\" + "temp";
            if (!Directory.Exists(Application.StartupPath.ToString() + "\\" + "temp"))
            {
                Directory.CreateDirectory(Application.StartupPath.ToString() + "\\" + "temp");
            }
            // Create a sub directory
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
        }
        public void DirectoryMaker(string path,string subdirec)
        {
            if (!Directory.Exists(Application.StartupPath.ToString() + "\\" + "EmployeeData"))
            {
                Directory.CreateDirectory(Application.StartupPath.ToString() + "\\" + "EmployeeData");
            }

            // Create a sub directory
            //if (!Directory.Exists(subdirec))
            //{
            //    Directory.CreateDirectory(subdirec);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpg/png/jpeg files (*.jpg; *.png; *.jpeg) | *.jpg; *.png; *.jpeg";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fullpath = ofd.FileName;
                    ext = Path.GetExtension(fullpath);
                    MessageBox.Show(ext);
                }
            }
            catch
            {
                MessageBox.Show("plese choose again");
            }
        }
    }
}
