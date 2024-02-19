using DWDNBD_E3_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DWDNBD_E3_1.Pages
{
    public class IndexModel : PageModel
    {
        public Produto prod { get; set; } // For it to be accessed on the cshtml (Razor Page), it needs to be a global attribute.
        public List<Produto> produtoList { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Console.WriteLine("Testing");
            prod = new Produto();
            Console.WriteLine(prod.Id + " Produto instanciado");
            prod.Id = 1;
            prod.Nome = "Teste";
            prod.Valor = 500;
            produtoList = new List<Produto>();
            produtoList.Add(prod);
            produtoList.Add(new Produto { Id = 5, Nome = "Pepsi", Valor = 4.99 });
            produtoList.Add(new Produto { Id = 6, Nome = "Fanta", Valor = 4.99 });
        }
    }
}
