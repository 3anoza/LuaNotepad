using System;

namespace LuaNotepad
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.LinesList = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Compile = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.RichTextBox();
            this.mainPanel.SuspendLayout();
            this.LinesList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.LinesList);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.Code);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // LinesList
            // 
            this.LinesList.Controls.Add(this.richTextBox1);
            this.LinesList.Location = new System.Drawing.Point(3, 37);
            this.LinesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinesList.Name = "LinesList";
            this.LinesList.Size = new System.Drawing.Size(35, 410);
            this.LinesList.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(94, 404);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Compile);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 30);
            this.panel1.TabIndex = 3;
            // 
            // Compile
            // 
            this.Compile.Location = new System.Drawing.Point(108, 3);
            this.Compile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Compile.Name = "Compile";
            this.Compile.Size = new System.Drawing.Size(96, 26);
            this.Compile.TabIndex = 2;
            this.Compile.Text = "Compile";
            this.Compile.UseVisualStyleBackColor = true;
            this.Compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(3, 3);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(89, 26);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Code
            // 
            this.Code.AcceptsTab = true;
            this.Code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Code.Location = new System.Drawing.Point(44, 37);
            this.Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(756, 414);
            this.Code.TabIndex = 0;
            this.Code.Text = "";
            this.Code.TextChanged += new System.EventHandler(this.Code_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "MainWindow:";
            this.mainPanel.ResumeLayout(false);
            this.LinesList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RichTextBox Code;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Compile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LinesList;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}