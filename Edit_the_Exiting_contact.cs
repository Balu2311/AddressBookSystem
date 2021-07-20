using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Edit_the_Exiting_contact
    {
        public void EditUsingName()
        {
            if (Add_New_ContactPerson.AddressBook.Count > 0)
            {
                Console.Write("Enter Name of the contact you want to edit: ");
                string EditDetails = Console.ReadLine();



                foreach (var item in Add_New_ContactPerson.AddressBook)
                {
                    if (EditDetails.ToLower() == item.FirstName.ToLower())
                    {
                        Console.WriteLine("\nChoice what you want to edit\n 1.First name\n2.Last name\n3.Address" +
                            "\n4.City\n5.State\n6.Zip Code\n7.Phone Number\n8.Email");

                        int EditChoice = int.Parse(Console.ReadLine());

                        switch (EditChoice)
                        {
                            case 1:
                                Console.Write("Enter new First Name: ");
                                item.FirstName = Console.ReadLine();
                                break;

                            case 2:
                                Console.Write("Enter new Last Name: ");
                                item.LastName = Console.ReadLine();
                                break;

                            case 3:
                                Console.Write("Enter Your new Address: ");
                                item.Address = Console.ReadLine();
                                break;

                            case 4:
                                Console.Write("Enter Your new City Name: ");
                                item.City = Console.ReadLine();
                                break;

                            case 5:
                                Console.Write("Enter new State Name: ");
                                item.State = Console.ReadLine();
                                break;

                            case 6:
                                while (true)
                                {
                                    Console.Write("Enter new Zip Code: ");
                                    string code = Console.ReadLine();

                                    if (code.Length == 6)
                                    {
                                        item.Zip = code;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid 6 digit Zip Code.");
                                    }
                                }
                                break;

                            case 7:
                                while (true)
                                {
                                    Console.Write("Enter Your new Phone Number: ");
                                    string number = Console.ReadLine();

                                    if (number.Length == 10)
                                    {
                                        item.PhoneNumber = number;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid 10 digit Phone Number.");
                                    }
                                }
                                break;

                            case 8:
                                while (true)
                                {
                                    Console.Write("Enter Your new Email Address: ");
                                    string mail = Console.ReadLine();

                                    if (mail.Contains("@"))
                                    {
                                        item.Email = mail;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid Email Address.");
                                    }
                                }
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("{0} does not exists in Address Book.", EditDetails);
                    }
                }
            }
        }
    }
}

