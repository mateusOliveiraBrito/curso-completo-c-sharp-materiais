using System.Globalization;

namespace CadastroProdutos {
    class Produto {

        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
            _quantidade = 0;
        }

        public Produto(string nome, double preco): this() {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade): this(nome, preco) {
            _quantidade = quantidade;
        }

        public string Nome {
            get { return _nome;  }
            set { 
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get {
                return _preco;
            }
        }

        public int Quantidade {
            get { return _quantidade;  }
        }

        public double ValorTotalEmEstoque() {
            return _quantidade * _preco;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return $"{this.Nome}, $ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {this.Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}