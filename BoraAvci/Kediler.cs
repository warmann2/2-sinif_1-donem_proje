using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoraAvci
{
    internal class Kediler : Hayvanlar
    {
        private int kediyasi;

        public int Kediyasi
        {
            get { return kediyasi; }
            set { kediyasi = value; }
        }

       public string kediTüyRengi { get; set; }


    }
}
