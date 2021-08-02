using System;
using System.IO;
namespace UserMgtConsoleApp

{
    public class UserFile
    {
       UserInterface user = new UserInterface();
        public static void UserToFile()
        {
            string file = @"../UserMgtConsoleApp/Users.txt";
            if (!File.Exists(file))
            {
                using StreamWriter sw = File.CreateText(file);
            }

                using (StreamWriter streamWriter = new StreamWriter(file))
                {
                    //Trying to loop the write action
                    // foreach (UserInterface user in users)
                    // {
                    //     streamWriter.WriteLine($"{user.FName },{user.LName }, {user.email}");
                    // }
                }

                using (StreamWriter streamWriter = File.AppendText(file))
                    {
                        UserInterface user = new UserInterface();
                    
                        streamWriter.WriteLine($"{user.FName },{user.LName }, {user.email}");
                        streamWriter.WriteLine("Name,Email,PhoneNumber");
            }

        }
        public static void UsersFromFile()
        {
            string file = @"../UserMgtConsoleApp/Users.txt";

            using (StreamReader streamReader = File.OpenText(file))
            {
                var read = streamReader.ReadToEnd();
                read = read.TrimEnd();
                var users = read.Split(Environment.NewLine);
                var last = users[^1];
                foreach (var item in users)
                {
                    var user = item.Split(',');
                    System.Console.WriteLine(user[0]);
                    System.Console.WriteLine(user[1]);
                    System.Console.WriteLine(user[2]);
                }
            }
        }
        // public async static UserInterface<string> ReadFileAsync()
        // {
        //     string file = @"../UserMgtConsoleApp/Users.txt";

        //     using (StreamReader streamReader = File.OpenText(file))
        //     {
        //         var read = await streamReader.ReadToEndAsync();
        //         return read;
        //     }
        //}
    }
}