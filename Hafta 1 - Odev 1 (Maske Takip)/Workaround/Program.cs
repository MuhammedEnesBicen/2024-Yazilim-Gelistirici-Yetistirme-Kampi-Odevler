using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {


            System.Console.WriteLine("Bu sistem ile bilgileri girilen vatandaşın bilgileri MERNİS' ten kontrol edilerek maske verilip verilemeyeceği kontrol edilir. \n");

            Person person1 = CreatePerson();

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        public static Person CreatePerson()
        {
            Console.WriteLine("Size maske verilebilmesi için Adınızı giriniz:");
            Person person = new Person();
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz:");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Doğum yılınızı giriniz:");
            person.DateOfBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("TC kimlik numaranızı giriniz:");
            person.NationalIdentity = Convert.ToInt64(Console.ReadLine());
            return person;
        }
    }

}
