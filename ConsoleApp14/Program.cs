using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass test = new SampleClass
            {
                Number1 = 3,
            };
            Console.WriteLine(test.Number1);
            TimePeriod tse = new TimePeriod { Hours = 13, };
            Console.WriteLine(tse.Hours);
            var person = new Person("maeda", "takahiro");
            Console.WriteLine(person.Name);
            var item = new SaleItem("shoes", 19.93m);
            Console.WriteLine($"{item.Name}: sells for{item.Price:C3}");
            var item2 = new SaleItems { Name = "shoes", Price = 19.982m };
            Console.WriteLine($"{item2.Name}: sells for{item2.Price:C2}");
            var shapes = new Shape { Height=32,Width=39 };
            Console.WriteLine(@"{0}:{1}:{2}:{3}", shapes.X,shapes.Y,shapes.Height,shapes.Width);
            shapes.Draw();
            var circ = new Circle();
            circ.Draw();
            var rec = new Rectangle();
            rec.Draw();
            var tri = new Triangle();
            tri.Draw();
            var shapew = new List<Shape>
            {
                new Rectangle(),new Triangle(),new Circle()
            };
            foreach(var sha in shapew)
            {
                sha.Draw();
            }
            Cats catdog = new Cats { Age = 43, Name = "tei"};
            Console.WriteLine(catdog.Age);
            animal ani = new animal();
            ani.Syubetu = "fe";
            Console.WriteLine(ani.Syubetu);
            ou an = new ou();
            an.Koumoku = "ffff";
            Console.WriteLine(an.koumoku);
            kyousitu ss = new kyousitu { Name = "ff", No = 3 };
            Console.WriteLine(ss.Name);
            Personsf ssa = new Personsf { Height = 322, Weight = 90 };
            Console.WriteLine(ssa.GetBMI());
            MagicalGirl nanoha = new MagicalGirl();
            nanoha.Name = "高町なのは";
            nanoha.MagicPower = 3580;
            BuchDerDunkelheit.Sammlung(nanoha);
            Console.ReadKey();
        }
    }
    public class SampleClass
    {
        private int _number1 = 0;
        public int Number1
        {
            get
            {
                return _number1;
            }
            set
            {
                _number1 = value;
            }
        }
    }
    public class TimePeriod
    {
        private double seconds;
        public double Hours
        {
            get { return seconds / 3600; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)}must be between 0 and 24.");
                }
                seconds = value * 3600;
            }
        }
    }
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string first,string last)
        {
            firstName = first;
            lastName = last;
        }
        public string Name => $"{firstName} {lastName}";
    }
    public class SaleItem
    {
        string name;
        decimal cost;

        public SaleItem(string name,decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public decimal Price
        {
            get => cost;
            set => cost = value;
        }
    }
    public class SaleItems
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Perfoming base class drawing tasks");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
    public class Cats
    {

        public int Age { get; set; }
        public string Name { get; set; }

    }
    public class animal : Cats
    {
        public string syubetu;
        public string Syubetu
        {
            get
            {
                return syubetu;
            }
            set
            {
                if (Age > 40)
                {
                    Console.WriteLine("適正値を確認してください。");
                }
                else
                {

                    syubetu = value;
                }
            }

        }
    }
    public class ou : animal
    {
        public string koumoku;
        public string Koumoku
        {
            get
            {
                return koumoku;
            }
            set
            {
                if (Syubetu =="")
                {
                    Console.WriteLine("適正値を確認してください。");
                }
                else
                {

                    koumoku = value;
                }
            }
        }
    }
    public class kyousitu
    {
        public int No { get; set; }
        public string Name { get; set; }
    }
    public class Personsf
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public double GetBMI()
        {
            if (Height == 0 || Weight == 0)
                throw new InvalidOperationException();

            return Weight / (Height * Height);
        }
    }
    public class MagicalGirl
    {
        public string Name { get; set; }
        public int MagicPower { get; set; }
    }
    public static class BuchDerDunkelheit
    {
        public static int PageCount { get; private set; }
        public static void Sammlung(MagicalGirl magicalGirl)
        {
            Console.WriteLine("集：" + magicalGirl.Name);
            int pages = magicalGirl.MagicPower / 100;
            PageCount += pages;
            magicalGirl.MagicPower -= pages * 100;
            Console.WriteLine("Geschrieben:" + pages + "pages");
        }
    }
    public class Data
    {

    }

}
