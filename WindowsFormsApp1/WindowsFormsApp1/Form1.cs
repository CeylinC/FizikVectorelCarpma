using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FizikVektorelCarpma : Form
    {
        double s1i, s1j, s1k, s2i, s2j, s2k, yanit, v1, v2;
        double pi = 3.14;
        string sv1, sv2, syanit, scosTeta;
        public FizikVektorelCarpma()
        {
            InitializeComponent();
            Gizle();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            sonuc.Items.Clear();

            switch (comboBox1.Text)
            {
                case "Skaler Çarpma":
                    SkalerCarpma();
                    break;
                case "Açı Bulma":
                    AciBulma();
                    break;
                case "Vektörel Çarpma":
                    VektorelCarpma();
                    break;
                case "Determinant ile Vektörel Çarpma":
                    Determinant();
                    break;
                default:
                    break;
            }
        }

        public void Tanimlama()
        {
            s1i = Convert.ToDouble(sayi1i.Text);
            s2i = Convert.ToDouble(sayi2i.Text);
            s1j = Convert.ToDouble(sayi1j.Text);
            s2j = Convert.ToDouble(sayi2j.Text);
            s1k = Convert.ToDouble(sayi1k.Text);
            s2k = Convert.ToDouble(sayi2k.Text);
            v1 = Math.Sqrt((s1i * s1i) + (s1j * s1j) + (s1k * s1k));
            v2 = Math.Sqrt((s2i * s2i) + (s2j * s2j) + (s2k * s2k));

            sv1 = String.Format("{0:0.00}", v1);
            sv2 = String.Format("{0:0.00}", v2);

        }
        public void SkalerCarpma()
        {
            Tanimlama();
            sonuc.Visible = true;
            Gizle();

            yanit = (s1i * s2i) + (s1j * s2j) + (s1k * s2k);
            sonuc.Items.Add("A . B = (" + s1i + "i + " + s1j + "j + " + s1k + "k) * (" + s2i + "i + " + s2j + "j + " + s2k + "k)");
            sonuc.Items.Add("= (" + s1i + "i." + s2i + "i) + (" + s1i + "i." + s2j + "j) + (" + s1i + "i." + s2k + "k) + (" + s1j + "j." + s2i + "i) + (" + s1j + "j." + s2j + "j) + (" + s1j + "j." + s2k + "k) + (" + s1k + "k." + s2i +"i) + (" + s1k + "k." + s2j + "j) + (" + s1k + "k." + s2k + "k)");
            sonuc.Items.Add("= " + s1i*s2i + "+0+0+" + s1j*s2j + "+0+0+" + s1k*s2k + "+0+0");
            sonuc.Items.Add("= " + yanit);
            Label_sonuc.Text = "Sonuç: "+yanit;
        }

        public void AciBulma()
        {
            Tanimlama();
            sonuc.Visible = true;
            Gizle();

            double skalerCarpim = (s1i * s2i) + (s1j * s2j) + (s1k * s2k);
            double cosTeta = skalerCarpim / (v1 * v2);
            double radyanTeta = Math.Acos(cosTeta);
            yanit = (radyanTeta * 180) / pi;

            syanit = String.Format("{0:0.00}", yanit);
            scosTeta = String.Format("{0:0.00}", cosTeta);

            sonuc.Items.Add("Kullanılacak formül = > A.B = | A |.| B |.cosa");
            sonuc.Items.Add("| A | = (" + s1i +" ^ 2 + "+ s1j +" ^ 2 + "+ s1k +" ^ 2) ^ (1 / 2) = "+ sv1);
            sonuc.Items.Add("| B | = (" + s2i + " ^ 2 + " + s2j + " ^ 2 + " + s2k + " ^ 2) ^ (1 / 2) = " + sv2);
            sonuc.Items.Add("A . B = ("+ s1i +"i+"+ s1j +"j+"+ s1k +"k) . ("+ s2i +"i+"+ s2j +"j+"+ s2k +"k)");
            sonuc.Items.Add("= (" + s1i + "i." + s2i + "i) + (" + s1i + "i." + s2j + "j) + (" + s1i + "i." + s2k + "k) + (" + s1j + "j." + s2i + "i) + (" + s1j + "j." + s2j + "j) + (" + s1j + "j." + s2k + "k) + (" + s1k + "k." + s2i + "i) + (" + s1k + "k." + s2j + "j) + (" + s1k + "k." + s2k + "k)");
            sonuc.Items.Add("= " + s1i * s2i + "+0+0+" + s1j * s2j + "+0+0+" + s1k * s2k + "+0+0");
            sonuc.Items.Add("= " + skalerCarpim);
            sonuc.Items.Add("Formül: "+ skalerCarpim +" = "+ sv1 +" . "+ sv2 +" . cosx");
            sonuc.Items.Add("cosx = "+ scosTeta);
            sonuc.Items.Add("arccos" + scosTeta + " = "+ syanit +"Derece");
            Label_sonuc.Text = "Sonuç: " + syanit;
        }

        public void VektorelCarpma()
        {
            Tanimlama();
            sonuc.Visible = true;
            Gizle();

            sonuc.Items.Add("A x B = ("+ s1i +"i+"+ s1j +"j+"+ s1k +"k) x ("+ s2i +"i+"+ s2j +"j+"+ s2k +"k)");
            sonuc.Items.Add("= ("+s1j+"*"+s2k+"-"+s1k+"*"+s2j+")i^ + (" + s1k + "*" + s2i + "-" + s1i + "*" + s2k + ")j^ + (" + s1i + "*" + s2j + "-" + s1j + "*" + s2i + ")k^");
            sonuc.Items.Add("= (" + s1j*s2k + "-" + s1k*s2j + ")i^ + (" + s1k*s2i + "-" + s1i*s2k + ")j^ + (" + s1i*s2j + "-" + s1j*s2i + ")k^");
            sonuc.Items.Add("= (" + (s1j * s2k - s1k * s2j) + ")i^ + (" + (s1k * s2i - s1i * s2k) + ")j^ + (" + (s1i * s2j - s1j * s2i) + ")k^");
            Label_sonuc.Text = "Sonuç: " + ((s1j * s2k - s1k * s2j) + "i^ + " + (s1k * s2i - s1i * s2k) + "j^ + " + (s1i * s2j - s1j * s2i) + "k^");
        }
        public void Determinant()
        {
            Tanimlama();
            sonuc.Visible = false;
            Goster();

            s1s1i.Text = Convert.ToString(s1i);
            s1s1j.Text = Convert.ToString(s1j);
            s1s1k.Text = Convert.ToString(s1k);

            s2s2i.Text = Convert.ToString(s2i);
            s2s2j.Text = Convert.ToString(s2j);
            s2s2k.Text = Convert.ToString(s2k);

            s3s1i.Text = Convert.ToString(s1i);
            s3s1j.Text = Convert.ToString(s1j);
            s3s1k.Text = Convert.ToString(s1k);

            sol1.Text = "k*"+s1j+"*"+s2i;
            sol2.Text = s1k+"*"+s2j+"*i";
            sol3.Text = s2k+"*j*"+s1i;

            sag1.Text = "i*"+s1j+"*"+s2k;
            sag2.Text = s1i+"*"+s2j+"*k";
            sag3.Text = s2i+"*j*"+s1k;

            s1.Text = "= ("+s1j*s2k+"-"+s1k*s2j+")i + ("+s2i*s1k+"-"+s2k*s1i+")j + ("+s1i*s2j+"-"+s1j*s2i+")k";
            s2.Text = "= ("+ (s1j * s2k - s1k * s2j) + ")i + (" + (s2i * s1k - s2k * s1i) + ")j + (" + (s1i * s2j - s1j * s2i) + ")k";

            Label_sonuc.Text = "Sonuç: " + ((s1j * s2k - s1k * s2j) + "i^ + " + (s1k * s2i - s1i * s2k) + "j^ + " + (s1i * s2j - s1j * s2i) + "k^");
        }

        public void Gizle()
        {
            panel1.Visible = false;
            sol1.Visible = false;
            sol2.Visible = false;
            sol3.Visible = false;
            sag1.Visible = false;
            sag2.Visible = false;
            sag3.Visible = false;
            s1.Visible = false;
            s2.Visible = false;
        }
        public void Goster()
        {
            panel1.Visible = true;
            sol1.Visible = true;
            sol2.Visible = true;
            sol3.Visible = true;
            sag1.Visible = true;
            sag2.Visible = true;
            sag3.Visible = true;
            s1.Visible = true;
            s2.Visible = true;
        }
    }
}
