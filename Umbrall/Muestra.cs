using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrall
{
    [Serializable]
    internal class Muestra
    {
        private String vrmsABC;
        private String irmsABC;
        public String pActiveABC;
        public String cosFiABC;
        public String energyABC;

        public Muestra(string vrmsABC, string irmsABC, string pActiveABC, string cosFiABC, string energyABC)
        {
            this.vrmsABC = vrmsABC;
            this.irmsABC = irmsABC;
            this.pActiveABC = pActiveABC;
            this.cosFiABC = cosFiABC;
            this.energyABC = energyABC;
        }


        public String VrmsABC
        {
            get { return vrmsABC; }
            set { vrmsABC = value; }
        }

        public String IrmsABC
        {
            get { return irmsABC; }
            set { irmsABC = value; }
        }

        public String PActiveABC
        {
            get { return pActiveABC; }
            set { pActiveABC = value; }
        }

        public String CosFiABC
        {
            get { return cosFiABC; }
            set { cosFiABC = value; }
        }

        public String EnergyABC
        {
            get { return energyABC; }
            set { energyABC = value; }
        }
        
        public int Guardar()
        {
            try
            {
                using(System.Windows.Forms.SaveFileDialog dialogo = new System.Windows.Forms.SaveFileDialog())
                {
                    if (dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (Stream st = File.Open(dialogo.FileName, FileMode.Create))
                        {
                            var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                            binfor.Serialize(st, this);
                            return 0;

                        }
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                return 2;
            }
        }
    }
}
