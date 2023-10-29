using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace part1
{ public class Program
    {
        static void Main()
        {
            ExcelentPupil p1 = new ExcelentPupil();
            ExcelentPupil p2 = new ExcelentPupil();
            GoodPupil p3 = new GoodPupil();
            BadPupil p4 = new BadPupil();

            ClassRoom c1 = new ClassRoom(p1, p4);
            ClassRoom c2 = new ClassRoom(p2, p3, p4);
            ClassRoom c3 = new ClassRoom(p1, p2, p3, p4);

            c1.ClassRoom_Do();
            c2.ClassRoom_Do();
            c3.ClassRoom_Do();
        }

        public class ClassRoom
        {

            Pupil[] clas = new Pupil[4];

            public ClassRoom()
            {
                for (int i = 0; i < clas.Length; i++)
                {
                    clas[i] = new Pupil();
                }
            }
            public ClassRoom(params Pupil[] list)
            {
                for (int i = 0; i < clas.Length; i++)
                {
                    clas[i] = new Pupil();
                }
                for (int i = 0; i < list.Length; i++)
                {
                    clas[i] = list[i];
                }
            }
            public void ClassRoom_Do()
            {
                for (int i = 0; i < clas.Length; i++)
                {
                    Console.WriteLine($"This is pupil {i + 1}.");
                    clas[i].Study();
                    clas[i].Write();
                    clas[i].Read();
                    clas[i].Relax();
                    Console.WriteLine();
                }
            }
        }

        public class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine($"Bad Study");
            }
            public override void Read()
            {
                Console.WriteLine($"Bad Read");
            }
            public override void Write()
            {
                Console.WriteLine($"Bad Write");
            }
            public override void Relax()
            {
                Console.WriteLine($"Bad Relax");
            }
        }

        public class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine($"Good Study");
            }
            public override void Read()
            {
                Console.WriteLine($"Good Read");
            }
            public override void Write()
            {
                Console.WriteLine($"Good Write");
            }
            public override void Relax()
            {
                Console.WriteLine($"Good Relax");
            }
        }

        public class ExcelentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine($"Excelent Study");
            }
            public override void Read()
            {
                Console.WriteLine($"Excelent Read");
            }
            public override void Write()
            {
                Console.WriteLine($"Excelent Write");
            }
            public override void Relax()
            {
                Console.WriteLine($"Excelent Relax");
            }
        }

        public class Pupil
        {
            virtual public void Study()
            {
                Console.WriteLine($"Study");
            }
            virtual public void Read()
            {
                Console.WriteLine($"Read");
            }
            virtual public void Write()
            {
                Console.WriteLine($"Write");
            }
            virtual public void Relax()
            {
                Console.WriteLine($"Relax");
            }
        }
    }
}
    