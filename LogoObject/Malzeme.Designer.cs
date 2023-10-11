namespace LogoObject
{
    partial class Malzeme
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
            btnAktar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtkullaniciadi = new TextBox();
            txtsifre = new TextBox();
            txtfirma = new TextBox();
            txtdonem = new TextBox();
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            btnexcelsec = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAktar
            // 
            btnAktar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAktar.Location = new Point(746, 20);
            btnAktar.Name = "btnAktar";
            btnAktar.Size = new Size(136, 78);
            btnAktar.TabIndex = 0;
            btnAktar.Text = "LOGOYA AKTAR";
            btnAktar.UseVisualStyleBackColor = true;
            btnAktar.Click += btnAktar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 1;
            label1.Text = "Logo Kullanıcı Adı *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 70);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Logo Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(357, 21);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 3;
            label3.Text = "Logo Firma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(357, 70);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 4;
            label4.Text = "Logo Dönem";
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtkullaniciadi.Location = new Point(217, 21);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(119, 29);
            txtkullaniciadi.TabIndex = 5;
            txtkullaniciadi.Text = "LOGO";
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtsifre.Location = new Point(217, 69);
            txtsifre.Name = "txtsifre";
            txtsifre.PasswordChar = '*';
            txtsifre.Size = new Size(119, 29);
            txtsifre.TabIndex = 6;
            txtsifre.Text = "LOGO";
            // 
            // txtfirma
            // 
            txtfirma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtfirma.Location = new Point(515, 20);
            txtfirma.Name = "txtfirma";
            txtfirma.Size = new Size(119, 29);
            txtfirma.TabIndex = 7;
            txtfirma.Text = "100";
            // 
            // txtdonem
            // 
            txtdonem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdonem.Location = new Point(515, 69);
            txtdonem.Name = "txtdonem";
            txtdonem.Size = new Size(119, 29);
            txtdonem.TabIndex = 8;
            txtdonem.Text = "01";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1054, 391);
            dataGridView1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnexcelsec
            // 
            btnexcelsec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexcelsec.Location = new Point(28, 117);
            btnexcelsec.Name = "btnexcelsec";
            btnexcelsec.Size = new Size(516, 33);
            btnexcelsec.TabIndex = 10;
            btnexcelsec.Text = "Excel Seç (MALZEME AKTARIM ŞABLONUNDAKİ MALZEME SAYFASI GEÇERLİDİR)";
            btnexcelsec.UseVisualStyleBackColor = true;
            btnexcelsec.Click += btnexcelsec_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(746, 117);
            label5.Name = "label5";
            label5.Size = new Size(269, 15);
            label5.TabIndex = 11;
            label5.Text = "* Bu kullanıcının Object kullanım yetkisi olmalıdır.";
            // 
            // Malzeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 746);
            Controls.Add(label5);
            Controls.Add(btnexcelsec);
            Controls.Add(dataGridView1);
            Controls.Add(txtdonem);
            Controls.Add(txtfirma);
            Controls.Add(txtsifre);
            Controls.Add(txtkullaniciadi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAktar);
            Name = "Malzeme";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAktar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtkullaniciadi;
        private TextBox txtsifre;
        private TextBox txtfirma;
        private TextBox txtdonem;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private Button btnexcelsec;
        private Label label5;
    }
}