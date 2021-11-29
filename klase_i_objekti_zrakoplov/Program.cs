using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti_zrakoplov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov zrakoplov1= new Zrakoplov("Airbus", 2000, 6000);
            
            Zrakoplov zrakoplov2= new Zrakoplov("Cessna Skycatcher", 75, 870);
            
            Zrakoplov zrakoplov3= new Zrakoplov("Pilatus", 1200, 1333);


            Console.WriteLine(zrakoplov1.ToString());
            Console.WriteLine(zrakoplov2.ToString());
            Console.WriteLine(zrakoplov3.ToString());


            Console.ReadKey();

        }

        class Zrakoplov
        {
            String naziv;
            double SnagaMotora;
            int DosegLeta;


            public override string ToString()
            {
                string ispis = "Naziv: " + this.getNaziv() + "\n"
                    + "Snaga motora: " + this.getSnagaMotora() + " kW\n"
                    + "Doseg leta: " + this.getDosegLeta() + " km\n";
                return ispis;
            }

            public Zrakoplov()
            {

            }

            public Zrakoplov(String naziv, double SnagaMotora, int DosegLeta)
            {
                this.naziv = naziv;
                this.SnagaMotora=SnagaMotora;
                this.DosegLeta=DosegLeta;
            }


            public void setNaziv(String naziv)
            {
                this.naziv=naziv;
            }

            public String getNaziv()
            {
                return this.naziv;
            }

            public void setSnagaMotora(double SnagaMotora)
            {
                this.SnagaMotora = SnagaMotora;
            }

            public double getSnagaMotora()
            {
                return this.SnagaMotora;
            }

            public void setDosegLeta(int DosegLeta)
            {
                this.DosegLeta = DosegLeta;
            }

            public int getDosegLeta()
            {
                return this.DosegLeta;
            }
        }
    }
}
