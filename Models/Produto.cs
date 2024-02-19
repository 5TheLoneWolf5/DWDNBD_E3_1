namespace DWDNBD_E3_1.Models
{
    public class Produto
    {
        private int id;
        private string nome;
        private double valor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
