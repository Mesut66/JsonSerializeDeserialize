using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-----------------Json Serialize----------------------");
            //Person person = new Person { Name = "Yasin", Age = 25, Salary = 57.500m, IsActive = true, Date = DateTime.Now };
            //string jsonString = JsonSerializer.Serialize(person);
            //Console.WriteLine(jsonString);
            //Console.WriteLine("-----------------Json Deserialize----------------------");

            //string json = "{\"Name\":\"Abuzer\",\"Age\":30,\"Salary\":57.500,\"IsActive\":true,\"Date\":\"2025-06-20T09:34:46.6505838+03:00\"}";
            //Person person2 = JsonSerializer.Deserialize<Person>(json);

            //Console.WriteLine(
            //    $"Name:{person2.Name},\n" +
            //    $"Age:{person2.Age},\n" +
            //    $"Salary:{person2.Salary},\n" +
            //    $"IsActive:{person2.IsActive},\n" +
            //    $"Date:{person2.Date},\n");


            //2. yol


            ////Path to the JSON file
            //string filePath = @"....\Downloads\sample2.json";

            ////Read the entire content of the JSON file into a string
            //var jsonP = File.ReadAllText(filePath);

            //Root root = JsonSerializer.Deserialize<Root>(jsonP);

            //Console.WriteLine(
            //    $"Bow:{root.bow},\n" +
            //    $"Darkness:{root.darkness},\n" +
            //    $"Proper:{root.proper},\n" +
            //    $"Worse:{root.worse},\n" +
            //    $"Tree:{root.tree},\n" +
            //    "-------------See--------------\n" +
            //     $"star: {root.see.star},\n" +
            //    $"chief: {root.see.chief},\n" +
            //    $"sugar:{root.see.sugar},\n" +
            //    $"straight:{root.see.straight},\n" +
            //    $"cake:{root.see.cake},\n" +
            //    "-------------These--------------\n" +
            //    $"Number Count:{root.see.these.Count},\n");

            //foreach (var item in root.see.these)
            //{
            //    Console.WriteLine("ValueKind : " + item);
            //}


            //3. yol

            string url = @"https://jsonplaceholder.typicode.com/posts/1";
            string jsonVerisi = "";
            using (WebClient response = new WebClient())
            {
                jsonVerisi = response.DownloadString(url);
            }
            RootOnline jsonOnline = JsonConvert.DeserializeObject<RootOnline>(jsonVerisi);

            Console.WriteLine(
                $"userId:{jsonOnline.userId},\n" +
                $"Id:{jsonOnline.id},\n" +
                $"Title:{jsonOnline.title},\n" +
                $"Body:{jsonOnline.body},\n");


            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public DateTime Date { get; set; }
    }

    public class Root
    {
        public bool bow { get; set; }
        public int darkness { get; set; }
        public string proper { get; set; }
        public int worse { get; set; }
        public See see { get; set; }
        public int tree { get; set; }
    }

    public class See
    {
        public List<object> these { get; set; }
        public string star { get; set; }
        public string chief { get; set; }
        public bool sugar { get; set; }
        public string straight { get; set; }
        public bool cake { get; set; }
    }

    public class RootOnline
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
