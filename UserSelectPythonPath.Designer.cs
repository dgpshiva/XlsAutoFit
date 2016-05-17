namespace XlsAutoFitTool
{
    partial class UserSelectPythonPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSelectPythonPath));
            this.SelectPythonPath_label = new System.Windows.Forms.Label();
            this.pythonPath_textbox = new System.Windows.Forms.TextBox();
            this.pythonPath_button = new System.Windows.Forms.Button();
            this.pythonPathOk_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectPythonPath_label
            // 
            this.SelectPythonPath_label.AutoSize = true;
            this.SelectPythonPath_label.Location = new System.Drawing.Point(72, 51);
            this.SelectPythonPath_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectPythonPath_label.Name = "SelectPythonPath_label";
            this.SelectPythonPath_label.Size = new System.Drawing.Size(444, 40);
            this.SelectPythonPath_label.TabIndex = 0;
            this.SelectPythonPath_label.Text = "Could not find path to Python in Path environment variable.\r\nPlease select path t" +
    "o python.exe on your computer:\r\n";
            this.SelectPythonPath_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectPythonPath_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pythonPath_textbox
            // 
            this.pythonPath_textbox.Location = new System.Drawing.Point(85, 125);
            this.pythonPath_textbox.Name = "pythonPath_textbox";
            this.pythonPath_textbox.Size = new System.Drawing.Size(341, 27);
            this.pythonPath_textbox.TabIndex = 1;
            this.pythonPath_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pythonPath_button
            // 
            this.pythonPath_button.Location = new System.Drawing.Point(432, 122);
            this.pythonPath_button.Name = "pythonPath_button";
            this.pythonPath_button.Size = new System.Drawing.Size(84, 30);
            this.pythonPath_button.TabIndex = 2;
            this.pythonPath_button.Text = "Browse";
            this.pythonPath_button.UseVisualStyleBackColor = true;
            this.pythonPath_button.Click += new System.EventHandler(this.pythonPath_button_Click);
            // 
            // pythonPathOk_button
            // 
            this.pythonPathOk_button.Location = new System.Drawing.Point(222, 170);
            this.pythonPathOk_button.Name = "pythonPathOk_button";
            this.pythonPathOk_button.Size = new System.Drawing.Size(86, 29);
            this.pythonPathOk_button.TabIndex = 3;
            this.pythonPathOk_button.Text = "OK";
            this.pythonPathOk_button.UseVisualStyleBackColor = true;
            this.pythonPathOk_button.Click += new System.EventHandler(this.pythonPathOk_button_Click);
            // 
            // UserSelectPythonPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 252);
            this.Controls.Add(this.pythonPathOk_button);
            this.Controls.Add(this.pythonPath_button);
            this.Controls.Add(this.pythonPath_textbox);
            this.Controls.Add(this.SelectPythonPath_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserSelectPythonPath";
            this.Text = "Xls AutoFit Tool - Select Path to python.exe";
            this.Load += new System.EventHandler(this.UserSelectPythonPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectPythonPath_label;
        private System.Windows.Forms.TextBox pythonPath_textbox;
        private System.Windows.Forms.Button pythonPath_button;
        private System.Windows.Forms.Button pythonPathOk_button;
    }
}