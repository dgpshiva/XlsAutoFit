namespace XlsAutoFitTool
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.Welcome_label = new System.Windows.Forms.Label();
            this.fileSelect_textBox = new System.Windows.Forms.TextBox();
            this.fileSelect_button = new System.Windows.Forms.Button();
            this.xlsSelectOk_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(92, 35);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(355, 80);
            this.Welcome_label.TabIndex = 0;
            this.Welcome_label.Text = "                              Welcome \r\n                          ==========\r\n\r\nS" +
    "elect folder location where you have your xls:";
            this.Welcome_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileSelect_textBox
            // 
            this.fileSelect_textBox.Location = new System.Drawing.Point(96, 155);
            this.fileSelect_textBox.Name = "fileSelect_textBox";
            this.fileSelect_textBox.Size = new System.Drawing.Size(351, 22);
            this.fileSelect_textBox.TabIndex = 1;
            this.fileSelect_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fileSelect_button
            // 
            this.fileSelect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelect_button.Location = new System.Drawing.Point(453, 149);
            this.fileSelect_button.Name = "fileSelect_button";
            this.fileSelect_button.Size = new System.Drawing.Size(94, 32);
            this.fileSelect_button.TabIndex = 2;
            this.fileSelect_button.Text = "Browse";
            this.fileSelect_button.UseVisualStyleBackColor = true;
            this.fileSelect_button.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // xlsSelectOk_button
            // 
            this.xlsSelectOk_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlsSelectOk_button.Location = new System.Drawing.Point(235, 205);
            this.xlsSelectOk_button.Name = "xlsSelectOk_button";
            this.xlsSelectOk_button.Size = new System.Drawing.Size(109, 30);
            this.xlsSelectOk_button.TabIndex = 3;
            this.xlsSelectOk_button.Text = "OK";
            this.xlsSelectOk_button.UseVisualStyleBackColor = true;
            this.xlsSelectOk_button.Click += new System.EventHandler(this.xlsSelectOk_button_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 294);
            this.Controls.Add(this.xlsSelectOk_button);
            this.Controls.Add(this.fileSelect_button);
            this.Controls.Add(this.fileSelect_textBox);
            this.Controls.Add(this.Welcome_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.Text = "Xls AutoFit Tool - Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.TextBox fileSelect_textBox;
        private System.Windows.Forms.Button fileSelect_button;
        private System.Windows.Forms.Button xlsSelectOk_button;
    }
}

