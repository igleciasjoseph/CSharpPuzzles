using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomArray();
            TossCoin();
            TossMultipleCoins(6);
            Names();
        }
        public static void RandomArray() {
            Random rand = new Random();
            int[] array;
            array = new int[] {5,16,13,22,20,6,7,17,19,25};
            int min = array[0];
            int max = array[0];
            int sum =0;
            for (int i = 0; i < array.Length; i++) {
                if ( array[i] > max) {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
        }
        public static void TossCoin(){
            Console.WriteLine("Tossing a Coin!");
            int headcount = 0;
            int tailcount = 0;
            Random rand = new Random();
            int coinside = rand.Next(1,3);
            if (coinside == 1) {
                Console.WriteLine("Heads!");
                Console.WriteLine(coinside);
                headcount++;
            }
            if (coinside == 2) {
                Console.WriteLine("Tails!");
                Console.WriteLine(coinside);
                tailcount++;
            }
        }
        public static void TossMultipleCoins(int num){
            for (int i = 0; i <= num; i++){
                TossCoin();
                // Console.WriteLine($"{headcount}:{tailcount}");
            }
        }
        public static void Names(){
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            Random rand = new Random();
            int n = names.Count;
            while (n > 1) {
                n--;
                int k = rand.Next(n+1);
                string value = names[k];
                names[k] = names[n];
                names[n] = value;
            }
            for (int i = 0; i < names.Count; i++) {
                Console.WriteLine(names[i]);
                if (names[i].Length > 5){
                    Console.WriteLine($"Longer than 5---{names[i]}");
                }
            }
        }
    }
}
