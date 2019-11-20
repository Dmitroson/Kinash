namespace Kinash_2_2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMainPicture = new System.Windows.Forms.Button();
            this.labelMainSize = new System.Windows.Forms.Label();
            this.labelMainSpeed = new System.Windows.Forms.Label();
            this.buttonMainDiagram = new System.Windows.Forms.Button();
            this.buttonMainGraphicObject = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.hScrollBarSize = new System.Windows.Forms.HScrollBar();
            this.hScrollBarSpeed = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // buttonMainPicture
            // 
            this.buttonMainPicture.Location = new System.Drawing.Point(99, 12);
            this.buttonMainPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonMainPicture.Name = "buttonMainPicture";
            this.buttonMainPicture.Size = new System.Drawing.Size(225, 51);
            this.buttonMainPicture.TabIndex = 0;
            this.buttonMainPicture.Text = "Picture";
            this.buttonMainPicture.UseVisualStyleBackColor = true;
            this.buttonMainPicture.Click += new System.EventHandler(this.buttonMainPicture_Click);
            // 
            // labelMainSize
            // 
            this.labelMainSize.AutoSize = true;
            this.labelMainSize.Location = new System.Drawing.Point(47, 91);
            this.labelMainSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainSize.Name = "labelMainSize";
            this.labelMainSize.Size = new System.Drawing.Size(35, 17);
            this.labelMainSize.TabIndex = 1;
            this.labelMainSize.Text = "Size";
            // 
            // labelMainSpeed
            // 
            this.labelMainSpeed.AutoSize = true;
            this.labelMainSpeed.Location = new System.Drawing.Point(47, 122);
            this.labelMainSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainSpeed.Name = "labelMainSpeed";
            this.labelMainSpeed.Size = new System.Drawing.Size(49, 17);
            this.labelMainSpeed.TabIndex = 2;
            this.labelMainSpeed.Text = "Speed";
            // 
            // buttonMainDiagram
            // 
            this.buttonMainDiagram.Location = new System.Drawing.Point(99, 173);
            this.buttonMainDiagram.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMainDiagram.Name = "buttonMainDiagram";
            this.buttonMainDiagram.Size = new System.Drawing.Size(225, 46);
            this.buttonMainDiagram.TabIndex = 3;
            this.buttonMainDiagram.Text = "Diagram";
            this.buttonMainDiagram.UseVisualStyleBackColor = true;
            this.buttonMainDiagram.Click += new System.EventHandler(this.buttonMainDiagram_Click);
            // 
            // buttonMainGraphicObject
            // 
            this.buttonMainGraphicObject.Location = new System.Drawing.Point(99, 250);
            this.buttonMainGraphicObject.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMainGraphicObject.Name = "buttonMainGraphicObject";
            this.buttonMainGraphicObject.Size = new System.Drawing.Size(225, 44);
            this.buttonMainGraphicObject.TabIndex = 4;
            this.buttonMainGraphicObject.Text = "Graphic object";
            this.buttonMainGraphicObject.UseVisualStyleBackColor = true;
            this.buttonMainGraphicObject.Click += new System.EventHandler(this.buttonMainGraphicObject_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(277, 355);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(144, 37);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // hScrollBarSize
            // 
            this.hScrollBarSize.Location = new System.Drawing.Point(99, 91);
            this.hScrollBarSize.Minimum = 1;
            this.hScrollBarSize.Name = "hScrollBarSize";
            this.hScrollBarSize.Size = new System.Drawing.Size(262, 20);
            this.hScrollBarSize.TabIndex = 6;
            this.hScrollBarSize.Value = 1;
            this.hScrollBarSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarSize_Scroll);
            // 
            // hScrollBarSpeed
            // 
            this.hScrollBarSpeed.Location = new System.Drawing.Point(99, 122);
            this.hScrollBarSpeed.Minimum = 10;
            this.hScrollBarSpeed.Name = "hScrollBarSpeed";
            this.hScrollBarSpeed.Size = new System.Drawing.Size(262, 20);
            this.hScrollBarSpeed.TabIndex = 7;
            this.hScrollBarSpeed.Value = 10;
            this.hScrollBarSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarSpeed_Scroll);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.hScrollBarSpeed);
            this.Controls.Add(this.hScrollBarSize);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMainGraphicObject);
            this.Controls.Add(this.buttonMainDiagram);
            this.Controls.Add(this.labelMainSpeed);
            this.Controls.Add(this.labelMainSize);
            this.Controls.Add(this.buttonMainPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormMain";
            this.Text = "Лабораторна робота №2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainPicture;
        private System.Windows.Forms.Label labelMainSize;
        private System.Windows.Forms.Label labelMainSpeed;
        private System.Windows.Forms.Button buttonMainDiagram;
        private System.Windows.Forms.Button buttonMainGraphicObject;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.HScrollBar hScrollBarSize;
        private System.Windows.Forms.HScrollBar hScrollBarSpeed;
    }
}

