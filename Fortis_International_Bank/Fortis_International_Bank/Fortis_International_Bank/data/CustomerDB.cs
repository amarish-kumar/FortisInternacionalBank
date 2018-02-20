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
    public static class CustomerDB
    {
        public static string filePath = @"CustomerDict1.ser";
        public static string filePath2 = @"CustomerSortedDict1.ser";

        public static void SaveToFile(Dictionary<int, Customer> custList)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (Customer current in custList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static void SaveToFile(SortedDictionary<int, Customer> custSortedDict)
        {
            FileStream fileStream = new FileStream(filePath2, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (Customer current in custSortedDict.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static Dictionary<int, Customer> ReadFromFile()
        {
            Dictionary<int, Customer> customerList = new Dictionary<int, Customer>();
            if (File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    Customer aCust = new Customer();
                    aCust = (Customer)binaryFormatter.Deserialize(fileStream);
                    customerList.Add(aCust.PersonId, aCust);
                }
                fileStream.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File empty", "File error");
                customerList = null;
            }
            return customerList;
        }

        public static SortedDictionary<int, Customer> ReadFromFileSorted()
        {
            SortedDictionary<int, Customer> custSortedDict = new SortedDictionary<int, Customer>();
            if (File.Exists(filePath2))
            {
                FileStream fileStream = new FileStream(filePath2, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    Customer aCust = new Customer();
                    aCust = (Customer)binaryFormatter.Deserialize(fileStream);
                    custSortedDict.Add(aCust.PersonId, aCust);
                }
                fileStream.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File empty", "File error");
                custSortedDict = null;
            }
            return custSortedDict;
        }

    }
}
