using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HepsiSurada
{
    abstract class Odeme : Siparis
    {
        
        public static double OdenecekTutar { get; set; }
        public int onay;
        public abstract void Ode(double Tutar);
    }
}
