namespace lab1Ti
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
            this.ButCipher = new System.Windows.Forms.Button();
            this.ButDeCipher = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.radRail = new System.Windows.Forms.RadioButton();
            this.ButOpen = new System.Windows.Forms.Button();
            this.ButSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.radVigenere = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ButCipher
            // 
            this.ButCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButCipher.Location = new System.Drawing.Point(305, 290);
            this.ButCipher.Name = "ButCipher";
            this.ButCipher.Size = new System.Drawing.Size(134, 41);
            this.ButCipher.TabIndex = 0;
            this.ButCipher.Text = "Encrypt";
            this.ButCipher.UseVisualStyleBackColor = true;
            this.ButCipher.Click += new System.EventHandler(this.ButCipher_Click);
            // 
            // ButDeCipher
            // 
            this.ButDeCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButDeCipher.Location = new System.Drawing.Point(471, 290);
            this.ButDeCipher.Name = "ButDeCipher";
            this.ButDeCipher.Size = new System.Drawing.Size(134, 41);
            this.ButDeCipher.TabIndex = 1;
            this.ButDeCipher.Text = "Decrypt";
            this.ButDeCipher.UseVisualStyleBackColor = true;
            this.ButDeCipher.Click += new System.EventHandler(this.ButDeCipher_Click);
            // 
            // keyBox
            // 
            this.keyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyBox.Location = new System.Drawing.Point(134, 256);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(163, 26);
            this.keyBox.TabIndex = 6;
            // 
            // radRail
            // 
            this.radRail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRail.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radRail.Location = new System.Drawing.Point(12, 12);
            this.radRail.Name = "radRail";
            this.radRail.Size = new System.Drawing.Size(102, 28);
            this.radRail.TabIndex = 7;
            this.radRail.TabStop = true;
            this.radRail.Text = "RailFence";
            this.radRail.UseVisualStyleBackColor = true;
            // 
            // ButOpen
            // 
            this.ButOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButOpen.Location = new System.Drawing.Point(484, 11);
            this.ButOpen.Name = "ButOpen";
            this.ButOpen.Size = new System.Drawing.Size(121, 29);
            this.ButOpen.TabIndex = 8;
            this.ButOpen.Text = "Open File";
            this.ButOpen.UseVisualStyleBackColor = true;
            this.ButOpen.Click += new System.EventHandler(this.ButOpen_Click);
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(637, 11);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(115, 29);
            this.ButSave.TabIndex = 9;
            this.ButSave.Text = "Save File";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(134, 63);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(762, 170);
            this.inputBox.TabIndex = 10;
            this.inputBox.Text = "";
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(134, 355);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(762, 161);
            this.outputBox.TabIndex = 11;
            this.outputBox.Text = "";
            // 
            // radVigenere
            // 
            this.radVigenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVigenere.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radVigenere.Location = new System.Drawing.Point(134, 12);
            this.radVigenere.Name = "radVigenere";
            this.radVigenere.Size = new System.Drawing.Size(102, 28);
            this.radVigenere.TabIndex = 12;
            this.radVigenere.TabStop = true;
            this.radVigenere.Text = "Vigenere";
            this.radVigenere.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 528);
            this.Controls.Add(this.radVigenere);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ButOpen);
            this.Controls.Add(this.radRail);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.ButDeCipher);
            this.Controls.Add(this.ButCipher);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton radVigenere;

        private System.Windows.Forms.RichTextBox outputBox;

        private System.Windows.Forms.RichTextBox inputBox;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.Button ButOpen;
        private System.Windows.Forms.Button ButSave;

        private System.Windows.Forms.RadioButton radRail;

        private System.Windows.Forms.TextBox keyBox;

        private System.Windows.Forms.Button ButCipher;
        private System.Windows.Forms.Button ButDeCipher;

        #endregion
    }
}