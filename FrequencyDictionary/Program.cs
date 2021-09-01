using System;
using System.IO;

namespace FrequencyDictionary {
    public class Calc {
        
    }

    internal class Program {
        public static void Main(string[] args) {
            MyFrequencyDictionary dictionary = new MyFrequencyDictionary("C:\\Temp1");

            foreach (var item in dictionary.Frequency) {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}