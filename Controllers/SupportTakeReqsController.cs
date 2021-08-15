using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using another_test.Data;
using techSupport.Model;

namespace another_test.Controllers
{
    [Route("[controller]")]
    public class SupportTakeReqsController : Controller
    {

        private readonly another_testContext _context;
        
         public SupportTakeReqsController(another_testContext context)
        {
            _context = context;
        }/*
        // GET: SupportTakeReqs
        public async Task<IActionResult> Index()
        {
            var another_testContext = _context.SupportTakeReq.Include(s => s.SupportReq);
            return View(await another_testContext.ToListAsync());
        }

       
        private readonly another_testContext _context;

        public SupportTakeReqsController(another_testContext context)
        {
            _context = context;
        }

        // GET: SupportTakeReqs
        public async Task<IActionResult> Index()
        {
            var another_testContext = _context.SupportTakeReq.Include(s => s.SupportReq);
            return View(await another_testContext.ToListAsync());
        }

        // GET: SupportTakeReqs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportTakeReq = await _context.SupportTakeReq
                .Include(s => s.SupportReq)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (supportTakeReq == null)
            {
                return NotFound();
            }

            return View(supportTakeReq);
        }

        // GET: SupportTakeReqs/Create
        public IActionResult Create()
        {
            ViewData["SupportReqID"] = new SelectList(_context.Set<SupportReq>(), "ID", "ID");
            return View();
        }

        // POST: SupportTakeReqs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupportReqID,ReqStatus,SupporterPresonID,ID")] SupportTakeReq supportTakeReq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supportTakeReq);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupportReqID"] = new SelectList(_context.Set<SupportReq>(), "ID", "ID", supportTakeReq.SupportReqID);
            return View(supportTakeReq);
        }

        // GET: SupportTakeReqs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportTakeReq = await _context.SupportTakeReq.FindAsync(id);
            if (supportTakeReq == null)
            {
                return NotFound();
            }
            ViewData["SupportReqID"] = new SelectList(_context.Set<SupportReq>(), "ID", "ID", supportTakeReq.SupportReqID);
            return View(supportTakeReq);
        }

        // POST: SupportTakeReqs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupportReqID,ReqStatus,SupporterPresonID,ID")] SupportTakeReq supportTakeReq)
        {
            if (id != supportTakeReq.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supportTakeReq);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupportTakeReqExists(supportTakeReq.ID))
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
            ViewData["SupportReqID"] = new SelectList(_context.Set<SupportReq>(), "ID", "ID", supportTakeReq.SupportReqID);
            return View(supportTakeReq);
        }

        // GET: SupportTakeReqs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportTakeReq = await _context.SupportTakeReq
                .Include(s => s.SupportReq)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (supportTakeReq == null)
            {
                return NotFound();
            }

            return View(supportTakeReq);
        }

        // POST: SupportTakeReqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supportTakeReq = await _context.SupportTakeReq.FindAsync(id);
            _context.SupportTakeReq.Remove(supportTakeReq);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupportTakeReqExists(int id)
        {
            return _context.SupportTakeReq.Any(e => e.ID == id);
        }*/
    }
}
