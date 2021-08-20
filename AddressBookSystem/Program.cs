using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Bharath", "Pasumarthi", "Kunkalamarru", "Karamchedu", "AP", "bharathmighty248@gmail.com", 523168, 8498017061);
            addressBook.ViewContact();
        }
    }
}
