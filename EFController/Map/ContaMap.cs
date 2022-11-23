using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFController.Map
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        public ContaMap()
        {
            this.ToTable("Contas");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_CONTAS");
            this.Property(d => d.Nome).HasColumnName("NOME");
            this.Property(d => d.Banco).HasColumnName("BANCO");
            this.Property(d => d.Agencia).HasColumnName("AGENCIA");
            this.Property(d => d.NumeroConta).HasColumnName("NUMEROCONTA");
            this.Property(d => d.Digito).HasColumnName("DIGITO");
            this.Property(d => d.Saldo).HasColumnName("SALDO");

            /*  public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Banco { get; set; }
        public string? Agencia { get; set; }
        public string? NumeroConta { get; set; }
        public string? Digito { get; set; }
        public double Saldo { get; set; }*/
        }
    }
}
