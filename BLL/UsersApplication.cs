using System;
using System.Collections.Generic;
using System.IO;
using DAL;

namespace BLL
{
    public static class UsersApplication
    {

        public static string filePath = @"users.txt";  
        public static List<UserModel> usersList = new List<UserModel>();  

        public static void AddUser(string username, string password)
        {
            usersList.Add(new UserModel(username, password));
            SaveUsersToFile();
        }


        public static void SaveUsersToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var user in usersList)
                {
                    writer.WriteLine($"{user.Username},{user.Password}");
                }
            }
        }

        public static void LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                usersList.Clear();
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    usersList.Add(new UserModel(data[0], data[1]));
                }
            }
        }

        public static bool ValidateLogin(string username, string password)
        {
            foreach (var user in usersList)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}