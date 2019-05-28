using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    public class Initializer : DropCreateDatabaseAlways<DatContext>
    {
        protected override void Seed(DatContext context)
        {
            List<MBarang> brg = new List<MBarang>();
            brg.Add(new MBarang { TokoID = 1, KdBarang = "KB0001", NmBarang = "Paracetamol", AslPabrik = "Jawa Timur", JmlBarang = 30, LmKadaluarsa = 21 });

            foreach(MBarang item in brg)
            {
                context.Master_Barangs.Add(item);
            }
            base.Seed(context);
        }
    }
}
