using System;
using System.Runtime.CompilerServices;

public class Pedido (int numeropedido, string cliente)
{
    public int NumeroPedido {get; set;} = numeropedido;
    public string Cliente {get; set;} = cliente;
    public List<Item> Itens {get; set;} = new List<Item>();
    public decimal Total {get; set;} = new decimal();

    public void AdicionarItem (Item item)
    {
        Itens.Add(item);
    }

    public void RemoverItem (Item item)
    {
        Itens.Remove(item);
    }

    public void CalcularTotal()
    {
        Total = 0; 
        foreach (var item in Itens)
        {
            decimal precoCalculado = item.CalcularPreco();
            Total += precoCalculado;
        }
    }

    public override string ToString()
    {
        CalcularTotal();
        string listaItens = string.Join("\n", Itens);
        return $"Número pedido: {NumeroPedido} Cliente: {Cliente}\nItens:\n{listaItens}\nTotal: {Total}";
    }
}