using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Araba
    {
        private string _marka;
        private string _model;
        private string _renk;
        private int _kapisayisi;

        // Sınıfın constructerı
        public Araba(string marka, string model, string renk, int kapisayisi)
        {
            _marka = marka;
            _model = model;
            _renk = renk;
            Kapisayisi = kapisayisi;
        }

        // Kapı sayısı özelliği
        public int Kapisayisi
        {
            get { return _kapisayisi; }
            set
            {
                if (value == 2 || value == 4)
                    _kapisayisi = value;
                else
                {
                    Console.WriteLine("Geçersiz kapı sayısı. Kapı sayısı -1 olarak ayarlandı.");
                    _kapisayisi = -1;
                }
            }
        }

        // Sınıfın bilgilerini yazdırmak için bir yöntem
        public void Bilgiler()
        {
            Console.WriteLine("\nArabanın Markası: " + _marka);
            Console.WriteLine("Arabanın Modeli: " + _model);
            Console.WriteLine("Arabanın Rengi: " + _renk);
            Console.WriteLine("Arabanın Kapı Sayısı: " + _kapisayisi);
        }
    }
}

