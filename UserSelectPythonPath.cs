using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XlsAutoFitTool
{
    public partial class UserSelectPythonPath : Form
    {
        public UserSelectPythonPath()
        {
            InitializeComponent();
        }

        private void pythonPath_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pythonPathSelect = new FolderBrowserDialog();
            pythonPathSelect.Description = "Select path to python.exe";

            if (pythonPathSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pythonPath_textbox.Text = pythonPathSelect.SelectedPath;
            }
        }

        public string PythonPath
        {
            get { return pythonPath_textbox.Text; }
        }

        private void pythonPathOk_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void UserSelectPythonPath_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
