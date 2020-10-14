using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class ContactManager
    {
        public List<Contact> Contacts;
        public ContactManager()
        {
            Contacts = new List<Contact>();
        }

        public void List()
        {
            if (Contacts.Count == 0)
            {
                Console.WriteLine("You don't have any contacts!");
            }
            else
            {
                Console.WriteLine("Your contacts: ");

                Contacts.Sort(delegate(Contact contact1, Contact contact2)
                { return contact1.Name.CompareTo(contact2.Name); });
                foreach (var c in Contacts)
                {
                    Console.WriteLine("{0}, {1},{2}", c.Name, c.Surname, c.Phone);
                }
            }
        }
        public void Add()
        {

            Console.WriteLine("Enter the name of the contact: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the surname of the contact:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter the phone of the contact:");
            string phone = Console.ReadLine();
            Contact contact = new Contact(name, surname, phone);

           Contact existingContact = Contacts.Find(c => c.Name == name && c.Surname == surname);
            if (existingContact == null)
            {
                Contacts.Add(contact);
                Console.WriteLine("Contact added - {0} {1} {2}", name, surname, phone);
            }
            else
            {
                Console.WriteLine("Contact already exists - {0} {1} {2}", name, surname, phone);
            }

        }
    

        public void Delete()
        {
            Console.WriteLine("Enter the name of the contact:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the surname of the contact:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter the phone of the contact:");
            string phone = Console.ReadLine();
            Contact contact = new Contact(name, surname, phone);
           contact = Contacts.Find(e => e.Name == name && e.Surname == surname);
            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                Contacts.Remove(contact);
                Console.WriteLine("Contact removed - {0} {1}.", name, surname);
            }
        }
    }
        }
    

    

