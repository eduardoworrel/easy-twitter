using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app.Pages;

public class IndexModel : PageModel
{
    private readonly MyContext _context;
    public IndexModel(MyContext context)
    {
       _context = context;
    }

    public IActionResult OnGetPublish(string email, string conteudo)
    {
        var post = new Post{
            Email = email,
            Conteudo = conteudo,
            Data = DateTime.Now()
        }
        _context.Post.Add(post);
        _context.SaveChanges();
        return new JsonResult(new { Post = post})
    }

    public IActionResult OnGetObtains()
    {
        var list = _context.Post.OrderByDescending(e=> e.Data).ToList()
        return new JsonResult(new { List = list});
    }
}
