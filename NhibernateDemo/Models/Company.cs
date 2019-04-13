using System.Collections.Generic;

namespace NhibernateDemo.Models
{
    public class Company    
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Person> Persons { get; set; }
    }
}