using AspNetCoreStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreStudy.DataContext
{
    public class AspnetNoteDbContext : DbContext //EntitityFramwork 아래에 있는 DBContext을 상속을 받기 위해서 다음과 같이 사용한다.
    {
        public DbSet<User> Users { get; set; } // 
        public DbSet<Note> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // DB에 접속하는 아이디 및 정보를 작성하는 부분
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetNoteDb;User Id=sa;Password=wlsdn1306;Encrypt=false");// 접속하고자 하는 DB에 대한 정보를 작성
        }
    }
}
