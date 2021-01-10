
namespace powerPointGenerator.Forms
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
            this.Intro = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Intro
            // 
            this.Intro.AutoSize = true;
            this.Intro.Location = new System.Drawing.Point(24, 21);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(225, 13);
            this.Intro.TabIndex = 0;
            this.Intro.Text = "Fill out the form to generate a PowerPoint slide";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(27, 78);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(250, 20);
            this.titleBox.TabIndex = 1;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(24, 62);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(53, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Slide Title";
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(27, 155);
            this.bodyBox.Multiline = true;
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(250, 200);
            this.bodyBox.TabIndex = 3;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(24, 139);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(57, 13);
            this.bodyLabel.TabIndex = 4;
            this.bodyLabel.Text = "Slide Body";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(202, 378);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 300);
            this.textBox1.TabIndex = 6;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.Intro);
            this.Name = "Form1";
            this.Text = "Make a PowerPoint Slide";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Intro;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textBox1;
    }
}

