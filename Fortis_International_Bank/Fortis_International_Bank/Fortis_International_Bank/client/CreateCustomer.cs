using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using Fortis_International_Bank.business;
using Fortis_International_Bank.data;

namespace Fortis_International_Bank.client
{
    public partial class CreateCustomer : Form
    {
        string filePath1 = CustomerDB.filePath;
        string filePath2 = CustomerDB.filePath2;
        string filePath3 = AccountDB.filePath;
        string filePath4 = AccountDB.filePath2;
        string filePath5 = TransactionDB.filePath;
        

        Dictionary<int, Customer> dictCustomer = new Dictionary<int, Customer>();
        Dictionary<int, Account> dictAccount = new Dictionary<int, Account>();
        SortedDictionary<int, Customer> sortedCustomer = new SortedDictionary<int, Customer>();
        SortedDictionary<int, Account> sortedAccount = new SortedDictionary<int, Account>();
        Dictionary<int, Transaction> dictTransaction = new Dictionary<int, Transaction>();
        SortedDictionary<int, Transaction> sortedTransaction = new SortedDictionary<int, Transaction>();

        NumGenerator custNum = new NumGenerator(1000);
        int lastValueCust;
        int lastValueAcc;
        int lastValueTrans;
        

        

        public CreateCustomer()
        {
            InitializeComponent();            
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
            aCustomer.PersonId = custNum.NextValue(lastValueCust);
            aCustomer.Fn = FirstNametextBox.Text;
            aCustomer.Ln = LastNametextBox.Text;

            if (EmailValidation(EmailtextBox.Text))
            {
                aCustomer.Email = new Email(EmailtextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid email address!");
                aCustomer = null;
            }

            if (!(IntegerValidation(StreetNumbertextBox.Text)))
            {
                MessageBox.Show("Invalid street number!");
                aCustomer = null;
            }

            if (!(IntegerValidation(AptNumbertextBox.Text)))
            {
                MessageBox.Show("Invalid apartment number!");
                aCustomer = null;
            }



            if (aCustomer != null)
            {
                aCustomer.Email = new Email(EmailtextBox.Text);
                aCustomer.Phone = new Phone(PhonetextBox.Text);
                aCustomer.Address = new Address(Int32.Parse(StreetNumbertextBox.Text), StreetNametextBox.Text, Int32.Parse(AptNumbertextBox.Text),
                                                CitytextBox.Text, ProvincetextBox.Text, CountrytextBox.Text, PostalCodetextBox.Text);
                aCustomer.Pin = 1234;
                CustomerIDtextBox.Text = Convert.ToString(aCustomer.PersonId);
                AccCustIDtextBox.Text = CustomerIDtextBox.Text;
                dictCustomer.Add(aCustomer.PersonId, aCustomer);
                sortedCustomer.Add(aCustomer.PersonId, aCustomer);
                CustomerDB.SaveToFile(dictCustomer);
                CustomerDB.SaveToFile(sortedCustomer);
                ShowAllCustomers(dictCustomer);
                lastValueCust++;
            }
            else
            {
                MessageBox.Show("Please input correct information!");
            }
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            AccountDetailsButton.Enabled = false;
            TransactionDetailsButton.Enabled = false;
            CustomerDetailsButton.Enabled = false;
            AccountTypecomboBox.DataSource = Enum.GetValues(typeof(EnumType));
            if (File.Exists(filePath1) && File.Exists(filePath2))
            {
                dictCustomer = CustomerDB.ReadFromFile();
                sortedCustomer = CustomerDB.ReadFromFileSorted();                
                lastValueCust = sortedCustomer.Keys.Last();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Customer Database not found", "ERROR");
                lastValueCust = 1000;
            }
            if (File.Exists(filePath3) && File.Exists(filePath4))
            {
                dictAccount = AccountDB.ReadFromFile();
                sortedAccount = AccountDB.ReadFromFileSorted();
                lastValueAcc = sortedAccount.Keys.Last();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Account Database not found", "ERROR");
                lastValueAcc = 5000;
            }
            if (File.Exists(filePath5))
            {
                dictTransaction = TransactionDB.ReadFromFile();
                sortedTransaction = TransactionDB.ReadFromFileSorted();
                lastValueTrans = sortedTransaction.Keys.Last();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Transaction Database not found", "ERROR");
                //lastValueTransac = 30000;
            }
            ShowAllCustomers(dictCustomer);
            ShowAllAccounts(dictAccount);
            ShowAllTransactions(dictTransaction);
        }

        public void ShowAllCustomers(Dictionary<int, Customer> dictCustomer)
        {
            dictCustomer = CustomerDB.ReadFromFile();
            CustomerListView.Items.Clear();

            if (dictCustomer != null)
            {
                foreach (Customer current in dictCustomer.Values)
                {
                    ListViewItem item = new ListViewItem(current.PersonId.ToString());
                    item.SubItems.Add(current.Ln + ", " + current.Fn);                
                    CustomerListView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No Data");
            }        
        }

        public void ShowAllAccounts(Dictionary<int, Account> dictAccount)
        {
            AccountlistView.Items.Clear();

            if (dictAccount != null)
            {
                foreach (Account current in dictAccount.Values)
                {
                    ListViewItem item = new ListViewItem(current.AccNumber.ToString());
                    item.SubItems.Add(Convert.ToString(current.Acctype));
                    item.SubItems.Add(Convert.ToString(current.CustomerId));
                    item.SubItems.Add(current.OpenDate.DayOfYear.ToString());
                    AccountlistView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No Data");
            }  
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            foreach (Control guiControl in AddressGroupBox.Controls)
            {
                if (guiControl is TextBox)
                {

                    ((TextBox)guiControl).Clear();
                }
                
            }

            foreach (Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {

                    ((TextBox)guiControl).Clear();
                }
                if (guiControl is MaskedTextBox)
                {

                    ((MaskedTextBox)guiControl).Clear();
                }
                if (guiControl is ListView)
                {
                    ((ListView)guiControl).Items.Clear();
                }
            }
            this.AccountTypecomboBox.SelectedItem = EnumType.Undefined;
            FirstNametextBox.Focus();
            ShowAllCustomers(dictCustomer);
            ShowAllAccounts(dictAccount);
            ShowAllTransactions(dictTransaction);                
        }

        private void CustomerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            dictCustomer = CustomerDB.ReadFromFile();
            Dictionary<int, Account> tempDictAcc = new Dictionary<int, Account>();
            Dictionary<int, Transaction> tempDictTrans = new Dictionary<int, Transaction>();

            if (CustomerListView.SelectedIndices.Count > 0)
            {
                Customer aCustomer;
                dictCustomer.TryGetValue(Int32.Parse(CustomerListView.SelectedItems[0].SubItems[0].Text), out aCustomer);
                this.CustomerIDtextBox.Text = Convert.ToString(aCustomer.PersonId);
                this.FirstNametextBox.Text = aCustomer.Fn;
                this.LastNametextBox.Text = aCustomer.Ln;
                this.EmailtextBox.Text = aCustomer.Email.ToString();
                this.PhonetextBox.Text = aCustomer.Phone.ToString();
                this.StreetNumbertextBox.Text = Convert.ToString(aCustomer.Address.StreetNo);
                this.StreetNametextBox.Text = aCustomer.Address.StreetName;
                this.AptNumbertextBox.Text = Convert.ToString(aCustomer.Address.AptNo);
                this.CitytextBox.Text = aCustomer.Address.City;
                this.ProvincetextBox.Text = aCustomer.Address.Province;
                this.CountrytextBox.Text = aCustomer.Address.Country;
                this.PostalCodetextBox.Text = aCustomer.Address.PostalCode;
                this.AccCustIDtextBox.Text = this.CustomerIDtextBox.Text;
                tempDictAcc = aCustomer.customerAccount;
                ShowAllAccounts(tempDictAcc);
                ShowAllTransactions(tempDictAcc);                
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
            aCustomer.PersonId = Int32.Parse(CustomerIDtextBox.Text);
            aCustomer.Fn = FirstNametextBox.Text;
            aCustomer.Ln = LastNametextBox.Text;
            aCustomer.Email = new Email(EmailtextBox.Text);
            aCustomer.Phone = new Phone(PhonetextBox.Text);
            aCustomer.Address = new Address(Int32.Parse(StreetNumbertextBox.Text), StreetNametextBox.Text, Int32.Parse(AptNumbertextBox.Text),
                                            CitytextBox.Text, ProvincetextBox.Text, CountrytextBox.Text, PostalCodetextBox.Text);
            aCustomer.Pin = 1234;

            dictCustomer.Remove(Convert.ToInt32(CustomerIDtextBox.Text));   

            dictCustomer.Add(aCustomer.PersonId, aCustomer);

            CustomerDB.SaveToFile(dictCustomer);
            ShowAllCustomers(dictCustomer);
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            dictCustomer.Remove(Convert.ToInt32(CustomerIDtextBox.Text));
            CustomerDB.SaveToFile(dictCustomer);
            Reset();
            ShowAllCustomers(dictCustomer);
        }

        private void AccountTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OpenAccountButton_Click(object sender, EventArgs e)
        {
            Customer tempCustomer = new Customer();
            Dictionary<int, Customer> tempCustDict = new Dictionary<int,Customer>();
            tempCustDict = CustomerDB.ReadFromFile();
            tempCustDict.TryGetValue(Int32.Parse(AccCustIDtextBox.Text), out tempCustomer);
            
            Dictionary<int, Account> tempAccDict = new Dictionary<int,Account>();
            tempAccDict = tempCustomer.customerAccount;
            bool checkingPermission = true;
            bool savingPermission = true;
            foreach (Account current in tempAccDict.Values)
            {
                if (current.Acctype == Account.EnumType.Checkings)
                {checkingPermission = false;}
                if (current.Acctype == Account.EnumType.Savings)
                {savingPermission = false;}
            }


            switch (AccountTypecomboBox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Please select one type of account");
                    break;

                case 1:
                    if (checkingPermission)
                    {
                        Checking check = new Checking();
                        lastValueAcc++;
                        check.AccNumber = custNum.NextValue(lastValueAcc);
                        //lastValueAcc++;
                        check.CustomerId = Int32.Parse(AccCustIDtextBox.Text);
                        check.Acctype = Account.EnumType.Checkings;
                        dictAccount.Add(check.AccNumber, check);
                        sortedAccount.Add(check.AccNumber, check);
                        AccountDB.SaveToFile(dictAccount);
                        AccountDB.SaveToFile(sortedAccount);
                        dictCustomer = CustomerDB.ReadFromFile();
                        sortedCustomer = CustomerDB.ReadFromFileSorted();
                        AccountNumbertextBox.Text = Convert.ToString(check.AccNumber);
                        ShowAllAccounts(dictAccount);
                        dictCustomer[check.CustomerId].customerAccount.Add(check.AccNumber, check);
                        sortedCustomer[check.CustomerId].customerAccount.Add(check.AccNumber, check);
                        CustomerDB.SaveToFile(dictCustomer);
                        CustomerDB.SaveToFile(sortedCustomer);
                    }
                    else
                    {
                        MessageBox.Show("This customer already has a Chekings account!");
                    }
                    break;

                case 2:
                    if(savingPermission)
                    {
                        Saving sav = new Saving();
                        lastValueAcc++;
                        sav.AccNumber = custNum.NextValue(lastValueAcc);                    
                        sav.CustomerId = Int32.Parse(AccCustIDtextBox.Text);
                        sav.Acctype = Account.EnumType.Savings;
                        dictAccount.Add(sav.AccNumber, sav);
                        AccountDB.SaveToFile(dictAccount);
                        AccountDB.SaveToFile(sortedAccount);
                        dictCustomer = CustomerDB.ReadFromFile();
                        sortedCustomer = CustomerDB.ReadFromFileSorted();
                        AccountNumbertextBox.Text = Convert.ToString(sav.AccNumber);
                        ShowAllAccounts(dictAccount);
                        dictCustomer[sav.CustomerId].customerAccount.Add(sav.AccNumber, sav);
                        sortedCustomer[sav.CustomerId].customerAccount.Add(sav.AccNumber, sav);
                        CustomerDB.SaveToFile(dictCustomer);
                        CustomerDB.SaveToFile(sortedCustomer);
                    }
                    else
                    {
                        MessageBox.Show("This customer already has a Savings account!");
                    }
                    break;

                case 3:
                    MessageBox.Show("Service Not Available");
                    break;                
            }
            ShowAllAccounts(dictAccount);
                           
        }

        private void CloseAccountButton_Click(object sender, EventArgs e)
        {
            dictCustomer[Int32.Parse(AccCustIDtextBox.Text)].customerAccount.Remove(Int32.Parse(AccountNumbertextBox.Text));
            dictAccount.Remove(Convert.ToInt32(AccountNumbertextBox.Text));
            AccountDB.SaveToFile(dictAccount);
            Reset();
            ShowAllAccounts(dictAccount);
            this.AccountTypecomboBox.SelectedItem = EnumType.Undefined;
        }

        private void AccountlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            dictAccount = AccountDB.ReadFromFile();
            dictCustomer = CustomerDB.ReadFromFile();
            Dictionary<int, Transaction> tempDictTrans = new Dictionary<int, Transaction>();

            if (AccountlistView.SelectedIndices.Count > 0)
            {
                Account anAcc;
                Customer aCustomer;
                dictAccount.TryGetValue(Int32.Parse(AccountlistView.SelectedItems[0].SubItems[0].Text), out anAcc);
                this.AccountNumbertextBox.Text = Convert.ToString(anAcc.AccNumber);
                this.AccCustIDtextBox.Text = Convert.ToString(anAcc.CustomerId);
                this.AccountTypecomboBox.SelectedItem = anAcc.Acctype;
                dictCustomer.TryGetValue(Int32.Parse(AccountlistView.SelectedItems[0].SubItems[2].Text), out aCustomer);
                this.CustomerIDtextBox.Text = Convert.ToString(aCustomer.PersonId);
                this.FirstNametextBox.Text = aCustomer.Fn;
                this.LastNametextBox.Text = aCustomer.Ln;
                this.EmailtextBox.Text = aCustomer.Email.ToString();
                this.PhonetextBox.Text = aCustomer.Phone.ToString();
                this.StreetNumbertextBox.Text = Convert.ToString(aCustomer.Address.StreetNo);
                this.StreetNametextBox.Text = aCustomer.Address.StreetName;
                this.AptNumbertextBox.Text = Convert.ToString(aCustomer.Address.AptNo);
                this.CitytextBox.Text = aCustomer.Address.City;
                this.ProvincetextBox.Text = aCustomer.Address.Province;
                this.CountrytextBox.Text = aCustomer.Address.Country;
                this.PostalCodetextBox.Text = aCustomer.Address.PostalCode;
                this.AccCustIDtextBox.Text = this.CustomerIDtextBox.Text;
                tempDictTrans = anAcc.accTransactionDict;
                ShowAllTransactions(tempDictTrans);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dictCustomer = CustomerDB.ReadFromFile();
            String code = SearchCustomerTextBox.Text;
            Customer aCustomer;
            if (dictCustomer.TryGetValue(Int32.Parse(code), out aCustomer))
            {
                ListViewItem searchItem = null;
                int index = 0;
                do
                {
                    if (index < CustomerListView.Items.Count)
                    {       
                        searchItem = CustomerListView.FindItemWithText(code, true, index, false);
                        if (searchItem != null)
                        {
                            for (int i = 0; i < CustomerListView.SelectedIndices.Count; i++)
                            {
                                CustomerListView.Items[CustomerListView.SelectedIndices[i]].Selected = false;
                            }
                            CustomerListView.Items[searchItem.Index].Selected = true;
                            CustomerListView.Select();index = searchItem.Index + 1;
                        }
                    }
                    else
                        searchItem = null;

                } while (searchItem != null);                  

            }
            else
            {
                MessageBox.Show("Customer not found!");
                Reset();
            }
        }

        public void ShowAllTransactions(Dictionary<int, Transaction> tempDictTransaction)
        {
            TransacListView.Items.Clear();
            foreach (Transaction transac in tempDictTransaction.Values)
            {
                ListViewItem secItem = new ListViewItem(transac.TransNumber.ToString());                
                secItem.SubItems.Add(transac.AccNumber.ToString());
                secItem.SubItems.Add("CAD" + transac.Amount.ToString());                
                secItem.SubItems.Add(Convert.ToString(transac.TransType));
                secItem.SubItems.Add(transac.Date.ToShortDateString());                
                TransacListView.Items.Add(secItem);
            }
        }

        public void ShowAllTransactions(Dictionary<int, Account> tempDictAccount)
        {
            TransacListView.Items.Clear();
            foreach (Account current in tempDictAccount.Values)
            {
                foreach (Transaction transac in current.accTransactionDict.Values)
                {
                    ListViewItem secItem = new ListViewItem(transac.TransNumber.ToString());
                    secItem.SubItems.Add(transac.AccNumber.ToString());
                    secItem.SubItems.Add("CAD" + transac.Amount.ToString());
                    secItem.SubItems.Add(Convert.ToString(transac.TransType));
                    secItem.SubItems.Add(transac.Date.ToShortDateString());
                    TransacListView.Items.Add(secItem);
                }
            }
        }

        public bool EmailValidation(String email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            else
                return false;                
        }

        public bool IntegerValidation(String number)
        {
            int n;
            bool isNumeric = int.TryParse(number, out n);
            return isNumeric;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            byte answer;
            answer = (byte)MessageBox.Show("Do you want to quit IManage?", "Exit ?", MessageBoxButtons.YesNo);
            if (answer == 6)
            {
                this.Close();
            }
        }
    }
}
