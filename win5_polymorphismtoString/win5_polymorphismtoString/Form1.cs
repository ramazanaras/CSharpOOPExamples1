using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win5_polymorphismtoString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = textBox1.Text;
            ogr.soyadi = textBox2.Text;
            ogr.Tckn = textBox3.Text;
            ogr.DogumTarihi = dateTimePicker1.Value;

           // listBox1.Items.Add(ogr); //ogr de yazabiliriz yada ogr.ToString() de yazabiliriz.

            listBox1.Items.Add(ogr.ToString());//ogrenci sınıfındaki miras alınan object sınıfındaki to string metodunu çağırıyor .bu metodda bize nesnenin adını döndürüyor.Ama biz object sınıfıdaki tostring metodu virtual olarak tanımlandığı için biz bu metodu ogrenci sınıfında override edip içeriğini değiştirebiliriz. 
            //tostring metodu polymorphisme güzel bir örnektir.
            //Not:listbox a obje(nesne) tipinde değer alır bizde nesneyi yazdık.
            //Not:miras konusu ile polymorphism konusu birbiriyle çok alakalı konulardır.
            MessageBox.Show(ogr.ToString());

            }
    }
}
