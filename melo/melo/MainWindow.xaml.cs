using melo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace melo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Context c = new Context();
            Login log = new Login();

            string usr = username.Text;
            string ps = password.Password.ToString();

            bool found = c.logins.Any(user => user.username == usr && user.password == ps);

            if(found)
            {
                MainPage fm = new MainPage();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }












            //    SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-EHVPQGR;Initial Catalog=wpf_proje;Integrated Security=True;Pooling=False");
            //    string username = txtusername.Text;
            //    string password = txt_password.Password.ToString();

            //    try
            //    {
            //        string query = "SELECT * FROM login WHERE username= '"+txtusername.Text+"'AND password='"+txt_password.Password.ToString()+"'";
            //        SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            //        DataTable dt = new DataTable();
            //        sda.Fill(dt);

            //        if(dt.Rows.Count>0)
            //        {
            //            username = txtusername.Text;
            //            password = txt_password.Password.ToString();
            //            form1 fm = new form1();
            //            fm.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("kullanıcı adı veya şifreniz yanlış");
            //            txtusername.Clear();
            //            txt_password.Clear();
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("error");
            //    }
            //    finally
            //    {
            //        sql.Close();
            //    }

        }
    }
}
