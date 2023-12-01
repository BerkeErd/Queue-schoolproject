using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
   
    public class Kuyruk 
    {
       
        public object[] Bkuyruk;
        public int front = -1;
        private int rear = -1;
        private int size = 0;
        public int count = 0;

        
        public Kuyruk(int size)
        {
            this.size = size;
            Bkuyruk = new object[size];
        }

        public void Insert(object o)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Kuyruk dolu.");
            if (front == -1)
                front = 0;
            Bkuyruk[++rear] = o;

            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Bkuyruk[front];
        }

        public object Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Kuyruk Boştur.");
            }
            object temp = Bkuyruk[front];
            Bkuyruk[front] = null;
            front++;
            count--;
            return temp;
        }
    }
}
