﻿namespace CatchAFish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Fish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fish
            // 
            this.Fish.Image = ((System.Drawing.Image)(resources.GetObject("Fish.Image")));
            this.Fish.Location = new System.Drawing.Point(246, 118);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(1289, 695);
            this.Fish.TabIndex = 0;
            this.Fish.UseVisualStyleBackColor = true;
            this.Fish.MouseEnter += new System.EventHandler(this.Fish_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 995);
            this.Controls.Add(this.Fish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fish;
    }
}

