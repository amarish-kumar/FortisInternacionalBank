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
    public static class TransactionDB
    {
        public static string filePath = @"TransactionDict1.ser";
        public static string filePath2 = @"SortedTransactionDict1.ser";

        public static void SaveToFile(Dictionary<int, Transaction> transList)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (Transaction current in transList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static void SaveToFile(SortedDictionary<int, Transaction> sortedTransList)
        {
            FileStream fileStream = new FileStream(filePath2, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (Transaction current in sortedTransList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static Dictionary<int, Transaction> ReadFromFile()
        {
            Dictionary<int, Transaction> transactionList = new Dictionary<int, Transaction>();
            if (File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    Transaction aTrans = new Transaction();
                    aTrans = (Transaction)binaryFormatter.Deserialize(fileStream);
                    transactionList.Add(aTrans.TransNumber, aTrans);
                }
                fileStream.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File empty", "File error");
                transactionList = null;
            }
            return transactionList;
        }

        public static SortedDictionary<int, Transaction> ReadFromFileSorted()
        {
            SortedDictionary<int, Transaction> transactionList = new SortedDictionary<int, Transaction>();
            if (File.Exists(filePath2))
            {
                FileStream fileStream = new FileStream(filePath2, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    Transaction aTrans = new Transaction();
                    aTrans = (Transaction)binaryFormatter.Deserialize(fileStream);
                    transactionList.Add(aTrans.TransNumber, aTrans);
                }
                fileStream.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File empty", "File error");
                transactionList = null;
            }
            return transactionList;
        }

    }
}
