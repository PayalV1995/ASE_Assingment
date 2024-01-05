namespace WindowsFormsApp2
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ControlePanel = new System.Windows.Forms.RichTextBox();
            this.commandline = new System.Windows.Forms.TextBox();
            this.display = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ControlePanel
            // 
            this.ControlePanel.Location = new System.Drawing.Point(18, 25);
            this.ControlePanel.Name = "ControlePanel";
            this.ControlePanel.Size = new System.Drawing.Size(270, 257);
            this.ControlePanel.TabIndex = 3;
            this.ControlePanel.Text = "";
            // 
            // commandline
            // 
            this.commandline.Location = new System.Drawing.Point(18, 311);
            this.commandline.Name = "commandline";
            this.commandline.Size = new System.Drawing.Size(270, 22);
            this.commandline.TabIndex = 4;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.display.Location = new System.Drawing.Point(316, 25);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(499, 436);
            this.display.TabIndex = 5;
            this.display.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(827, 473);
            this.Controls.Add(this.display);
            this.Controls.Add(this.commandline);
            this.Controls.Add(this.ControlePanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox ControlePanel;
        private System.Windows.Forms.TextBox commandline;
        private System.Windows.Forms.PictureBox display;
    }
}

