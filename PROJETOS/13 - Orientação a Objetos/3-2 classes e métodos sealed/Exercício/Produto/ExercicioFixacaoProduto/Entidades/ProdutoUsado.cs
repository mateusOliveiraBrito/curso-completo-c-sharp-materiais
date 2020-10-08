using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoProduto.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado() { }
        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao)
            : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public sealed override string EtiquetaDePreco()
        {
            return $"{Nome} (usado) $ {Preco.ToString("F2", CultureInfo.InvariantCulture)} (Fabricado em: {DataFabricacao})";
        }
    }
}
