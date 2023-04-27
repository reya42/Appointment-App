using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_App
{
    public partial class mainScreen : Form
    {
        private int loginId;

        public mainScreen()
        {
            InitializeComponent();
        }
        /*login sayfası işlemleri*/
        private void login_forgot_Click(object sender, EventArgs e)
        {
            page_controller.SelectedTab = page_forgot;
        }
        private void login_button_signup_Click(object sender, EventArgs e)
        {
            page_controller.SelectedTab = page_signup;
        }
        private void login_button_login_Click(object sender, EventArgs e)
        {
            //login yapmak için ilk önce girilen kullanıcı adı gerçekten var mı kontrolünü yapar
            if (checkUsername(login_username.Text) != -1)
            {
                login_error_username.ForeColor = Color.FromArgb(30, 30, 30);
                int id = checkUsername(login_username.Text);
                if (checkPassword(login_password.Text, id))
                {   //eğer doğruysa girilen şifre ile uyuşuyor mu
                    // uyuşuyorsa sonraki alana geçer ve loginIdyi satır sayısına eşler
                    login_error_password.ForeColor = Color.FromArgb(30, 30, 30);
                    loginId = id;
                    page_controller.SelectedTab = page_mainmenu;
                }
                else login_error_password.ForeColor = Color.Red;
            }
            else
            {
                login_error_username.ForeColor = Color.Red;
                login_error_username.Text = "Kullanıcı adınız hatalı!";
            }
        }
        /*signup sayfası işlemleri*/
        private void signup_button_return_Click(object sender, EventArgs e)
        {
            cleanTextBoxes();
            page_controller.SelectedTab = page_login;
        }
        private void signup_button_signup_Click(object sender, EventArgs e)
        {
            bool doesUsable = true;
            //girilen değerler null mu veya girilen username alınmış mı?
            if (checkUsername(signup_username.Text) == -1)
            {
                doesUsable = false;
                signup_error_username.Text = "Girilen kullanıcı adı daha önce alınmış!";
                signup_error_username.ForeColor = Color.Red;
            }
            else if (signup_username.Text.Equals(null) || signup_username.Text.Equals(""))
            {
                doesUsable = false;
                signup_error_username.Text = "Kullanıcı adını boş bırakamazsınız!";
                signup_error_username.ForeColor = Color.Red;
            }
            else
            {
                signup_error_username.ForeColor = Color.FromArgb(30, 30, 30);
            }
            if (signup_name.Text.Equals(null) || signup_name.Text.Equals(""))
            {
                doesUsable = false;
                signup_error_name.ForeColor = Color.Red;
            }
            else
            {
                signup_error_name.ForeColor = Color.FromArgb(30, 30, 30);
            }
            if (signup_surname.Equals(null) || signup_surname.Text.Equals(""))
            {
                doesUsable = false;
                signup_error_surname.ForeColor = Color.Red;
            }
            else
            {
                signup_error_surname.ForeColor = Color.FromArgb(30, 30, 30);
            }
            if (signup_password.Equals(null) || signup_password.Text.Equals(""))
            {
                doesUsable = false;
                signup_error_password.ForeColor = Color.Red;
            }
            else
            {
                signup_error_password.ForeColor = Color.FromArgb(30, 30, 30);
            }
            //Eğer herhangi bir değer boş değilse ve kullanıcı adı alınmamışsa database'e gönderilir
            if (doesUsable)
            {
                createUser(signup_label_username.Text,
                            signup_label_password.Text,
                            signup_label_name.Text,
                            signup_label_surname.Text);
                cleanTextBoxes();
                login_error_username.ForeColor = Color.White;
                login_error_username.Text = "Kullanıcı başarılı bir şekilde oluşturuldu. Lütfen giriş yapın.";
                page_controller.SelectedTab = page_login;
            }
        }
        //forgot password işlemleri
        private void forgot_button_Click(object sender, EventArgs e)
        {
            forgot_reveal_pass.ForeColor = Color.Red;
            if (checkUsername(login_username.Text) != -1)
            {
                int id = checkUsername(login_username.Text);
                if (checkName(forgot_name.Text, id) && checkSurname(forgot_surname.Text, id))
                {   //eğer doğruysa girilen ad ve soyad doğru mu
                    //Doğruysa şifreyi forgot_reveal_pass'a yazdırırız ve rengini görünecek bir renge çeviririz
                    forgot_reveal_pass.Text = "Şifreniz: " + getPassword(id);
                    forgot_reveal_pass.ForeColor = Color.Blue;
                }
                else forgot_reveal_pass.Text = "Lütfen her şeyi doğru giriniz";
            }
            else forgot_reveal_pass.Text = "Lütfen her şeyi doğru giriniz";
        }
        private void forgot_return_Click(object sender, EventArgs e)
        {
            cleanTextBoxes();
            page_controller.SelectedTab = page_login;
        }
        /*Sayfalar tarafından kullanılan fonksiyonlar*/
        private void createUser(string username,string password, string name, string surname)
        {
            //database'e kullanıcı gönderen fonksiyon
        }
        private int checkUsername(string username)
        {
            bool doFound = false;
            int foundId = 1;
            //database'de var mı kontrolünü sağlamak için bir döngü oluşturulmalı
            return doFound ? foundId : -1;  //eğer bulunursa bulunan satırı geri çevirir bulunmazsa ise 0 çevirir
        }
        private bool checkPassword(string password, int id)
        {
            //database'de girilen satırdaki password ile aynı mı?
            return true;  //eğer bulunursa true bulunmazsa false çevirir
        }
        private bool checkName(string name, int id)
        {
            //girilen iddeki name ile girilen name uyuşuyor mu?
            return true;
        }
        private bool checkSurname(string surname, int id)
        {   //girilen iddeki surname ile girilen surname uyuşuyor mu?
            return true;
        }
        private string getPassword(int id)
        {       //girilen iddeki paswordu return eder
            return "";
        }
        private string getName(int id)
        {       //girilen iddeki adı return eder
            return "";
        }
        private string getSurname(int id)
        {       //girilen iddeki soyadı return eder
            return "";
        }
        private void cleanTextBoxes()
        {       //Kullanıcı güvenliği için girilen değerleri işlem bittikten sonra silen fonksiyon
            forgot_reveal_pass.ForeColor = Color.FromArgb(30, 30, 30);
            forgot_reveal_pass.Text = "";
            forgot_surname.Text = "";
            forgot_name.Text = "";
            forgot_username.Text = "";
            login_username.Text = "";
            login_password.Text = "";
            signup_username.Text = "";
            signup_password.Text = "";
            signup_name.Text = "";
            signup_surname.Text = "";
        }
    }
}