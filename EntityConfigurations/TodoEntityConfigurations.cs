using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApis.Models;

namespace TodoApis.Data;

public class TodoEntityConfigurations : IEntityTypeConfiguration<Todo>
{
    public void Configure(EntityTypeBuilder<Todo> entityBuilder)
    {
        entityBuilder.ToTable("Todos");

        entityBuilder
        .Property(x => x.Id)
        .HasColumnName("Id");

        entityBuilder
        .HasKey(x => x.Id);

        entityBuilder
        .Property(x=>x.Description)
        .HasColumnName("Description")
        .HasColumnType("TEXT")
        .HasMaxLength(500);

        entityBuilder
        .Property(x=>x.EndDateTime)
        .HasColumnType("DATETIME")
        .HasColumnName("EndDateTime");

        entityBuilder
        .Property(x=>x.Title)
        .HasColumnName("Title")
        .HasColumnType("TEXT");
    }
}
