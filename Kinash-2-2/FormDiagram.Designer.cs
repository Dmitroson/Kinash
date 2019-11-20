namespace Kinash_2_2
{
    partial class FormDiagram
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
            this.pictureBoxDiagram = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDiagram
            // 
            this.pictureBoxDiagram.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDiagram.Name = "pictureBoxDiagram";
            this.pictureBoxDiagram.Size = new System.Drawing.Size(408, 323);
            this.pictureBoxDiagram.TabIndex = 0;
            this.pictureBoxDiagram.TabStop = false;
            this.pictureBoxDiagram.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDiagram_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display Pie Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxDiagram);
            this.Name = "FormDiagram";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormDiagram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDiagram;
        private System.Windows.Forms.Button button1;
    }
}