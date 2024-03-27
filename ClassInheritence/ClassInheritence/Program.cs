namespace ClassInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student nicat = new Student();
            nicat.Name= "Nicat";
            nicat.Surname = "Aliyev";
            nicat.Group = "AP100";
            nicat.Point = 75;
            //Console.WriteLine($"{nicat.Group}-{nicat.Name} {nicat.Surname} {nicat.Point}bal");
            //nicat.Getİnfo();
            //nicat.CheckGraduation();
            //nicat.GetDiplomDegree();


        }
    }
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;


        //public Student(string name, string surname, string group, byte point)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Group = group;
        //    Point = point;
        //}

        public void Getİnfo()
        {
            Console.WriteLine($"{Group}-{Name} {Surname} {Point}bal");
        }

        public void CheckGraduation()
        {
            if (isGraduated==true)
            {
                Console.WriteLine("Graduated");
            }
            else
            {
                Console.WriteLine("Not a graduate");
            }
        }

        public void GetDiplomDegree()
        {
            if(Point<65)
            {
                Console.WriteLine("No Diploma");
            }
            if (65<=Point && Point>=80)
            {
                Console.WriteLine("Ordinary Diploma");
            }
            if (80 <= Point && Point >= 90)
            {
                Console.WriteLine("Honor Diploma");
            }
            else
            {
                Console.WriteLine("High Honor Diploma");
            }
        }
    }
}