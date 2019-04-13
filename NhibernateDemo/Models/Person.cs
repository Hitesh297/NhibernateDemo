using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NhibernateDemo.Models
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual string Full_Name { get; set; }
        public virtual Company Company { get; set; }
    }
}