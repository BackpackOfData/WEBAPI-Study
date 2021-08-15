using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using another_test.Data;
using techSupport.Model;
using Microsoft.AspNetCore.Http;

namespace another_test.Controllers
{

  
    [ApiController, Route("[controller]")]
    public class SupportReqsController : Controller
    {
        private readonly another_testContext _context;

        public SupportReqsController(another_testContext context)
        {
            _context = context;
        }
       
       /* public IActionResult Create()
        {
            return View();
        }*/

        // GET: SupportReqs
        
        /*public async Task<IActionResult> Index()
        {
           
           return View(await Get);
        }*/
        
        [Route("Create"), HttpPost]
        
        public IActionResult Create([FromForm] SupportReq supportReq)
        {
            /*view*/
            ViewData["Message"] = supportReq.Message;
            ViewData["FromWhoId"] = supportReq.FromWhoID;
            ViewData["DateCreate"] = supportReq.DateCreate;
            ViewData["DateExpired"] = supportReq.DateExpired;
            /*insert*/
            SupportReqReposit todo = new SupportReqReposit(_context);
            todo.InsertIntoSupportReqTab(supportReq);
            return View();
        }
        
        [Route("Create"), HttpGet]
        public IActionResult Create() // sync
        {
            
            return View();
        }


        // GET: SupportReqs/Details/5
        /* 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportReq = await _context.SupportReq
                .FirstOrDefaultAsync(m => m.ID == id);
            if (supportReq == null)
            {
                return NotFound();
            }

            return View(supportReq);
        }
        
        // GET: SupportReqs/Create
        public IActionResult Create()
        {
            return View();
        }
        */
        // POST: SupportReqs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Message,FromWhoID,DateCreate,DateExpired,ID")] SupportReq supportReq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supportReq);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supportReq);
        }*/
        /*
        // GET: SupportReqs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportReq = await _context.SupportReq.FindAsync(id);
            if (supportReq == null)
            {
                return NotFound();
            }
            return View(supportReq);
        }

        // POST: SupportReqs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Message,FromWhoID,DateCreate,DateExpired,ID")] SupportReq supportReq)
        {
            if (id != supportReq.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supportReq);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupportReqExists(supportReq.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(supportReq);
        }

        // GET: SupportReqs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportReq = await _context.SupportReq
                .FirstOrDefaultAsync(m => m.ID == id);
            if (supportReq == null)
            {
                return NotFound();
            }

            return View(supportReq);
        }

        // POST: SupportReqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supportReq = await _context.SupportReq.FindAsync(id);
            _context.SupportReq.Remove(supportReq);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupportReqExists(int id)
        {
            return _context.SupportReq.Any(e => e.ID == id);
        }
        */
    }
}
