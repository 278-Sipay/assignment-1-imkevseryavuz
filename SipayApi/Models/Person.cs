using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace SipayApi
{
    public class Person
    {
        private Person person;

        //Constructor
        public Person(Person person)
        {
            this.Id = person.Id;
            this.Name = person.Name;
            this.Lastname = person.Lastname;
            this.Phone = person.Phone;
            this.AccessLevel = person.AccessLevel;
            this.Salary = person.Salary;
        }

        public Person()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public int AccessLevel { get; set; }
        public decimal Salary { get; set; }


    }
    
}
