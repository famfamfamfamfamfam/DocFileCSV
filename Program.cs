using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\pc\Desktop\Module1\BaiTap\ip_addresses.csv";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                Console.WriteLine("Dia chi IP bat dau, Dia chi IP ket thuc, Ma quoc gia, Ten quoc gia");
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 6)
                    {
                        string startIp = parts[0].Trim('"');
                        string endIp = parts[1].Trim('"');
                        string countryCode = parts[4].Trim('"');
                        string countryName = parts[5].Trim('"');

                        Console.WriteLine($"{startIp}, {endIp}, {countryCode}, {countryName}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
