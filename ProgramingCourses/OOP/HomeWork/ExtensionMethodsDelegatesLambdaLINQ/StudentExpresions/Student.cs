﻿namespace StudentExpresions
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Age + "-years-old";
        }
    }
}
