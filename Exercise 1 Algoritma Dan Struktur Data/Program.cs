using System;

namespace Exercise1
{
    //membuat class
    class Program
    {
        //deklarasi array int dengan ukuran 44
        private int[] a = new int[44];
        //deklarasi variabel int uuntuk menyimpan banyaknya data pada array
        private int n;
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while(true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 44)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 44 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("---------------------");

            //memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Elemen array yang tersusun");
            Console.WriteLine("--------------------------");
            for (int RA = 0; RA < n; RA++)
            {
                Console.WriteLine(a[RA]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 2; i < n; i++)
            {
                for (int RA = 0; RA < n - i; RA++)
                {
                    if (a[RA] > a[RA + 1])
                    {
                        //tukar elemen
                        int temp;
                        temp = a[RA];
                        a[RA] = a[RA + 1];
                        a[RA + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            myList.read();
            myList.BubbleSortArray();
            myList.display();
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}