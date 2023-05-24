using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LembreteApp.Models;

namespace LembreteApp.Controllers
{
    public class HomeController : Controller
    {
        private static List<Lembrete> lembretes = new List<Lembrete>(); //DECLARANDO LISTA LEMBRETE

        public IActionResult Index() //FUNÇÃO OCORRE DURANTE A PAGINA ABERTA
        {
            var groupedLembretes = lembretes.OrderBy(r => r.Data).GroupBy(r => r.Data.Date); //ORDENA OS LEMBRETES POR ORDEM DE DATA

            var lembreteGroups = new List<List<Lembrete>>();

            foreach (var group in groupedLembretes)
            {
                var lembreteList = group.ToList();
                lembreteGroups.Add(lembreteList);
            }

            return View(lembreteGroups);
        }

        [HttpPost]
        public IActionResult AddLembrete(string nome, DateTime data) //FUNCAO PARA ADICIONAR O LEMBRETE
        {
            if (string.IsNullOrWhiteSpace(nome)) //CASO O NOME DO LEMBRETE ESTEJA VAZIO OU NULO
            {
                TempData["ErrorMessage"] = "O nome do lembrete deve ser preenchido."; 
                return RedirectToAction("Index");
            }

            if (data < DateTime.Now) //CASO A DATA DO LEMBRETE ESTEJA NO PASSADO/HOJE OU NULO
            {
                TempData["ErrorMessage"] = "A data do lembrete deve estar no futuro.";
                return RedirectToAction("Index");
            }

            Lembrete lembrete = new Lembrete
            {
                Nome = nome,
                Data = data
            };

            lembretes.Add(lembrete);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteLembrete(string nome) //FUNCAO PARA DELETAR O LEMBRETE
        {
            Lembrete lembrete = lembretes.FirstOrDefault(r => r.Nome == nome);
            if (lembrete != null)
            {
                lembretes.Remove(lembrete);
            }
            return RedirectToAction("Index");
        }
    }
}