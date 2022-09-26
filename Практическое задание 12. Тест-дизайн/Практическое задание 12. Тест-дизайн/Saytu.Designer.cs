namespace Практическое_задание_12._Тест_дизайн_
{
    partial class Saytu
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
            this.components = new System.ComponentModel.Container();
            this.Data = new System.Windows.Forms.MaskedTextBox();
            this.timerdate = new System.Windows.Forms.Timer(this.components);
            this.BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(112, 60);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(243, 27);
            this.Data.TabIndex = 0;
            this.Data.Enter += new System.EventHandler(this.Data_Enter);
            this.Data.Leave += new System.EventHandler(this.Data_Leave);
            // 
            // BT
            // 
            this.BT.Location = new System.Drawing.Point(183, 109);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(94, 29);
            this.BT.TabIndex = 2;
            this.BT.Text = "Поиск";
            this.BT.UseVisualStyleBackColor = true;
            this.BT.Click += new System.EventHandler(this.BT_Click);
            // 
            // Saytu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 240);
            this.Controls.Add(this.BT);
            this.Controls.Add(this.Data);
            this.Name = "Saytu";
            this.Text = "Сайты";
            this.Load += new System.EventHandler(this.Saytu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox Data;
        private System.Windows.Forms.Timer timerdate;
        private Button BT;
    }
}