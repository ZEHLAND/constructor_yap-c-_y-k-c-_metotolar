using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_yapıcı_yıkıcı_metotolar
{
    class bilgi
    {
        string ad;
        string soyad;
        int yas;
        char cinsiyet;
        string sehir;
        public string AD
        {
            get
            {
                return ad;
            }
            set
            {
               ad = value.ToLower();//ToUpper() büyük yazma/ToLower() kücük yazma 
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set {  soyad = value.ToUpper();  }
        }
        public string MEMLEKET
        {
            get { return sehir; }
            set { sehir= value; }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }

        }
        public char CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        public bilgi()
        {
            ad = "";
            soyad = "";
            yas = 18;
            cinsiyet = 'k';
            sehir = "SİVAS";
        }
      
        
    }
    
}
