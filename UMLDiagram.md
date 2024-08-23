```mermaid
classDiagram
    class Pedido {
        - int NumeroPedido
        - string Cliente
        - List~Item~ Itens
        - decimal Total
        + void AdicionarItem(Item item)
        + void RemoverItem(Item item)
        + void CalcularTotal()
    }

    class Item {
        - string Nome
        - decimal Preco
        + decimal CalcularPreco()
    }

    class Bebida {
        - string Tamanho
        + decimal CalcularPreco()
    }

    class Cafe {
        - string TipoGrao
        + decimal CalcularPreco()
    }

    class Sobremesa {
        - string Sabor
        + decimal CalcularPreco()
    }

    Pedido --> Item
    Item <|-- Bebida : "abstract"
    Bebida <|-- Cafe
    Item <|-- Sobremesa
