using System.ComponentModel.Design;
using System.Text.Json;
using static System.Console;

namespace json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*User user = new User { Name = "Tom", Age = 10, Email = "tom@cartoon.com" };

            string filePath = "user.json";

            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonStr = JsonSerializer.Serialize(user, options);
            File.WriteAllText(filePath, jsonStr);

            Console.WriteLine("File was serialized");


            if (File.Exists(filePath))
            {
                string readJson = File.ReadAllText(filePath);
                User? restoredUser = JsonSerializer.Deserialize<User>(readJson);
                if (restoredUser != null)
                {
                    Console.WriteLine("User is deserialized");
                    Console.WriteLine(restoredUser);
                }
            }*/

            Album myAlbum = null;
            string fileName = "album.json";

            bool running = true;
            while (running)
            {
                WriteLine("1 Create album");
                WriteLine("2 Show album");
                WriteLine("3 Save in file");
                WriteLine("4 Dovnload from a file");
                WriteLine("5 exit");
                Write("Choose: ");

                string choise = ReadLine();


                if (choise == "1")
                {
                    myAlbum = new Album();
                    Write("Name: ");
                    myAlbum.Title = ReadLine();

                    Write("Artist: ");
                    myAlbum.Artist = ReadLine();

                    Write("Year: ");
                    myAlbum.Year = Convert.ToInt32(ReadLine());

                    Write("Studio: ");
                    myAlbum.Studio = ReadLine();

                    Write("Num sungs: ");
                    int count = Convert.ToInt32(ReadLine());

                    myAlbum.Songs = new Song[count];

                    for (int i = 0; i < count; i++)
                    {
                        Write($"Song {i + 1}: ");
                        Song s = new Song();

                        Write("Name: ");
                        s.Title = ReadLine();
                        Write("Duration: ");
                        s.Duration = ReadLine();
                        Write("Style: ");
                        s.Style = ReadLine();

                        myAlbum.Songs[i] = s;
                    }
                    WriteLine("Album Created");
                }
                else if (choise == "2")
                {
                    if (myAlbum == null)
                    {
                        WriteLine("Firstly create album");
                        continue;
                    }
                    WriteLine($"Name: {myAlbum.Title}");
                    WriteLine($"Artist: {myAlbum.Artist}");
                    WriteLine($"Year: {myAlbum.Year}");
                    WriteLine($"Studio: {myAlbum.Studio}");

                    for (int i = 0; i < myAlbum.Songs.Length; i++)
                    {
                        var s = myAlbum.Songs[i];
                        WriteLine($"{i + 1}. Title: {s.Title}, Duration: {s.Duration}, Style: {s.Style}");
                    }
                }
                else if (choise == "3")
                {
                    if (myAlbum == null)
                    {
                        WriteLine("Nothing to save");
                        continue;
                    }
                    var options = new JsonSerializerOptions { WriteIndented = true };

                    string jsonStr = JsonSerializer.Serialize(myAlbum, options);

                    File.WriteAllText(fileName, jsonStr);

                    WriteLine("all save");

                }
                else if (choise == "4")
                {

                }
                else if (choise == "5")
                {
                    running = false;
                    WriteLine("The program has finished running");
                }
                else
                {
                    WriteLine("Wrong Choice");
                }
            }
        }
    }
}
