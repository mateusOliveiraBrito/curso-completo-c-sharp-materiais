using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoProduto.Entidades
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado() { }
        public ProdutoImportado(string nome, double preco, double taxaAlfandega)
            : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public sealed override string EtiquetaDePreco()
        {
            return Nome + " $ " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) + $" (Taxa alfandegária: $ {TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture)})";
        }
        
        public double PrecoTotal()
        {
            return Preco + TaxaAlfandega;
        }
    }
}
