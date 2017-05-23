using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helper;

namespace ConsoleApp3
{
    class realCard
    {
        public long cardN;
        public int cvv;
        public string name;
        
        private int balance;

        public realCard(long a, int b, string c, int d)
        {
            this.cardN = a;
            this.cvv = b;
            this.name = c;
            this.balance = d;

        }

        public string Name {
            get
            {
                return this.name;
            }

        }
        public int Balance
        {
            get
            {
                return this.balance;
            }
        }
        public int Cvv
        {
            get
            {
                return this.cvv;
            }
        }

    }
    class virtualCard
    {
        public long cardN;
        public int cvv;
        public string name;
        private int balance;
        realCard real;
        public virtualCard(string a, int b,realCard c)
        {
            this.name = a;
            this.real = c;
            checkBalance(b);
            yazma();
        }
        Random a = new Random();
        public int Cvvcreator() {
            cvv = a.Next(100,999);
            return cvv;
        }
        public long createcardn()
        {
            cardN = a.Next(100000, 999999);
            return cardN;
        }
        public void checkBalance(int d)
        {
            if(real.Balance >= d)
            {
                this.balance = d;
            }
            else
            {
                this.balance = real.Balance;
            }
        }
        
        public void yazma()
        {
            Console.WriteLine("Hormetli {0} , sizin balansinizda {1} manat pul var ve sizin kart nomreniz {2}, cvv nomreniz ise {3} ", this.name,this.balance, createcardn(), Cvvcreator());
        }
    }
   
}
