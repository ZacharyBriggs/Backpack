namespace Backpack
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
            this.bullets = new System.Windows.Forms.PictureBox();
            this.clip = new System.Windows.Forms.PictureBox();
            this.liquid = new System.Windows.Forms.PictureBox();
            this.emptySyringe = new System.Windows.Forms.PictureBox();
            this.vest = new System.Windows.Forms.PictureBox();
            this.gun = new System.Windows.Forms.PictureBox();
            this.shield = new System.Windows.Forms.PictureBox();
            this.combatShot = new System.Windows.Forms.PictureBox();
            this.knife = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bullets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySyringe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bullets
            // 
            this.bullets.Location = new System.Drawing.Point(417, 247);
            this.bullets.Name = "bullets";
            this.bullets.Size = new System.Drawing.Size(100, 50);
            this.bullets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullets.TabIndex = 10;
            this.bullets.TabStop = false;
            this.bullets.Click += new System.EventHandler(this.bullets_Click);
            // 
            // clip
            // 
            this.clip.Location = new System.Drawing.Point(417, 191);
            this.clip.Name = "clip";
            this.clip.Size = new System.Drawing.Size(100, 50);
            this.clip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clip.TabIndex = 9;
            this.clip.TabStop = false;
            this.clip.Click += new System.EventHandler(this.clip_Click);
            // 
            // liquid
            // 
            this.liquid.Location = new System.Drawing.Point(244, 192);
            this.liquid.Name = "liquid";
            this.liquid.Size = new System.Drawing.Size(100, 50);
            this.liquid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liquid.TabIndex = 7;
            this.liquid.TabStop = false;
            // 
            // emptySyringe
            // 
            this.emptySyringe.Location = new System.Drawing.Point(138, 192);
            this.emptySyringe.Name = "emptySyringe";
            this.emptySyringe.Size = new System.Drawing.Size(100, 50);
            this.emptySyringe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptySyringe.TabIndex = 6;
            this.emptySyringe.TabStop = false;
            // 
            // vest
            // 
            this.vest.Location = new System.Drawing.Point(523, 120);
            this.vest.Name = "vest";
            this.vest.Size = new System.Drawing.Size(100, 66);
            this.vest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vest.TabIndex = 5;
            this.vest.TabStop = false;
            // 
            // gun
            // 
            this.gun.Location = new System.Drawing.Point(417, 119);
            this.gun.Name = "gun";
            this.gun.Size = new System.Drawing.Size(100, 66);
            this.gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gun.TabIndex = 4;
            this.gun.TabStop = false;
            this.gun.Click += new System.EventHandler(this.gun_Click);
            // 
            // shield
            // 
            this.shield.ImageLocation = "";
            this.shield.Location = new System.Drawing.Point(296, 119);
            this.shield.Name = "shield";
            this.shield.Size = new System.Drawing.Size(113, 67);
            this.shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shield.TabIndex = 3;
            this.shield.TabStop = false;
            this.shield.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // combatShot
            // 
            this.combatShot.Location = new System.Drawing.Point(177, 119);
            this.combatShot.Name = "combatShot";
            this.combatShot.Size = new System.Drawing.Size(113, 67);
            this.combatShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.combatShot.TabIndex = 2;
            this.combatShot.TabStop = false;
            this.combatShot.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // knife
            // 
            this.knife.Location = new System.Drawing.Point(52, 119);
            this.knife.Name = "knife";
            this.knife.Size = new System.Drawing.Size(119, 67);
            this.knife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knife.TabIndex = 1;
            this.knife.TabStop = false;
            this.knife.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Backpack.Properties.Resources.backpack;
            this.pictureBox1.Location = new System.Drawing.Point(203, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 473);
            this.Controls.Add(this.bullets);
            this.Controls.Add(this.clip);
            this.Controls.Add(this.liquid);
            this.Controls.Add(this.emptySyringe);
            this.Controls.Add(this.vest);
            this.Controls.Add(this.gun);
            this.Controls.Add(this.shield);
            this.Controls.Add(this.combatShot);
            this.Controls.Add(this.knife);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bullets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySyringe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox knife;
        private System.Windows.Forms.PictureBox combatShot;
        private System.Windows.Forms.PictureBox shield;
        private System.Windows.Forms.PictureBox gun;
        private System.Windows.Forms.PictureBox vest;
        private System.Windows.Forms.PictureBox emptySyringe;
        private System.Windows.Forms.PictureBox liquid;
        private System.Windows.Forms.PictureBox clip;
        private System.Windows.Forms.PictureBox bullets;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

