using System;    // equivalente ao import
                // namespace é equivalente ao package de JAVA
public class Item (string nome, decimal preco)//para tornar classe
{
    // Atributos da classe
    public string Nome {get; private set;} = nome;
    public decimal Preco {get; protected set;} = preco;

    // Construtor

    // Métodos
    public virtual decimal CalcularPreco()
    {
        return Preco;
    }

    // toString()

    public override string ToString()
    {
        return $"Item: {Nome}, Preço: {Preco:C}";
    }
}