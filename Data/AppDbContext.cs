using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Adicione seus DbSets aqui, exemplo:
    // public DbSet<Livro> Livros { get; set; }
}