using Microsoft.EntityFrameworkCore;

namespace Pim2.Data
{
    public class PimContext : DbContext
    {
        public PimContext(DbContextOptions<PimContext> options) : base(options) { }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Produto> Produto { get; set; }
    }

    public class Pedido
    {
        public int Id { get; set; }
        public string CNPJCliente { get; set; }
        public string Produto { get; set; }
        public int QuantidadeProduto { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataCriacao { get; set; }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime DataCriacao { get; set; }
    }

}
