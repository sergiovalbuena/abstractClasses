using System;

namespace overview
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Person aPerson = new Person("12345", "Valbuena", "Sergio", 33);
            Student aStudent = new Student("88888", "Canwait", "Sally", "Computer Science", "s12345");
            //aPerson.LastName = "Ben"; //puede llamar a quien tiene get y SET
            //Console.WriteLine(aPerson.ToString());
            //Console.WriteLine(aPerson.GetSleepAmt());
            Console.WriteLine(aStudent);
            Console.WriteLine(aStudent.GetSleepAmt());
            //Console.WriteLine(aStudent.GetHobbies());
            Console.ReadKey();
        }
    }

    //abstract class.
    //we can instantiate an abstract class
  //  [access modifier] abstract returnType =

    public class Person
    {
        private string idNumber;
        protected string lastname;
        protected string firstName;
        private int age;

        public Person()
        {
        }

        public Person(string id, string lname, string fname, int anAge)
        {
            idNumber = id;
            lastname = lname;
            firstName = fname;
            age = anAge;
        }

        public Person(string id, string lname, string fname)
        {
            idNumber = id;
            lastname = lname;
            firstName = fname;
        }
        public Person(string id)
        {
            idNumber = id;

        }

        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }


        //Overriding Methods
        
        public override string ToString()
        {
            return firstName + " " + lastname + " " + this.GetType();
        }
        
        public virtual int GetSleepAmt()
        {
            return 8;
        }

        //public abstract string GetHobbies();


        
        
    }
    //end of person class

    public class Student : Person, ITraveler, ILearner
    {
        private string major;
        private string studentId;

        public Student() : base() { }

        public Student(string id, string fname, string lname, string maj, string sId)
            :base(id, fname, lname)
            {
                major = maj;
                studentId = sId;
            }

        public override int GetSleepAmt()
        {
            return 6;
        }

        public override string ToString()
        {
            return firstName + " " + lastname + " " + this.GetType() + major;
        }

        /*
        public override string GetHobbies()
        {
            return "sleeping";
        }
        */

        public string GetDestination()
        {
            return "here";
        }
        public string GetStartLocation()
        {
            return "here here";
        }
        public double DetermineKilometers()
        {
            return 45.6;
        }


        public string GetMajor()
        {
            return "Computer Science";
        }


    }


    interface ITraveler
    {
        string GetDestination();
        string GetStartLocation();
        double DetermineKilometers();
    }


    interface ILearner
    {
        string GetMajor();
    }
}
