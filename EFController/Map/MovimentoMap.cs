using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFController.Map
{
    public class MovimentoMap : EntityTypeConfiguration<Movimento>
    {
        public MovimentoMap()
        {
            this.ToTable("Movimentos");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_MOV");
            this.Property(d => d.Tipomov).HasColumnName("TIPOMOV");
            this.Property(d => d.Valor).HasColumnName("VALOR");
            this.Property(d => d.Datamovimento).HasColumnName("DATAMOVIMENTO");
            this.Property(d => d.Horamovimento).HasColumnName("HORAMOVIMENTO");
            this.Property(d => d.Idconta).HasColumnName("IDCONTA");


        }
    }
}
