using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XlsAutoFitTool
{
    public partial class Welcome : Form
    {
        private Process p;
        private string pythonPath = "";
        public OpenFileDialog xlsFileLoc;
        public string xlsFile;
        public string initialDir = "";
        
        public Welcome()
        {
            InitializeComponent();
            initialDir = ConfigurationManager.AppSettings["DefaultXlsFileFolderPath"];

            xlsFile = "";
            xlsFileLoc = new OpenFileDialog();

            //Getting path to python.exe on the computer from Path Environment variable
            string path = Environment.GetEnvironmentVariable("Path");
            if (path != null)
            {
                foreach (string pathPart in path.Split(';'))
                {
                    if (pathPart.Contains("Python") && !(pathPart.Contains("Scripts")))
                    {
                        pythonPath = pathPart;
                    }
                }
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            xlsFileLoc.Title = "Select path to xls file";
            xlsFileLoc.InitialDirectory = initialDir;
            xlsFileLoc.Filter = "Xlsx files (*.xlsx)|*.xlsx|Xls files (*.xls)|*.xls";
            xlsFileLoc.RestoreDirectory = true;

            if (xlsFileLoc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    xlsFile = xlsFileLoc.FileName;
                    fileSelect_textBox.Text = xlsFile;
                }
                catch (Exception ex)
                {   
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void xlsSelectOk_button_Click(object sender, EventArgs e)
        {
            //If unable to get path to python.exe from Environment variable,
            //directing user to select path to it from another winform
            if (pythonPath == "")
            {
                UserSelectPythonPath usp = new UserSelectPythonPath();
                this.Hide();
                usp.ShowDialog();
                pythonPath = usp.PythonPath;
            }

            try
            {
                //Python code to extract all postRec cfw files
                ProcessStartInfo pInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    FileName = pythonPath + @"\python.exe",
                    Arguments = "autoFitXls.py " + string.Format("\"{0}\"", xlsFile)
                };

                p = Process.Start(pInfo);
                p.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Check path to python provided", "Unable to run python code!");
                Application.Exit();
            }

            this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
