using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBeLifeEntity
{
    public class Tarificador
    {
        public DateTime FechaNacimiento { get; set; }
        public int Sexo { get; set; }
        public int EstadoCivil { get; set; }



        public void CalcularPremisa(double Base) {




        }


        public Tarificador() {
            this.Inicializar();
        }

        private void Inicializar() {
            this.FechaNacimiento = DateTime.Today;
            this.Sexo = 0;
            this.EstadoCivil = 0;
        }







        /*
        public String Sexo
        {
            get {
                switch (_sexo)
                {
                    case 0:
                        return "Mujer";
                    case 1:
                        return "Hombre";
                    default:
                        return String.Empty;
                }
            }
            set {
                if (value.Equals("mujer", StringComparison.OrdinalIgnoreCase))
                {
                    _sexo = 0;
                }
                else if (value.Equals("hombre", StringComparison.OrdinalIgnoreCase))
                {
                    _sexo = 1;
                } else { _sexo = 0; }

            }
        }
        public String EstadoCivil { get; set; }
        //Cliente._sexo = 1;
        */

    }
}
