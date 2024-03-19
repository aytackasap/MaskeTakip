using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {


            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 1;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }




    }
}

