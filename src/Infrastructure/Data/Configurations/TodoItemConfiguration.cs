using dotnet_clean_architecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet_clean_architecture.Infrastructure.Data.Configurations;

public class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
{
    public void Configure(EntityTypeBuilder<TodoItem> builder)
    {
        builder.Property(t => t.Title)
            .HasMaxLength(200)
            .IsRequired();
    }
}
