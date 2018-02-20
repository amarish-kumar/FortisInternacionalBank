namespace Fortis_International_Bank.client
{
    partial class CreateCustomer
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.SearchCustomerLabel = new System.Windows.Forms.Label();
            this.TransactionDetailsButton = new System.Windows.Forms.Button();
            this.TransacListView = new System.Windows.Forms.ListView();
            this.TransNbrColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountNbrColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransTypecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountDetailsButton = new System.Windows.Forms.Button();
            this.CustomerDetailsButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.AccountlistView = new System.Windows.Forms.ListView();
            this.AccountNumbercolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountTypecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostumerIDcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpeningDatecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerListView = new System.Windows.Forms.ListView();
            this.CustomerIDcolumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseAccountButton = new System.Windows.Forms.Button();
            this.OpenAccountButton = new System.Windows.Forms.Button();
            this.AccountTypecomboBox = new System.Windows.Forms.ComboBox();
            this.CustomerIDAccLabel = new System.Windows.Forms.Label();
            this.AccCustIDtextBox = new System.Windows.Forms.TextBox();
            this.AccountNumbertextBox = new System.Windows.Forms.TextBox();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.PostalCodetextBox = new System.Windows.Forms.TextBox();
            this.CountrytextBox = new System.Windows.Forms.TextBox();
            this.ProvincetextBox = new System.Windows.Forms.TextBox();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.AptNumbertextBox = new System.Windows.Forms.TextBox();
            this.StreetNametextBox = new System.Windows.Forms.TextBox();
            this.StreetNumbertextBox = new System.Windows.Forms.TextBox();
            this.StreetNumberLabel = new System.Windows.Forms.Label();
            this.StreetNameLabel = new System.Windows.Forms.Label();
            this.ApartNumberLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDtextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.PhonetextBox = new System.Windows.Forms.MaskedTextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.AddressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(314, 20);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(78, 23);
            this.SearchButton.TabIndex = 73;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchCustomerTextBox
            // 
            this.SearchCustomerTextBox.Location = new System.Drawing.Point(141, 22);
            this.SearchCustomerTextBox.Name = "SearchCustomerTextBox";
            this.SearchCustomerTextBox.Size = new System.Drawing.Size(167, 20);
            this.SearchCustomerTextBox.TabIndex = 72;
            // 
            // SearchCustomerLabel
            // 
            this.SearchCustomerLabel.AutoSize = true;
            this.SearchCustomerLabel.Location = new System.Drawing.Point(19, 25);
            this.SearchCustomerLabel.Name = "SearchCustomerLabel";
            this.SearchCustomerLabel.Size = new System.Drawing.Size(116, 13);
            this.SearchCustomerLabel.TabIndex = 71;
            this.SearchCustomerLabel.Text = "Search Customer by ID";
            // 
            // TransactionDetailsButton
            // 
            this.TransactionDetailsButton.Location = new System.Drawing.Point(753, 606);
            this.TransactionDetailsButton.Name = "TransactionDetailsButton";
            this.TransactionDetailsButton.Size = new System.Drawing.Size(487, 23);
            this.TransactionDetailsButton.TabIndex = 70;
            this.TransactionDetailsButton.Text = "See Full Transaction Details";
            this.TransactionDetailsButton.UseVisualStyleBackColor = true;
            // 
            // TransacListView
            // 
            this.TransacListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransNbrColumnHeader,
            this.AccountNbrColumnHeader,
            this.AmountColumnHeader,
            this.TransTypecolumnHeader,
            this.DateColumnHeader});
            this.TransacListView.GridLines = true;
            this.TransacListView.Location = new System.Drawing.Point(753, 412);
            this.TransacListView.Name = "TransacListView";
            this.TransacListView.Size = new System.Drawing.Size(487, 173);
            this.TransacListView.TabIndex = 69;
            this.TransacListView.UseCompatibleStateImageBehavior = false;
            this.TransacListView.View = System.Windows.Forms.View.Details;
            // 
            // TransNbrColumnHeader
            // 
            this.TransNbrColumnHeader.Text = "Transaction Number";
            this.TransNbrColumnHeader.Width = 111;
            // 
            // AccountNbrColumnHeader
            // 
            this.AccountNbrColumnHeader.Text = "Account Number";
            this.AccountNbrColumnHeader.Width = 100;
            // 
            // AmountColumnHeader
            // 
            this.AmountColumnHeader.Text = "Amount";
            this.AmountColumnHeader.Width = 84;
            // 
            // TransTypecolumnHeader
            // 
            this.TransTypecolumnHeader.Text = "Transaction Type";
            this.TransTypecolumnHeader.Width = 100;
            // 
            // DateColumnHeader
            // 
            this.DateColumnHeader.Text = "Date";
            this.DateColumnHeader.Width = 88;
            // 
            // AccountDetailsButton
            // 
            this.AccountDetailsButton.Location = new System.Drawing.Point(355, 606);
            this.AccountDetailsButton.Name = "AccountDetailsButton";
            this.AccountDetailsButton.Size = new System.Drawing.Size(386, 23);
            this.AccountDetailsButton.TabIndex = 68;
            this.AccountDetailsButton.Text = "See Full Account Details";
            this.AccountDetailsButton.UseVisualStyleBackColor = true;
            // 
            // CustomerDetailsButton
            // 
            this.CustomerDetailsButton.Location = new System.Drawing.Point(22, 606);
            this.CustomerDetailsButton.Name = "CustomerDetailsButton";
            this.CustomerDetailsButton.Size = new System.Drawing.Size(320, 23);
            this.CustomerDetailsButton.TabIndex = 67;
            this.CustomerDetailsButton.Text = "See Full Customer Details";
            this.CustomerDetailsButton.UseVisualStyleBackColor = true;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(995, 63);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(245, 333);
            this.ClearAllButton.TabIndex = 66;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // AccountlistView
            // 
            this.AccountlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AccountNumbercolumnHeader,
            this.AccountTypecolumnHeader,
            this.CostumerIDcolumnHeader,
            this.OpeningDatecolumnHeader});
            this.AccountlistView.FullRowSelect = true;
            this.AccountlistView.GridLines = true;
            this.AccountlistView.Location = new System.Drawing.Point(355, 412);
            this.AccountlistView.Name = "AccountlistView";
            this.AccountlistView.Size = new System.Drawing.Size(386, 173);
            this.AccountlistView.TabIndex = 65;
            this.AccountlistView.UseCompatibleStateImageBehavior = false;
            this.AccountlistView.View = System.Windows.Forms.View.Details;
            this.AccountlistView.SelectedIndexChanged += new System.EventHandler(this.AccountlistView_SelectedIndexChanged);
            // 
            // AccountNumbercolumnHeader
            // 
            this.AccountNumbercolumnHeader.Text = "Account Number";
            this.AccountNumbercolumnHeader.Width = 98;
            // 
            // AccountTypecolumnHeader
            // 
            this.AccountTypecolumnHeader.Text = "Account Type";
            this.AccountTypecolumnHeader.Width = 100;
            // 
            // CostumerIDcolumnHeader
            // 
            this.CostumerIDcolumnHeader.Text = "Customer ID";
            this.CostumerIDcolumnHeader.Width = 106;
            // 
            // OpeningDatecolumnHeader
            // 
            this.OpeningDatecolumnHeader.Text = "Opening Date";
            this.OpeningDatecolumnHeader.Width = 100;
            // 
            // CustomerListView
            // 
            this.CustomerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerIDcolumnHeader1,
            this.CustomerNamecolumnHeader});
            this.CustomerListView.FullRowSelect = true;
            this.CustomerListView.GridLines = true;
            this.CustomerListView.Location = new System.Drawing.Point(22, 412);
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.Size = new System.Drawing.Size(320, 173);
            this.CustomerListView.TabIndex = 64;
            this.CustomerListView.UseCompatibleStateImageBehavior = false;
            this.CustomerListView.View = System.Windows.Forms.View.Details;
            this.CustomerListView.SelectedIndexChanged += new System.EventHandler(this.CustomerListView_SelectedIndexChanged);
            // 
            // CustomerIDcolumnHeader1
            // 
            this.CustomerIDcolumnHeader1.Text = "Customer ID";
            this.CustomerIDcolumnHeader1.Width = 137;
            // 
            // CustomerNamecolumnHeader
            // 
            this.CustomerNamecolumnHeader.Text = "Customer Name";
            this.CustomerNamecolumnHeader.Width = 284;
            // 
            // CloseAccountButton
            // 
            this.CloseAccountButton.Location = new System.Drawing.Point(874, 346);
            this.CloseAccountButton.Name = "CloseAccountButton";
            this.CloseAccountButton.Size = new System.Drawing.Size(103, 50);
            this.CloseAccountButton.TabIndex = 63;
            this.CloseAccountButton.Text = "Close Account";
            this.CloseAccountButton.UseVisualStyleBackColor = true;
            this.CloseAccountButton.Click += new System.EventHandler(this.CloseAccountButton_Click);
            // 
            // OpenAccountButton
            // 
            this.OpenAccountButton.Location = new System.Drawing.Point(753, 346);
            this.OpenAccountButton.Name = "OpenAccountButton";
            this.OpenAccountButton.Size = new System.Drawing.Size(103, 50);
            this.OpenAccountButton.TabIndex = 62;
            this.OpenAccountButton.Text = "Open Account";
            this.OpenAccountButton.UseVisualStyleBackColor = true;
            this.OpenAccountButton.Click += new System.EventHandler(this.OpenAccountButton_Click);
            // 
            // AccountTypecomboBox
            // 
            this.AccountTypecomboBox.FormattingEnabled = true;
            this.AccountTypecomboBox.Location = new System.Drawing.Point(566, 362);
            this.AccountTypecomboBox.Name = "AccountTypecomboBox";
            this.AccountTypecomboBox.Size = new System.Drawing.Size(161, 21);
            this.AccountTypecomboBox.TabIndex = 61;
            this.AccountTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.AccountTypecomboBox_SelectedIndexChanged);
            // 
            // CustomerIDAccLabel
            // 
            this.CustomerIDAccLabel.AutoSize = true;
            this.CustomerIDAccLabel.Location = new System.Drawing.Point(230, 365);
            this.CustomerIDAccLabel.Name = "CustomerIDAccLabel";
            this.CustomerIDAccLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDAccLabel.TabIndex = 60;
            this.CustomerIDAccLabel.Text = "Customer ID";
            // 
            // AccCustIDtextBox
            // 
            this.AccCustIDtextBox.Location = new System.Drawing.Point(301, 362);
            this.AccCustIDtextBox.Name = "AccCustIDtextBox";
            this.AccCustIDtextBox.Size = new System.Drawing.Size(167, 20);
            this.AccCustIDtextBox.TabIndex = 59;
            // 
            // AccountNumbertextBox
            // 
            this.AccountNumbertextBox.Location = new System.Drawing.Point(112, 362);
            this.AccountNumbertextBox.Name = "AccountNumbertextBox";
            this.AccountNumbertextBox.ReadOnly = true;
            this.AccountNumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.AccountNumbertextBox.TabIndex = 58;
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.AutoSize = true;
            this.AccountTypeLabel.Location = new System.Drawing.Point(485, 365);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.AccountTypeLabel.TabIndex = 57;
            this.AccountTypeLabel.Text = "Account Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Account Number";
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Location = new System.Drawing.Point(676, 262);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(301, 61);
            this.RemoveCustomerButton.TabIndex = 55;
            this.RemoveCustomerButton.Text = "Remove Customer";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(355, 262);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(296, 61);
            this.UpdateButton.TabIndex = 54;
            this.UpdateButton.Text = "Update Information";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.Location = new System.Drawing.Point(22, 262);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(303, 61);
            this.CreateCustomerButton.TabIndex = 53;
            this.CreateCustomerButton.Text = "Create Costumer";
            this.CreateCustomerButton.UseVisualStyleBackColor = true;
            this.CreateCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.Controls.Add(this.PostalCodetextBox);
            this.AddressGroupBox.Controls.Add(this.CountrytextBox);
            this.AddressGroupBox.Controls.Add(this.ProvincetextBox);
            this.AddressGroupBox.Controls.Add(this.CitytextBox);
            this.AddressGroupBox.Controls.Add(this.AptNumbertextBox);
            this.AddressGroupBox.Controls.Add(this.StreetNametextBox);
            this.AddressGroupBox.Controls.Add(this.StreetNumbertextBox);
            this.AddressGroupBox.Controls.Add(this.StreetNumberLabel);
            this.AddressGroupBox.Controls.Add(this.StreetNameLabel);
            this.AddressGroupBox.Controls.Add(this.ApartNumberLabel);
            this.AddressGroupBox.Controls.Add(this.CityLabel);
            this.AddressGroupBox.Controls.Add(this.ProvinceLabel);
            this.AddressGroupBox.Controls.Add(this.CountryLabel);
            this.AddressGroupBox.Controls.Add(this.PostalCodeLabel);
            this.AddressGroupBox.Location = new System.Drawing.Point(22, 156);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Size = new System.Drawing.Size(955, 100);
            this.AddressGroupBox.TabIndex = 52;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Address";
            // 
            // PostalCodetextBox
            // 
            this.PostalCodetextBox.Location = new System.Drawing.Point(676, 64);
            this.PostalCodetextBox.Name = "PostalCodetextBox";
            this.PostalCodetextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PostalCodetextBox.Size = new System.Drawing.Size(143, 20);
            this.PostalCodetextBox.TabIndex = 25;
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Location = new System.Drawing.Point(452, 64);
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CountrytextBox.Size = new System.Drawing.Size(143, 20);
            this.CountrytextBox.TabIndex = 24;
            // 
            // ProvincetextBox
            // 
            this.ProvincetextBox.Location = new System.Drawing.Point(241, 64);
            this.ProvincetextBox.Name = "ProvincetextBox";
            this.ProvincetextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ProvincetextBox.Size = new System.Drawing.Size(143, 20);
            this.ProvincetextBox.TabIndex = 23;
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(45, 64);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CitytextBox.Size = new System.Drawing.Size(123, 20);
            this.CitytextBox.TabIndex = 22;
            // 
            // AptNumbertextBox
            // 
            this.AptNumbertextBox.Location = new System.Drawing.Point(752, 24);
            this.AptNumbertextBox.Name = "AptNumbertextBox";
            this.AptNumbertextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AptNumbertextBox.Size = new System.Drawing.Size(189, 20);
            this.AptNumbertextBox.TabIndex = 21;
            // 
            // StreetNametextBox
            // 
            this.StreetNametextBox.Location = new System.Drawing.Point(258, 24);
            this.StreetNametextBox.Name = "StreetNametextBox";
            this.StreetNametextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.StreetNametextBox.Size = new System.Drawing.Size(371, 20);
            this.StreetNametextBox.TabIndex = 20;
            // 
            // StreetNumbertextBox
            // 
            this.StreetNumbertextBox.Location = new System.Drawing.Point(96, 24);
            this.StreetNumbertextBox.Name = "StreetNumbertextBox";
            this.StreetNumbertextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.StreetNumbertextBox.Size = new System.Drawing.Size(72, 20);
            this.StreetNumbertextBox.TabIndex = 19;
            // 
            // StreetNumberLabel
            // 
            this.StreetNumberLabel.AutoSize = true;
            this.StreetNumberLabel.Location = new System.Drawing.Point(15, 27);
            this.StreetNumberLabel.Name = "StreetNumberLabel";
            this.StreetNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.StreetNumberLabel.TabIndex = 6;
            this.StreetNumberLabel.Text = "Street Number";
            // 
            // StreetNameLabel
            // 
            this.StreetNameLabel.AutoSize = true;
            this.StreetNameLabel.Location = new System.Drawing.Point(186, 27);
            this.StreetNameLabel.Name = "StreetNameLabel";
            this.StreetNameLabel.Size = new System.Drawing.Size(66, 13);
            this.StreetNameLabel.TabIndex = 7;
            this.StreetNameLabel.Text = "Street Name";
            // 
            // ApartNumberLabel
            // 
            this.ApartNumberLabel.AutoSize = true;
            this.ApartNumberLabel.Location = new System.Drawing.Point(651, 27);
            this.ApartNumberLabel.Name = "ApartNumberLabel";
            this.ApartNumberLabel.Size = new System.Drawing.Size(95, 13);
            this.ApartNumberLabel.TabIndex = 8;
            this.ApartNumberLabel.Text = "Apartment Number";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(15, 67);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 9;
            this.CityLabel.Text = "City";
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(186, 67);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(49, 13);
            this.ProvinceLabel.TabIndex = 10;
            this.ProvinceLabel.Text = "Province";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(403, 67);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 11;
            this.CountryLabel.Text = "Country";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(606, 67);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.PostalCodeLabel.TabIndex = 12;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(57, 110);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(296, 20);
            this.EmailtextBox.TabIndex = 50;
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Location = new System.Drawing.Point(549, 63);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(428, 20);
            this.LastNametextBox.TabIndex = 49;
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(283, 63);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(167, 20);
            this.FirstNametextBox.TabIndex = 48;
            // 
            // CustomerIDtextBox
            // 
            this.CustomerIDtextBox.Location = new System.Drawing.Point(90, 63);
            this.CustomerIDtextBox.Name = "CustomerIDtextBox";
            this.CustomerIDtextBox.ReadOnly = true;
            this.CustomerIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDtextBox.TabIndex = 47;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(397, 113);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 46;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(19, 113);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 45;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(485, 66);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 44;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(220, 66);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 43;
            this.FirstNameLabel.Text = "First Name";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(19, 66);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIdLabel.TabIndex = 42;
            this.CustomerIdLabel.Text = "Customer ID";
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(441, 110);
            this.PhonetextBox.Mask = "0 (999) 000-0000";
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(92, 20);
            this.PhonetextBox.TabIndex = 74;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(995, 19);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(245, 23);
            this.QuitButton.TabIndex = 75;
            this.QuitButton.Text = "Quit IManage";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 665);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PhonetextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCustomerTextBox);
            this.Controls.Add(this.SearchCustomerLabel);
            this.Controls.Add(this.TransactionDetailsButton);
            this.Controls.Add(this.TransacListView);
            this.Controls.Add(this.AccountDetailsButton);
            this.Controls.Add(this.CustomerDetailsButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.AccountlistView);
            this.Controls.Add(this.CustomerListView);
            this.Controls.Add(this.CloseAccountButton);
            this.Controls.Add(this.OpenAccountButton);
            this.Controls.Add(this.AccountTypecomboBox);
            this.Controls.Add(this.CustomerIDAccLabel);
            this.Controls.Add(this.AccCustIDtextBox);
            this.Controls.Add(this.AccountNumbertextBox);
            this.Controls.Add(this.AccountTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateCustomerButton);
            this.Controls.Add(this.AddressGroupBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.LastNametextBox);
            this.Controls.Add(this.FirstNametextBox);
            this.Controls.Add(this.CustomerIDtextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.CustomerIdLabel);
            this.Name = "CreateCustomer";
            this.Text = "IManage";
            this.Load += new System.EventHandler(this.CreateCustomer_Load);
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchCustomerTextBox;
        private System.Windows.Forms.Label SearchCustomerLabel;
        private System.Windows.Forms.Button TransactionDetailsButton;
        private System.Windows.Forms.ListView TransacListView;
        private System.Windows.Forms.ColumnHeader TransNbrColumnHeader;
        private System.Windows.Forms.ColumnHeader AccountNbrColumnHeader;
        private System.Windows.Forms.ColumnHeader AmountColumnHeader;
        private System.Windows.Forms.ColumnHeader TransTypecolumnHeader;
        private System.Windows.Forms.ColumnHeader DateColumnHeader;
        private System.Windows.Forms.Button AccountDetailsButton;
        private System.Windows.Forms.Button CustomerDetailsButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.ListView AccountlistView;
        private System.Windows.Forms.ColumnHeader AccountNumbercolumnHeader;
        private System.Windows.Forms.ColumnHeader AccountTypecolumnHeader;
        private System.Windows.Forms.ColumnHeader CostumerIDcolumnHeader;
        private System.Windows.Forms.ColumnHeader OpeningDatecolumnHeader;
        private System.Windows.Forms.ListView CustomerListView;
        private System.Windows.Forms.ColumnHeader CustomerIDcolumnHeader1;
        private System.Windows.Forms.ColumnHeader CustomerNamecolumnHeader;
        private System.Windows.Forms.Button CloseAccountButton;
        private System.Windows.Forms.Button OpenAccountButton;
        private System.Windows.Forms.ComboBox AccountTypecomboBox;
        private System.Windows.Forms.Label CustomerIDAccLabel;
        private System.Windows.Forms.TextBox AccCustIDtextBox;
        private System.Windows.Forms.TextBox AccountNumbertextBox;
        private System.Windows.Forms.Label AccountTypeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CreateCustomerButton;
        private System.Windows.Forms.GroupBox AddressGroupBox;
        private System.Windows.Forms.TextBox PostalCodetextBox;
        private System.Windows.Forms.TextBox CountrytextBox;
        private System.Windows.Forms.TextBox ProvincetextBox;
        private System.Windows.Forms.TextBox CitytextBox;
        private System.Windows.Forms.TextBox AptNumbertextBox;
        private System.Windows.Forms.TextBox StreetNametextBox;
        private System.Windows.Forms.TextBox StreetNumbertextBox;
        private System.Windows.Forms.Label StreetNumberLabel;
        private System.Windows.Forms.Label StreetNameLabel;
        private System.Windows.Forms.Label ApartNumberLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox LastNametextBox;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.TextBox CustomerIDtextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.MaskedTextBox PhonetextBox;
        private System.Windows.Forms.Button QuitButton;
    }
}