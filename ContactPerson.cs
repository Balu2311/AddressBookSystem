using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class ContactPerson
	{ 
		public String FirstName;
		public String LastName;
		public String Address;
		public String City;
		public String State;
		public String Zip;
		public String PhoneNumber;
		public String Email;

        public ContactPerson()
        {
        }

        public ContactPerson(string firstName, string lastName, string address, string state, string contact, string zip)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            State = state;
            Zip = zip;
        }

        public ContactPerson(String FirstName, String LastName, String Address, String City, String State, String PhoneNumber, String Zip, String Email)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Address = Address;
			this.PhoneNumber = PhoneNumber;
			this.State = State;
			this.Zip = Zip;
			this.City = City;
			this.Email = Email;
		}
		public void print()
		{
			Console.WriteLine(FirstName + " \t  " + LastName + " \t  " + Address + " \t  " + City +" \t" + State + " \t  " + PhoneNumber + " \t " + Zip + " \t" +Email); 
		}
	}
}
