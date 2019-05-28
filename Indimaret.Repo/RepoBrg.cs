using Indimaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Indimaret.Repo
{
    public class RepoBrg
    {
        public static List<MBarang> GetAll()
        {
            List<MBarang> rst = new List<MBarang>();
            using (DatContext db = new DatContext())
            {
                rst = db.Master_Barangs.ToList();
            }
            return rst;
        }

        public static Boolean CreateBrg(MBarang barang)
        {
            try
            {
                using (DatContext db = new DatContext())
                {
                    db.Master_Barangs.Add(barang);
                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

        public static Boolean DeleteBrg(int ID)
        {
            try
            {
                MBarang take;
                using (DatContext db = new DatContext())
                {
                    take = db.Master_Barangs.Where(itm => itm.ID==ID).First();
                    db.Master_Barangs.Remove(take);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
     
        }

        public static MBarang GetID(int ID)
        {
            MBarang mbrg = new MBarang();
            using (DatContext db = new DatContext())
            {
                mbrg = db.Master_Barangs.Where(d => d.ID==ID).First();
                return mbrg;
            }
         }

        public static Boolean EditBrg(int ID)
        {
            try
            {
                MBarang change;
                using (DatContext db = new DatContext())
                {
                    change = db.Master_Barangs.Where(itm => itm.ID == ID).First();
                    db.Entry(change).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

    }
}
