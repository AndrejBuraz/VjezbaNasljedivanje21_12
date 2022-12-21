using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaNasljedivanjePolimorfizam21_12
{

    class Dessert
    {
        private string name;
        private double weight;
        private int calories;

        public Dessert(string name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }

        public Dessert()
        {
        }

        public string GetDessertType()
        {
            return ("dessert");
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }

        public override string ToString()
        {
            string ispis=  ("Ime deserta: " + this.name + "\ntežina: " + this.weight + "\nkalorije: " + this.calories);
            return ispis;
        }
    }

    class Cake : Dessert
    {
        Boolean containsGluten;
        string cakeType;

        public Cake(bool containtsGluten, string cakeType, string name, double weight, int calories) : base(name, weight, calories)
        {
            this.containsGluten = containtsGluten;
            this.cakeType = cakeType;
        }

        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }

        public string getDessertType()
        {
            return ("cake");
        }
        public override string ToString()
        {
            return (base.ToString() + "\nsadrži gluten: " + this.containsGluten + "\nvrsta torte: " + this.cakeType);
        }

    }

    class IceCream : Dessert
    {
        string flavour, color;

        public IceCream(string flavour, string color, string name, double weight, int calories) : base(name, weight, calories)
        {
            this.flavour = flavour;
            this.color = color;
        }

        public string Flavour { get => flavour; set => flavour = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return (base.ToString() + "\nokus: " + this.flavour + "\nboja: " + this.color);
        }
        public string getDessertType()
        {
            return ("ice cream");
        }
    }

    class Person
    {
        string name, surname;
        int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return ("Ime: "+ this.name + "\nprezime: "+this.surname + "\ngodine: "+this.age);
        }

        public bool Equals(int age1, int age2, string name1, string name2, string surname1, string surname2)
        {
            if(age1 == age2 && name1 == name2 && surname1 == surname2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Student : Person
    {
        string studentID;
        short academicYear;

        public Student(string studentID, short academicYear, string name, string surname, int age) : base(name, surname, age)
        {
            this.studentID = studentID;
            this.academicYear = academicYear;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public short AcademicYear { get => academicYear; set => academicYear = value; }

        public override string ToString()
        {
            return (base.ToString() + "\nstudent ID: " + this.studentID + "\nakademska godina: "+ this.academicYear);
        }

        public bool Equals(string studentID1, string studentID2)
        {
            if(studentID1 == studentID2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Teacher : Person
    {
        string email, subject;
        double salary;

        public Teacher(string email, string subject, double salary, string name, string surname, int age) : base(name, surname, age)
        {
            this.email = email;
            this.subject = subject;
            this.salary = salary;
        }

        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return (base.ToString() + "\nemail: " + this.email + "\npredmet: " + this.subject + "\nplaća: " + this.salary);
        }

        public bool Equals( string email1, string email2)
        {
            if(email1 == email2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void increaseSalary(int postotak)
        {
            this.salary += (this.salary * (postotak/100));
        }

        static void increaseSalary(int postotak, Teacher ucitelj)
        {
            ucitelj.salary += (ucitelj.salary * (postotak / 100));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dessert desert = new Dessert("tiramisu", 88.4, 2);
            Console.WriteLine(desert.ToString());
            IceCream sladoled = new IceCream("vanilija","bijeli", "sladoled", 92.2, 4);
            Console.WriteLine(sladoled.ToString());
            Cake torta = new Cake(false, "torta", "mađarice", 132.3, 52);
            Console.WriteLine(torta.ToString());

            Console.ReadKey();
        }
    }
}
