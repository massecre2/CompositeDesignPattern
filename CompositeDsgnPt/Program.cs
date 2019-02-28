using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Design.Pattern
{
    //bu yapıya singleton yapı denilir.(Yegane tasarım deseni denilir)
    //Composite(Bileşik) tasarım deseni
    class CBilgisayar
    {
        public string _model;
        public int _uretimyili;

        public void Goster()
        {
            Console.WriteLine("Model        :" + _model);
            Console.WriteLine("Üretim Yılı  :" + _uretimyili);
        }

        private CBilgisayar()
        {

        }

        private static CBilgisayar nesne = new CBilgisayar();//bunu public yaparsak ve nesneVer' i silersek aşağıda sadece obje yerine CBilgisayar.nesne() diye 

        public static CBilgisayar nesneVer()
        {
            return nesne; 
        }
         
    }
    class Program
    {
        static void Main(string[] args)
        {
            CBilgisayar A = CBilgisayar.nesneVer();
            A._model = "Exper";
            A._uretimyili = 2015;
            Console.WriteLine("A Nesnesi ---------------");
            A.Goster();

            CBilgisayar B = CBilgisayar.nesneVer();
            B._model = "Casper";
            B._uretimyili = 2016;
            Console.WriteLine("B Nesnesi ---------------");
            B.Goster();

            A.Goster();

        }
    }

}
