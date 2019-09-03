using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            List <Livros> list = new List<Livros>();
            list.Add(new Livros { Id = 1, Titulo = "História Sem Fim", Autor = "Michael Ende", Editora = "Martins Fontes", Preco = 38.90f });
            list.Add(new Livros { Id = 2, Titulo = "Momo e o Senhor do Tempo", Autor = "Michael Ende", Editora = "Martins Fontes", Preco = 38.90f });

            return View(list);
        }
    }
}