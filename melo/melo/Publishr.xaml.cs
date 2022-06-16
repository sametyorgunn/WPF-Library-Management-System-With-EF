using melo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace melo
{
    /// <summary>
    /// Interaction logic for Publishr.xaml
    /// </summary>
    public partial class Publishr : Window
    {
        Context c = new Context();  //Context classımızdan c nesnesi oluşturduk.
        Publisher p = new Publisher();//publisher clasımızdan p nesnesi oluşturduk
        public Publishr()
        {
            InitializeComponent();
        }
        public void loaddatagrid() //load datagrid adlı bir fonksiyon oluşturduk.
        {
            var value = c.publishers.ToList(); //value değişkeni olusturup,context classımızdan oluşturdugumuz c nesnesini kullanarak publishers 
            dtgrid.ItemsSource = value;//degerlerimize eriştik ve tolist metoduyla listelenmesini sağladık ve bu değerleri value değişkenimize atadık.
            //datagrid te degerlerimizin gözükmesini sağlama için ıtemsourcelarına value degerlerimizi atadık.
        }

        private void btn_save_publisher_Click(object sender, RoutedEventArgs e)
        {//btn save publisher butonuna tıklandıgında
            p.publishername = txt_publisher_name.Text;   //publisher classımızdan olusturudugumuz p nesnesi ile publisher degerlerimize ulaştık  
            p.publisherphone = txt_publisher_phone.Text;//punlishername,publisherphone ve publishermail gibi ve bunlara textboxlara girilen degerlerin
            p.publishermail = txt_publisher_mail.Text;//text halini atadık.

            c.publishers.Add(p);  //c nesnesi ile publishers tablomuza erişip  add metodu ile ekleme işlemi yaptık  
            c.SaveChanges(); //veritabanımızda ki değişiklileri savechange metodu ile kaydettik.
            txt_publisher_name.Clear();  //clear metodu ile textboxlarımızda ki verileri işlemden sonra temizledik.
            txt_publisher_mail.Clear();
            txt_publisher_phone.Clear();
            loaddatagrid(); //loaddatagrid fonksinoynumuzu cagırarak son halini tabloda gösterdik .

        }

        private void btn_update_publisher_Click(object sender, RoutedEventArgs e)//update butonuna tıklandıgında
        {
            int idtxt = Convert.ToInt16(txt_id_gir.Text); //int veri tipinde idtxt değişkeni olusturup id gir textboxına girilen degeri integera convert edip atadık
            var value = c.publishers.Find(idtxt); //var veri tipinde value degiskeni olusturup, c nesnesi ile publisher tablomuza erişip find metodu ile idtxt degerini aradık
            //ve value ya atamış olduk.
            txt_publisher_name.Text = value.publishername; //textboxlarımıza o id ye ait bilgilerin getirilmesibi sağladık.
            txt_publisher_mail.Text = value.publishermail;
            txt_publisher_phone.Text = value.publisherphone;
           

            c.publishers.Update(value); //c nesnesi ile publishers tablomuza erişip update metodu ile güncelledik.
            c.SaveChanges();//savechange metodu ile işlemleri kaydettik.
            txt_id_gir.Clear();//id gir textboımızı temizledik.
            loaddatagrid();//tablomuzun son halini gösterdik
        }

        private void btn_delete_publisher_Click(object sender, RoutedEventArgs e)//delete butonuna tıklandıgında
        {
            int idtxt = Convert.ToInt16(txt_id_gir.Text);//int veri tipinde idtxt değişkeni olusturup id gir textboxına girilen degeri integera convert edip atadık
            var value = c.publishers.Find(idtxt);//var veri tipinde value degiskeni olusturup, c nesnesi ile publisher tablomuza erişip find metodu ile idtxt degerini aradık
            c.publishers.Remove(value); //c nesnesi ile publishers tablomuza erişip remove metodu ile sildik.
            c.SaveChanges();//savechange metodu ile işlemleri kaydettik.
            txt_id_gir.Clear();//id gir textboımızı temizledik.
            loaddatagrid();//tablomuzun son halini gösterdik
        }
    }
}
