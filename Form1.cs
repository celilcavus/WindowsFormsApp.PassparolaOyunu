using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp.PassparolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void ResetAll()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;

            soruno = 0;
            dogru = 0;
            yanlis = 0;

            richTextBox1.Clear();
            textBox1.Clear();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Text = "";
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "isparta")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "hanami")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    default:
                        DialogResult res = MessageBox.Show("Sorular Bitti Sıfırlamak İstermisiniz?", "", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            ResetAll();

                        }
                        else
                            MessageBox.Show("İşlem İptal Edildi");
                        break;
                }
            }
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnBasla.Text = "Sonraki Soru >>";
            soruno++;
            this.Text = soruno.ToString();


            switch (soruno)
            {
                case 1:
                    richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                    button2.BackColor = Color.Yellow;
                    break;

                case 2:
                    richTextBox1.Text = "Yeşiliğiyle ünlü marma ilimiz?";
                    button3.BackColor = Color.Yellow;
                    break;

                case 3:
                    richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                    button4.BackColor = Color.Yellow;
                    break;
                case 4:
                    richTextBox1.Text = "Karpuzuyla meşhur ilimiz?";
                    button5.BackColor = Color.Yellow;
                    break;

                case 5:
                    richTextBox1.Text = "Yeni Kelimesinin Zıt Anlamı?";
                    button11.BackColor = Color.Yellow;
                    break;

                case 6:
                    richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                    button12.BackColor = Color.Yellow;
                    break;

                case 7:
                    richTextBox1.Text = "Dünyanın Isı Kaynağı?";
                    button13.BackColor = Color.Yellow;
                    break;

                case 8:
                    richTextBox1.Text = "Öğrencilerin Kötü Karne getirince bakıştığı nesne?";
                    button14.BackColor = Color.Yellow;
                    break;

                case 9:
                    richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                    button6.BackColor = Color.Yellow;
                    break;
                case 10:
                    richTextBox1.Text = "Mersinin Diğer İsmi?";
                    button7.BackColor = Color.Yellow;
                    break;

                case 11:
                    richTextBox1.Text = "Askeri topluluk?";
                    button8.BackColor = Color.Yellow;
                    break;

                case 12:
                    richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                    button9.BackColor = Color.Yellow;
                    break;
                case 13:
                    richTextBox1.Text = "Her Yıl Bahar aylarında düzenlenen meşhur çiçek festivali?";
                    button10.BackColor = Color.Yellow;
                    break;

                case 14:
                    richTextBox1.Text = "Yılın 3. Ayı ?";
                    button15.BackColor = Color.Yellow;
                    break;

                case 15:
                    richTextBox1.Text = "Üflemeli bir müzik Aleti?";
                    button16.BackColor = Color.Yellow;
                    break;

                case 16:
                    richTextBox1.Text = "Halk Şairi ?";
                    button17.BackColor = Color.Yellow;
                    break;

                case 17:
                    richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzeler ile yapılan yemek?";
                    button18.BackColor = Color.Yellow;
                    break;

                case 18:
                    richTextBox1.Text = "11 Ayın Sultanı?";
                    button1.BackColor = Color.Yellow;
                    break;

                default:
                    DialogResult res = MessageBox.Show("Sorular Bitti Sıfırlamak İstermisiniz?", "", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        ResetAll();
                        
                    }
                    else
                        MessageBox.Show("İşlem İptal Edildi");
                    break;
            }
        }
    }
}
