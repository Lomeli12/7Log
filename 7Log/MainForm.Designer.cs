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
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectALoginImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lgoinHacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreLoginBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinstallOEMBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recreateBackgroundFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectALoginImageToolStripMenuItem,
            this.lgoinHacksToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectALoginImageToolStripMenuItem
            // 
            this.selectALoginImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectALoginImageToolStripMenuItem.Image")));
            this.selectALoginImageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.selectALoginImageToolStripMenuItem.Name = "selectALoginImageToolStripMenuItem";
            this.selectALoginImageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.selectALoginImageToolStripMenuItem.Text = "Select Login Image...";
            this.selectALoginImageToolStripMenuItem.Click += new System.EventHandler(this.selectALoginImageToolStripMenuItem_Click);
            // 
            // lgoinHacksToolStripMenuItem
            // 
            this.lgoinHacksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lgoinHacksToolStripMenuItem.Image")));
            this.lgoinHacksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lgoinHacksToolStripMenuItem.Name = "lgoinHacksToolStripMenuItem";
            this.lgoinHacksToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.lgoinHacksToolStripMenuItem.Text = "Login Hacks";
            this.lgoinHacksToolStripMenuItem.Click += new System.EventHandler(this.lgoinHacksToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreLoginBackgroundToolStripMenuItem,
            this.reinstallOEMBackgroundToolStripMenuItem,
            this.recreateBackgroundFolderToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // restoreLoginBackgroundToolStripMenuItem
            // 
            this.restoreLoginBackgroundToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restoreLoginBackgroundToolStripMenuItem.Image")));
            this.restoreLoginBackgroundToolStripMenuItem.Name = "restoreLoginBackgroundToolStripMenuItem";
            this.restoreLoginBackgroundToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.restoreLoginBackgroundToolStripMenuItem.Text = "Restore Defauld Background";
            this.restoreLoginBackgroundToolStripMenuItem.Click += new System.EventHandler(this.restoreLoginBackgroundToolStripMenuItem_Click);
            // 
            // reinstallOEMBackgroundToolStripMenuItem
            // 
            this.reinstallOEMBackgroundToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reinstallOEMBackgroundToolStripMenuItem.Image")));
            this.reinstallOEMBackgroundToolStripMenuItem.Name = "reinstallOEMBackgroundToolStripMenuItem";
            this.reinstallOEMBackgroundToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.reinstallOEMBackgroundToolStripMenuItem.Text = "Reinstall OEMBackground";
            this.reinstallOEMBackgroundToolStripMenuItem.Click += new System.EventHandler(this.reinstallOEMBackgroundToolStripMenuItem_Click);
            // 
            // recreateBackgroundFolderToolStripMenuItem
            // 
            this.recreateBackgroundFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recreateBackgroundFolderToolStripMenuItem.Image")));
            this.recreateBackgroundFolderToolStripMenuItem.Name = "recreateBackgroundFolderToolStripMenuItem";
            this.recreateBackgroundFolderToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.recreateBackgroundFolderToolStripMenuItem.Text = "Recreate Background folder";
            this.recreateBackgroundFolderToolStripMenuItem.Click += new System.EventHandler(this.recreateBackgroundFolderToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPDFToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewPDFToolStripMenuItem
            // 
            this.viewPDFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewPDFToolStripMenuItem.Image")));
            this.viewPDFToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewPDFToolStripMenuItem.Name = "viewPDFToolStripMenuItem";
            this.viewPDFToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.viewPDFToolStripMenuItem.Text = "View PDF";
            this.viewPDFToolStripMenuItem.Click += new System.EventHandler(this.viewPDFToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("websiteToolStripMenuItem.Image")));
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Select Login Image";
            this.openFileDialog1.Filter = "JPG Images (*.jpg)|*.jpg|All Supported Images(*.jpg,*.png,*.gif,*.bmp)|*.jpg;*.pn" +
    "g;*.gif;*.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(90, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select Login Image...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Login Hacks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "Restore Default Background";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Get Backgrounds";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Donate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 249);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "7Log";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectALoginImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lgoinHacksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreLoginBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reinstallOEMBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recreateBackgroundFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
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
