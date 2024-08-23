using System;

public class Sobremesa(string nome, decimal preco, string sabor) : Item(nome, preco)
{
    // Atributos
    public string Sabor {get; private set;} = sabor;

    // Construtor
    
    // Métodos
    public override decimal CalcularPreco()
    {
        return base.CalcularPreco();
    }

    // toString()

    public override string ToString()
    {
        return $"Sobremesa : {Nome}, Preço : {Preco:C}, Sabor : {Sabor}";
    }
}

