
namespace WindowsFormsApp1
{
    partial class FizikVektorelCarpma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FizikVektorelCarpma));
            this.islem = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hesapla = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.ListBox();
            this.sayi1i = new System.Windows.Forms.TextBox();
            this.sayi1j = new System.Windows.Forms.TextBox();
            this.sayi1k = new System.Windows.Forms.TextBox();
            this.sayi2i = new System.Windows.Forms.TextBox();
            this.sayi2j = new System.Windows.Forms.TextBox();
            this.sayi2k = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.s1s1i = new System.Windows.Forms.Label();
            this.s1s1j = new System.Windows.Forms.Label();
            this.s1s1k = new System.Windows.Forms.Label();
            this.s2s2i = new System.Windows.Forms.Label();
            this.s2s2j = new System.Windows.Forms.Label();
            this.s2s2k = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.s3s1i = new System.Windows.Forms.Label();
            this.s3s1j = new System.Windows.Forms.Label();
            this.s3s1k = new System.Windows.Forms.Label();
            this.sol1 = new System.Windows.Forms.Label();
            this.sol2 = new System.Windows.Forms.Label();
            this.sol3 = new System.Windows.Forms.Label();
            this.sag1 = new System.Windows.Forms.Label();
            this.sag2 = new System.Windows.Forms.Label();
            this.sag3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_sonuc = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // islem
            // 
            this.islem.AutoSize = true;
            this.islem.Location = new System.Drawing.Point(18, 143);
            this.islem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(64, 25);
            this.islem.TabIndex = 0;
            this.islem.Text = "İşlem:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Skaler Çarpma",
            "Açı Bulma",
            "Vektörel Çarpma",
            "Determinant ile Vektörel Çarpma"});
            this.comboBox1.Location = new System.Drawing.Point(76, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "i^:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "j^:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "k^:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "i^:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "j^:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "k^:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "2. Vektör:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "1. Vektör:";
            // 
            // hesapla
            // 
            this.hesapla.BackColor = System.Drawing.Color.OrangeRed;
            this.hesapla.ForeColor = System.Drawing.Color.PeachPuff;
            this.hesapla.Location = new System.Drawing.Point(285, 140);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(90, 28);
            this.hesapla.TabIndex = 10;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = false;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // sonuc
            // 
            this.sonuc.BackColor = System.Drawing.SystemColors.Window;
            this.sonuc.FormattingEnabled = true;
            this.sonuc.ItemHeight = 25;
            this.sonuc.Location = new System.Drawing.Point(13, 316);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(808, 329);
            this.sonuc.TabIndex = 11;
            // 
            // sayi1i
            // 
            this.sayi1i.Location = new System.Drawing.Point(147, 206);
            this.sayi1i.Name = "sayi1i";
            this.sayi1i.Size = new System.Drawing.Size(40, 30);
            this.sayi1i.TabIndex = 12;
            // 
            // sayi1j
            // 
            this.sayi1j.Location = new System.Drawing.Point(216, 206);
            this.sayi1j.Name = "sayi1j";
            this.sayi1j.Size = new System.Drawing.Size(40, 30);
            this.sayi1j.TabIndex = 12;
            // 
            // sayi1k
            // 
            this.sayi1k.Location = new System.Drawing.Point(294, 206);
            this.sayi1k.Name = "sayi1k";
            this.sayi1k.Size = new System.Drawing.Size(40, 30);
            this.sayi1k.TabIndex = 12;
            // 
            // sayi2i
            // 
            this.sayi2i.Location = new System.Drawing.Point(147, 238);
            this.sayi2i.Name = "sayi2i";
            this.sayi2i.Size = new System.Drawing.Size(40, 30);
            this.sayi2i.TabIndex = 12;
            // 
            // sayi2j
            // 
            this.sayi2j.Location = new System.Drawing.Point(216, 238);
            this.sayi2j.Name = "sayi2j";
            this.sayi2j.Size = new System.Drawing.Size(40, 30);
            this.sayi2j.TabIndex = 12;
            // 
            // sayi2k
            // 
            this.sayi2k.Location = new System.Drawing.Point(294, 238);
            this.sayi2k.Name = "sayi2k";
            this.sayi2k.Size = new System.Drawing.Size(40, 30);
            this.sayi2k.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PeachPuff;
            this.label9.Location = new System.Drawing.Point(54, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "i";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PeachPuff;
            this.label10.Location = new System.Drawing.Point(127, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "j";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.PeachPuff;
            this.label11.Location = new System.Drawing.Point(197, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "k";
            // 
            // s1s1i
            // 
            this.s1s1i.AutoSize = true;
            this.s1s1i.BackColor = System.Drawing.Color.PeachPuff;
            this.s1s1i.Location = new System.Drawing.Point(54, 51);
            this.s1s1i.Name = "s1s1i";
            this.s1s1i.Size = new System.Drawing.Size(16, 25);
            this.s1s1i.TabIndex = 14;
            this.s1s1i.Text = "i";
            // 
            // s1s1j
            // 
            this.s1s1j.AutoSize = true;
            this.s1s1j.BackColor = System.Drawing.Color.PeachPuff;
            this.s1s1j.Location = new System.Drawing.Point(127, 51);
            this.s1s1j.Name = "s1s1j";
            this.s1s1j.Size = new System.Drawing.Size(16, 25);
            this.s1s1j.TabIndex = 14;
            this.s1s1j.Text = "j";
            // 
            // s1s1k
            // 
            this.s1s1k.AutoSize = true;
            this.s1s1k.BackColor = System.Drawing.Color.PeachPuff;
            this.s1s1k.Location = new System.Drawing.Point(197, 51);
            this.s1s1k.Name = "s1s1k";
            this.s1s1k.Size = new System.Drawing.Size(22, 25);
            this.s1s1k.TabIndex = 14;
            this.s1s1k.Text = "k";
            // 
            // s2s2i
            // 
            this.s2s2i.AutoSize = true;
            this.s2s2i.BackColor = System.Drawing.Color.PeachPuff;
            this.s2s2i.Location = new System.Drawing.Point(54, 92);
            this.s2s2i.Name = "s2s2i";
            this.s2s2i.Size = new System.Drawing.Size(16, 25);
            this.s2s2i.TabIndex = 14;
            this.s2s2i.Text = "i";
            // 
            // s2s2j
            // 
            this.s2s2j.AutoSize = true;
            this.s2s2j.BackColor = System.Drawing.Color.PeachPuff;
            this.s2s2j.Location = new System.Drawing.Point(127, 92);
            this.s2s2j.Name = "s2s2j";
            this.s2s2j.Size = new System.Drawing.Size(16, 25);
            this.s2s2j.TabIndex = 14;
            this.s2s2j.Text = "j";
            // 
            // s2s2k
            // 
            this.s2s2k.AutoSize = true;
            this.s2s2k.BackColor = System.Drawing.Color.PeachPuff;
            this.s2s2k.Location = new System.Drawing.Point(197, 92);
            this.s2s2k.Name = "s2s2k";
            this.s2s2k.Size = new System.Drawing.Size(22, 25);
            this.s2s2k.TabIndex = 14;
            this.s2s2k.Text = "k";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.PeachPuff;
            this.label18.Location = new System.Drawing.Point(54, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 25);
            this.label18.TabIndex = 14;
            this.label18.Text = "i";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.PeachPuff;
            this.label19.Location = new System.Drawing.Point(127, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 25);
            this.label19.TabIndex = 14;
            this.label19.Text = "j";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.PeachPuff;
            this.label20.Location = new System.Drawing.Point(197, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 25);
            this.label20.TabIndex = 14;
            this.label20.Text = "k";
            // 
            // s3s1i
            // 
            this.s3s1i.AutoSize = true;
            this.s3s1i.BackColor = System.Drawing.Color.PeachPuff;
            this.s3s1i.Location = new System.Drawing.Point(54, 173);
            this.s3s1i.Name = "s3s1i";
            this.s3s1i.Size = new System.Drawing.Size(16, 25);
            this.s3s1i.TabIndex = 14;
            this.s3s1i.Text = "i";
            // 
            // s3s1j
            // 
            this.s3s1j.AutoSize = true;
            this.s3s1j.BackColor = System.Drawing.Color.PeachPuff;
            this.s3s1j.Location = new System.Drawing.Point(127, 173);
            this.s3s1j.Name = "s3s1j";
            this.s3s1j.Size = new System.Drawing.Size(16, 25);
            this.s3s1j.TabIndex = 14;
            this.s3s1j.Text = "j";
            // 
            // s3s1k
            // 
            this.s3s1k.AutoSize = true;
            this.s3s1k.BackColor = System.Drawing.Color.PeachPuff;
            this.s3s1k.Location = new System.Drawing.Point(197, 173);
            this.s3s1k.Name = "s3s1k";
            this.s3s1k.Size = new System.Drawing.Size(22, 25);
            this.s3s1k.TabIndex = 14;
            this.s3s1k.Text = "k";
            // 
            // sol1
            // 
            this.sol1.AutoSize = true;
            this.sol1.ForeColor = System.Drawing.Color.Red;
            this.sol1.Location = new System.Drawing.Point(149, 482);
            this.sol1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sol1.Name = "sol1";
            this.sol1.Size = new System.Drawing.Size(0, 25);
            this.sol1.TabIndex = 15;
            // 
            // sol2
            // 
            this.sol2.AutoSize = true;
            this.sol2.ForeColor = System.Drawing.Color.Red;
            this.sol2.Location = new System.Drawing.Point(149, 519);
            this.sol2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sol2.Name = "sol2";
            this.sol2.Size = new System.Drawing.Size(0, 25);
            this.sol2.TabIndex = 15;
            // 
            // sol3
            // 
            this.sol3.AutoSize = true;
            this.sol3.ForeColor = System.Drawing.Color.Red;
            this.sol3.Location = new System.Drawing.Point(149, 554);
            this.sol3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sol3.Name = "sol3";
            this.sol3.Size = new System.Drawing.Size(0, 25);
            this.sol3.TabIndex = 15;
            // 
            // sag1
            // 
            this.sag1.AutoSize = true;
            this.sag1.ForeColor = System.Drawing.Color.Blue;
            this.sag1.Location = new System.Drawing.Point(519, 482);
            this.sag1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sag1.Name = "sag1";
            this.sag1.Size = new System.Drawing.Size(0, 25);
            this.sag1.TabIndex = 15;
            // 
            // sag2
            // 
            this.sag2.AutoSize = true;
            this.sag2.ForeColor = System.Drawing.Color.Blue;
            this.sag2.Location = new System.Drawing.Point(519, 519);
            this.sag2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sag2.Name = "sag2";
            this.sag2.Size = new System.Drawing.Size(0, 25);
            this.sag2.TabIndex = 15;
            // 
            // sag3
            // 
            this.sag3.AutoSize = true;
            this.sag3.ForeColor = System.Drawing.Color.Blue;
            this.sag3.Location = new System.Drawing.Point(519, 554);
            this.sag3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sag3.Name = "sag3";
            this.sag3.Size = new System.Drawing.Size(0, 25);
            this.sag3.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.s3s1k);
            this.panel1.Controls.Add(this.s3s1i);
            this.panel1.Controls.Add(this.s3s1j);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.s1s1k);
            this.panel1.Controls.Add(this.s2s2k);
            this.panel1.Controls.Add(this.s1s1j);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.s1s1i);
            this.panel1.Controls.Add(this.s2s2i);
            this.panel1.Controls.Add(this.s2s2j);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(241, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 221);
            this.panel1.TabIndex = 16;
            // 
            // Label_sonuc
            // 
            this.Label_sonuc.AutoSize = true;
            this.Label_sonuc.BackColor = System.Drawing.Color.PeachPuff;
            this.Label_sonuc.Location = new System.Drawing.Point(519, 288);
            this.Label_sonuc.Name = "Label_sonuc";
            this.Label_sonuc.Size = new System.Drawing.Size(75, 25);
            this.Label_sonuc.TabIndex = 17;
            this.Label_sonuc.Text = "Sonuç:";
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Location = new System.Drawing.Point(202, 595);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(0, 25);
            this.s1.TabIndex = 18;
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Location = new System.Drawing.Point(202, 623);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(0, 25);
            this.s2.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(-6, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 133);
            this.panel2.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("LEMON MILK Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.PeachPuff;
            this.label13.Location = new System.Drawing.Point(19, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(483, 60);
            this.label13.TabIndex = 21;
            this.label13.Text = "Vektörel Çarpma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 288);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nasıl Çözdük:";
            // 
            // FizikVektorelCarpma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(837, 657);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.Label_sonuc);
            this.Controls.Add(this.sag3);
            this.Controls.Add(this.sol3);
            this.Controls.Add(this.sag2);
            this.Controls.Add(this.sag1);
            this.Controls.Add(this.sol2);
            this.Controls.Add(this.sol1);
            this.Controls.Add(this.sayi2k);
            this.Controls.Add(this.sayi2j);
            this.Controls.Add(this.sayi1k);
            this.Controls.Add(this.sayi2i);
            this.Controls.Add(this.sayi1j);
            this.Controls.Add(this.sayi1i);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sonuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FizikVektorelCarpma";
            this.Text = "Fizik Vektorel Carpma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label islem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.ListBox sonuc;
        private System.Windows.Forms.TextBox sayi1i;
        private System.Windows.Forms.TextBox sayi1j;
        private System.Windows.Forms.TextBox sayi1k;
        private System.Windows.Forms.TextBox sayi2i;
        private System.Windows.Forms.TextBox sayi2j;
        private System.Windows.Forms.TextBox sayi2k;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label s1s1i;
        private System.Windows.Forms.Label s1s1j;
        private System.Windows.Forms.Label s1s1k;
        private System.Windows.Forms.Label s2s2i;
        private System.Windows.Forms.Label s2s2j;
        private System.Windows.Forms.Label s2s2k;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label s3s1i;
        private System.Windows.Forms.Label s3s1j;
        private System.Windows.Forms.Label s3s1k;
        private System.Windows.Forms.Label sol1;
        private System.Windows.Forms.Label sol2;
        private System.Windows.Forms.Label sol3;
        private System.Windows.Forms.Label sag1;
        private System.Windows.Forms.Label sag2;
        private System.Windows.Forms.Label sag3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_sonuc;
        private System.Windows.Forms.Label s1;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

