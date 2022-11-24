using Ovelse_3_Pylomorfi__Icomparable;
using System;

namespace Ovelse_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(001, "- Alexander", " Runge ", new DateTime(2003, 08, 08));
            s1.Mellemnavn = " M.H ";


            Student s2 = new Student(002, "Thomas", "Jense  ", new DateTime(2001, 09, 02));
            s2.Mellemnavn = " M.H ";
            Student s3 = new Student(003, "- Alexander", " Runge ", new DateTime(2004, 10, 09));
            s3.Mellemnavn = " M.H ";

            Student s4 = new Student(004, "- Amanda", " Gudmand ", new DateTime(1999, 02, 08));
            s4.Mellemnavn = " Elisabeth Vang";
            Student s5 = new Student(005, "- Amanda ", " Gudmand ", new DateTime(1999, 02, 08));
            s5.Mellemnavn = " Elisabeth Vang ";
            Student s6 = new Student(006, "- Amanda ", " Gudmand ", new DateTime(1999, 02, 08));
            s6.Mellemnavn = " Elisabeth Vang";

            Student s7 = new Student(007, "- Denis", " Paaske ", new DateTime(2000, 10, 08));
            s7.Mellemnavn = " Daniel B";
            Student s8 = new Student(008, "- Denis", " Paaske ", new DateTime(2000, 10, 08));
            s8.Mellemnavn = " Daniel B";
            Student s9 = new Student(009, "- Denis", " Paaske ", new DateTime(2000, 10, 08));
            s9.Mellemnavn = " Daniel B";

            Student s10 = new Student(010, "- Ozan", " Korkmaz ", new DateTime(1997, 01, 01));
            Student s11 = new Student(011, "- Ozan", " Korkmaz ", new DateTime(1997, 01, 01));

            Student s12 = new Student(012, "- Camilla", "Kløjgaard ", new DateTime(1998, 02, 02));
            Student s13 = new Student(013, "- Camilla", "Kløjgaard ", new DateTime(1998, 09, 02));

            Teacher t1 = new Teacher(  1, "- Niels", " Olsen ", new DateTime(1996, 04, 01));
            Teacher t2 = new Teacher(10, "- Niels", " Olsen ", new DateTime(1996, 04, 01));
            Teacher t3 = new Teacher(20, "- Niels", " Olsen ", new DateTime(1996, 04, 01));

            Course fag1 = new Course(Subject.Studieteknik, t1);
            Course fag2 = new Course(Subject.Grprog, t2);
            Course fag3 = new Course(Subject.OOP, t3);
            try
            {

                Enrollment e1 = new();
                e1.Enrollments = new List<Enrollment>()
            {
                new Enrollment(s1,fag1),
                 new Enrollment (s2,fag2) ,
                  new Enrollment (s3,fag3) ,

                   new Enrollment (s4,fag1) ,
                    new Enrollment (s5,fag2) ,
                     new Enrollment (s6,fag3) ,

                      new Enrollment (s7,fag1) ,
                       new Enrollment (s8,fag2) ,
                        new Enrollment (s9,fag3) ,

                         new Enrollment (s10,fag2) ,
                          new Enrollment (s11,fag3) ,

                          new Enrollment (s12,fag2) ,
                          new Enrollment (s13,fag3) ,
                };

                e1.Enrollments.Sort();
                foreach (Enrollment e in e1.Enrollments)
                {
                    Console.WriteLine($"\n{e.StudentInfo.SudentID} {e.StudentInfo.FirstName}  {e.StudentInfo.LastName} {e.StudentInfo.Mellemnavn} {e.StudentInfo.DateOfBirth} Age :{e.StudentInfo.Age}, Fag : {e.CourseInfo.CourseName}{e.CourseInfo.Teacherinfo.FirstName}  {e.CourseInfo.Teacherinfo.LastName} Age: {e.CourseInfo.Teacherinfo.Age} ");

                };
                if (e1.Enrollments.Count < 8)
                {
                    throw new Exception("Det er ikke nok elever");
                }
                if (e1.Enrollments.Count > 16)
                {
                    throw new Exception("Det er for mange elver");
                }

                // s10.GetAge();   Age

                    s3.GetAllCourse(e1); 


                //     s5.GetStudentName(e1);
            //    s1.GetAllCourse(e1);


                Console.ReadLine();
            }

            catch(Exception ex) 
            {
            Console.WriteLine(ex.Message);
            }
           


            

        }


    }
}
