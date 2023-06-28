using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace CodeSnippet.Models.Exercise
{
    public class Student
    {
        public String Name { get; set; }
        public String PhoneNumber { get; set; }

        public Student(String name, String phoneNumber) { 
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public class ExampleDictionary
        {
            public void Example()
            { 
                Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
                Student s1 = new Student("Ben", "123456789");
                Student s2 = new Student("Ben2", "123456789");

                studentDictionary.Add(1, s1);
                studentDictionary.Add(2, s2);

                Student result = new Student("", "");

                studentDictionary.TryGetValue(1, out result);
                //  branch1
            }

        }
    }
}