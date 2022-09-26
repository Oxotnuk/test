namespace SQL
{
    partial class SQLInformation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Informaciya = new System.Windows.Forms.Button();
            this.Katalog = new System.Windows.Forms.Button();
            this.VxodVSistemu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(468, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(105, 58);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Informaciya
            // 
            this.Informaciya.Location = new System.Drawing.Point(10, 107);
            this.Informaciya.Name = "Informaciya";
            this.Informaciya.Size = new System.Drawing.Size(556, 68);
            this.Informaciya.TabIndex = 2;
            this.Informaciya.Text = "Информация об программистах";
            this.Informaciya.UseVisualStyleBackColor = true;
            // 
            // Katalog
            // 
            this.Katalog.Location = new System.Drawing.Point(10, 181);
            this.Katalog.Name = "Katalog";
            this.Katalog.Size = new System.Drawing.Size(556, 68);
            this.Katalog.TabIndex = 3;
            this.Katalog.Text = "Каталог";
            this.Katalog.UseVisualStyleBackColor = true;
            // 
            // VxodVSistemu
            // 
            this.VxodVSistemu.Location = new System.Drawing.Point(12, 255);
            this.VxodVSistemu.Name = "VxodVSistemu";
            this.VxodVSistemu.Size = new System.Drawing.Size(556, 68);
            this.VxodVSistemu.TabIndex = 4;
            this.VxodVSistemu.Text = "Вход в систему";
            this.VxodVSistemu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пункты главного меню";
            // 
            // SQLInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VxodVSistemu);
            this.Controls.Add(this.Katalog);
            this.Controls.Add(this.Informaciya);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SQLInformation";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Exit;
        private Button Informaciya;
        private Button Katalog;
        private Button VxodVSistemu;
        private Label label1;
    }
}