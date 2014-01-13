using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newman.Model;

namespace Newman.Newman.Model
{
    public class Data
    {
        public static IEnumerable<Email> GetAll()
        {
            var data = new List<Email>();
            data.Add(new Email(){Id=1,Body="{{test}}",Name="welcome", Subject = "welcome", ToAddress="dallas@example.com"});
            return data;
        }

        public static Email GetById(int id)
        {
            return GetAll().Where(p => p.Id == id).FirstOrDefault();
        }
    }
}