using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingCorrecte
{
    public class Alumne
    {
        public String Nom { get; set; }
        public String Cognom { get; set; }

        public String Email { get; set; }
        public DateTime DataNaixement { get; set; }

        public Boolean Curset1 { get; set; }
        public Boolean Curset2 { get; set; }

        public Boolean Curset3 { get; set; }

        private bool _Horari_mati;
        private bool _Horari_tarda;
        public Boolean Horari_mati {

            get => _Horari_mati;
            set { 
                _Horari_mati = value;
                _Horari_tarda = !value;
            }
        }

        public Boolean Horari_tarda { 

        get => _Horari_tarda;
            set { 
                _Horari_mati = !value;
                _Horari_tarda = value;
            }
        }
public Alumne(string nom, string cognom, string email, DateTime dataNaixement, bool curset1, bool curset2, bool curset3, bool horari_mati, bool horari_tarda)
        {
            Nom = nom;
            Cognom = cognom;
            Email = email;
            DataNaixement = dataNaixement;
            Curset1 = curset1;
            Curset2 = curset2;
            Curset3 = curset3;
            Horari_mati = horari_mati;
            Horari_tarda = horari_tarda;
        }

       
     

    }


}
