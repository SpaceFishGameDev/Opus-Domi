
namespace Opus_Domi
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoWork = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DoWork
            // 
            this.DoWork.Location = new System.Drawing.Point(944, 538);
            this.DoWork.Name = "DoWork";
            this.DoWork.Size = new System.Drawing.Size(352, 78);
            this.DoWork.TabIndex = 0;
            this.DoWork.Text = "Do work.";
            this.DoWork.UseVisualStyleBackColor = true;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(2, 2);
            this.Subject.Name = "Subject";
            this.Subject.PlaceholderText = "Subject";
            this.Subject.Size = new System.Drawing.Size(200, 23);
            this.Subject.TabIndex = 1;
            this.Subject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 628);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.DoWork);
            this.Name = "MainWindow";
            this.Text = "Opus domi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoWork;
        private System.Windows.Forms.TextBox Subject;
    }
}

