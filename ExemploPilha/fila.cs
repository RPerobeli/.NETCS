namespace ExemploPilha
{
    public class Fila
    {
        Posicao percorreFila;
        public void Enqueue(object item)
        {
            while(percorreFila != null)
            {
                percorreFila = percorreFila.next;
            }
            percorreFila = new Posicao(item);
            

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