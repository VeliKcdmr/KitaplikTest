using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaplıkTest
{
    public class Kitap
    {
        int id;
        string ad;
        string yazar;

        public int Id { get { return id; } set { id = value; } }
        public string Ad { get { return ad; } set { ad = value; } }
        public string Yazar { get { return yazar; } set {   yazar = value; } }
    }
}
