using System.Globalization;

namespace CadastroProdutos {
    class Produto {

        // _nome não pode ser uma auto propertie devido ao fato de ter uma implementacao particular, por isso possui
        // uma outra implementação (manual) logo abaixo
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto() {
            Quantidade = 0;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return $"{this.Nome}, $ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {this.Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}