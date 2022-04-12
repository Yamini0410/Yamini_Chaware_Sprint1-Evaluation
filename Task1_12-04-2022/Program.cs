using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1_12_04_2022
{
    /*
    //TASK-1
    class student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string smailid { get; set; }
        public string branch { get; set; }
        public double percentage { get; set; }
        public List<string> skills { get; set; }
    }
    class program
    {
        static void Main(string[] args)
        {
            List<student> Slist = new List<student>()
            {
                new student() { firstname = "Yamini", lastname = "Chaware", smailid = "yamini123@gmailcom", branch = "EE", percentage = 78,skills=new List<string>{ "C#","PHP"} },
                new student() { firstname = "Nandini", lastname = "Kumbhare", smailid = "nandini123@gmailcom", branch = "IT", percentage = 85,skills=new List<string>{ ".NET","PHP"} },
                new student() { firstname = "Jay", lastname = "Agarwal", smailid = "jay123@gmailcom", branch = "EC", percentage = 89,skills=new List<string>{ "HTML","JAVASCRIPT"} },
                new student() { firstname = "Jasmin", lastname = "Singh", smailid = "jasmin31@gmailcom", branch = "IS", percentage = 93,skills=new List<string>{ "HTML","ORACLE"}},
                new student() { firstname = "Aravi", lastname = "Khanna", smailid = "aravi123@gmailcom", branch = "IS", percentage = 79,skills=new List<string>{ "PHP","JAVASCRIPT"}, },
                new student() { firstname = "Minal", lastname = "Deshpande", smailid = "minal123@gmailcom", branch = "IT", percentage = 90,skills=new List<string>{ "C#","PHP"}  },
                new student() { firstname = "Samar", lastname = "Jaiswal", smailid = "samar23@gmailcom", branch = "EC", percentage = 73,skills=new List<string>{ ".NET","ORACLE"} },
                new student() { firstname = "Samir", lastname = "Singh", smailid = "samir12@gmailcom", branch = "EE", percentage = 96,skills=new List<string>{ "C#","PHP"} }
            };

            Console.WriteLine("**********Select************");
            var query1 = from i in Slist select i;
            foreach (var i in query1)
            {
                Console.WriteLine(i.firstname + " " + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);
            }

            Console.WriteLine("*********Where**************");

            var query2 = from i in Slist where i.percentage > 80 select i;
            foreach (var i in query2)
            {
                Console.WriteLine(i.firstname + " " + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);

            }

            Console.WriteLine("**********Take*************");

            IEnumerable<student> query3 = (from i in Slist where i.percentage > 75 select i).Take(3);
            foreach (var i in query3)
            {
                Console.WriteLine(i.firstname + " " + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);
            }

            Console.WriteLine("*********SkipWhile and TakeWhile***************");

            IEnumerable<student> query4 = (from i in Slist select i).SkipWhile(i => i.percentage < 80).TakeWhile(i => i.percentage < 90);
            foreach (var i in query4)
            {
                Console.WriteLine(i.firstname + " " + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);
            }

            Console.WriteLine("************Skip*************");


            IEnumerable<student> query5 = (from i in Slist where i.percentage > 75 select i).Skip(1).Take(4);
            foreach (var i in query5)
            {
                Console.WriteLine(i.firstname + " " + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);
            }
            Console.WriteLine("*************Orderby (Asc)******************");

            var query6 = from i in Slist where i.percentage > 75 orderby i.percentage ascending select i;
            foreach (var i in query6)
            {
                Console.WriteLine(i.firstname + " " + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);

            }

            Console.WriteLine("*************orderby (Desc)**************");

            var query7 = from i in Slist where i.percentage > 75 orderby i.percentage descending select i;
            foreach (var i in query7)
            {
                Console.WriteLine(i.firstname + " " + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);

            }
            Console.WriteLine("**********Groupby**************");

            var query8 = from i in Slist group i by i.branch;
            foreach (var group in query8)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("-------------------------");
                foreach (var i in group)
                {
                    Console.WriteLine(i.firstname + " " + i.lastname + "," + i.percentage);
                }
            }

            Console.WriteLine("*********Select and select many*************");

            var query9 = Slist.Select(i => i);
            foreach (var i in query9)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.percentage + "," + i.branch);
            }
            Console.WriteLine("--------------------------------");
            var query10 = Slist.SelectMany(i => i.skills);
            foreach (var i in query10)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**********Aggregate Functions*************");

            double sum = (from i in Slist select i.percentage).Sum();
            Console.WriteLine("Total sum of percentage is:" + sum);

            double max = (from i in Slist select i.percentage).Max();
            Console.WriteLine("Maximum percentage is:" + max);

            double min = (from i in Slist select i.percentage).Min();
            Console.WriteLine("Minimum percentage is:" + min);

            double avg = (from i in Slist select i.percentage).Average();
            Console.WriteLine("Total average of percentage is:" + avg);

            var query13 = (from i in Slist select i.branch).Distinct();
            foreach (string i in query13)
            {
                Console.WriteLine(" Branch: "+i);
            }

            Console.WriteLine("**********OffType************");

            var query11 = (from i in Slist select i.percentage).OfType<double>();
            foreach (var i in query11)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");
            var query12 = (from i in Slist select i.firstname).OfType<string>();
            foreach (var i in query12)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***********Startswith**********");

            var query14 = (from i in Slist where i.firstname.StartsWith('Y') select i);
            foreach (var i in query14)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("***********Endswith**********");

            var query15 = (from i in Slist where i.firstname.EndsWith('i') select i);
            foreach (var i in query15)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("************Contains**********");

            var query16 = (from i in Slist where i.lastname.Contains('d') select i);
            foreach (var i in query16)
            {
                Console.WriteLine(i.lastname);
            }
            
            Console.WriteLine("*************Into keyword************");

            var query17 = from i in Slist
                        where i.branch == "IT"
                        select i into res
                        where
               res.firstname.StartsWith("N")
                        select res;
            foreach (var i in query17)
            {
                Console.WriteLine(i.firstname + "," + i.branch);
            }
            
            Console.WriteLine("**********Let keyword************");

            var query18 = from i in Slist let res = i.percentage + 5 select res;
            foreach (int i in query18)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**********Single************");
            var query19 = (from i in Slist where i.percentage == 90 select i).Single();
            Console.WriteLine(query19.firstname) ;

            Console.WriteLine("**********SingleOrDefault************");
            var query20 = (from i in Slist where i.percentage == 90 select i).SingleOrDefault();
            Console.WriteLine(query20.firstname);

            Console.WriteLine("**********First************");
            var query21 = (from i in Slist where i.percentage == 90 select i).First();
            Console.WriteLine(query21.firstname);

            Console.WriteLine("**********FirstOrDefault************");
            var query22 = (from i in Slist where i.percentage == 78 select i).FirstOrDefault();
            Console.WriteLine(query22.firstname);

            Console.WriteLine("**********ElementAt************");
            var query23 = (from i in Slist select i).ElementAt(3);
            Console.WriteLine(query23.firstname);

            Console.WriteLine("**********ElementAtOrDefault************");
            var query24 = (from i in Slist select i).ElementAtOrDefault(5);
            Console.WriteLine(query24.firstname);



            Console.WriteLine("**********IQureyable************");

            IQueryable<student> query25 = (from i in Slist select i).AsQueryable();
            foreach (var i in query25)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }

            Console.WriteLine("**********IEnumarable************");

            IEnumerable<string> query26 = Slist.Select(i => i.firstname);
            foreach (var i in query26)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**********Deffered Execution***************");

            var query27 = (from i in Slist select i); 
            Slist.Add(new student() { firstname = "Nikhil", lastname = "Prasad", smailid = "nikhil12@gmailcom", branch = "EE", percentage = 96, skills = new List<string> { "ORACLE", "PHP" } });
            Slist.Add(new student() { firstname = "Kunal", lastname = "Zade", smailid = "kunal21@gmailcom", branch = "CS", percentage = 89, skills = new List<string> { "C#", "JAVASCRIPT" } });
            foreach (student e in query27)
            {
                Console.WriteLine(e.firstname + " " + e.lastname + " , " + e.smailid+" , "+e.branch);
            }

            Console.WriteLine("***************Immediate execution**********");
            var query28 = (from i in Slist select i).Count();
            Slist.Add(new student() { firstname = "Gauri", lastname = "Meghe", smailid = "gauri12@gmailcom", branch = "IT", percentage = 96 });
            Slist.Add(new student() { firstname = "Sayli", lastname = "Hadke", smailid = "Sayli21@gmailcom", branch = "IS", percentage = 89 });
            Console.WriteLine(query28);

        }
    }*/
    
    
    class program2
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] array2 = new int[] { 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 };
            Console.WriteLine("--------------------Concat-------------");
            IEnumerable<int> query29 = array1.Concat(array2);
            foreach (int i in query29)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------Union------------------");

            IEnumerable<int> query30 = array1.Union(array2);
            foreach (int i in query30)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------Intersect---------------------");

            IEnumerable<int> query31 = array1.Intersect(array2);
            foreach (int i in query31)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------Except------------------");

            IEnumerable<int> query32 = array1.Intersect(array2);
            foreach (int i in query32)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------Aggregate Function for array1------------------");

            int sum = (from i in array1 select i).Sum();
            Console.WriteLine("Sum of all elements: "+sum);

            int max = (from i in array1 select i).Max();
            Console.WriteLine("Maximum element in array1 is: "+max);

            int min = (from i in array1 select i).Min();
            Console.WriteLine("Maximum element in array1 is: " + min);

            double avg = (from i in array1 select i).Average();
            Console.WriteLine("Average of array1: " + avg);

            int count = (from i in array1 select i).Count();
            Console.WriteLine("No of element present in array1 is: "+count);

            var query33 = (from i in array1 select i).Distinct();
            foreach (int i in query33)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------Aggregate Function for array2------------------");

            int sum2 = (from i in array2 select i).Sum();
            Console.WriteLine("Sum of all elements: " + sum2);

            int max2 = (from i in array2 select i).Max();
            Console.WriteLine("Maximum element in array2 is: " + max2);

            int min2 = (from i in array2 select i).Min();
            Console.WriteLine("Maximum element in array2 is: " + min2);

            double avg2 = (from i in array2 select i).Average();
            Console.WriteLine("Average of array2: " + avg);

            int count2 = (from i in array2 select i).Count();
            Console.WriteLine("No of element present in array2 is: " + count);

            var query34 = (from i in array2 select i).Distinct();
            foreach (int i in query34)
            {
                Console.WriteLine(i);
            }


        }
    

    }
    
}
