using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SahaJsonParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----All Data----- \n");
            LoadJson();

            Console.WriteLine("\n\n-----Remove Duplicate-----\n");
            LoadJson2();

            Console.WriteLine("\n\n-----Parse By Gender-----\n");
            LoadJson3();
        }

        //ALl data
        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader("README.json"))
            {
                string json = r.ReadToEnd();
                List<MyObject> items = JsonConvert.DeserializeObject<List<MyObject>>(json);
                int i = 1;
                foreach (var item in items)
                {
                    Console.WriteLine(i + "- " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                    i += 1;
                }
            }
        }

        //Parse Duplicate
        public static void LoadJson2()
        {
            using (StreamReader r = new StreamReader("README.json"))
            {
                string json = r.ReadToEnd();
                List<MyObject> items = JsonConvert.DeserializeObject<List<MyObject>>(json);
                var dist = items.Distinct(new PersonNameComparer()).ToArray();
                int i = 1;
                foreach (var item in dist)
                {

                    Console.WriteLine(i + "= " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                    i = i + 1;

                }



            }

        }

        //Parse Gender
        public static void LoadJson3()
        {
            using (StreamReader r = new StreamReader("README.json"))
            {
                string json = r.ReadToEnd();
                List<MyObject> items = JsonConvert.DeserializeObject<List<MyObject>>(json);
                var dist = items.Distinct(new PersonNameComparer()).ToArray();
                int i = 1;
                Console.WriteLine("---Female");
                foreach (var item in dist)
                {
                    if (item.Gender == "Female")
                    {
                        Console.WriteLine(i + "= " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                        i = i + 1;
                    }


                }

                Console.WriteLine("---Male");
                foreach (var item in dist)
                {
                    if (item.Gender == "Male")
                    {
                        Console.WriteLine(i + "= " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                        i = i + 1;
                    }


                }

                Console.WriteLine("---Genderqueer");
                foreach (var item in dist)
                {
                    if (item.Gender == "Genderqueer")
                    {
                        Console.WriteLine(i + "= " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                        i = i + 1;
                    }


                }

                Console.WriteLine("---Genderfluid");
                foreach (var item in dist)
                {
                    if (item.Gender == "Genderfluid")
                    {
                        Console.WriteLine(i + "= " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                        i = i + 1;
                    }


                }

                Console.WriteLine("---Bigender");
                foreach (var item in dist)
                {
                    if (item.Gender == "Bigender")
                    {
                        Console.WriteLine(i + "= " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                        i = i + 1;
                    }


                }

                Console.WriteLine("---Non-binary");
                foreach (var item in dist)
                {
                    if (item.Gender == "Non-binary")
                    {
                        Console.WriteLine(i + "= " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                        i = i + 1;
                    }

                }

                Console.WriteLine("---Agender");
                foreach (var item in dist)
                {
                    if (item.Gender == "Agender")
                    {
                        Console.WriteLine(i + "= " + "{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.Email, item.Gender, item.Country);
                        i = i + 1;
                    }

                }
                









                Console.ReadKey();

            }

        }

    }
}



