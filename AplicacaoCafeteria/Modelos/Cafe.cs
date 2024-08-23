using System;

public class Cafe : Bebida
{
    // Atributos
    public string Tipo {get; private set;}

    // Construtor
    public Cafe (string nome, decimal preco, string tamanho, string tipo): base(nome, preco, tamanho)
    {
        Tipo = tipo;
        Preco = CalcularPreco();
    }
    // Métodos
    public override decimal CalcularPreco()
    {
        if (Tamanho == "Grande"){
            return Preco * 2;
        }
        return Preco;
    }

    // toString()

    public override string ToString()
    {
        return $"Café : {Nome}, Preço : {Preco:C}, Tamanho : {Tamanho}, Tipo : {Tipo}";
    }
}