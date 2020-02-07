using System;
using System.Linq;
using CrudLoja.Models;
using Microsoft.AspNetCore.Mvc;
using CrudLoja.DataBase;

namespace CrudLoja.Controllers
{
    public class ProdutosController : Controller
    {
        
        private readonly ApplicationDBContext database;
        public ProdutosController(ApplicationDBContext database){
                this.database = database;
        }

        public IActionResult listar(){
            var produtos = database.Produtos.ToList();
            return View(produtos);
        }

        public IActionResult Cadastrar(){
            return View();
        }

        public IActionResult Editar(int id){
            Produto produto = database.Produtos.First(registro => registro.Id == id);
            return View("Cadastrar", produto);
        }

        public IActionResult Deletar(int id){
            Produto produto = database.Produtos.First(registro => registro.Id == id);
            database.Produtos.Remove(produto);
            database.SaveChanges();
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Salvar(Produto produto){
            if(produto.Id == 0){
                database.Produtos.Add(produto);
            }else{
                Produto produtoDoBanco = database.Produtos.First(registro => registro.Id == produto.Id);
                
                produtoDoBanco.Nome = produto.Nome;
                produtoDoBanco.Cor = produto.Cor;
                produtoDoBanco.Quantidade = produto.Quantidade;
                produtoDoBanco.Valor = produto.Valor;
            }
            database.SaveChanges();
            return RedirectToAction("listar");

        }
    }
}