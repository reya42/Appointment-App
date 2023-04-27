namespace Appointment_App
{
    partial class mainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            page_controller = new TabControl();
            page_login = new TabPage();
            login_forgot = new Label();
            login_error_password = new Label();
            login_error_username = new Label();
            login_button_signup = new Button();
            login_button_login = new Button();
            login_label_password = new Label();
            login_title = new Label();
            login_label_username = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            page_signup = new TabPage();
            signup_error_password = new Label();
            signup_label_password = new Label();
            signup_password = new TextBox();
            signup_error_username = new Label();
            signup_label_username = new Label();
            signup_username = new TextBox();
            signup_error_surname = new Label();
            signup_error_name = new Label();
            signup_button_return = new Button();
            signup_button_signup = new Button();
            signup_label_surname = new Label();
            signup_title = new Label();
            signup_label_name = new Label();
            signup_name = new TextBox();
            signup_surname = new TextBox();
            page_forgot = new TabPage();
            forgot_reveal_pass = new Label();
            forgot_label_username = new Label();
            forgot_username = new TextBox();
            forgot_return = new Button();
            forgot_button = new Button();
            forgot_label_surname = new Label();
            forgot_title = new Label();
            forgot_label_name = new Label();
            forgot_name = new TextBox();
            forgot_surname = new TextBox();
            page_mainmenu = new TabPage();
            page_controller.SuspendLayout();
            page_login.SuspendLayout();
            page_signup.SuspendLayout();
            page_forgot.SuspendLayout();
            SuspendLayout();
            // 
            // page_controller
            // 
            page_controller.Controls.Add(page_login);
            page_controller.Controls.Add(page_signup);
            page_controller.Controls.Add(page_forgot);
            page_controller.Controls.Add(page_mainmenu);
            page_controller.Location = new Point(-14, -29);
            page_controller.Name = "page_controller";
            page_controller.SelectedIndex = 0;
            page_controller.Size = new Size(1020, 618);
            page_controller.TabIndex = 0;
            // 
            // page_login
            // 
            page_login.BackColor = Color.FromArgb(30, 30, 30);
            page_login.Controls.Add(login_forgot);
            page_login.Controls.Add(login_error_password);
            page_login.Controls.Add(login_error_username);
            page_login.Controls.Add(login_button_signup);
            page_login.Controls.Add(login_button_login);
            page_login.Controls.Add(login_label_password);
            page_login.Controls.Add(login_title);
            page_login.Controls.Add(login_label_username);
            page_login.Controls.Add(login_username);
            page_login.Controls.Add(login_password);
            page_login.Location = new Point(4, 24);
            page_login.Name = "page_login";
            page_login.Size = new Size(1012, 590);
            page_login.TabIndex = 0;
            // 
            // login_forgot
            // 
            login_forgot.AutoSize = true;
            login_forgot.BackColor = Color.Transparent;
            login_forgot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_forgot.ForeColor = Color.White;
            login_forgot.Location = new Point(405, 326);
            login_forgot.Name = "login_forgot";
            login_forgot.Size = new Size(124, 21);
            login_forgot.TabIndex = 46;
            login_forgot.Text = "Şifremi unuttum";
            login_forgot.Click += login_forgot_Click;
            // 
            // login_error_password
            // 
            login_error_password.AutoSize = true;
            login_error_password.BackColor = Color.Transparent;
            login_error_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_error_password.ForeColor = Color.FromArgb(30, 30, 30);
            login_error_password.Location = new Point(405, 231);
            login_error_password.Name = "login_error_password";
            login_error_password.Size = new Size(109, 21);
            login_error_password.TabIndex = 45;
            login_error_password.Text = "Şifreniz hatalı!";
            // 
            // login_error_username
            // 
            login_error_username.AutoSize = true;
            login_error_username.BackColor = Color.Transparent;
            login_error_username.FlatStyle = FlatStyle.Flat;
            login_error_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_error_username.ForeColor = Color.FromArgb(30, 30, 30);
            login_error_username.Location = new Point(405, 170);
            login_error_username.Name = "login_error_username";
            login_error_username.Size = new Size(160, 21);
            login_error_username.TabIndex = 44;
            login_error_username.Text = "Kullanıcı adınız hatalı!";
            // 
            // login_button_signup
            // 
            login_button_signup.FlatAppearance.BorderColor = Color.White;
            login_button_signup.FlatAppearance.BorderSize = 2;
            login_button_signup.FlatAppearance.MouseDownBackColor = Color.White;
            login_button_signup.FlatAppearance.MouseOverBackColor = Color.White;
            login_button_signup.FlatStyle = FlatStyle.Flat;
            login_button_signup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_button_signup.ForeColor = Color.White;
            login_button_signup.Location = new Point(552, 316);
            login_button_signup.Name = "login_button_signup";
            login_button_signup.Size = new Size(103, 41);
            login_button_signup.TabIndex = 43;
            login_button_signup.Text = "Kayıt Ol";
            login_button_signup.UseVisualStyleBackColor = true;
            login_button_signup.Click += login_button_signup_Click;
            // 
            // login_button_login
            // 
            login_button_login.FlatAppearance.BorderColor = Color.White;
            login_button_login.FlatAppearance.BorderSize = 2;
            login_button_login.FlatAppearance.MouseDownBackColor = Color.White;
            login_button_login.FlatAppearance.MouseOverBackColor = Color.White;
            login_button_login.FlatStyle = FlatStyle.Flat;
            login_button_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_button_login.ForeColor = Color.White;
            login_button_login.Location = new Point(675, 316);
            login_button_login.Name = "login_button_login";
            login_button_login.Size = new Size(103, 41);
            login_button_login.TabIndex = 42;
            login_button_login.Text = "Giriş Yap";
            login_button_login.UseVisualStyleBackColor = true;
            login_button_login.Click += login_button_login_Click;
            // 
            // login_label_password
            // 
            login_label_password.AutoSize = true;
            login_label_password.BackColor = Color.Transparent;
            login_label_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            login_label_password.ForeColor = Color.White;
            login_label_password.Location = new Point(287, 261);
            login_label_password.Name = "login_label_password";
            login_label_password.Size = new Size(53, 25);
            login_label_password.TabIndex = 40;
            login_label_password.Text = "Şifre";
            // 
            // login_title
            // 
            login_title.Anchor = AnchorStyles.None;
            login_title.AutoSize = true;
            login_title.BackColor = Color.Transparent;
            login_title.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            login_title.ForeColor = Color.White;
            login_title.Location = new Point(483, 99);
            login_title.Name = "login_title";
            login_title.Size = new Size(185, 54);
            login_title.TabIndex = 41;
            login_title.Text = "Giriş Yap";
            login_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_label_username
            // 
            login_label_username.AutoSize = true;
            login_label_username.BackColor = Color.Transparent;
            login_label_username.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            login_label_username.ForeColor = Color.White;
            login_label_username.Location = new Point(249, 200);
            login_label_username.Name = "login_label_username";
            login_label_username.Size = new Size(122, 25);
            login_label_username.TabIndex = 39;
            login_label_username.Text = "Kullanıcı Adı";
            // 
            // login_username
            // 
            login_username.Anchor = AnchorStyles.Bottom;
            login_username.BackColor = Color.FromArgb(30, 30, 30);
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            login_username.ForeColor = Color.White;
            login_username.Location = new Point(405, 194);
            login_username.MaxLength = 64;
            login_username.Name = "login_username";
            login_username.Size = new Size(373, 36);
            login_username.TabIndex = 37;
            login_username.WordWrap = false;
            // 
            // login_password
            // 
            login_password.Anchor = AnchorStyles.Bottom;
            login_password.BackColor = Color.FromArgb(30, 30, 30);
            login_password.BorderStyle = BorderStyle.FixedSingle;
            login_password.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            login_password.ForeColor = Color.White;
            login_password.Location = new Point(405, 255);
            login_password.MaxLength = 64;
            login_password.Name = "login_password";
            login_password.Size = new Size(373, 36);
            login_password.TabIndex = 38;
            login_password.WordWrap = false;
            // 
            // page_signup
            // 
            page_signup.BackColor = Color.FromArgb(30, 30, 30);
            page_signup.Controls.Add(signup_error_password);
            page_signup.Controls.Add(signup_label_password);
            page_signup.Controls.Add(signup_password);
            page_signup.Controls.Add(signup_error_username);
            page_signup.Controls.Add(signup_label_username);
            page_signup.Controls.Add(signup_username);
            page_signup.Controls.Add(signup_error_surname);
            page_signup.Controls.Add(signup_error_name);
            page_signup.Controls.Add(signup_button_return);
            page_signup.Controls.Add(signup_button_signup);
            page_signup.Controls.Add(signup_label_surname);
            page_signup.Controls.Add(signup_title);
            page_signup.Controls.Add(signup_label_name);
            page_signup.Controls.Add(signup_name);
            page_signup.Controls.Add(signup_surname);
            page_signup.Location = new Point(4, 24);
            page_signup.Name = "page_signup";
            page_signup.Size = new Size(1012, 590);
            page_signup.TabIndex = 1;
            // 
            // signup_error_password
            // 
            signup_error_password.AutoSize = true;
            signup_error_password.BackColor = Color.Transparent;
            signup_error_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signup_error_password.ForeColor = Color.FromArgb(30, 30, 30);
            signup_error_password.Location = new Point(405, 359);
            signup_error_password.Name = "signup_error_password";
            signup_error_password.Size = new Size(195, 21);
            signup_error_password.TabIndex = 60;
            signup_error_password.Text = "Şifreyi boş bırakamazsınız!";
            // 
            // signup_label_password
            // 
            signup_label_password.AutoSize = true;
            signup_label_password.BackColor = Color.Transparent;
            signup_label_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signup_label_password.ForeColor = Color.White;
            signup_label_password.Location = new Point(290, 389);
            signup_label_password.Name = "signup_label_password";
            signup_label_password.Size = new Size(53, 25);
            signup_label_password.TabIndex = 59;
            signup_label_password.Text = "Şifre";
            // 
            // signup_password
            // 
            signup_password.Anchor = AnchorStyles.Bottom;
            signup_password.BackColor = Color.FromArgb(30, 30, 30);
            signup_password.BorderStyle = BorderStyle.FixedSingle;
            signup_password.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            signup_password.ForeColor = Color.White;
            signup_password.Location = new Point(405, 383);
            signup_password.MaxLength = 64;
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(373, 36);
            signup_password.TabIndex = 58;
            signup_password.WordWrap = false;
            // 
            // signup_error_username
            // 
            signup_error_username.AutoSize = true;
            signup_error_username.BackColor = Color.Transparent;
            signup_error_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signup_error_username.ForeColor = Color.FromArgb(30, 30, 30);
            signup_error_username.Location = new Point(405, 294);
            signup_error_username.Name = "signup_error_username";
            signup_error_username.Size = new Size(258, 21);
            signup_error_username.TabIndex = 57;
            signup_error_username.Text = "Kullanıcı adınızı boş bırakamazsınız!";
            // 
            // signup_label_username
            // 
            signup_label_username.AutoSize = true;
            signup_label_username.BackColor = Color.Transparent;
            signup_label_username.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signup_label_username.ForeColor = Color.White;
            signup_label_username.Location = new Point(257, 324);
            signup_label_username.Name = "signup_label_username";
            signup_label_username.Size = new Size(122, 25);
            signup_label_username.TabIndex = 56;
            signup_label_username.Text = "Kullanıcı Adı";
            // 
            // signup_username
            // 
            signup_username.Anchor = AnchorStyles.Bottom;
            signup_username.BackColor = Color.FromArgb(30, 30, 30);
            signup_username.BorderStyle = BorderStyle.FixedSingle;
            signup_username.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            signup_username.ForeColor = Color.White;
            signup_username.Location = new Point(405, 318);
            signup_username.MaxLength = 64;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(373, 36);
            signup_username.TabIndex = 55;
            signup_username.WordWrap = false;
            // 
            // signup_error_surname
            // 
            signup_error_surname.AutoSize = true;
            signup_error_surname.BackColor = Color.Transparent;
            signup_error_surname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signup_error_surname.ForeColor = Color.FromArgb(30, 30, 30);
            signup_error_surname.Location = new Point(405, 231);
            signup_error_surname.Name = "signup_error_surname";
            signup_error_surname.Size = new Size(222, 21);
            signup_error_surname.TabIndex = 54;
            signup_error_surname.Text = "Soyadınızı boş bırakamazsınız!";
            // 
            // signup_error_name
            // 
            signup_error_name.AutoSize = true;
            signup_error_name.BackColor = Color.Transparent;
            signup_error_name.FlatStyle = FlatStyle.Flat;
            signup_error_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signup_error_name.ForeColor = Color.FromArgb(30, 30, 30);
            signup_error_name.Location = new Point(405, 170);
            signup_error_name.Name = "signup_error_name";
            signup_error_name.Size = new Size(198, 21);
            signup_error_name.TabIndex = 53;
            signup_error_name.Text = "Adınızı boş bırakamazsınız!";
            // 
            // signup_button_return
            // 
            signup_button_return.FlatAppearance.BorderColor = Color.White;
            signup_button_return.FlatAppearance.BorderSize = 2;
            signup_button_return.FlatAppearance.MouseDownBackColor = Color.White;
            signup_button_return.FlatAppearance.MouseOverBackColor = Color.White;
            signup_button_return.FlatStyle = FlatStyle.Flat;
            signup_button_return.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signup_button_return.ForeColor = Color.White;
            signup_button_return.Location = new Point(552, 434);
            signup_button_return.Name = "signup_button_return";
            signup_button_return.Size = new Size(103, 41);
            signup_button_return.TabIndex = 52;
            signup_button_return.Text = "Geri Dön";
            signup_button_return.UseVisualStyleBackColor = true;
            signup_button_return.Click += signup_button_return_Click;
            // 
            // signup_button_signup
            // 
            signup_button_signup.FlatAppearance.BorderColor = Color.White;
            signup_button_signup.FlatAppearance.BorderSize = 2;
            signup_button_signup.FlatAppearance.MouseDownBackColor = Color.White;
            signup_button_signup.FlatAppearance.MouseOverBackColor = Color.White;
            signup_button_signup.FlatStyle = FlatStyle.Flat;
            signup_button_signup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signup_button_signup.ForeColor = Color.White;
            signup_button_signup.Location = new Point(675, 434);
            signup_button_signup.Name = "signup_button_signup";
            signup_button_signup.Size = new Size(103, 41);
            signup_button_signup.TabIndex = 51;
            signup_button_signup.Text = "Kayıt Ol";
            signup_button_signup.UseVisualStyleBackColor = true;
            signup_button_signup.Click += signup_button_signup_Click;
            // 
            // signup_label_surname
            // 
            signup_label_surname.AutoSize = true;
            signup_label_surname.BackColor = Color.Transparent;
            signup_label_surname.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signup_label_surname.ForeColor = Color.White;
            signup_label_surname.Location = new Point(285, 261);
            signup_label_surname.Name = "signup_label_surname";
            signup_label_surname.Size = new Size(67, 25);
            signup_label_surname.TabIndex = 49;
            signup_label_surname.Text = "Soyad";
            // 
            // signup_title
            // 
            signup_title.Anchor = AnchorStyles.None;
            signup_title.AutoSize = true;
            signup_title.BackColor = Color.Transparent;
            signup_title.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            signup_title.ForeColor = Color.White;
            signup_title.Location = new Point(483, 100);
            signup_title.Name = "signup_title";
            signup_title.Size = new Size(172, 54);
            signup_title.TabIndex = 50;
            signup_title.Text = "Kayıt Ol";
            signup_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signup_label_name
            // 
            signup_label_name.AutoSize = true;
            signup_label_name.BackColor = Color.Transparent;
            signup_label_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signup_label_name.ForeColor = Color.White;
            signup_label_name.Location = new Point(301, 199);
            signup_label_name.Name = "signup_label_name";
            signup_label_name.Size = new Size(37, 25);
            signup_label_name.TabIndex = 48;
            signup_label_name.Text = "Ad";
            // 
            // signup_name
            // 
            signup_name.Anchor = AnchorStyles.Bottom;
            signup_name.BackColor = Color.FromArgb(30, 30, 30);
            signup_name.BorderStyle = BorderStyle.FixedSingle;
            signup_name.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            signup_name.ForeColor = Color.White;
            signup_name.Location = new Point(405, 194);
            signup_name.MaxLength = 64;
            signup_name.Name = "signup_name";
            signup_name.Size = new Size(373, 36);
            signup_name.TabIndex = 46;
            signup_name.WordWrap = false;
            // 
            // signup_surname
            // 
            signup_surname.Anchor = AnchorStyles.Bottom;
            signup_surname.BackColor = Color.FromArgb(30, 30, 30);
            signup_surname.BorderStyle = BorderStyle.FixedSingle;
            signup_surname.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            signup_surname.ForeColor = Color.White;
            signup_surname.Location = new Point(405, 255);
            signup_surname.MaxLength = 64;
            signup_surname.Name = "signup_surname";
            signup_surname.Size = new Size(373, 36);
            signup_surname.TabIndex = 47;
            signup_surname.WordWrap = false;
            // 
            // page_forgot
            // 
            page_forgot.BackColor = Color.FromArgb(30, 30, 30);
            page_forgot.Controls.Add(forgot_reveal_pass);
            page_forgot.Controls.Add(forgot_label_username);
            page_forgot.Controls.Add(forgot_username);
            page_forgot.Controls.Add(forgot_return);
            page_forgot.Controls.Add(forgot_button);
            page_forgot.Controls.Add(forgot_label_surname);
            page_forgot.Controls.Add(forgot_title);
            page_forgot.Controls.Add(forgot_label_name);
            page_forgot.Controls.Add(forgot_name);
            page_forgot.Controls.Add(forgot_surname);
            page_forgot.Location = new Point(4, 24);
            page_forgot.Name = "page_forgot";
            page_forgot.Size = new Size(1012, 590);
            page_forgot.TabIndex = 2;
            // 
            // forgot_reveal_pass
            // 
            forgot_reveal_pass.AutoSize = true;
            forgot_reveal_pass.BackColor = Color.Transparent;
            forgot_reveal_pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            forgot_reveal_pass.ForeColor = Color.FromArgb(30, 30, 30);
            forgot_reveal_pass.Location = new Point(246, 392);
            forgot_reveal_pass.Name = "forgot_reveal_pass";
            forgot_reveal_pass.Size = new Size(0, 25);
            forgot_reveal_pass.TabIndex = 69;
            // 
            // forgot_label_username
            // 
            forgot_label_username.AutoSize = true;
            forgot_label_username.BackColor = Color.Transparent;
            forgot_label_username.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            forgot_label_username.ForeColor = Color.White;
            forgot_label_username.Location = new Point(246, 332);
            forgot_label_username.Name = "forgot_label_username";
            forgot_label_username.Size = new Size(122, 25);
            forgot_label_username.TabIndex = 68;
            forgot_label_username.Text = "Kullanıcı Adı";
            // 
            // forgot_username
            // 
            forgot_username.Anchor = AnchorStyles.Bottom;
            forgot_username.BackColor = Color.FromArgb(30, 30, 30);
            forgot_username.BorderStyle = BorderStyle.FixedSingle;
            forgot_username.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            forgot_username.ForeColor = Color.White;
            forgot_username.Location = new Point(394, 326);
            forgot_username.MaxLength = 64;
            forgot_username.Name = "forgot_username";
            forgot_username.Size = new Size(373, 36);
            forgot_username.TabIndex = 67;
            forgot_username.WordWrap = false;
            // 
            // forgot_return
            // 
            forgot_return.FlatAppearance.BorderColor = Color.White;
            forgot_return.FlatAppearance.BorderSize = 2;
            forgot_return.FlatAppearance.MouseDownBackColor = Color.White;
            forgot_return.FlatAppearance.MouseOverBackColor = Color.White;
            forgot_return.FlatStyle = FlatStyle.Flat;
            forgot_return.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            forgot_return.ForeColor = Color.White;
            forgot_return.Location = new Point(537, 385);
            forgot_return.Name = "forgot_return";
            forgot_return.Size = new Size(103, 41);
            forgot_return.TabIndex = 66;
            forgot_return.Text = "Geri Dön";
            forgot_return.UseVisualStyleBackColor = true;
            forgot_return.Click += forgot_return_Click;
            // 
            // forgot_button
            // 
            forgot_button.FlatAppearance.BorderColor = Color.White;
            forgot_button.FlatAppearance.BorderSize = 2;
            forgot_button.FlatAppearance.MouseDownBackColor = Color.White;
            forgot_button.FlatAppearance.MouseOverBackColor = Color.White;
            forgot_button.FlatStyle = FlatStyle.Flat;
            forgot_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            forgot_button.ForeColor = Color.White;
            forgot_button.Location = new Point(660, 385);
            forgot_button.Name = "forgot_button";
            forgot_button.Size = new Size(107, 41);
            forgot_button.TabIndex = 65;
            forgot_button.Text = "Şifremi Bul";
            forgot_button.UseVisualStyleBackColor = true;
            forgot_button.Click += forgot_button_Click;
            // 
            // forgot_label_surname
            // 
            forgot_label_surname.AutoSize = true;
            forgot_label_surname.BackColor = Color.Transparent;
            forgot_label_surname.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            forgot_label_surname.ForeColor = Color.White;
            forgot_label_surname.Location = new Point(274, 269);
            forgot_label_surname.Name = "forgot_label_surname";
            forgot_label_surname.Size = new Size(67, 25);
            forgot_label_surname.TabIndex = 63;
            forgot_label_surname.Text = "Soyad";
            // 
            // forgot_title
            // 
            forgot_title.Anchor = AnchorStyles.None;
            forgot_title.AutoSize = true;
            forgot_title.BackColor = Color.Transparent;
            forgot_title.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            forgot_title.ForeColor = Color.White;
            forgot_title.Location = new Point(418, 108);
            forgot_title.Name = "forgot_title";
            forgot_title.Size = new Size(338, 54);
            forgot_title.TabIndex = 64;
            forgot_title.Text = "Şifremi Unuttum";
            forgot_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // forgot_label_name
            // 
            forgot_label_name.AutoSize = true;
            forgot_label_name.BackColor = Color.Transparent;
            forgot_label_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            forgot_label_name.ForeColor = Color.White;
            forgot_label_name.Location = new Point(290, 207);
            forgot_label_name.Name = "forgot_label_name";
            forgot_label_name.Size = new Size(37, 25);
            forgot_label_name.TabIndex = 62;
            forgot_label_name.Text = "Ad";
            // 
            // forgot_name
            // 
            forgot_name.Anchor = AnchorStyles.Bottom;
            forgot_name.BackColor = Color.FromArgb(30, 30, 30);
            forgot_name.BorderStyle = BorderStyle.FixedSingle;
            forgot_name.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            forgot_name.ForeColor = Color.White;
            forgot_name.Location = new Point(394, 202);
            forgot_name.MaxLength = 64;
            forgot_name.Name = "forgot_name";
            forgot_name.Size = new Size(373, 36);
            forgot_name.TabIndex = 60;
            forgot_name.WordWrap = false;
            // 
            // forgot_surname
            // 
            forgot_surname.Anchor = AnchorStyles.Bottom;
            forgot_surname.BackColor = Color.FromArgb(30, 30, 30);
            forgot_surname.BorderStyle = BorderStyle.FixedSingle;
            forgot_surname.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            forgot_surname.ForeColor = Color.White;
            forgot_surname.Location = new Point(394, 263);
            forgot_surname.MaxLength = 64;
            forgot_surname.Name = "forgot_surname";
            forgot_surname.Size = new Size(373, 36);
            forgot_surname.TabIndex = 61;
            forgot_surname.WordWrap = false;
            // 
            // page_mainmenu
            // 
            page_mainmenu.BackColor = Color.FromArgb(30, 30, 30);
            page_mainmenu.Location = new Point(4, 24);
            page_mainmenu.Name = "page_mainmenu";
            page_mainmenu.Size = new Size(1012, 590);
            page_mainmenu.TabIndex = 3;
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 580);
            Controls.Add(page_controller);
            Name = "mainScreen";
            Text = "Randevu Al";
            page_controller.ResumeLayout(false);
            page_login.ResumeLayout(false);
            page_login.PerformLayout();
            page_signup.ResumeLayout(false);
            page_signup.PerformLayout();
            page_forgot.ResumeLayout(false);
            page_forgot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl page_controller;
        private TabPage page_login;
        private TabPage page_signup;
        private Label login_error_password;
        private Label login_error_username;
        private Button login_button_signup;
        private Button login_button_login;
        private Label login_label_password;
        private Label login_title;
        private Label login_label_username;
        private TextBox login_username;
        private TextBox login_password;
        private Label signup_error_password;
        private Label signup_label_password;
        private TextBox signup_password;
        private Label signup_error_username;
        private Label signup_label_username;
        private TextBox signup_username;
        private Label signup_error_surname;
        private Label signup_error_name;
        private Button signup_button_return;
        private Button signup_button_signup;
        private Label signup_label_surname;
        private Label signup_title;
        private Label signup_label_name;
        private TextBox signup_name;
        private TextBox signup_surname;
        private Label login_forgot;
        private TabPage page_forgot;
        private Label forgot_reveal_pass;
        private Label forgot_label_username;
        private TextBox forgot_username;
        private Button forgot_button;
        private Label forgot_label_surname;
        private Label forgot_title;
        private Label forgot_label_name;
        private TextBox forgot_name;
        private TextBox forgot_surname;
        private Button forgot_return;
        private TabPage page_mainmenu;
    }
}