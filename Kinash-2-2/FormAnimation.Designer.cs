namespace Kinash_2_2
{
    partial class FormAnimation
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxAnimation = new System.Windows.Forms.PictureBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAnimation
            // 
            this.pictureBoxAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAnimation.Image = global::Kinash_2_2.Properties.Resources.smallball;
            this.pictureBoxAnimation.Location = new System.Drawing.Point(158, 138);
            this.pictureBoxAnimation.Name = "pictureBoxAnimation";
            this.pictureBoxAnimation.Size = new System.Drawing.Size(121, 104);
            this.pictureBoxAnimation.TabIndex = 0;
            this.pictureBoxAnimation.TabStop = false;
            this.pictureBoxAnimation.Click += new System.EventHandler(this.pictureBoxAnimation_Click);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Enabled = true;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // FormAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.pictureBoxAnimation);
            this.Name = "FormAnimation";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.Timer timerAnimation;
        protected internal System.Windows.Forms.PictureBox pictureBoxAnimation;
    }
}