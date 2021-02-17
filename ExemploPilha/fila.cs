using System;
namespace ExemploPilha
{
    public class Fila
    {
        Posicao head;
        public void Enqueue(object item)
        {
            if(this.head == null)
            {
                this.head = new Posicao(item);
            }
            else
            {
                Posicao percorreFila = this.head;
                while(percorreFila.next != null)
                {
                    percorreFila = percorreFila.next;
                }
                percorreFila.next = new Posicao(item);

            }   
        }
        public object Dequeue()
        {
            if(this.head == null)
            {
                throw new InvalidOperationException("A fila está vazia");
            }
            object resp =  this.head.item;
            this.head = this.head.next;
            return resp;
        }
        class Posicao
        {
            public Posicao next;
            public object item;

            public Posicao(object item)
            {
                this.item = item;
                this.next = null;
            }
            
        }
    }
}