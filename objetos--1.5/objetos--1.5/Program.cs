using System;
using System.Collections.Generic;

namespace objetos__1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoa = new List<Pessoa>();

            pessoa.Add(new Pessoa(1, "Victor", "65"));
            pessoa.Add(new Pessoa(2, "Leandro", "31"));
            pessoa.Add(new Pessoa(3, "Marcelo", "25"));
            pessoa.Add(new Pessoa(4, "Victoria", "75"));
            pessoa.Add(new Pessoa(5, "Roberta", "46"));
            pessoa.Add(new Pessoa(6, "Mariana", "35"));
            pessoa.Add(new Pessoa(7, "Felipe", "25"));
            pessoa.Add(new Pessoa(8, "Frederico", "17"));


            ListaPessoa listapessoa = new ListaPessoa();

            listapessoa.Pessoa = pessoa;
            listapessoa.Pessoa = new List<Pessoa>();

            foreach (Pessoa p in pessoa)
            {
                listapessoa.Pessoa.Add(new Pessoa(p.Codigo, p.Nome, p.Idade));
            }

            int opcao = Convert.ToInt32(Console.ReadLine());
            //if's ou switch's:
            if (opcao == (int)Opcoes.InserirNoCarrinho)
            {
                //pedir pro usuário o código do produto.
                int codigo = Convert.ToInt32(Console.ReadLine());
                Pessoa pSelecionado = EncontrarPessoa(pessoa, codigo);
                //criar uma validação e etc.
                if (pSelecionado != null)
                {
                    //carrinho.Produtos.Add(produtoSelecionado);
                    listapessoa.Pessoa.Add(new Pessoa(pSelecionado.Codigo, pSelecionado.Nome,
                                          pSelecionado.Idade));
                    Console.WriteLine("Produto adicionado ao carrinho.");
                }
            }
        }

        static Pessoa EncontrarPessoa(List<Pessoa> pessoa, int codigo) {

            Pessoa pessoinha = null;
            for (int i = 0; i< pessoa.Count; i++)
            {
                if (pessoa[i].Codigo == codigo)
                {
                    pessoinha = pessoa[i];
                }
            }
            return pessoinha; 
        }

        enum Opcoes
        {
            InserirNoCarrinho,
            CriarVenda

        }
        //Console.Write(string.Join(Environment.NewLine, listapessoa.Pessoa));
      
        //else if (opcao == (int)Opcoes.CriarVenda)
        //{
        //    //pedir pro usuário o codigo do cliente;
        //    //pedir pro usuário o cracha do vendedor;
        //    //para poder criar a venda;
        //    int codigoCliente = Convert.ToInt32(Console.ReadLine());
        //    int codigoVendedor = Convert.ToInt32(Console.ReadLine());
        //    //encontra o cliente
        //    Cliente cSelecionado = EncontrarCliente(clientes, codigoCliente);
        //    //encontra o vendedor
        //    Vendedor vSelecionado = EncontrarVendedor(vendedores, codigoVendedor);

        //    //precisa achar os dois para poder criar a venda.
        //    if (cSelecionado != null && vSelecionado != null)
        //    {
        //        vendaAtual.Cliente = cSelecionado;//fazer isso na hora de fechar a venda: new Cliente(cSelecionado.Codigo, cSelecionado.Nome, cSelecionado.Cpf, cSelecionado.Endereco);
        //        vendaAtual.Vendedor = vSelecionado;
        //        if (carrinho.Produtos != null && carrinho.Produtos.Any())
        //        {
        //            //pois assim, caso mexa no carrinho, a atualização aparecerá na venda.
        //            vendaAtual.Produtos = carrinho.Produtos;
        //            //ou pode se fazer usando algum laço de repetição, adicionando novos objetos na lista.
        //        }
        //    }
        //}
        //else if (opcao == (int)Opcoes.FinalizarVenda)
        //{
        //    //pega os produtos do carrinho e joga na venda para finalizá-la e guardar o histórico dela.
        //    vendaAtual.Produtos = CopiarProdutosParaOutraLista(carrinho.Produtos);
        //    vendaAtual.Cliente = new Cliente(clienteAtual.Codigo, clienteAtual.Nome, clienteAtual.Cpf, clienteAtual.Endereco);
        //    vendaAtual.Vendedor = new Vendedor(vendedorAtual.Codigo, vendedorAtual.Nome, vendedorAtual.CodigoCracha);
        //    vendaAtual.Finalizada = true;
        //    vendas.Add(new Venda());
        //    Console.WriteLine("Venda finalizada.");
        //}








    }
}

public class Pessoa
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Idade { get; set; }

    public override string ToString()
    {
        return $"{this.Codigo} {this.Nome} {this.Idade}";
    }

    public Pessoa(int codigo, string nome, string idade)
    {
        this.Codigo = codigo;
        this.Nome = nome;
        this.Idade = idade;


    }

}

public class ListaPessoa
{

    public List<Pessoa> Pessoa;

}

