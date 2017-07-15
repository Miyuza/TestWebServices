using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using webservices.Models;

namespace webservices.DBHelper
{
    public class DAL
    {
        public static List<person> get()
        {
            String q = "";
            List<person> lst = new List<person>();
            person p = null;
            q = String.Format("selest * from Test");
            using (DBHelper db = new DBHelper())
            {
                SqlDataReader dr =  db.ExecuteReader(q);
                while (dr.Read())
                {
                    p = new person();
                    p.id = dr.GetInt32(0);
                    p.name = dr.GetString(1);
                    lst.Add(p);
                }
            }
            return lst;
        }
        public static person get(int id)
        {
            String q = "";
            List<person> lst = new List<person>();
            person p = null;
            q = String.Format("selest * from Test where id = "+id);
            using (DBHelper db = new DBHelper())
            {
                SqlDataReader dr = db.ExecuteReader(q);
                if (dr.Read())
                {
                    p = new person();
                    p.id = dr.GetInt32(0);
                    p.name = dr.GetString(1);
                    
                }
            }
            return p;
        }
        public static void post(int id,String name)
        {
            String q = "";
            q = String.Format("insert into Test(id,name) values("+id+",'"+name+"')");
            using (DBHelper db = new DBHelper())
            {
                db.ExecuteQuery(q);
            }
        }
        public static void put(int id, String name)
        {
            String q = "";
            q = String.Format("update Test set name = '"+name+"' where id = "+id);
            using (DBHelper db = new DBHelper())
            {
                db.ExecuteQuery(q);
            }
        }
    }
}