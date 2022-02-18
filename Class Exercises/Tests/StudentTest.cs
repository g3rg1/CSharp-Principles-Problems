using System;

namespace Classes.Tests
{
    class StudentTest
    {
        private int studentCount = 0;
        private Random rng = new Random();
        private static Student statStud = null;
        private static Student statStud1 = null;
        private static Student statStud2 = null;
        public static Student StatStud
        {
            get => statStud;
            set => statStud = value;
        }
        public static Student StatStud1
        {
            get => statStud1;
            set => statStud1 = value;
        }
        public static Student StatStud2
        {
            get => statStud2;
            set => statStud2 = value;
        }
        public StudentTest()
        {

        }
        public StudentTest(int StudentCount)
        {
            this.studentCount = StudentCount;
        }
        private string GetName()
        {
            int seed = rng.Next(-1, 9);
            int seed2 = rng.Next(-1, 9);
            string firstname = "";
            string lastname = "";
            string fullname = "";
            switch (seed)
            {
                case 0:
                    {
                        firstname = "Archimedes";
                    }
                    break;
                case 1:
                    {
                        firstname = "Socrates";
                    }
                    break;
                case 2:
                    {
                        firstname = "Hieronimous";
                    }
                    break;
                case 3:
                    {
                        firstname = "Karl";
                    }
                    break;
                case 4:
                    {
                        firstname = "Arcadius";
                    }
                    break;
                case 5:
                    {
                        firstname = "Isaac";
                    }
                    break;
                case 6:
                    {
                        firstname = "George";
                    }
                    break;
                case 7:
                    {
                        firstname = "Tobias";
                    }
                    break;
                case 8:
                    {
                        firstname = "Chun";
                    }
                    break;
                case 9:
                    {
                        firstname = "Benoir";
                    }
                    break;
            }
            switch (seed2)
            {
                case 0:
                    {
                        lastname = "Mongous";
                    }
                    break;
                case 1:
                    {
                        lastname = "Sharpus";
                    }
                    break;
                case 2:
                    {
                        lastname = "Ipsus";
                    }
                    break;
                case 3:
                    {
                        lastname = "Javius";
                    }
                    break;
                case 4:
                    {
                        lastname = "McCennzie";
                    }
                    break;
                case 5:
                    {
                        lastname = "Georgiev";
                    }
                    break;
                case 6:
                    {
                        lastname = "Chen";
                    }
                    break;
                case 7:
                    {
                        lastname = "Uzumaki";
                    }
                    break;
                case 8:
                    {
                        lastname = "Patterson";
                    }
                    break;
                case 9:
                    {
                        lastname = "Eastwood";
                    }
                    break;
            }
            fullname += firstname + " " + lastname;
            return fullname;
        }
        private int GetYear()
        {
            int seed = rng.Next(0, 5);
            return seed;
        }
        private string GetSpecialty()
        {
            int seed = rng.Next(-1, 9);
            string specialty = "";
            switch (seed)
            {
                case 0:
                    {
                        specialty = "Particle Physics";
                    }
                    break;
                case 1:
                    {
                        specialty = "Biology";
                    }
                    break;
                case 2:
                    {
                        specialty = "XenoEntimology";
                    }
                    break;
                case 3:
                    {
                        specialty = "Phylosophy";
                    }
                    break;
                case 4:
                    {
                        specialty = "Magic Arts";
                    }
                    break;
                case 5:
                    {
                        specialty = "Electroengineering";
                    }
                    break;
                case 6:
                    {
                        specialty = "Finance";
                    }
                    break;
                case 7:
                    {
                        specialty = "Law";
                    }
                    break;
                case 8:
                    {
                        specialty = "Chemistry";
                    }
                    break;
                case 9:
                    {
                        specialty = "Astrozoology";
                    }
                    break;
            }
            return specialty;
        }
        private string GetUnivercity()
        {
            int seed = rng.Next(-1, 9);
            string univercity = "";
            switch (seed)
            {
                case 0:
                    {
                        univercity = "Particle Physics";
                    }
                    break;
                case 1:
                    {
                        univercity = "VUZ \"Chernorizec Hrabur\" ";
                    }
                    break;
                case 2:
                    {
                        univercity = "Kyoto University";
                    }
                    break;
                case 3:
                    {
                        univercity = "Heidelberg University";
                    }
                    break;
                case 4:
                    {
                        univercity = "Massachusets Institute of Technology";
                    }
                    break;
                case 5:
                    {
                        univercity = "Harvart";
                    }
                    break;
                case 6:
                    {
                        univercity = "Technical Univercity Sofia";
                    }
                    break;
                case 7:
                    {
                        univercity = "South Harmon Institute of Technology";
                    }
                    break;
                case 8:
                    {
                        univercity = "The invisible university";
                    }
                    break;
                case 9:
                    {
                        univercity = "Hogwarts";
                    }
                    break;
            }
            return univercity;
        }
        private string GetEmail()
        {
            int seed = rng.Next(-1, 9);
            string email = "";
            switch (seed)
            {
                case 0:
                    {
                        email = "swelldude@mail.com";
                    }
                    break;
                case 1:
                    {
                        email = "funguy@abv.bg";
                    }
                    break;
                case 2:
                    {
                        email = "mymail@yandex.ru";
                    }
                    break;
                case 3:
                    {
                        email = "420blaze@mail.cz";
                    }
                    break;
                case 4:
                    {
                        email = "crazy@yahoo.com";
                    }
                    break;
                case 5:
                    {
                        email = "poebot@protonmail.com";
                    }
                    break;
                case 6:
                    {
                        email = "l33th4ckz0r@gmx.com";
                    }
                    break;
                case 7:
                    {
                        email = "lovec#@abv.bg";
                    }
                    break;
                case 8:
                    {
                        email = "octavian@freemail.org";
                    }
                    break;
                case 9:
                    {
                        email = "harryp@muggle.gb";
                    }
                    break;
            }
            return email;
        }
        private string GetPhonenum()
        {
            int seed = rng.Next(-1, 4);
            string phoneNum = "";
            int restOfNums = 6;
            switch (seed)
            {
                case 0:
                    {
                        phoneNum = "089";
                    }
                    break;
                case 1:
                    {
                        phoneNum = "+359";
                    }
                    break;
                case 2:
                    {
                        phoneNum = "+255";
                    }
                    break;
                case 3:
                    {
                        phoneNum = "+81";
                    }
                    break;
                case 4:
                    {
                        phoneNum = "+11";
                    }
                    break;
            }
            if(phoneNum.Length==2)
            {
                restOfNums = 7;
            }
            for (int i = 0; i <= restOfNums; i++)
            {
                seed = rng.Next(-1, 9);
                phoneNum += seed;
            }
            return phoneNum;
        }
        private Student[] CreateStudents()
        {
            Student[] stud = new Student[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                stud[i] = new Student();
                stud[i].Name = GetName();
                stud[i].Year = GetYear();
                stud[i].Specialty = GetSpecialty();
                stud[i].University = GetUnivercity();
                stud[i].Email = GetEmail();
                stud[i].Phonenum = GetPhonenum();
            }
            return stud;
        }
        public static void GetStaticStudent()
        {
            Student stud1 = new Student();
            Student stud2 = new Student();
            Student stud3 = new Student();
            int count = 0;
            Student[] studs = { stud1, stud2, stud3 };
            foreach (var stud in studs)
            {
                stud.Name = "Static Student" + count;
                stud.Year = 1 + count;
                stud.Specialty = "StaticSpeciality" + count;
                stud.University = "StaticUnivercity" + count;
                stud.Email = "StaticEmail" + count;
                stud.Phonenum = "01010101" + count;
                count++;
            }
            statStud = stud1;
            statStud1 = stud2;
            statStud2 = stud3;
        }

        public void Print()
        {
            Student[] stud = CreateStudents();
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i].StudentInfo();
            }
        }
    }
}
