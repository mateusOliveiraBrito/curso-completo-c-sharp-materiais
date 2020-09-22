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

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            this._nome = nome;
        }

        public double GetPreco() {
            return this._preco;
        }

        public void SetPreco(double preco) {
            this._preco = preco;
        }

        public int GetQuantidade() {
            return this._quantidade;
        }

        public void SetQuantidade(int quantidade) {
            this._quantidade = quantidade;
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
            return $"{this.GetNome()}, $ {this.GetPreco().ToString("F2", CultureInfo.InvariantCulture)}, {this.GetQuantidade()} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}