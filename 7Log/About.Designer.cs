/*
 * This comment is added to every CS file in order to state
 * the original creator of the source code, me, Anthony Lomeli.
 * 
 * Each original CS File MUST have this comment embedded somewhere in it
 * for its use.
 * 
 * Any files created by the user of the source code does not need this comment embedded.
 * 
 * Deleting this comment will violate the terms of agreement between the author and
 * source code user and thus be counted as copyright infringement in a court of law.
 * 
 * Please note this is just a safety percaution. I apologize for any inconvience.
 * 
 * - Anthony Lomeli
 *   Author of 7Log
*/
namespace _7Log
{
    partial class About
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(12, 12);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(124, 112);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 0;
        	this.pictureBox1.TabStop = false;
        	// 
        	// textBox1
        	// 
        	this.textBox1.BackColor = System.Drawing.Color.White;
        	this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
        	this.textBox1.ForeColor = System.Drawing.Color.Black;
        	this.textBox1.Location = new System.Drawing.Point(154, 12);
        	this.textBox1.Multiline = true;
        	this.textBox1.Name = "textBox1";
        	this.textBox1.ReadOnly = true;
        	this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.textBox1.Size = new System.Drawing.Size(314, 112);
        	this.textBox1.TabIndex = 1;
        	this.textBox1.Text = resources.GetString("textBox1.Text");
        	// 
        	// About
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(480, 136);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.pictureBox1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "About";
        	this.Text = "About";
        	this.Load += new System.EventHandler(this.AboutLoad);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBox1;
    }
}