﻿using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook address = new AddressBook();
            while (true)
            {
                Console.WriteLine("Enter Option \n1) Add Contact ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.AddContact();
                        break;
                        /*case 2:
                            address.Display();
                            break; */
                }
            }
        }
    }
}
