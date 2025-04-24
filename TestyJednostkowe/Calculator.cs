using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    public class Calculator
    {
        public int Sum(int firstNumber, int secoundNumber) => firstNumber + secoundNumber;
        public int ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader sreader = new StreamReader(filePath))
                {
                    int firstNumber = int.Parse(sreader.ReadLine());
                    int secondNumber = int.Parse(sreader.ReadLine());
                    return Sum(firstNumber, secondNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading from file, code: {ex.Message}");
                return 0;
            }
        }
    }
    public class Volume
    {
        public double CalcVol(double length, double width, double height) => length * width * height;
        public int ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader sreader = new StreamReader(filePath))
                {
                    double length = int.Parse(sreader.ReadLine());
                    double width = int.Parse(sreader.ReadLine());
                    double height = int.Parse(sreader.ReadLine());
                    return (int)CalcVol(length, width, height);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading from file, code: {ex.Message}");
                return 0;
            }
        }
    }
}

/*
public void Read(string filePath)
        {
            int[] tablicaZPliku = ReadData(filePath);
        }

        public static int[] ReadData(string filePath)
        {
            try
            {
                using (StreamReader sreader = new StreamReader(filePath))
                {
                    string content = sreader.ReadToEnd();
                    string[] stringArray = content.Split(' ');
                    int[] intArray = Array.ConvertAll(stringArray, int.Parse);
                    return intArray;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading from file, code: {ex.Message}");
                return null;
            }
        }
    }
*/