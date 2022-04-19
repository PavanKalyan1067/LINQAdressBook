using System;

namespace LINQ_AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ AddressBookSystem!");
            //Create Object for DataTable
            ContactDataManager contactDataManager = new ContactDataManager();
            ContactDataManager contactDataManagers = new ContactDataManager();
            DataTableManager dataTableManger = new DataTableManager();
            dataTableManger.CreateDataTable();

            //Insert Values into Table
            contactDataManager.FirstName = "Pavan";
            contactDataManager.LastName = "Yadav";
            contactDataManager.PhoneNumber = 9805005050;
            contactDataManager.Email = "abc@gmail.com";
            contactDataManager.Address = "4,B Block,Hyd";
            contactDataManager.City = "Hyd";
            contactDataManager.State = "TS";
            contactDataManager.zip = 500072;
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.FirstName = "Abc";
            contactDataManagers.LastName = "Efg";
            contactDataManagers.PhoneNumber = 7705005050;
            contactDataManagers.Email = "bca@gmail.com";
            contactDataManagers.Address = "sasthri street,Hyd";
            contactDataManagers.City = "Hyd";
            contactDataManagers.State = "TS";
            contactDataManagers.zip = 123001;
            dataTableManger.InsertintoDataTable(contactDataManagers);
            dataTableManger.Display();

            //Modify
            int varl = dataTableManger.EditDataTable("Yadav", "Lastname");
            Console.WriteLine("Success" + varl);
        }
    }
}