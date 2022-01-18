using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using System.Collections;

namespace K181133_Q1
{
    public class Person
    {
        public string userName;
        public string password;
        public string StationId;

        public static string Base64Encode(string plainPassword)
        {
            try
            {
                var plainPasswordBytes = System.Text.Encoding.UTF8.GetBytes(plainPassword);
                return System.Convert.ToBase64String(plainPasswordBytes);
            }
            catch (Exception exception)
            {
                throw new Exception("Error in base64Encode" + exception.Message);
            }
        }
        public void WriteinFile(string uname, string password, string stationId)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["Path"];
                
                if (!File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path, true);
                    sw.WriteLine(uname + ',' + Base64Encode(password) + ',' + stationId);
                    sw.Close();
                }
                else
                {
                    ArrayList unameList = new ArrayList();
                    bool exist = false;
                    var lines = File.ReadAllLines(path);
                    foreach (var line in lines)
                    {
                        String[] fields = line.Split(',');
                        unameList.Add(fields[0]);
                    }
                    for (int i = 0; i< unameList.Count;i++)
                    {
                        if(uname == unameList[i].ToString())
                        {
                            Console.WriteLine("Username already exists");
                            exist = true;
                        }
                    }
                    if(exist == false)
                    {
                        using (StreamWriter sw = new StreamWriter(path, true))
                        {
                            Console.WriteLine("User Successfully Added");
                            sw.WriteLine(uname + ',' + Base64Encode(password) + ',' + stationId);
                            sw.Close();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Exception: " + error.Message);
            }
        }
    }
}
