using JengLib;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace jeng
{
    class Program
    {
        //static string century(int year)
        //{
        //    string century = "";
        //    int century2 = 0;
        //    if (year >= 1000 && year <= 2010)
        //    {
        //        char[] charArr = year.ToString().ToCharArray();
        //        century = charArr[0].ToString() + charArr[1].ToString();
        //        if (int.Parse(charArr[3].ToString()) > 0 || int.Parse(charArr[2].ToString()) > 0)
        //        {
        //            century2 = int.Parse(century) + 1;
        //            century = century2.ToString();
        //        }
        //    }
        //    if (year < 1000 && year > 2010)
        //    {
        //        century = "Error";
        //    }
        //    return century + "th century";
        //}
        //static void Main(string[] args)
        //{
        //    int year;
        //    Console.WriteLine("Enter a year.");
        //    year = Int32.Parse(Console.ReadLine());
        //    Console.WriteLine(century(year));
        //    Console.ReadKey();
        //}
        //static string Nemo(string[] words)
        //{
        //string Nemo = "I can't find Nemo :(";
        //int keeper = 0;
        //for (int i = 0; i < words.Length; i++)
        //    {
        //        if (words[i].ToString() == "Nemo")
        //        {
        //            Nemo = "I found Nemo at ";
        //            keeper = keeper + i + 1;
        //            keeper.ToString();
        //        }
        //    }
        //    return Nemo + keeper + "!";
        //}
        //static void Main(string[] args)
        //{
        //    string sentence;
        //    Console.WriteLine("Write a sentence");
        //    sentence = Console.ReadLine();
        //    string[] words = sentence.Split(' ');
        //    Console.WriteLine(Nemo(words));
        //    Console.ReadKey();
        //}
        //  static string FlipEndChars (char[] charArr)
        //  {
        //    List<string> List = new List<string>();
        //    bool invalid = false;
        //    int n;
        //    if (charArr.Length >= 3 && charArr[0] != charArr[charArr.Length - 1])
        //    {
        //        List.Add(charArr[charArr.Length - 1].ToString());
        //        for (int i = 0; i < charArr.Length; i++)
        //        {
        //            if (int.TryParse(charArr[i].ToString(), out n))
        //            {
        //                invalid = true;
        //                break;
        //            }
        //            if (!int.TryParse(charArr[i].ToString(), out n))
        //            {
        //                if (i != 0 && i != charArr.Length - 1)
        //                {
        //                    List.Add(charArr[i].ToString());
        //                }
        //            }
        //        }
        //        List.Add(charArr[0].ToString());
        //    }
        //    if (invalid == true)
        //        List.Clear();
        //    {
        //        for (int i = 0; i < charArr.Length; i++)
        //        {
        //            if (int.TryParse(charArr[i].ToString(), out n))
        //            {
        //                List.Add("Incompatible.");
        //                break;
        //            }
        //        }
        //    }
        //    if (charArr.Length < 3)
        //    {
        //        List.Add("Incompatible.");
        //    }
        //    if (charArr[0] == charArr[charArr.Length - 1] && charArr.Length > 2)
        //    {
        //        List.Add("Two's a pair");
        //    }
        //    string OutPut = string.Join("", List);
        //    return OutPut;
        //}
        //static void Main(string[] args)
        //{
        //    string something;
        //    Console.WriteLine("Enter a string that has at least 3 letters.");
        //    something = Console.ReadLine();
        //    char[] charArr = something.ToCharArray();
        //    Console.WriteLine(FlipEndChars(charArr));
        //    Console.ReadKey();
        //}
        //static bool ValidateEmail (char[] charArr)
        //{
        //    bool Valid = false;
        //    int keeper1 = 0;
        //    int keeper2 = 0;
        //    for (int i = 0; i < charArr.Length; i++)
        //    {
        //        if (charArr[i].Equals('@'))
        //        {
        //            keeper1 = i;
        //        }
        //    }
        //    for (int i = charArr.Length - 1; i >= 0; i--)
        //    {
        //        if (charArr[i].Equals('m'))
        //        {
        //            if (charArr[i - 1].Equals('o'))
        //            {
        //                if (charArr[i - 2].Equals('c'))
        //                {
        //                    keeper2 = i - 3;
        //                }
        //            }
        //        }
        //    }
        //    if (keeper1 < keeper2)
        //    {
        //        Valid = true;
        //    }
        //    if (keeper1 == 0)
        //    {
        //        Valid = false;
        //    }
        //    return Valid;
        //}
        static void Main(string[] args)
        {
            /*
            string email;
            Console.WriteLine("Enter your email.");
            email = Console.ReadLine();
            char[] charArr = email.ToCharArray();
            Console.WriteLine(ValidateEmail(charArr));
            Console.ReadKey();*/
            //Console.WriteLine("from console");
            //human.EyeColor = "blue";
            //Trigonometry parallelogram = new Trigonometry();
            //Console.WriteLine(parallelogram.square_area(2));
            //Console.WriteLine(parallelogram.rectangle_area(2, 4));
            //Console.WriteLine(parallelogram.triangle_area(3, 6));
            //pet dog = new pet("Thai", -4);
            //Console.WriteLine(dog.Kind);
            //Console.WriteLine(dog.Legs_number);
            //pet monkey = new pet("Thai", 2);
            //Console.WriteLine(monkey.Kind);
            //Console.WriteLine(monkey.Legs_number);
            //Console.WriteLine(dog.start_running());
            //Console.WriteLine(dog.stop_running());
            //Console.WriteLine(monkey.start_running());
            //Console.WriteLine(monkey.stop_running());
            //Box box = new Box(-1, 2, 2);
            //Console.WriteLine(box.display_volume());
            //Console.WriteLine(box.display_dimensions());
            //Cube cube = new Cube(5);
            //Console.WriteLine(cube.volume());
            //Console.WriteLine(cube.surface());
            //Console.WriteLine(cube.total_surface());
            //Circle circle = new Circle();
            //circle.Radius = 7;
            //Console.WriteLine(circle.diameter());
            //Console.WriteLine(circle.area());
            //Console.WriteLine(circle.perimeter());
            //Info text = new Info();
            //text.Text = "I love cats.";
            //Console.WriteLine(text.spaces());
            //Console.WriteLine(text.words());
            //Console.WriteLine(text.vowels());
            //Console.WriteLine(text.letters());
            //EncryptDecrypt text = new EncryptDecrypt();
            //text.text = "abc";
            //text.Encr_decr_key = 2;
            //Console.WriteLine(text.encrypt());
            //PhotoBook PhotoBook = new PhotoBook(20);
            //Console.WriteLine(PhotoBook.GetNumberPages());
            //Person person = new Person();
            //person.SetAge(20); 
            //Console.WriteLine(person.GetAge());
            //Message Message = new Message();
            //Message.content = "I like cats";
            //Message.SetContent("I like cats.");
            //Console.WriteLine(Message.send());
            //Email Email = new Email();
            //Email.SetContent("I like dogs");
            //Email.SetReceiver("David");
            //Email.Sender = "James";
            //Console.WriteLine(Email.send());
            //Console.WriteLine(Email.ShowReceiver());
            //Console.WriteLine(Email.Sender);
            //Hydrogen hydrogen = new Hydrogen();
            //hydrogen.Electron = 5;
            JengLib.Information information = new JengLib.Information("Jim", "Doe", "097-237-3890");
            Console.WriteLine(information.ReGroup());
            //Computer computer = new Computer("Asus", "1", "Ryzen", "16gb", "5tb");
            /*Numbers numbers = new Numbers("11000,0815627440,025275564,abc");
            foreach(XBox bx in numbers.Get_Xboxes)
            {
                Console.WriteLine(bx.Type);
            }*/
            Console.ReadKey();
        }
    }
}