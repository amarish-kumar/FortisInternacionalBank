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
    public partial class BalanceInquiry : Form
    {
        string code;
        string filePath1 = CustomerDB.filePath;
        string filePath2 = AccountDB.filePath;
        string filePath3 = TransactionDB.filePath;
        string filePath4 = TransactionDB.filePath2;
        Customer aCustomer = new Customer();
        
        Dictionary<int, Customer> dictCustomer = new Dictionary<int, Customer>();
        Dictionary<int, Account> dictAccount = new Dictionary<int, Account>();
        Dictionary<int, Transaction> dictTransaction = new Dictionary<int, Transaction>();
        SortedDictionary<int, Transaction> sortedTransaction = new SortedDictionary<int, Transaction>();

        int lastValueTransac;
        NumGenerator transacNum = new NumGenerator(30000);

        public BalanceInquiry()
        {
            InitializeComponent();
        }

        private void BalanceInquiry_Load(object sender, EventArgs e)
        {    
            //will always find, otherwise wouldn't open the form;
            if (File.Exists(filePath1))
            {
                dictCustomer = CustomerDB.ReadFromFile();
                dictCustomer.TryGetValue(Int32.Parse(code), out aCustomer);                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("CUSTOMER Database not found", "ERROR");
            }

            if (File.Exists(filePath2))
            {
                dictAccount = AccountDB.ReadFromFile();                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ACCOUNT Database not found", "ERROR");
            }

            if (File.Exists(filePath3) && File.Exists(filePath4))
            {
                dictTransaction = TransactionDB.ReadFromFile();
                sortedTransaction = TransactionDB.ReadFromFileSorted();
                lastValueTransac = sortedTransaction.Keys.Last();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("TRANSACTION Database not found", "ERROR");
                lastValueTransac = 30000;
            }
                      
            if (aCustomer.customerAccount == null) MessageBox.Show("No accounts to show");

            dictAccount = aCustomer.customerAccount;
            
            AcclistView.Items.Clear();            

            if (dictAccount != null)
            {
                foreach (Account current in dictAccount.Values)
                {
                    ListViewItem item = new ListViewItem(current.AccNumber.ToString());
                    item.SubItems.Add(Convert.ToString(current.Acctype));
                    item.SubItems.Add(current.OpenDate.ToShortDateString());
                    item.SubItems.Add("CAD " + current.Balance);
                    AcclistView.Items.Add(item);
                    Dictionary<int, Transaction> tempDictTransaction = new Dictionary<int, Transaction>();
                    tempDictTransaction = current.accTransactionDict;
                    foreach (Transaction transac in tempDictTransaction.Values)
                    {
                        ListViewItem secItem = new ListViewItem(transac.TransNumber.ToString());
                        secItem.SubItems.Add(Convert.ToString(transac.TransType));
                        secItem.SubItems.Add(current.AccNumber.ToString());
                        secItem.SubItems.Add(Convert.ToString(current.Acctype));
                        secItem.SubItems.Add(transac.Date.ToShortDateString());
                        secItem.SubItems.Add("CAD" + transac.Amount.ToString());
                        TransacListView.Items.Add(secItem);
                        //dictTransaction.Add(transac.TransNumber, transac);
                    }                    
                }
            }
            else
            {
                MessageBox.Show("No Data");
            }         
        }

        public BalanceInquiry(string code)
        {
            InitializeComponent();
            this.code = code;
        }

        public void ShowAllAccounts()
        {
            dictCustomer = CustomerDB.ReadFromFile();
            dictCustomer.TryGetValue(Int32.Parse(code), out aCustomer);
            AcclistView.Items.Clear();

            if (dictCustomer != null)
            {
                foreach (Account current in aCustomer.customerAccount.Values)
                {
                    ListViewItem item = new ListViewItem(current.AccNumber.ToString());
                    item.SubItems.Add(Convert.ToString(current.Acctype));                    
                    item.SubItems.Add(current.OpenDate.ToShortDateString());
                    item.SubItems.Add("CAD " + current.Balance);
                    AcclistView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }


        //make a transaction
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            UpdateTempData();
            Checking tempCheckAccount = new Checking();
            Saving tempSavAccount = new Saving();
            double amount;
            

            
            
            Transaction aTransac = new Transaction();
            if (Double.TryParse(AmountTextBox.Text, out amount))
            {
                if (amount > 0)
                {
                    aTransac.Date = DateTime.Now;
                    aTransac.Amount = Convert.ToDouble(AmountTextBox.Text);
                    aTransac.AccNumber = Int32.Parse(AccNumTextBox.Text);
                    aTransac.AccType = dictAccount[Int32.Parse(AccNumTextBox.Text)].Acctype;
                }
                else
                {
                    MessageBox.Show("Amount must be a positive value!");
                    aTransac = null;
                }
            }
            else 
            {
                MessageBox.Show("Invalid amount!");
                
            }
            /*
            if (aTransac.AccType == Account.EnumType.Checkings)
            {
                foreach (Checking current in aCustomer.customerAccount.Values)
                {
                    tempCheckAccount = (Checking)current;
                }
                if (tempCheckAccount.Counter < tempCheckAccount.LimitTransac)
                {
                    tempCheckAccount.Counter++;
                }
                else
                {
                    aTransac = null;
                    MessageBox.Show("You have reached your transaction limit for this account");
                }
            }

            if (aTransac.AccType == Account.EnumType.Savings)
            {
                foreach (Saving current in aCustomer.customerAccount.Values)
                {
                    tempSavAccount = (Saving)current;
                }
            } 
            */


            if (!(checkBoxWithdraw.Checked || checkBoxDeposit.Checked))
            {
                MessageBox.Show("Please Select a Transaction Type");
                aTransac = null;
            }
            
            if (aTransac != null && (Double.TryParse(AmountTextBox.Text, out amount)))/////CHECAR REPETICAO AQUI!
            {
                if (checkBoxWithdraw.Checked)
                {
                    aTransac.TransNumber = transacNum.NextValue(lastValueTransac);
                    aTransac.TransType = Transaction.EnumType.Withdraw;
                    dictAccount[Int32.Parse(AccNumTextBox.Text)].Balance -= aTransac.Amount;
                    dictCustomer[Int32.Parse(code)].customerAccount[Int32.Parse(AccNumTextBox.Text)].Balance -= aTransac.Amount;
                }
                else if (checkBoxDeposit.Checked)
                {
                    aTransac.TransNumber = transacNum.NextValue(lastValueTransac);
                    aTransac.TransType = Transaction.EnumType.Deposit;
                    dictAccount[Int32.Parse(AccNumTextBox.Text)].Balance += aTransac.Amount;
                    dictCustomer[Int32.Parse(code)].customerAccount[Int32.Parse(AccNumTextBox.Text)].Balance += aTransac.Amount;
                }
                TransactionNumberTextBox.Text = Convert.ToString(aTransac.TransNumber);
                NewBalanceTextBox.Text = Convert.ToString(dictCustomer[Int32.Parse(code)].customerAccount[Int32.Parse(AccNumTextBox.Text)].Balance);
                sortedTransaction.Add(aTransac.TransNumber, aTransac);
                TransactionDB.SaveToFile(sortedTransaction);
                dictTransaction.Add(aTransac.TransNumber, aTransac);
                TransactionDB.SaveToFile(dictTransaction);
                dictAccount[Int32.Parse(AccNumTextBox.Text)].accTransactionDict.Add(aTransac.TransNumber, aTransac);
                AccountDB.SaveToFile(dictAccount);
                dictCustomer[Int32.Parse(code)].customerAccount[Int32.Parse(AccNumTextBox.Text)].accTransactionDict.Add(aTransac.TransNumber, aTransac);                 
                CustomerDB.SaveToFile(dictCustomer);
                DisplayTransacList(dictCustomer[Int32.Parse(code)].customerAccount[Int32.Parse(AccNumTextBox.Text)].accTransactionDict);
                Dictionary<int, Account> tempDictAccount = new Dictionary<int, Account>();
                tempDictAccount = dictCustomer[Int32.Parse(code)].customerAccount;
                DisplayAccList(tempDictAccount);//ATUALIZAR
                lastValueTransac++;
                ConfirmButton.Enabled = false;
            }
        }

        private void AcclistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTempData();
            TransacListView.Items.Clear();

            if (AcclistView.SelectedIndices.Count > 0)
            {
                Account anAcc = new Account();
                Dictionary<int, Transaction> tempDictTransac = new Dictionary<int, Transaction>();
                dictAccount.TryGetValue(Int32.Parse(AcclistView.SelectedItems[0].SubItems[0].Text), out anAcc);
                AccNumTextBox.Text = Convert.ToString(anAcc.AccNumber);
                CurrentBalancetextBox.Text = Convert.ToString(anAcc.Balance);
                tempDictTransac = anAcc.accTransactionDict;
                DisplayTransacList(tempDictTransac);
            }
        }

        public void DisplayTransacList(Dictionary<int, Transaction> tempDictTransaction)
        {
            TransacListView.Items.Clear();
            foreach (Transaction transac in tempDictTransaction.Values)
            {
                ListViewItem secItem = new ListViewItem(transac.TransNumber.ToString());
                secItem.SubItems.Add(Convert.ToString(transac.TransType));
                secItem.SubItems.Add(transac.AccNumber.ToString());
                secItem.SubItems.Add(Convert.ToString(transac.AccType));
                secItem.SubItems.Add(transac.Date.ToShortDateString());
                secItem.SubItems.Add("CAD" + transac.Amount.ToString());
                TransacListView.Items.Add(secItem);                
            }
        }

        public void DisplayAccList(Dictionary<int, Account> tempDictAcc)
        {
            AcclistView.Items.Clear();
            foreach (Account current in tempDictAcc.Values)
            {
                ListViewItem item = new ListViewItem(current.AccNumber.ToString());
                item.SubItems.Add(Convert.ToString(current.Acctype));
                item.SubItems.Add(current.OpenDate.ToShortDateString());
                item.SubItems.Add("CAD " + current.Balance);
                AcclistView.Items.Add(item);
                //dictTransaction.Add(current.TransNumber, current);
            }
        }

        public void UpdateTempData()
        {
            if (File.Exists(filePath1))
            {
                dictCustomer = CustomerDB.ReadFromFile();
            }
            if (File.Exists(filePath2))
            {
                dictAccount = AccountDB.ReadFromFile();
            }
            if (File.Exists(filePath3))
            {
                dictTransaction = TransactionDB.ReadFromFile();
            }
            if (File.Exists(filePath4))
            {
                sortedTransaction = TransactionDB.ReadFromFileSorted();
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            byte answer;
            answer = (byte)MessageBox.Show("Do you want to quit IBanking?", "Exit ?", MessageBoxButtons.YesNo);
            if (answer == 6)
            {
                this.Close();
            }
        }

        private void checkBoxDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDeposit.Checked)
                checkBoxWithdraw.Checked = false;
        }

        private void checkBoxWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxWithdraw.Checked)            
                checkBoxDeposit.Checked = false;
        }

        public void Reset()
        {
            checkBoxDeposit.Checked = false;
            checkBoxWithdraw.Checked = false;
            foreach (Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {

                    ((TextBox)guiControl).Clear();
                }

                if (guiControl is ListView)
                {
                    ((ListView)guiControl).Items.Clear();
                }
            }
            Dictionary<int, Customer> tempCustDict = new Dictionary<int,Customer>();
            Dictionary<int, Account> tempAccDict = new Dictionary<int,Account>();
            Dictionary<int, Transaction> tempTransacDict = new Dictionary<int,Transaction>();
            tempCustDict = CustomerDB.ReadFromFile();
            tempAccDict = tempCustDict[Int32.Parse(code)].customerAccount;
            foreach (Account current in tempAccDict.Values)
                {
                    Dictionary<int, Transaction> tempDictTransaction = new Dictionary<int, Transaction>();
                    tempDictTransaction = current.accTransactionDict;
                    foreach (Transaction transac in tempDictTransaction.Values)
                    {
                        tempTransacDict.Add(transac.TransNumber, transac);
                    }                    
                }
            DisplayAccList(tempAccDict);
            DisplayTransacList(tempTransacDict);
            ConfirmButton.Enabled = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        

    }
}
