using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl
{
  public  class PropertyChildrenBl
    {
        public static List<Dal.Class1> GetAllChildren()
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {

                List<Dal.Class1> Children = PropertyChildrenDal.GetAllChildren();
                return Children;

            }
        }
        //public static bool checkID(string id)
        //{
        //    int sum = 0;
        //    bool odd = true;
        //    int temp = 0;

        //    for (int i = 0; i < 9; i++)
        //    {
        //        odd = !odd;

        //        temp = (id % 10) * ((odd ? 1 : 0) + 1);

        //        sum += temp % 10;
        //        if (temp > 10)
        //        {
        //            sum++;
        //        }
        //     //   Console.WriteLine("Digit: " + id % 10 + " ID res= " + id + " odd is: " + ((odd ? 1 : 0) + 1) + " temp: " + temp + " sum= " + sum);
        //        id /= 10;

        //    }

        //    if (sum % 10 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static string GetChild(string id)
        //{
        //    using (KindergardenEntities db = new KindergardenEntities())
        //    {
        //        string pass = (from o in db.Connections where o.UserId.Contains(id) select o.ChildId).FirstOrDefault();
        //        return pass;
        //    }
        //}
        public static string GetChild(string id)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                string pass = PropertyChildrenDal.GetChild(id);
                return pass;
            }
        }
        public static Children Getallpropertyc(string id)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                Children pass = PropertyChildrenDal.Getallpropertyc(id);
                return pass;
            }
        }
        public static bool Addtimecoming(string id)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                // ArrivalChildren p = db.ArrivalChildrens.Find(id);
                //db.ArrivalChildrens.Remove(p);
                Children c=null;
                c=db.Children.Find(id);
                if (c!=null)
                {
                    ArrivalChildren p1 = new ArrivalChildren();
                    p1.ChildId = id;
                    p1.Date = DateTime.Today;
                    p1.ArrivalTime = DateTime.Now.TimeOfDay;
                    db.ArrivalChildren.Add(p1);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            
        }
        public static bool AddChildren(PropertyChildrenDto ch)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                bool id=false;
                Children poDal = PropertyChildrenDto.ToDal(ch);
                if(poDal.ChildId!=null && poDal.ChildClass!=null && poDal.ChildGroup!=null && poDal.ChildName!=null)
                    id = PropertyChildrenDal.AddChildren(poDal); 
                return id;

            }
            return false;
        }
        public static bool UpdateChildren(PropertyChildrenDto ch)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                bool id = false;
                Children poDal = PropertyChildrenDto.ToDal(ch);
                if (poDal.ChildId != null && poDal.ChildClass != null && poDal.ChildGroup != null && poDal.ChildName != null)
                    id = PropertyChildrenDal.UpdateChildren(poDal);
                return id;

            }
            return false;
        }
        //public static string GetUser(string id)
        //{
        //    using (KindergardenEntities db = new KindergardenEntities())
        //    {
        //        string name = (from o in db.Users where o.Password.Contains(id) select o.UserName).FirstOrDefault();
        //        return name;
        //    }
        //}
        public static string GetUser(string id)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                string name = PropertyChildrenDal.GetUser(id);
                if(name!=null)
                return "Welcome "+name+ " To enter press on your child picture";
                return name;
            }
        }

        //           public static bool Addtimecoming(string id)
        //{
        //    using (KindergardenEntities db = new KindergardenEntities())
        //    {
        //        PropertiesOwner p = db.PropertiesOwners.Find(id);
        //        p.status = false;
        //        db.SaveChanges();
        //        return true;
        //    }
        //}

    }
}