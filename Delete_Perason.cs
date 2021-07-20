using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Delete_Perason
    {
        public void DeletetheName()
        {
            if (Add_New_ContactPerson.AddressBook.Count > 0)
            {
                Console.Write("Enter name of contact you want to delete: ");
                string deleteName = Console.ReadLine();


                foreach (var item in Add_New_ContactPerson.AddressBook)
                {
                    if (deleteName.ToLower() == item.FirstName.ToLower())
                    {
                        Add_New_ContactPerson.AddressBook.Remove(item);
                        Console.WriteLine(deleteName + "'s Contact is successfully deleted.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine(deleteName + " does not exist in Address Book.");
                    }
                }
            }

            else
            {
                Console.WriteLine("Address Book is empty.");
            }
        }
    }
}

