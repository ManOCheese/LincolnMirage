namespace WinFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addDelayButton = new System.Windows.Forms.Button();
            this.removeDelayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(50, 137);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1907, 1084);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2352, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 128);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // addDelayButton
            // 
            this.addDelayButton.Location = new System.Drawing.Point(2158, 622);
            this.addDelayButton.Name = "addDelayButton";
            this.addDelayButton.Size = new System.Drawing.Size(112, 34);
            this.addDelayButton.TabIndex = 4;
            this.addDelayButton.Text = "+1";
            this.addDelayButton.UseVisualStyleBackColor = true;
            this.addDelayButton.Click += new System.EventHandler(this.addDelayButton_Click);
            // 
            // removeDelayButton
            // 
            this.removeDelayButton.Location = new System.Drawing.Point(2158, 699);
            this.removeDelayButton.Name = "removeDelayButton";
            this.removeDelayButton.Size = new System.Drawing.Size(112, 34);
            this.removeDelayButton.TabIndex = 5;
            this.removeDelayButton.Text = "-1";
            this.removeDelayButton.UseVisualStyleBackColor = true;
            this.removeDelayButton.Click += new System.EventHandler(this.removeDelayButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(356, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 70);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3005, 1567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeDelayButton);
            this.Controls.Add(this.addDelayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Label label1;
        private Button addDelayButton;
        private Button removeDelayButton;
        private Label label2;
    }
}