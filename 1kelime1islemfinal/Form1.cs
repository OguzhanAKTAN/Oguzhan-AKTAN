using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace _1kelime1islemfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LabelTemizle();
        }
        void LabelTemizle()
        {
            Uzunluk.Text = string.Empty;
            BonusHarfLabel.Text = string.Empty;
            BulunanKelime.Text = string.Empty;
        }// Labelleri string.empty yapar
        
        // CLICK EVENTLERİ
        private void RndAllButton_Click(object sender, EventArgs e)
        {
            RastgeleDoldurHepsi();
        }
        private void Rnd1_Click(object sender, EventArgs e)
        {
            tekhane1.Text = RastgeleDoldur();
        }
        private void Rnd2_Click(object sender, EventArgs e)
        {
            tekhane2.Text = RastgeleDoldur();
        }
        private void Rnd3_Click(object sender, EventArgs e)
        {
            tekhane3.Text = RastgeleDoldur();
        }
        private void Rnd4_Click(object sender, EventArgs e)
        {
            tekhane4.Text = RastgeleDoldur();
        }
        private void Rnd5_Click(object sender, EventArgs e)
        {
            tekhane5.Text = RastgeleDoldur();
        }
        private void RndCift_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Cifthanecombo.Text = (rnd.Next(1, 9) * 10).ToString();
        }
        private void RndHedef_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            hedeftextBox.Text = rnd.Next(100, 999).ToString();
        }
        private void HarfRnd1_Click(object sender, EventArgs e)
        {
            Harf1.Text = Harf1.Items[RastgeleHarfDoldur()].ToString();
        }
        private void HarfRnd2_Click(object sender, EventArgs e)
        {
            Harf2.Text = Harf1.Items[RastgeleHarfDoldur()].ToString();
        }
        private void HarfRnd3_Click(object sender, EventArgs e)
        {
            Harf3.Text = Harf1.Items[RastgeleHarfDoldur()].ToString();
        }
        private void HarfRnd4_Click(object sender, EventArgs e)
        {
            Harf4.Text = Harf1.Items[RastgeleHarfDoldur()].ToString();
        }
        private void HarfRnd5_Click(object sender, EventArgs e)
        {
            Harf5.Text = Harf1.Items[RastgeleHarfDoldur()].ToString();
        }
        private void HarfRnd6_Click(object sender, EventArgs e)
        {
            Harf6.Text = Harf1.Items[RastgeleHarfDoldur()].ToString();
        }
        private void HarfRnd7_Click(object sender, EventArgs e)
        {
            Harf7.Text = Harf1.Items[RastgeleHarfDoldur()].ToString();
        }
        private void HarfRnd8_Click(object sender, EventArgs e)
        {
            Harf8.Text = Harf1.Items[RastgeleHarfDoldur()].ToString();
        }
        private void HarfRndAllButton_Click(object sender, EventArgs e)
        {
            RastgeleHarfDoldurHepsi();
        }

        // RASTGELE BUTTON METODLARI
        void RastgeleDoldurHepsi()
        {
            Random rnd = new Random();
            tekhane1.Text = rnd.Next(1, 9).ToString();
            tekhane2.Text = rnd.Next(1, 9).ToString();
            tekhane3.Text = rnd.Next(1, 9).ToString();
            tekhane4.Text = rnd.Next(1, 9).ToString();
            tekhane5.Text = rnd.Next(1, 9).ToString();
            Cifthanecombo.Text = (rnd.Next(1, 9) * 10).ToString();
            hedeftextBox.Text = rnd.Next(100, 999).ToString();
        }
        string RastgeleDoldur()
        {
            Random rnd = new Random();
            return rnd.Next(1, 9).ToString();
        }
        int RastgeleHarfDoldur()
        {
            Random rnd = new Random();
            return rnd.Next(0, 28);
        }
        void RastgeleHarfDoldurHepsi()
        {
            Random rnd = new Random();
            Harf1.Text = Harf1.Items[rnd.Next(0, 28)].ToString();
            Harf2.Text = Harf1.Items[rnd.Next(0, 28)].ToString();
            Harf3.Text = Harf1.Items[rnd.Next(0, 28)].ToString();
            Harf4.Text = Harf1.Items[rnd.Next(0, 28)].ToString();
            Harf5.Text = Harf1.Items[rnd.Next(0, 28)].ToString();
            Harf6.Text = Harf1.Items[rnd.Next(0, 28)].ToString();
            Harf7.Text = Harf1.Items[rnd.Next(0, 28)].ToString();
            Harf8.Text = Harf1.Items[rnd.Next(0, 28)].ToString();
        }

        // TEXTBOX DEĞERLERİNİ LİSTELERE ATAMA METODLARI
        void SayilarListeDoldur(List<int> temp)
        {
            temp.Add(Convert.ToInt32(tekhane1.Text));
            temp.Add(Convert.ToInt32(tekhane2.Text));
            temp.Add(Convert.ToInt32(tekhane3.Text));
            temp.Add(Convert.ToInt32(tekhane4.Text));
            temp.Add(Convert.ToInt32(tekhane5.Text));
            temp.Add(Convert.ToInt32(Cifthanecombo.Text));
        }
        void HarflerListeDoldur(List<string> temp)
        {
            temp.Add(Harf1.Text);
            temp.Add(Harf2.Text);
            temp.Add(Harf3.Text);
            temp.Add(Harf4.Text);
            temp.Add(Harf5.Text);
            temp.Add(Harf6.Text);
            temp.Add(Harf7.Text);
            temp.Add(Harf8.Text);
        }
        void HarflerListeDoldurChar(List<char> temp)
        {
            temp.Add(Convert.ToChar(Harf1.Text));
            temp.Add(Convert.ToChar(Harf2.Text));
            temp.Add(Convert.ToChar(Harf3.Text));
            temp.Add(Convert.ToChar(Harf4.Text));
            temp.Add(Convert.ToChar(Harf5.Text));
            temp.Add(Convert.ToChar(Harf6.Text));
            temp.Add(Convert.ToChar(Harf7.Text));
            temp.Add(Convert.ToChar(Harf8.Text));
        }

        // 1 ISLEM FONKSİYONLARINI GERÇEKLEŞTİREN METODLAR
        static Sonuc DortIslem(List<int> sayilar, int ortasayi, int hedef)
        {
            /*Bu algoritma Bruteforce dört işlem algoritmasıdır
             listedeki sayılar biribirleri içinde 4 işlemden geçirilir 
             her işlemden sonraki sonuç ortasayi adlı int olarak 1 sayıymış gibi devam eder
             hedef sayıya ulaşıncaya veya olabilecek bütün işlemler yapılıncaya kadar*/

            /*Yapılan işlemler 2.000.000 adetten fazladır
             i7 8750h işlemci ve 16gb ram bulunan bir bilgisayarda
             hedef sayıya ulaşılması yaklaşık 0,08 saniye sürmektedir*/

            Sonuc ortasonuc = new Sonuc();
            if (ortasayi == hedef)
            {
                ortasonuc.kontrol = true;
                ortasonuc.islem = "";
                return ortasonuc;
            }
            foreach (int sayi in sayilar)
            {
                List<int> TempList = new List<int>(sayilar);
                TempList.Remove(sayi);
                if (TempList.Count == 0)
                {
                    if (ortasayi - sayi == hedef)
                    {
                        ortasonuc.kontrol = true;
                        ortasonuc.islem = "-" + sayi;
                        return ortasonuc;
                    }
                    if (ortasayi + sayi == hedef)
                    {
                        ortasonuc.kontrol = true;
                        ortasonuc.islem = "+" + sayi;
                        return ortasonuc;
                    }
                    if (ortasayi * sayi == hedef)
                    {
                        ortasonuc.kontrol = true;
                        ortasonuc.islem = "*" + sayi;
                        return ortasonuc;
                    }
                    if (ortasayi / sayi == hedef)
                    {
                        ortasonuc.kontrol = true;
                        ortasonuc.islem = "/" + sayi;
                        return ortasonuc;
                    }
                    ortasonuc.kontrol = false;
                    ortasonuc.islem = "f" + sayi;
                    return ortasonuc;
                }
                else
                {
                    ortasonuc = DortIslem(TempList, ortasayi - sayi, hedef);
                    if (ortasonuc.kontrol)
                    {
                        ortasonuc.islem = "-" + sayi + ortasonuc.islem;
                        return ortasonuc;
                    }
                    ortasonuc = DortIslem(TempList, ortasayi + sayi, hedef);
                    if (ortasonuc.kontrol)
                    {
                        ortasonuc.islem = "+" + sayi + ortasonuc.islem;
                        return ortasonuc;
                    }
                    ortasonuc = DortIslem(TempList, ortasayi * sayi, hedef);
                    if (ortasonuc.kontrol)
                    {
                        ortasonuc.islem = "*" + sayi + ortasonuc.islem;
                        return ortasonuc;
                    }
                    ortasonuc = DortIslem(TempList, ortasayi / sayi, hedef);
                    if (ortasonuc.kontrol)
                    {
                        ortasonuc.islem = "/" + sayi + ortasonuc.islem;
                        return ortasonuc;
                    }
                }

            }
            return ortasonuc;
        }   // Bruteforce dört islem metodu
        bool IslemListe(List<int> sayilar, int hedef)
        {
            /*Bu döngü hedef sayı bulununcaya kadar sayilar listesindeki
             her sayı için DortIslem metodunu çağırır*/
             
            /*Eğer hedef sayı bulunduysa metod gerekli işlemi 
              Sonuclabel a yazar ve true değerini verir*/
            foreach (int sayi in sayilar)
            {
                List<int> islemliste = new List<int>(sayilar);
                islemliste.Remove(sayi);
                Sonuc sonuc = DortIslem(islemliste, sayi, hedef);
                if (sonuc.kontrol)
                {
                    label8.Text = "Hedef Sayi Bulundu!";
                    Sonuclabel.Text = (sayi.ToString() + sonuc.islem + " = " + hedef);
                    return true;
                }
            }
            /*Eğer hedef sayının kendisi bulunamadıysa FarkIslemListe metodu çağırılır*/
            return FarkIslemListe(sayilar, hedef);
        }   // Hedef sayının kendisini bulma metodu
        bool FarkIslemListe(List<int> sayilar, int hedef)
        {
            /*Bu metod IslemLıste metodu ile aynı çalışır
             fakat while döngüsüne her girildiğinde hem hedef sayının fark sayısı kadar fazalasına
             hem de fark sayısı kadar ekiğine bakılır*/
             /*Döngü fark 10 dan küçük olana kadar fark her seferinde 1 artırılarak devam eder
              ilk önce hangi DortIslem metodu true değerini verirse onun cevabı yazılır metoddan çıkılır*/
            int fark = 1;
            while (fark < 10)
            {
                foreach (int sayi in sayilar)
                {
                    List<int> islemliste = new List<int>(sayilar);
                    islemliste.Remove(sayi);
                    Sonuc fazlasonuc = DortIslem(islemliste, sayi, (hedef + fark));
                    Sonuc eksiksonuc = DortIslem(islemliste, sayi, (hedef - fark));
                    if (fazlasonuc.kontrol)
                    {
                        label8.Text = ($"Hedef Sayinin {fark} fazlasi bulundu!");
                        Sonuclabel.Text = (sayi.ToString() + fazlasonuc.islem + " = " + hedef + " + " + fark);
                        return true;
                    }
                    if (eksiksonuc.kontrol)
                    {
                        label8.Text = ($"Hedef Sayinin {fark} eksigi bulundu!");
                        Sonuclabel.Text = (sayi.ToString() + eksiksonuc.islem + " = " + hedef + " - " + fark);
                        return true;
                    }
                }
                fark++;
            }
            /*Eğer hedef sayının 9 fazlası veya 9 eksiği dahi bulunamamışsa false değer döndürülür*/
            return false;
        }   // Hedef sayının fazla/eksik bulma metodu
       
        // HESAPLA BUTONU
        private void Hesapla_Click(object sender, EventArgs e)  
        {
            label8.Text = string.Empty;
            Sonuclabel.Text = string.Empty;                     
            int hedef = Convert.ToInt32(hedeftextBox.Text);
            List<int> sayilar = new List<int> { };
            SayilarListeDoldur(sayilar);
            bool kontrol;
            //İlk başta IslemLıste metodu çağırılır
            kontrol = IslemListe(sayilar, hedef);
            /*Eğer hedef sayının fazla/eksiği dahi bulunamamışsa 
            if kondisyonunun içine girilir*/
            if (kontrol == false)
            {
                Sonuclabel.Text = "Hedef Sayi Bulunamadi!";
            }
        }

        // 1 KELİME FONKSİYONLARINI GERÇEKLEŞTİREN METODLAR
        void Hepsiniyazdır(List<string> liste, string strg)
        {
            /*(2**n -1) Kadar altküme var */
            int n = strg.Length;
            int boyut = (int)Math.Pow(2, n);

            /* Verilen kelimenin sayaç kullanarak
               000..1 dan 111..1 kadar bütün altdizileri oluştur*/
            for (int sayac = 1; sayac < boyut; sayac++)
            {
                string altdizi = "";
                for (int j = 0; j < n; j++)
                {
                    /* j ninci bit yazılmışmı kontrol et
                        eğer yazılmışsa dizi[]den j ninci elemanı oluştur */
                    if ((sayac & (1 << j)) != 0)
                    {
                        altdizi += (strg[j]);
                    }

                }
                Permutasyon(liste, altdizi, 0, (altdizi.Length - 1));
            }
        } // Bu metod bir stringten oluşabilecek bütün kelimeleri oluşturur
        void Permutasyon(List<string> liste,string temp,int l,int r)
        {
            if (l == r)
                liste.Add(temp);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    temp = Swap(temp, l, i);
                    Permutasyon(liste,temp, l + 1, r);
                    temp = Swap(temp, l, i);
                }
            }
        } // Bu metod bir stringin bütün permutasyonlarını oluşturur
        static string Swap(string strg,int i,int j)
        {
            char temp;
            char[] charArray = strg.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }   // String içinde harf yer değiştirme metodu
        void BonusHarfIleBul(List<char> list)
        {           
            string okunan;
            System.IO.StreamReader dosya = new System.IO.StreamReader(@"C:\Users\aktan\Desktop\yazilim (oguzhan aktan)\C#\1kelime1islemfinal\SozlukSiralanmis.txt");
            while ((okunan = dosya.ReadLine()) != null)
            {               
                HarflerListeDoldurChar(list);
                char[] okunandizi = okunan.ToCharArray();
                List<char> bonusharf = okunandizi.ToList();
                for (int i = 0; i < okunan.Length; i++)
                {
                    if (list.Contains(okunandizi[i]))
                    {
                        list.Remove(okunandizi[i]);
                        bonusharf.Remove(okunandizi[i]);
                        okunandizi[i] = '*';                      
                    }
                }
                if (bonusharf.Count==1)
                {
                    BulunanKelime.Text = okunan;
                    KelimePuanlama(okunan);
                    BonusHarfLabel.Text = bonusharf[0].ToString();
                    dosya.Close();
                    break;
                }
                list.Clear();
            }
            dosya.Close();

        }   // Bonus harf kullanarak kelime bulma metodu
        
        //KELİME BUL BUTONU
        private void KelimeBul_Click(object sender, EventArgs e)
        {
            LabelTemizle();
            List<string> harfler = new List<string> { };
            List<char> harflerchar = new List<char> { };
            List<string> kelimeler = new List<string> { };
            HarflerListeDoldur(harfler);
            string harflerstring = null;
            for (int i = 0; i < 8; i++)
            {
                harflerstring += harfler[i];
            }
            Hepsiniyazdır(kelimeler,harflerstring);

            HashSet<string> vs1 = new HashSet<string> { };
            vs1.UnionWith(kelimeler);

            if (BHcheckBox.Checked)
            {
                MessageBox.Show("Bonus harf kullanılıyor!");
                BonusHarfIleBul(harflerchar);
            }
            else
            {
                BonusHarfLabel.Text = string.Empty;
                string aranan;
                System.IO.StreamReader dosya = new System.IO.StreamReader(@"C:\Users\aktan\Desktop\yazilim (oguzhan aktan)\C#\1kelime1islemfinal\SozlukSiralanmis.txt");
                while ((aranan = dosya.ReadLine()) != null)
                {
                    if (vs1.Contains(aranan))
                    {
                        BulunanKelime.Text = aranan;
                        KelimePuanlama(aranan);
                        dosya.Close();
                        break;
                    }
                    else
                    {
                        BulunanKelime.Text ="Bulunamadi";
                    }
                }
            }           
        }
        void KelimePuanlama(string bulunan)     // Bu metod bululan kelimenin uzunluğuna göre puan verir
        {
            int kelimepuan = Convert.ToInt32(KelimePuan.Text);
            switch (bulunan.Length)
            {
                case 9:
                    kelimepuan += 15;
                    KazanilanKelimePuan.Text = "15";
                    Uzunluk.Text = "9";
                    KelimePuan.Text = kelimepuan.ToString();
                    break;
                case 8:
                    kelimepuan += 11;
                    KazanilanKelimePuan.Text = "11";
                    Uzunluk.Text = "8";
                    KelimePuan.Text = kelimepuan.ToString();
                    break;
                case 7:
                    kelimepuan += 9;
                    KazanilanKelimePuan.Text = "9";
                    Uzunluk.Text = "7";
                    KelimePuan.Text = kelimepuan.ToString();
                    break;
                case 6:
                    kelimepuan += 7;
                    KazanilanKelimePuan.Text = "7";
                    Uzunluk.Text = "6";
                    KelimePuan.Text = kelimepuan.ToString();
                    break;
                case 5:
                    kelimepuan += 5;
                    KazanilanKelimePuan.Text = "5";
                    Uzunluk.Text = "5";
                    KelimePuan.Text = kelimepuan.ToString();
                    break;
                case 4:
                    kelimepuan += 4;
                    KazanilanKelimePuan.Text = "4";
                    Uzunluk.Text = "4";
                    KelimePuan.Text = kelimepuan.ToString();
                    break;
                case 3:
                    kelimepuan += 3;
                    KazanilanKelimePuan.Text = "3";
                    Uzunluk.Text = "3";
                    KelimePuan.Text = kelimepuan.ToString();
                    break;
                default:
                    KazanilanKelimePuan.Text = "-";
                    Uzunluk.Text = "-";
                    break;
            }
        }

    }
}
