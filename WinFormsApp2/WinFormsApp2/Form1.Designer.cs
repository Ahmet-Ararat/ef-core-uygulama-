namespace WinFormsApp2
{
    partial class Form1
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
            btn_ekle = new Button();
            txt_ad = new TextBox();
            txt_soyad = new TextBox();
            txt_okulNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btn_sil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(50, 99);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(100, 23);
            btn_ekle.TabIndex = 0;
            btn_ekle.Text = "EKLE";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(50, 12);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(100, 23);
            txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(50, 41);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(100, 23);
            txt_soyad.TabIndex = 2;
            // 
            // txt_okulNo
            // 
            txt_okulNo.Location = new Point(50, 70);
            txt_okulNo.Name = "txt_okulNo";
            txt_okulNo.Size = new Size(100, 23);
            txt_okulNo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 4;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 49);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 81);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Okul No";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(288, 164);
            dataGridView1.TabIndex = 7;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(50, 128);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(100, 23);
            btn_sil.TabIndex = 8;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 184);
            Controls.Add(btn_sil);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_okulNo);
            Controls.Add(txt_soyad);
            Controls.Add(txt_ad);
            Controls.Add(btn_ekle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ekle;
        private TextBox txt_ad;
        private TextBox txt_soyad;
        private TextBox txt_okulNo;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btn_sil;
    }
}