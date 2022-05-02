using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrall
{
    internal class Calculadora
    {
        public static int dateDiff(DateTime dateBegin, DateTime dateEnd)
        {
            TimeSpan tSpan = dateEnd - dateBegin;
            int days = tSpan.Days; 
            return days;
        }

        public static double energyDiff(double energyBegin, double energyEnd)
        {
            double energy;
            energy = energyEnd - energyBegin;
            return energy;
        }

        public static double energyReactDiff(double energyReactBegin, double energyReactEnd)
        {
            double energyReact;
            energyReact = energyReactEnd - energyReactBegin;
            return energyReact;
        }

        public static double factorPotencia(double energy, double energyReact)
        {
            double factorPot = energy / Math.Sqrt(Math.Pow(energy, 2) + Math.Pow(energyReact, 2)) * 100;
            return factorPot;
        }

        public static double bonificacion(double fP)
        {
            double bono = -((1 - 90 / fP) / 4);
            return bono;
        }

        public static double penalizacion(double fP)
        {
            double pena = -(3 * ((90 / fP) - 1) / 5);
            return pena;
        }

        public static double factorPotCargo(double fP)
        {
            /* Se evalua el factor de potencia para definir el cargo */
            double cargoFP;
            double bonificacion = Calculadora.bonificacion(fP);
            double penalizacion = Calculadora.penalizacion(fP);
            if (fP >= 90)
            {
                cargoFP = bonificacion;

            }
            else
            {
                cargoFP = penalizacion;
            }
            return cargoFP;
        }

        public static double potenciaElectricaMovil(double energyDiff, int dias, double acuerdoGdmto)
        {
            double potenciaMovil = energyDiff / (24 * dias * acuerdoGdmto);
            return potenciaMovil;
        }

        public static double potenciaDistribucion(double demanda, double potenciaMax)
        {
            /* Determinación de potencia eléctrica para distribución */
            double potDist = Math.Min(demanda, potenciaMax);
            return potDist;
        }

        public static double suministro(double cantidad, double suministroCargo)
        {
            double suministroResult = cantidad * suministroCargo;
            return suministroResult;
        }

        public static double distribucion(double potencia, double distribucionCargo)
        {
            double distribResult = potencia * distribucionCargo;
            return distribResult;
        }

        public static double transmision(double energy, double transmisionCargo)
        {
            double transmisionResult = energy * transmisionCargo;
            return transmisionResult;
        }

        public static double cenace(double energy, double cenaceCargo)
        {
            double cenaceResult = energy * cenaceCargo;
            return cenaceResult;
        }

        public static double energia(double energy, double generacion)
        {
            double energiaResult = energy * generacion;
            return energiaResult;
        }

        public static double capacidad(double potencia, double capacidadCargo)
        {
            double capacidadResult = potencia * capacidadCargo;
            return capacidadResult;
        }

        public static double sncnmem(double energy, double sncnmemCargo)
        {
            double sncnmemResult = energy * sncnmemCargo;
            return sncnmemResult;
        }
    }
}
