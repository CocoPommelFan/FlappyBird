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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pipe = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Pipe2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pipe
            // 
            this.Pipe.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Pipe.ErrorImage")));
            this.Pipe.Image = ((System.Drawing.Image)(resources.GetObject("Pipe.Image")));
            this.Pipe.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pipe.InitialImage")));
            this.Pipe.Location = new System.Drawing.Point(-140, -154);
            this.Pipe.Name = "Pipe";
            this.Pipe.Size = new System.Drawing.Size(450, 1170);
            this.Pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipe.TabIndex = 0;
            this.Pipe.TabStop = false;
            this.Pipe.Visible = false;
            this.Pipe.Click += new System.EventHandler(this.Pipe_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(111, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 220);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pipe2
            // 
            this.Pipe2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Pipe2.ErrorImage")));
            this.Pipe2.Image = ((System.Drawing.Image)(resources.GetObject("Pipe2.Image")));
            this.Pipe2.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pipe2.InitialImage")));
            this.Pipe2.Location = new System.Drawing.Point(341, -76);
            this.Pipe2.Name = "Pipe2";
            this.Pipe2.Size = new System.Drawing.Size(450, 1170);
            this.Pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipe2.TabIndex = 3;
            this.Pipe2.TabStop = false;
            this.Pipe2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 708);
            this.Controls.Add(this.Pipe2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pipe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Pipe2;
    }
}

