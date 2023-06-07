using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext {
    public MyContext (DbContextOptions<MyContext> Options) : base(Options) {
        
    }

    public DbSet<Post> Posts { get; set; }
    

}