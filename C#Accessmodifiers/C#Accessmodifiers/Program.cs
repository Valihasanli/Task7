using System.Text.RegularExpressions;

namespace C_Accessmodifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {   int studentlimit;
            string no;
            do
            {
               Console.WriteLine("max telebe sayini daxil edin:");
               studentlimit = int.Parse(Console.ReadLine());
            }
            while (!(studentlimit > 0 && studentlimit <= 20));
            do
            {
                Console.WriteLine("Qrup nomresi daxil et");
                no = Console.ReadLine();
            }
            while(! (no[0]>='A'&& no[0]<='Z'&& no[1] >= 'A' && no[1] <= 'Z' && no[2] >= '0' && no[2]<= '9' && no[3] >= '0' && no[3] <= '9' && no[4] >= '0' && no[4] <= '9'));

            Group group = new Group(no, studentlimit);
            //Console.WriteLine(group.AddStudent(A));
            bool check = true;
           
            while(check)
            {
                Console.WriteLine("1. Student əlavə et" +
                             "\n2. Bütün tələbələrə bax" +
                             "\n3. Fullname  axtarış et" +
                             "\n0. Proqramı bitir");

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":

                        Console.WriteLine("FullName daxil et");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("GroupNo daxil et");
                        string groupno = Console.ReadLine();
                        string avgstr;
                        double avgpoint;
                        do
                        {
                            Console.WriteLine("AvgPoint daxil et:");
                            avgstr = Console.ReadLine();
                        } while (!double.TryParse(avgstr, out avgpoint) && avgpoint >= 0);
                        Student student = new Student(fullname, groupno, avgpoint);
                        Console.WriteLine(group.AddStudent(student));
                        break;
                    case "2":
                        group.ShowAllStudents();
                        break;
                    case "3":
                        char A;
                        string Astr;
                        do
                        {
                            Console.WriteLine("axtarilan simvolu daxil et");
                            Astr = Console.ReadLine();
                        }
                        while (!char.TryParse(Astr, out A));
                        Student [] resultSt = group.Filtered(A);
                        foreach (var st in resultSt)
                        {
                            Console.WriteLine(st.ShowInfo());
                        }
                        
                        break;
                    case "0":
                        check = false;
                        break;

                    default: Console.WriteLine("duzgun sechim et"); break;


                }
            }


        }
    }
   
    
}
