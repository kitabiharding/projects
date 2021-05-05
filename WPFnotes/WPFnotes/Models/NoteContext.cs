using Microsoft.EntityFrameworkCore;

namespace WPFnotes.Models
{
    class NoteContext : DbContext
    {
        public DbSet<NoteModels> Notes { get; set; }
        public DbSet<TagsModels> Tags { get; set; }
        public DbSet<PromptModels> Prompts { get; set; }

        public NoteContext()
        {
            // для пересоздания базы данных
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=notesdb;Trusted_Connection=True;");
        }
    }
}
