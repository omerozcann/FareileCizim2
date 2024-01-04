namespace FareileCizim2
{
    partial class cizimFrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.silgiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // silgiBtn
            // 
            this.silgiBtn.Location = new System.Drawing.Point(49, 509);
            this.silgiBtn.Name = "silgiBtn";
            this.silgiBtn.Size = new System.Drawing.Size(75, 65);
            this.silgiBtn.TabIndex = 0;
            this.silgiBtn.Text = "Silgi";
            this.silgiBtn.UseVisualStyleBackColor = true;
            this.silgiBtn.Click += new System.EventHandler(this.silgiBtn_Click);
            // 
            // cizimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 622);
            this.Controls.Add(this.silgiBtn);
            this.Name = "cizimFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çizim";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cizimFrm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cizimFrm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cizimFrm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button silgiBtn;
    }
}

