using AspNetCoreStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreStudy.DataContext
{
    public class AspnetNoteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } // 
        public DbSet<Note> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // DB에 접속하는 아이디 및 정보를 작성하는 부분
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetNOteDb;User Id=sa;Password=wlsdn1306;");// 접속하고자 하는 DB에 대한 정보를 작성
        }
    }
}
