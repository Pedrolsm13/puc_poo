using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    public static void Main(string[] args){
        // Criar produtos
        Produto cerveja = new Produto(1, "Cerveja", 5.00);
        Produto agua = new Produto(2, "Água", 2.00);
        Produto biscoito = new Produto(3, "Biscoito", 3.50);

        // Criar compra
        Compra compraJose = new Compra(101, "Compra do José", cerveja);

        // Adicionar mais produtos à compra
        compraJose.addProduto(agua);
        compraJose.addProduto(biscoito);

        // Verificar se um produto está na compra
        bool cervejaNaCompra = compraJose.PesquisarProduto(1);
        Console.WriteLine($"Cerveja está na compra? {cervejaNaCompra}");

        // Remover um produto da compra
        int produtoRemovido = compraJose.ExcluirProduto(2);
        Console.WriteLine($"Produto removido com sucesso? {produtoRemovido}");

        // Listar produtos na compra
        compraJose.ListarProdutos();
    }
}

class Produto{
    public int codigo {get; set;}
    public string descricao {get; set;}
    public double preco;
    public Produto() {}
    public Produto(int codigo, string descricao, double preco) {
        this.codigo = codigo;
        this.descricao = descricao;
        this.preco = preco;
    }
    public double GetPreco() {
        return preco;
    }
    public void SetPreco(double preco) {
        this.preco = preco;
    }
    public void imprimedadosproduto() {
        Console.WriteLine($"codigo={codigo}, descricao={descricao},preco={preco}");
    }
}
class Compra{
    public int codigo;
    public string descricao;
    public List<Produto> Lista = new List<Produto>();
    public Compra(int codigo,string descricao, Produto produto) {
        this.codigo = codigo;
        this.descricao = descricao;
        Lista.Add(produto);
    }
    public int GetCodigo() {
        return codigo;
    }
    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }
    public int addProduto(Produto produto) {
        Lista.Add(produto);
        return 1;
    }
    public int ExcluirProduto(int codigoProduto){
        int removido = 0;
        foreach(Produto p in Lista) {
            if(p.codigo == codigoProduto) {
                Lista.Remove(p);
                removido = 1;
            }
        }
        return removido;
    }
    public bool PesquisarProduto(int codigo){
        bool resposta = false;
        foreach(Produto p in Lista){
            if(p.codigo == codigo){
                resposta = true;
            }
        }
        return resposta;
    }
    public void ListarProdutos() {
        foreach(Produto produto in Lista){
            produto.imprimedadosproduto();
        }
    }
}