using System;

public class Program
{
    public static void Main(string[] args)
    {
        Item item = new Item ("Pão de queijo",5.90m);
        Item item2 = new Item ("Torta",6.40m);
        Item item3 = new Item ("Salgado",4.00m);
        //Console.WriteLine(item);

        Bebida bebida = new Cafe ("Capuccino",4.00m,"Grande","Expresso");
        //Console.WriteLine(bebida);

        Sobremesa sobremesa = new Sobremesa ("Bolo",5.00m,"Limão");
        //Console.WriteLine(sobremesa);

        Pedido pedido = new Pedido (1234,"João");
        pedido.AdicionarItem(bebida);
        pedido.AdicionarItem(item);
        pedido.RemoverItem(bebida);
        pedido.AdicionarItem(sobremesa);
        pedido.CalcularTotal();
        pedido.AdicionarItem(item2);
        pedido.AdicionarItem(item3);
        Console.WriteLine(pedido);

    }
}