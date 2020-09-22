using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LuaNotepad
{
    public partial class Form1 : Form
    {
        public List<string> Syntax = new List<string>();
        private readonly Process _cmdRunInterp = new Process();
        public Form1()
        {
            InitializeComponent();
            _cmdRunInterp.StartInfo.Arguments = "/k java -cp luaj-jse-3.0.1.jar lua main.lua";
            _cmdRunInterp.StartInfo.FileName = "cmd.exe";
            richTextBox1.ReadOnly = true;
            Code.SelectionTabs = new int[] { 0, 4, Code.MaxLength};
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {
            int i = Code.Lines.Length;
            foreach (var line in Code.Lines)
            {
                Syntax.AddRange(GetWordsFromText(line));
            }
            if (i > 1)
            {
                richTextBox1.Text = String.Empty;
                for (int t = 1; t < i; t++)
                {
                    if (!richTextBox1.Text.Contains(t.ToString() + " \n"))
                        richTextBox1.Text += t.ToString() + " \n";
                }
            }

            //Code.Text += pos;
            /*foreach (var word in _syntax)
            {
                Code.Text += "\n" + word;
            }*/
        }

        private static IEnumerable<string> GetWordsFromText(string text)
        {
            var buffer = string.Empty;
            var words = new List<string>();
            foreach (var t in text)
            {
                if (t == 32 || t == '\n')
                {
                    words.Add(buffer);
                    buffer = "";
                }
                else buffer += t;
            }
            return words;
        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText("main.lua", Code.Text);
        }

        private void Compile_Click(object sender, EventArgs e)
        {
            _cmdRunInterp.Start();
        }
    }
}