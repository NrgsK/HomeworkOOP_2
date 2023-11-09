using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nergis Ketenci
            Customer customer1 = new Customer();
            customer1.Name = "Nergis";
            customer1.LastName = "Ketenci";
            customer1.Id = 1;
            customer1.TCNo = "11111111111";
            customer1.CustomerNo = "12345";
            customer1.CompanyName = "?"; //Müşteri adı ile alakalı değil

            //Geçek Müşteri - Tüzel Müşteri
            //SOLID

            //Eğer bir veri üzerinde matematiksel herhangi bir işlem yapılmayacaksa verinin metinsel bir türde saklanması daha iyi olur.
            //**Eğer bir değer o nesneye ait değilmiş gibi duruyorsa soyutlama hatası yapıyorsun demektir.

            Console.ReadKey();
        }
    }
}
