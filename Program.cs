using System;
using System.Collections;

namespace AddressBookCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact("1", "Rafa", "809-000-0000", "example@mail.com");
            Console.WriteLine(c1.Name);
        }
    }
}
