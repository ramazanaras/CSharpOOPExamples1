using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win14_pizzaotomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat {Adi="Küçük",Carpan=1 };
            Ebat orta = new Ebat { Adi = "Orta", Carpan = 1.25 };
            Ebat buyuk = new Ebat { Adi = "Büyük", Carpan = 1.75 };
            Ebat maxi = new Ebat {Adi="Maxi",Carpan=2 };

            //objeleri(nesneleri) combobaxa atadık.
            cmbEbat.Items.Add(kucuk);
            cmbEbat.Items.Add(orta);
            cmbEbat.Items.Add(buyuk);
            cmbEbat.Items.Add(maxi);

            Pizza klasik = new Pizza {Adi="Klasik",Fiyat=14 };
            Pizza karisik = new Pizza {Adi="Karışık",Fiyat=17 };
            Pizza turkish = new Pizza {Adi="Turkish",Fiyat=20 };
            Pizza tuna = new Pizza {Adi="Tuna",Fiyat=21 };
            Pizza akdeniz = new Pizza { Adi = "Akdeniz", Fiyat = 19 };
            Pizza karadeniz = new Pizza {Adi="Karadeniz",Fiyat=22 };

            //objeleri(nesneleri) combobaxa atadık.
            listPizzalar.Items.Add(klasik);
            listPizzalar.Items.Add(karisik);
            listPizzalar.Items.Add(turkish);
            listPizzalar.Items.Add(tuna);
            listPizzalar.Items.Add(akdeniz);
            listPizzalar.Items.Add(karadeniz);

            KenarTip ince = new KenarTip {Adi="İnce Kenar",EkFiyat=0 };
            KenarTip kalin = new KenarTip {Adi="Kalın Kenar",EkFiyat=2 };

            //Tag özelliği içerisinde obje barındırır bizde obje atadık.Tag özelliği kontrolün cebi gibi birşeydir.
            rdbInceKenar.Tag = ince;
            rdbKalinKenar.Tag = kalin;


        }
        Siparis s;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)listPizzalar.SelectedItem;//unboxing yaptık(objeyi çıkarttık)
            p.Ebati =(Ebat)cmbEbat.SelectedItem;
            p.KenarTipi = rdbInceKenar.Checked ? (KenarTip)rdbInceKenar.Tag : (KenarTip)rdbKalinKenar.Tag;

            //foreach (Control ctrl in groupBox1.Controls)//groupboxın içinde gez
            //{
            //    CheckBox c = (CheckBox)ctrl;//cast ettik.
            //    if (c.Checked)
            //    {
                    
            //    }
            //}
                    //---ikinci yöntem aşağıdaki gibi

            p.Malzemeler = new List<string>();  //new leme  yaptık. yoksa aşağıda hata verirdi
            foreach (CheckBox ctrl in groupBox1.Controls)
            {
                if (ctrl.Checked)
                {
                    p.Malzemeler.Add(ctrl.Text);  //malzemeleri ekledik. //listeyi new 'lememiz lazım yoksa hata verir.
                }
            }

            decimal tutar = nudAdet.Value * p.Tutar;  //p.Tutar Pizza sınıfında hesaplanıp burda işleme konuyor.
            txtTutar.Text = tutar.ToString();  //pizzanın toplam fiyatını yazdık.
            s = new Siparis();  //yeni bir sipariş oluşturuyoruz.
            s.Pizza = p;  //s.Pizza bizden Pizza tipinde eleman istiyordu bizde p'yi atadık.
            s.Adet = (int)nudAdet.Value; //cast ettik.

        }
       
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (s!=null)  //sipariş elemanı null değilse.(new 'lenmişse) yani kullanıcı hesapla butonuna basmadan direk sepete ekle butonuna basarsa listboxa eklemez.
            {
                listSepet.Items.Add(s);
            }
            else
            {
                MessageBox.Show("Lütfen sepete eklemeden önce hesapla butonuna basın.");
            }
            
           
        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            int adet = 0;

            foreach (Siparis spr in listSepet.Items)//listsepet'in elemanlarında gez her seferinde Siparis nesnesi gelecek.
            {
                toplamTutar += spr.Adet * spr.Pizza.Tutar;
                adet++;
            }
            lblToplamTutar.Text = toplamTutar.ToString();
            MessageBox.Show(string.Format("Toplam Sipariş Adetiniz {0} \n Toplam Sipariş Tutarınız: {1}",adet,toplamTutar));
        }
    }
}
