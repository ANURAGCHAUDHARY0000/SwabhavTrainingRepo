using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace AccountSerialisationApp
{
    internal class AccountTest
    {
        static void Main(string[] args)
        {
           
            Account acc = new Account(101, "Krishna");
            acc.Deposit(100);
            //SerialiseAccount(acc);
            //DeSerialiseAccount();

            Account acc1 = new Account(102, "Anurag");
            Account acc2 = new Account(103, "Anu");
            Account [] accounts = new Account[3];
            accounts[0] = acc;
            accounts[1] = acc1;  
            accounts[2] = acc2;
            SerialiseAccountArray(accounts);
            DeserialiseAccountArray();

        }

        public static void SerialiseAccount(Account acc1)
        {
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\AccountSerialisationApp\AccountSerialisationApp\Write.txt", FileMode.Create);
            BinaryFormatter binaryObject = new BinaryFormatter();
            binaryObject.Serialize(fileStream, acc1);
            fileStream.Close();

        }

        public static void DeSerialiseAccount()
        {
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\AccountSerialisationApp\AccountSerialisationApp\Write.txt", FileMode.Open);
            BinaryFormatter binaryObject = new BinaryFormatter();
            Account acc2;
            acc2 = (Account)binaryObject.Deserialize(fileStream);
            fileStream.Close();
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc2.Name);
        }

        public static void SerialiseAccountArray(Account[] account)
        {
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\AccountSerialisationApp\AccountSerialisationApp\Write.txt", FileMode.Create);
            BinaryFormatter binaryObject = new BinaryFormatter();
            binaryObject.Serialize(fileStream, account);
            fileStream.Close();
        }


        public static void DeserialiseAccountArray()
        {
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\AccountSerialisationApp\AccountSerialisationApp\Write.txt", FileMode.Open);
            BinaryFormatter binaryObject = new BinaryFormatter();
            Account[] acc;
            acc = (Account[])binaryObject.Deserialize(fileStream);
            fileStream.Close();

            foreach (Account acc2 in acc)
            {
                Console.WriteLine(acc2);
            }
        }
    }
}
