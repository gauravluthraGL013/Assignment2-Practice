
namespace Assignment2_Practice
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
            this.btnRanNum = new System.Windows.Forms.Button();
            this.lblRanNum = new System.Windows.Forms.Label();
            this.btnchngimg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsound = new System.Windows.Forms.Button();
            this.Pbimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRanNum
            // 
            this.btnRanNum.Location = new System.Drawing.Point(105, 73);
            this.btnRanNum.Name = "btnRanNum";
            this.btnRanNum.Size = new System.Drawing.Size(119, 23);
            this.btnRanNum.TabIndex = 0;
            this.btnRanNum.Text = "RandomNumber";
            this.btnRanNum.UseVisualStyleBackColor = true;
            this.btnRanNum.Click += new System.EventHandler(this.btnRanNum_Click);
            // 
            // lblRanNum
            // 
            this.lblRanNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRanNum.Location = new System.Drawing.Point(332, 73);
            this.lblRanNum.Name = "lblRanNum";
            this.lblRanNum.Size = new System.Drawing.Size(353, 23);
            this.lblRanNum.TabIndex = 1;
            // 
            // btnchngimg
            // 
            this.btnchngimg.Location = new System.Drawing.Point(105, 233);
            this.btnchngimg.Name = "btnchngimg";
            this.btnchngimg.Size = new System.Drawing.Size(75, 23);
            this.btnchngimg.TabIndex = 3;
            this.btnchngimg.Text = "Change Image";
            this.btnchngimg.UseVisualStyleBackColor = true;
            this.btnchngimg.Click += new System.EventHandler(this.btnchngimg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnsound
            // 
            this.btnsound.Location = new System.Drawing.Point(105, 371);
            this.btnsound.Name = "btnsound";
            this.btnsound.Size = new System.Drawing.Size(75, 23);
            this.btnsound.TabIndex = 5;
            this.btnsound.Text = "Sound Player";
            this.btnsound.UseVisualStyleBackColor = true;
            this.btnsound.Click += new System.EventHandler(this.btnsound_Click);
            // 
            // Pbimage
            // 
            this.Pbimage.Image = global::Assignment2_Practice.Properties.Resources.image;
            this.Pbimage.Location = new System.Drawing.Point(335, 211);
            this.Pbimage.Name = "Pbimage";
            this.Pbimage.Size = new System.Drawing.Size(242, 197);
            this.Pbimage.TabIndex = 2;
            this.Pbimage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsound);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnchngimg);
            this.Controls.Add(this.Pbimage);
            this.Controls.Add(this.lblRanNum);
            this.Controls.Add(this.btnRanNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pbimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRanNum;
        private System.Windows.Forms.Label lblRanNum;
        private System.Windows.Forms.PictureBox Pbimage;
        private System.Windows.Forms.Button btnchngimg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsound;
    }
}

