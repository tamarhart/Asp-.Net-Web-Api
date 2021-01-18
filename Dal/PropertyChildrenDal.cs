﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class PropertyChildrenDal
    {
        public static List<Class1> GetAllChildren()
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {

                List<string> Children = db.empGetChildIdSp().ToList();
                List<Class1> podto = new List<Class1>();
                foreach (string c in Children)
                    podto.Add(new Class1(c));
                return podto;
            }
        }
        public static string GetUser(string id)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {

                string name = db.empGetUserSp(id).FirstOrDefault();
                return name;
            }
        }
        public static string GetChild(string id)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                string pass = db.empGetChildSp(id).FirstOrDefault();
                return pass;
            }
        }
        public static Children Getallpropertyc(string id)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
               Children c = db.Children.Find(id);
                return c;
            }
        }
        public static bool AddChildren(Children ch)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                db.Children.Add(ch);
                db.SaveChanges();
                return true;
            }
            return true;
        }
        public static bool UpdateChildren(Children ch)
        {
            using (kindergardenEntities db = new kindergardenEntities())
            {
                Children f=db.Children.Find(ch.ChildId);
                db.Children.Remove(f);
                db.Children.Add(ch);
                db.SaveChanges();
                return true;
            }
            return true;
        }
    }
}
