using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Fortis_International_Bank.business;

namespace Fortis_International_Bank.data
{
    public static class AccountDB
    {
        public static string filePath = @"AccountDict1.ser";
        public static string filePath2 = @"SortedAccountDict1.ser";

        public static void SaveToFile(Dictionary<int, Account> accList)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (Account current in accList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static void SaveToFile(SortedDictionary<int, Account> accSortedList)
        {
            FileStream fileStream = new FileStream(filePath2, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (Account current in accSortedList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }


        public static Dictionary<int, Account> ReadFromFile()
        {
            Dictionary<int, Account> accountList = new Dictionary<int, Account>();
            if (File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    Account aAcc = new Account();
                    aAcc = (Account)binaryFormatter.Deserialize(fileStream);
                    accountList.Add(aAcc.AccNumber, aAcc);
                }
                fileStream.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File empty", "File error");
                accountList = null;
            }
            return accountList;
        }

        public static SortedDictionary<int, Account> ReadFromFileSorted()
        {
            SortedDictionary<int, Account> sortedAccountList = new SortedDictionary<int, Account>();
            if (File.Exists(filePath2))
            {
                FileStream fileStream = new FileStream(filePath2, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    Account aAcc = new Account();
                    aAcc = (Account)binaryFormatter.Deserialize(fileStream);
                    sortedAccountList.Add(aAcc.AccNumber, aAcc);
                }
                fileStream.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File empty", "File error");
                sortedAccountList = null;
            }
            return sortedAccountList;
        }

    }
}
