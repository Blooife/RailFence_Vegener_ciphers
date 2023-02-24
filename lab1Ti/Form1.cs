using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Ti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            radRail.Checked = true;
        }

        public void RailEncode()
        {
            string input = inputBox.Text;
            input = Regex.Replace(input, "[^a-zA-Z]", "");
            input = input.ToLower();
            string key = keyBox.Text;
            int rows;
            if (input == "")
            {
                MessageBox.Show("Input data is not valid", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    rows = Convert.ToInt32(Regex.Replace(key, "[^0-9]", ""));
                }
                catch
                {
                    rows = 0;
                }

                if (rows == 0)
                {
                    MessageBox.Show("Key data is not valid", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    Program.RailFence railFence = new Program.RailFence(input,rows);
                    railFence.strArray = railFence.MakeStrArray();
                    outputBox.Text = railFence.Encode();
                    System.IO.File.WriteAllText("C:/Users/Asus/RiderProjects/lab1Ti/lab1Ti/files/rail_encode.txt", outputBox.Text);
                }
                
            }
        }

        public void RailDecode()
        {
            string input = inputBox.Text;
            input = Regex.Replace(input, "[^a-zA-Z]", "");
            input = input.ToLower();
            string key = keyBox.Text;
            int rows;
            if (input == "")
            {
                MessageBox.Show("Input data is not valid", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    rows = Convert.ToInt32(Regex.Replace(key, "[^0-9]", ""));
                }
                catch
                {
                    rows = 0;
                }

                if (rows == 0)
                {
                    MessageBox.Show("Key data is not valid", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    Program.RailFence railFence = new Program.RailFence(input,rows);
                    // railFence.MakeStrArray();
                    railFence.trLen = railFence.CountTrLen();
                    outputBox.Text = railFence.Decode();
                    System.IO.File.WriteAllText("C:/Users/Asus/RiderProjects/lab1Ti/lab1Ti/files/rail_decode.txt", outputBox.Text);
                }
                
            }
        }

        public void VigEncode()
        {
            string input = inputBox.Text;
            input = input.ToLower();
            input = Regex.Replace(input, "[^(а-я+ё)]", "");
            string key = keyBox.Text;
            key = Regex.Replace(key, "[^(а-я+ё)]", "");
            if (key == "" || input == "")
            {
                MessageBox.Show("Input or key data are not valid", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                Program.Vigenere vigenere = new Program.Vigenere(input, key);
                outputBox.Text = vigenere.Encode(vigenere.text, vigenere.key); 
                System.IO.File.WriteAllText("C:/Users/Asus/RiderProjects/lab1Ti/lab1Ti/files/vig_encode.txt", outputBox.Text);
            }
        }

        public void VigDecode()
        {
            string input = inputBox.Text;
            input = input.ToLower();
            input = Regex.Replace(input, "[^(а-я+ё)]", "");
            string key = keyBox.Text;
            key = Regex.Replace(key, "[^(а-я+ё)]", "");
            if (key == "" || input == "")
            {
                MessageBox.Show("Input or key data are not valid", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                Program.Vigenere vigenere = new Program.Vigenere(input, key);
                outputBox.Text = vigenere.Decode(vigenere.text, vigenere.key); 
                System.IO.File.WriteAllText("C:/Users/Asus/RiderProjects/lab1Ti/lab1Ti/files/vig_decode.txt", outputBox.Text);
            }
        }

        public void ButCipher_Click(object sender, EventArgs e)
        {
            if (radRail.Checked)
            {
                RailEncode();
            }
            else
            {
                VigEncode();
            }
        }

        private void ButDeCipher_Click(object sender, EventArgs e)
        {
            if (radRail.Checked)
            {
                RailDecode();
            }
            else
            {
                VigDecode();
            }
        }


        private void ButOpen_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            inputBox.Text = fileText;
            MessageBox.Show("Файл успешно открыт");
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, outputBox.Text);
            MessageBox.Show("Файл успешно сохранен");
        }
    }
        
}
