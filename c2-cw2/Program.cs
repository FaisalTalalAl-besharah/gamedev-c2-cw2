using System;

namespace c2_cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "batman";
            string name2 = "superman";
            string batSuperPower1 = ("world's greatest detective");
            string batSuperPower2 = ("Rich");
            int age1 = 29;
            int age2 = 31;
            string supsuperpower1 = ("super strangth");
            string supsuperpower2 = ("heat vision");
            Console.WriteLine("I am  " +  name1  + "  my age is  " + age1 + "  my super powers are  " + batSuperPower1 + "  and I am  " + batSuperPower2, name1, batSuperPower1, batSuperPower2, age1);



            Console.WriteLine("I am " + name2 + " my age is " + age2 + " my super powers are " + supsuperpower1 +  " and "  +  supsuperpower2 , name2, age2, supsuperpower1, supsuperpower2);





            int batmanpower1 = 30;   int batmanIQ = 192;
            int supermanpower1 = 50; int supermanIQ = 120;
            int batmanheight = 188;
            int supermanheight = 181;
            int batmanage = 29;
            int supermanage = 31;
            void checkPower()
            {
                if (supermanpower1 > batmanpower1) {
                    Console.WriteLine("superman is powerful");
                }
                else if (batmanpower1 > supermanpower1)
                {
                    Console.WriteLine("batman is powerful");
                }
                
                
            }
            checkPower(); 
            
            void checkheight()
            {
                if (supermanheight > batmanheight) {
                    Console.WriteLine("superman is taller");
                        }
                else if (batmanheight > supermanheight)
                {
                    Console.WriteLine("batman is taller");
                }
            }
            checkheight();
                   
            void agedifference()
            {
                if (supermanage > batmanage)
                {
                    Console.WriteLine("superman is older");
                }
                else if (batmanage > supermanage)
                {
                    Console.WriteLine("batman is older");
                }
            }

            agedifference();

            void iqlevel()
            {
                if (batmanIQ > supermanIQ)
                {
                    Console.WriteLine("batman is smarter");
                }
                else if (supermanIQ > batmanIQ)
                {
                    Console.WriteLine("superman is smarter");
                }
            }       iqlevel();                                                                                                                                                 

        } 
            } 
        }
    

