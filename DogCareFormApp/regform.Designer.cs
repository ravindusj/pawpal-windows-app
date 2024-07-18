namespace DogCareFormApp
{
    partial class Regform
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
            this.lblregsiterform = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblownersfullname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblregistrationform = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblpn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbladdress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OwnerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.OwnerContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.OwnerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.OwnerAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DogName = new Guna.UI2.WinForms.Guna2TextBox();
            this.DogAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.DogBreed = new Guna.UI2.WinForms.Guna2TextBox();
            this.DogGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.OwnerEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblregsiterform
            // 
            this.lblregsiterform.BackColor = System.Drawing.Color.Transparent;
            this.lblregsiterform.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregsiterform.Location = new System.Drawing.Point(374, 12);
            this.lblregsiterform.Name = "lblregsiterform";
            this.lblregsiterform.Size = new System.Drawing.Size(210, 24);
            this.lblregsiterform.TabIndex = 1;
            this.lblregsiterform.Text = "REGISTRATION FORM";
            this.lblregsiterform.Click += new System.EventHandler(this.lblregsiterform_Click);
            // 
            // lblownersfullname
            // 
            this.lblownersfullname.BackColor = System.Drawing.Color.Transparent;
            this.lblownersfullname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblownersfullname.Location = new System.Drawing.Point(47, 180);
            this.lblownersfullname.Name = "lblownersfullname";
            this.lblownersfullname.Size = new System.Drawing.Size(75, 20);
            this.lblownersfullname.TabIndex = 2;
            this.lblownersfullname.Text = "Owner ID :";
            this.lblownersfullname.Click += new System.EventHandler(this.lblownersfullname_Click);
            // 
            // lblregistrationform
            // 
            this.lblregistrationform.BackColor = System.Drawing.Color.Transparent;
            this.lblregistrationform.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrationform.Location = new System.Drawing.Point(47, 236);
            this.lblregistrationform.Name = "lblregistrationform";
            this.lblregistrationform.Size = new System.Drawing.Size(102, 20);
            this.lblregistrationform.TabIndex = 3;
            this.lblregistrationform.Text = "Owner Name      :";
            // 
            // lblpn
            // 
            this.lblpn.BackColor = System.Drawing.Color.Transparent;
            this.lblpn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpn.Location = new System.Drawing.Point(47, 292);
            this.lblpn.Name = "lblpn";
            this.lblpn.Size = new System.Drawing.Size(110, 20);
            this.lblpn.TabIndex = 4;
            this.lblpn.Text = "Owner Contact:";
            // 
            // lbladdress
            // 
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(47, 415);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(96, 20);
            this.lbladdress.TabIndex = 5;
            this.lbladdress.Text = "Owner Email:";
            // 
            // OwnerId
            // 
            this.OwnerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OwnerId.DefaultText = "";
            this.OwnerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OwnerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OwnerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerId.Location = new System.Drawing.Point(245, 170);
            this.OwnerId.Name = "OwnerId";
            this.OwnerId.PasswordChar = '\0';
            this.OwnerId.PlaceholderText = "";
            this.OwnerId.SelectedText = "";
            this.OwnerId.Size = new System.Drawing.Size(206, 30);
            this.OwnerId.TabIndex = 6;
            // 
            // OwnerContact
            // 
            this.OwnerContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OwnerContact.DefaultText = "";
            this.OwnerContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OwnerContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OwnerContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerContact.Location = new System.Drawing.Point(245, 276);
            this.OwnerContact.Name = "OwnerContact";
            this.OwnerContact.PasswordChar = '\0';
            this.OwnerContact.PlaceholderText = "";
            this.OwnerContact.SelectedText = "";
            this.OwnerContact.Size = new System.Drawing.Size(206, 36);
            this.OwnerContact.TabIndex = 7;
            this.OwnerContact.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // OwnerName
            // 
            this.OwnerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OwnerName.DefaultText = "";
            this.OwnerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OwnerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OwnerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerName.Location = new System.Drawing.Point(245, 220);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.PasswordChar = '\0';
            this.OwnerName.PlaceholderText = "";
            this.OwnerName.SelectedText = "";
            this.OwnerName.Size = new System.Drawing.Size(206, 36);
            this.OwnerName.TabIndex = 8;
            // 
            // OwnerAddress
            // 
            this.OwnerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OwnerAddress.DefaultText = "";
            this.OwnerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OwnerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OwnerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerAddress.Location = new System.Drawing.Point(245, 335);
            this.OwnerAddress.Name = "OwnerAddress";
            this.OwnerAddress.PasswordChar = '\0';
            this.OwnerAddress.PlaceholderText = "";
            this.OwnerAddress.SelectedText = "";
            this.OwnerAddress.Size = new System.Drawing.Size(206, 36);
            this.OwnerAddress.TabIndex = 9;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(47, 95);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(189, 26);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Owner\'s Information ";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(498, 95);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(166, 26);
            this.guna2HtmlLabel7.TabIndex = 21;
            this.guna2HtmlLabel7.Text = "Dog\'s Information ";
            this.guna2HtmlLabel7.Click += new System.EventHandler(this.guna2HtmlLabel7_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(498, 180);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(87, 20);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Dog Name : ";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(498, 351);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(59, 20);
            this.guna2HtmlLabel8.TabIndex = 23;
            this.guna2HtmlLabel8.Text = "Gender:";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(498, 292);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(36, 20);
            this.guna2HtmlLabel9.TabIndex = 24;
            this.guna2HtmlLabel9.Text = "Age:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(498, 236);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(112, 20);
            this.guna2HtmlLabel10.TabIndex = 25;
            this.guna2HtmlLabel10.Text = "Breed/Species:";
            // 
            // DogName
            // 
            this.DogName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DogName.DefaultText = "";
            this.DogName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DogName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DogName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DogName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DogName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DogName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DogName.Location = new System.Drawing.Point(668, 170);
            this.DogName.Name = "DogName";
            this.DogName.PasswordChar = '\0';
            this.DogName.PlaceholderText = "";
            this.DogName.SelectedText = "";
            this.DogName.Size = new System.Drawing.Size(206, 30);
            this.DogName.TabIndex = 26;
            // 
            // DogAge
            // 
            this.DogAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DogAge.DefaultText = "";
            this.DogAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DogAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DogAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DogAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DogAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DogAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DogAge.Location = new System.Drawing.Point(668, 282);
            this.DogAge.Name = "DogAge";
            this.DogAge.PasswordChar = '\0';
            this.DogAge.PlaceholderText = "";
            this.DogAge.SelectedText = "";
            this.DogAge.Size = new System.Drawing.Size(206, 30);
            this.DogAge.TabIndex = 27;
            // 
            // DogBreed
            // 
            this.DogBreed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DogBreed.DefaultText = "";
            this.DogBreed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DogBreed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DogBreed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DogBreed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DogBreed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DogBreed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogBreed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DogBreed.Location = new System.Drawing.Point(668, 226);
            this.DogBreed.Name = "DogBreed";
            this.DogBreed.PasswordChar = '\0';
            this.DogBreed.PlaceholderText = "";
            this.DogBreed.SelectedText = "";
            this.DogBreed.Size = new System.Drawing.Size(206, 30);
            this.DogBreed.TabIndex = 28;
            // 
            // DogGender
            // 
            this.DogGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DogGender.DefaultText = "";
            this.DogGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DogGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DogGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DogGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DogGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DogGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DogGender.Location = new System.Drawing.Point(668, 341);
            this.DogGender.Name = "DogGender";
            this.DogGender.PasswordChar = '\0';
            this.DogGender.PlaceholderText = "";
            this.DogGender.SelectedText = "";
            this.DogGender.Size = new System.Drawing.Size(206, 30);
            this.DogGender.TabIndex = 29;
            // 
            // OwnerEmail
            // 
            this.OwnerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OwnerEmail.DefaultText = "";
            this.OwnerEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OwnerEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OwnerEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerEmail.Location = new System.Drawing.Point(245, 399);
            this.OwnerEmail.Name = "OwnerEmail";
            this.OwnerEmail.PasswordChar = '\0';
            this.OwnerEmail.PlaceholderText = "";
            this.OwnerEmail.SelectedText = "";
            this.OwnerEmail.Size = new System.Drawing.Size(206, 36);
            this.OwnerEmail.TabIndex = 31;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(47, 351);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(115, 20);
            this.guna2HtmlLabel3.TabIndex = 30;
            this.guna2HtmlLabel3.Text = "Owner Address:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(776, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(776, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 30);
            this.button3.TabIndex = 33;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 870);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OwnerEmail);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.DogGender);
            this.Controls.Add(this.DogBreed);
            this.Controls.Add(this.DogAge);
            this.Controls.Add(this.DogName);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.OwnerAddress);
            this.Controls.Add(this.OwnerName);
            this.Controls.Add(this.OwnerContact);
            this.Controls.Add(this.OwnerId);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblpn);
            this.Controls.Add(this.lblregistrationform);
            this.Controls.Add(this.lblownersfullname);
            this.Controls.Add(this.lblregsiterform);
            this.Name = "Regform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblregsiterform;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblownersfullname;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblregistrationform;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblpn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbladdress;
        private Guna.UI2.WinForms.Guna2TextBox OwnerId;
        private Guna.UI2.WinForms.Guna2TextBox OwnerContact;
        private Guna.UI2.WinForms.Guna2TextBox OwnerName;
        private Guna.UI2.WinForms.Guna2TextBox OwnerAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox DogName;
        private Guna.UI2.WinForms.Guna2TextBox DogAge;
        private Guna.UI2.WinForms.Guna2TextBox DogBreed;
        private Guna.UI2.WinForms.Guna2TextBox DogGender;
        private Guna.UI2.WinForms.Guna2TextBox OwnerEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}