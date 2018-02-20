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
    public partial class InitialForm : Form
    {
        public string managerID = "0001";
        public string managerPIN = "1234";
        public int personId;
        string filePath1 = CustomerDB.filePath;
        Dictionary<int, Customer> dictCustomer = new Dictionary<int, Customer>();

        public InitialForm()
        {
            InitializeComponent();
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void managerButton_Click(object sender, EventArgs e) //Manager
        {
            string manID = IDmaskedTextBox.Text;
            string manPIN = PINtextBox.Text;
            if (manID == managerID)
            {
                if (manPIN == managerPIN)
                {
                    CreateCustomer createCust = new CreateCustomer();
                    createCust.Show();
                }
                else
                {
                    MessageBox.Show("Wrong PIN", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Manager does not exist! Error");
            }                        
        }

        private void buttonExit_Click(object sender, EventArgs e) //Exit
        {
            byte answer;
            answer = (byte)MessageBox.Show("Do you want to quit the application?", "Exit ?", MessageBoxButtons.YesNo);
            if (answer == 6)
            {
                this.Close();
            }
        }

        private void customerButton_Click(object sender, EventArgs e) //Customer
        {
            Customer aCustomer = null;
            if (File.Exists(filePath1))
            {
                dictCustomer = CustomerDB.ReadFromFile();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Database not found", "ERROR");
            }
            //If validates.
            int pin = Int32.Parse(PINtextBox.Text);
            personId = Int32.Parse(IDmaskedTextBox.Text);
            dictCustomer.TryGetValue(personId, out aCustomer);
            if (aCustomer != null)
                if (aCustomer.Pin == pin)
                {
                    BalanceInquiry balance = new BalanceInquiry(Convert.ToString(personId));
                    balance.Show();
                }
                else
                {
                    MessageBox.Show("Wrong PIN", "ERROR");
                }
            else
                MessageBox.Show("Customer not found! Error");            
        }
    }
}
