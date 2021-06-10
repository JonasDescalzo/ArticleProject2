using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArticleProject2.Data;
using ArticleProject2.Models;
using Microsoft.AspNetCore.Authorization;

namespace ArticleProject2.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Article
        public async Task<IActionResult> Index()
        {
            return View(await _context.Articles.ToListAsync());
        }

        // GET: Article/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if(id==0)
            {
                return View(new Article());
            }
            else
            {
                return View(_context.Articles.Find(id));
            }
        }

        // POST: Article/Create/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Title,Author,Body,DateCreated")] Article article)
        {
            if (ModelState.IsValid)
            {
                article.DateCreated = DateTime.Now;

                if (article.Id == 0)
                {
                    _context.Add(article);
                }
                else
                {
                    _context.Update(article);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: Article/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var article = await _context.Articles.FindAsync(id);

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}
