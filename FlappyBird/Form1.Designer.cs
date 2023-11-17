namespace FlappyBird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainBird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainBird)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBird
            // 
            this.mainBird.Image = global::FlappyBird.Properties.Resources._15b17a7beb2911d;
            this.mainBird.Location = new System.Drawing.Point(103, 149);
            this.mainBird.Name = "mainBird";
            this.mainBird.Size = new System.Drawing.Size(62, 54);
            this.mainBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainBird.TabIndex = 3;
            this.mainBird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 518);
            this.Controls.Add(this.mainBird);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox mainBird;
        private System.Windows.Forms.Timer timer1;
    }
}

