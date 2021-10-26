using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akaryakıt_Otomasyonu
{
    public partial class Form1 : Form
    {
        double benzin95depo=50
            , benzin97depo=100
            , dizeldepo=250
            , eurodizeldepo=500
            , lpgdepo=1000
            , benzin95fiyat=8.10
            , benzin97fiyat = 8.15
            , dizelfiyat=8.05
            , eurodizelfiyat = 8.10
            , lpgfiyat = 5.99;

        private void buttonSatisYap_Click(object sender, EventArgs e)
        {
            double tutar;
            if (comboBoxYakitTuru.SelectedIndex == 0)
            {
                
                tutar = Convert.ToDouble(numericUpDownBenzin95.Value);
                benzin95depo -= Convert.ToDouble(tutar / benzin95fiyat);
                if (benzin95depo < 0)
                {
                    MessageBox.Show("Satış Gerçekleştirilemedi! Depo Yetersiz!");
                    benzin95depo += Convert.ToDouble(tutar / benzin95fiyat);
                }
                else
                {
                    MessageBox.Show("Satış Gerçekleşti\n" +
                                    "Benzin95 Depo Miktarı:" + benzin95depo);
                    progressBarBenzin95.Value = (int)benzin95depo;
                    labelBenzin95.Text = benzin95depo.ToString();
                }

            }
            if (comboBoxYakitTuru.SelectedIndex == 1)
            {

                tutar = Convert.ToDouble(numericUpDownBenzin97.Value);
                benzin97depo -= Convert.ToDouble(tutar / benzin97fiyat);
                if (benzin97depo < 0)
                {
                    MessageBox.Show("Satış Gerçekleştirilemedi! Depo Yetersiz!");
                    benzin97depo += Convert.ToDouble(tutar / benzin97fiyat);
                }
                else
                {
                    MessageBox.Show("Satış Gerçekleşti\n" +
                                    "Benzin97 Depo Miktarı:" + benzin97depo);
                    progressBarBenzin97.Value = (int)benzin97depo;
                    labelBenzin97.Text = benzin97depo.ToString();
                }

            }
            if (comboBoxYakitTuru.SelectedIndex == 2)
            {

                tutar = Convert.ToDouble(numericUpDownDizel.Value);
                dizeldepo -= Convert.ToDouble(tutar / dizelfiyat);
                if (dizeldepo < 0)
                {
                    MessageBox.Show("Satış Gerçekleştirilemedi! Depo Yetersiz!");
                    dizeldepo += Convert.ToDouble(tutar / dizelfiyat);
                }
                else
                {
                    MessageBox.Show("Satış Gerçekleşti\n" +
                                    "Dizel Depo Miktarı:" + dizeldepo);
                    progressBarDizel.Value = (int)dizeldepo;
                    labelDizel.Text = dizeldepo.ToString();
                }

            }
            if (comboBoxYakitTuru.SelectedIndex == 3)
            {

                tutar = Convert.ToDouble(numericUpDownEuroDizel.Value);
                eurodizeldepo -= Convert.ToDouble(tutar / eurodizelfiyat);
                if (eurodizeldepo < 0)
                {
                    MessageBox.Show("Satış Gerçekleştirilemedi! Depo Yetersiz!");
                    eurodizeldepo += Convert.ToDouble(tutar / eurodizelfiyat);
                }
                else
                {
                    MessageBox.Show("Satış Gerçekleşti\n" +
                                    "Euro Dizel Depo Miktarı:" + eurodizeldepo);
                    progressBarEuroDizel.Value = (int)eurodizeldepo;
                    labelEuroDizel.Text = eurodizeldepo.ToString();
                }

            }
            if (comboBoxYakitTuru.SelectedIndex == 4)
            {

                tutar = Convert.ToDouble(numericUpDownLPG.Value);
                lpgdepo -= Convert.ToDouble(tutar / lpgfiyat);
                if (lpgdepo < 0)
                {
                    MessageBox.Show("Satış Gerçekleştirilemedi! Depo Yetersiz!");
                    lpgdepo += Convert.ToDouble(tutar / lpgfiyat);
                }
                else
                {
                    MessageBox.Show("Satış Gerçekleşti\n" +
                                    "LPG Depo Miktarı:" + lpgdepo);
                    progressBarDizel.Value = (int)lpgdepo;
                    labelLPG.Text = lpgdepo.ToString();
                }

            }
        }

        private void comboBoxYakitTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYakitTuru.SelectedIndex == 0)
            {
                numericUpDownBenzin95.Enabled = true;
                numericUpDownBenzin97.Enabled = false;
                numericUpDownDizel.Enabled = false;
                numericUpDownEuroDizel.Enabled = false;
                numericUpDownLPG.Enabled = false;
            }
            if (comboBoxYakitTuru.SelectedIndex == 1)
            {
                numericUpDownBenzin95.Enabled = false;
                numericUpDownBenzin97.Enabled = true;
                numericUpDownDizel.Enabled = false;
                numericUpDownEuroDizel.Enabled = false;
                numericUpDownLPG.Enabled = false;
            }
            if (comboBoxYakitTuru.SelectedIndex == 2)
            {
                numericUpDownBenzin95.Enabled = false;
                numericUpDownBenzin97.Enabled = false;
                numericUpDownDizel.Enabled = true;
                numericUpDownEuroDizel.Enabled = false;
                numericUpDownLPG.Enabled = false;
            }
            if (comboBoxYakitTuru.SelectedIndex == 3)
            {
                numericUpDownBenzin95.Enabled = false;
                numericUpDownBenzin97.Enabled = false;
                numericUpDownDizel.Enabled = false;
                numericUpDownEuroDizel.Enabled = true;
                numericUpDownLPG.Enabled = false;
            }
            if (comboBoxYakitTuru.SelectedIndex == 4)
            {
                numericUpDownBenzin95.Enabled = false;
                numericUpDownBenzin97.Enabled = false;
                numericUpDownDizel.Enabled = false;
                numericUpDownEuroDizel.Enabled = false;
                numericUpDownLPG.Enabled = true;
            }
        }

        private void buttonFiyatlarıGuncelle(object sender, EventArgs e)
        {
            if (textBoxBenzin95Fiyat.Text != "")
            {
                benzin95fiyat += Convert.ToDouble(textBoxBenzin95Fiyat.Text);
                labelBenzin95Fiyat.Text = benzin95fiyat.ToString();
            }
            if (textBoxBenzin97Fiyat.Text != "")
            {
                benzin97fiyat += Convert.ToDouble(textBoxBenzin97Fiyat.Text);
                labelBenzin97Fiyat.Text = benzin97fiyat.ToString();
            }
            if (textBoxDizelFiyat.Text != "")
            {
                dizelfiyat += Convert.ToDouble(textBoxDizelFiyat.Text);
                labelDizelFiyat.Text = dizelfiyat.ToString();
            }
            if (textBoxEuroDizelFiyat.Text != "")
            {
                eurodizelfiyat += Convert.ToDouble(textBoxEuroDizelFiyat.Text);
                labelEuroDizelFiyat.Text = eurodizelfiyat.ToString();
            }
            if (textBoxLPGFiyat.Text != "")
            {
                lpgfiyat += Convert.ToDouble(textBoxLPGFiyat.Text);
                labelLPGFiyat.Text = lpgfiyat.ToString();
            }
            textBoxBenzin95Fiyat.Clear();
            textBoxBenzin97Fiyat.Clear();
            textBoxDizelFiyat.Clear();
            textBoxEuroDizelFiyat.Clear();
            textBoxLPGFiyat.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBarBenzin95.Value = Convert.ToInt32(benzin95depo);
            progressBarBenzin97.Value = Convert.ToInt32(benzin97depo);
            progressBarDizel.Value = Convert.ToInt32(dizeldepo);
            progressBarEuroDizel.Value = Convert.ToInt32(eurodizeldepo);
            progressBarLPG.Value = Convert.ToInt32(lpgdepo);
            numericUpDownBenzin95.Enabled = false;
            numericUpDownBenzin97.Enabled = false;
            numericUpDownDizel.Enabled = false;
            numericUpDownEuroDizel.Enabled = false;
            numericUpDownLPG.Enabled = false;
        }

        private void buttonDepoBilgileriniGüncelle_Click(object sender, EventArgs e)
        {
            if (textBoxBenzin95.Text != "")
            {
                benzin95depo += Convert.ToDouble(textBoxBenzin95.Text);
                if(benzin95depo>1000 || benzin95depo < 0)
                {
                    benzin95depo -= Convert.ToDouble(textBoxBenzin95.Text);
                    MessageBox.Show("0-1000 arası değer aşıldı");
                    textBoxBenzin95.Text = "HATA!";
                }
                labelBenzin95.Text = benzin95depo.ToString();
                progressBarBenzin95.Value = Convert.ToInt32(benzin95depo);
            }
            if (textBoxBenzin97.Text != "")
            {
                benzin97depo += Convert.ToDouble(textBoxBenzin97.Text);
                if (benzin97depo > 1000 || benzin97depo < 0)
                {
                    benzin97depo -= Convert.ToDouble(textBoxBenzin97.Text);
                    MessageBox.Show("0-1000 arası değer aşıldı");
                    textBoxBenzin97.Text = "HATA!";
                }
                labelBenzin97.Text = benzin97depo.ToString();
                progressBarBenzin97.Value = Convert.ToInt32(benzin97depo);
            }
            if (textBoxDizel.Text != "")
            {
                dizeldepo += Convert.ToDouble(textBoxDizel.Text);
                if (dizeldepo > 1000 || dizeldepo < 0)
                {
                    dizeldepo -= Convert.ToDouble(textBoxDizel.Text);
                    MessageBox.Show("0-1000 arası değer aşıldı");
                    textBoxDizel.Text = "HATA!";
                }
                labelDizel.Text = dizeldepo.ToString();
                progressBarDizel.Value = Convert.ToInt32(dizeldepo);
            }
            if (textBoxEuroDizel.Text != "")
            {
                eurodizeldepo += Convert.ToDouble(textBoxEuroDizel.Text);
                if (eurodizeldepo > 1000 || eurodizeldepo < 0)
                {
                    eurodizeldepo -= Convert.ToDouble(textBoxEuroDizel.Text);
                    MessageBox.Show("0-1000 arası değer aşıldı");
                    textBoxEuroDizel.Text = "HATA!";
                }
                labelEuroDizel.Text = eurodizeldepo.ToString();
                progressBarEuroDizel.Value = Convert.ToInt32(eurodizeldepo);
            }
            if (textBoxLPG.Text != "")
            {
                lpgdepo += Convert.ToDouble(textBoxLPG.Text);
                if (lpgdepo > 1000 || lpgdepo < 0)
                {
                    lpgdepo -= Convert.ToDouble(textBoxLPG.Text);
                    MessageBox.Show("0-1000 arası değer aşıldı");
                    textBoxLPG.Text = "HATA!";
                }
                labelLPG.Text = lpgdepo.ToString();
                progressBarLPG.Value = Convert.ToInt32(lpgdepo);
            }
            textBoxBenzin95.Clear();
            textBoxBenzin97.Clear();
            textBoxDizel.Clear();
            textBoxEuroDizel.Clear();
            textBoxLPG.Clear();
        }
    }
}
