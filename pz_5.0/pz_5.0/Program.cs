namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User u1 = new Employee() { Name = "Ivan" };
            //User u2 = (Employee)u1.Clone();
            //u1.Name = "Sergey";
            //Console.WriteLine(u1.Name + "|" + u2.Name);
            //Student st  = new Student() { Name = "Petr"};

            //ICloneable clone = u2;
            //clone = st;

            //ICloneable[] clones = {u1, u2, st };
            //foreach( ICloneable i in clones)
            //Console.WriteLine(i);  
            //Console.WriteLine(u1.Name +"|" + u2.Name);

            //u1 = (User)u2.Clone();
            //Console.WriteLine(u1.Name + "|" + u2.Name);


        }
    }
    internal class Employee
    {
        private string _fio;
        private DateTime _dataBith;
        private Post _post;

        public string FIO
        {
            get { return _fio; }
            set
            {
                if (value != null)
                    _fio = value;
                else Console.WriteLine("Incorrect data");
            }
        }
        public DateTime DataBith
        {
            get { return _dataBith; }
            set
            {
                if ((DateTime.Now - value).Days < 6570)
                    _dataBith = value;
                else Console.WriteLine("Incorrect data");
            }
        }
        public Post Post
        {
            get => _post; set => _post = value;
        }

        public override string ToString()
        {
            return new string($"ФИО: {FIO}\n" +
                $"Дата рождения: {DataBith.Year}.{DataBith.Month}.{DataBith.Day}\n" +
                $"Должность: {Post}");
        }
    }
    internal class Post
    {
        public string PostName { get; set; }


    }
    class Employee : ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            Employee temp = new Employee() { Name = this.Name };
            return temp;
        }
    }
}