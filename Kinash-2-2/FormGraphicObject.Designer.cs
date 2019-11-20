namespace Kinash_2_2
{
    partial class FormGraphicObject
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
            this.pictureBoxGraphicObject = new System.Windows.Forms.PictureBox();
            this.groupBoxChange = new System.Windows.Forms.GroupBox();
            this.radioButtonShape = new System.Windows.Forms.RadioButton();
            this.radioButtonSize = new System.Windows.Forms.RadioButton();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphicObject)).BeginInit();
            this.groupBoxChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGraphicObject
            // 
            this.pictureBoxGraphicObject.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxGraphicObject.Name = "pictureBoxGraphicObject";
            this.pictureBoxGraphicObject.Size = new System.Drawing.Size(407, 247);
            this.pictureBoxGraphicObject.TabIndex = 0;
            this.pictureBoxGraphicObject.TabStop = false;
            this.pictureBoxGraphicObject.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGraphicObject_Paint);
            // 
            // groupBoxChange
            // 
            this.groupBoxChange.Controls.Add(this.radioButtonShape);
            this.groupBoxChange.Controls.Add(this.radioButtonSize);
            this.groupBoxChange.Controls.Add(this.radioButtonColor);
            this.groupBoxChange.Location = new System.Drawing.Point(13, 276);
            this.groupBoxChange.Name = "groupBoxChange";
            this.groupBoxChange.Size = new System.Drawing.Size(200, 115);
            this.groupBoxChange.TabIndex = 1;
            this.groupBoxChange.TabStop = false;
            this.groupBoxChange.Text = "Change:";
            // 
            // radioButtonShape
            // 
            this.radioButtonShape.AutoSize = true;
            this.radioButtonShape.Location = new System.Drawing.Point(7, 77);
            this.radioButtonShape.Name = "radioButtonShape";
            this.radioButtonShape.Size = new System.Drawing.Size(70, 21);
            this.radioButtonShape.TabIndex = 2;
            this.radioButtonShape.TabStop = true;
            this.radioButtonShape.Text = "Shape";
            this.radioButtonShape.UseVisualStyleBackColor = true;
            this.radioButtonShape.CheckedChanged += new System.EventHandler(this.radioButtonShape_CheckedChanged);
            // 
            // radioButtonSize
            // 
            this.radioButtonSize.AutoSize = true;
            this.radioButtonSize.Location = new System.Drawing.Point(7, 50);
            this.radioButtonSize.Name = "radioButtonSize";
            this.radioButtonSize.Size = new System.Drawing.Size(56, 21);
            this.radioButtonSize.TabIndex = 1;
            this.radioButtonSize.TabStop = true;
            this.radioButtonSize.Text = "Size";
            this.radioButtonSize.UseVisualStyleBackColor = true;
            this.radioButtonSize.CheckedChanged += new System.EventHandler(this.radioButtonSize_CheckedChanged);
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Location = new System.Drawing.Point(7, 22);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(62, 21);
            this.radioButtonColor.TabIndex = 0;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "Color";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            this.radioButtonColor.CheckedChanged += new System.EventHandler(this.radioButtonColor_CheckedChanged);
            // 
            // FormGraphicObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.groupBoxChange);
            this.Controls.Add(this.pictureBoxGraphicObject);
            this.Name = "FormGraphicObject";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormGraphicObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphicObject)).EndInit();
            this.groupBoxChange.ResumeLayout(false);
            this.groupBoxChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGraphicObject;
        private System.Windows.Forms.GroupBox groupBoxChange;
        private System.Windows.Forms.RadioButton radioButtonShape;
        private System.Windows.Forms.RadioButton radioButtonSize;
        private System.Windows.Forms.RadioButton radioButtonColor;
    }
}