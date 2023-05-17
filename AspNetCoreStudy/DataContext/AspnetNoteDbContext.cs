using AspNetCoreStudy.Models;
using Microsoft.EntityFrameworkCore;

// 모델에 선언된 프로퍼티(User.cs, Note.cs)와 데이터 베이스를 연결하기 위한 클래스
namespace AspNetCoreStudy.DataContext
{
    public class AspnetNoteDbContext : DbContext //EntitityFramwork 아래에 있는 DBContext을 상속을 받기 위해서 다음과 같이 사용한다.(상속 키워드 :)
    {
        // EF COre Migration 작업
        public DbSet<User> Users { get; set; } //  모델 클래스로 부터 데이터 베이스와 테이블을 생성하기 위한 과정(Model에 정의한 프로퍼티를 테이블화 시켜준다.)
        public DbSet<Note> Notes { get; set; } // 모델 클래스로 부터 데이터 베이스와 테이블을 생성하기 위한 과정(Model에 정의한 프로퍼티를 테이블화 시켜준다.)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // DB에 접속하는 아이디 및 정보를 작성하는 부분
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetNoteDb;User Id=sa;Password=wlsdn1306;Encrypt=false");// 접속하고자 하는 DB에 대한 정보를 작성
        }
    }
}
