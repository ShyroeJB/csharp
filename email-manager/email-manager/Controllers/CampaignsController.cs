using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using email_manager.Contexts;
using email_manager.Models;
using email_manager.ViewModels;

namespace email_manager.Controllers
{
    public class CampaignsController : Controller
    {
        private readonly EmailManagerContext _context;

        public CampaignsController(EmailManagerContext context)
        {
            _context = context;
        }

        // GET: Campaigns
        public async Task<IActionResult> Index()
        {
            var emailManagerContext = _context.Campaign.Include(c => c.CampaignStatus).Include(c => c.Email);
            return View(await emailManagerContext.ToListAsync());
        }

        // GET: Campaigns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaign
                .Include(c => c.CampaignStatus)
                .Include(c => c.Email)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campaign == null)
            {
                return NotFound();
            }

            return View(campaign);
        }

        // GET: Campaigns/Create
        public IActionResult Create()
        {
            ViewData["EmailId"] = new SelectList(_context.Email, "Id", "Id");
            ViewData["ContactsEmailAdress"] = new MultiSelectList(_context.Contact, "EmailAdress", "EmailAdress");
            return View();
        }

        // POST: Campaigns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,EmailId,EmailName,EmailContent,EmailObject,EmailExpeditor,ContactsEmailAdress")] CampaignDto campaignDto)
        {
            if (ModelState.IsValid)
            {
                int emailId = 0;
                if (!string.IsNullOrEmpty(campaignDto.EmailName))
                {
                    Email email = new Email()
                    {
                        Name = campaignDto.EmailName,
                        Content = campaignDto.EmailContent,
                        Object = campaignDto.EmailObject,
                        Expeditor = campaignDto.EmailExpeditor
                    };
                    _context.Email.Add(email);
                    await _context.SaveChangesAsync();
                    var emailSaved = _context.Email.FirstOrDefault(e => e.Name.Equals(email.Name));
                    emailId = emailSaved.Id;
                }
                else
                {
                    emailId = (int)campaignDto.EmailId;
                }

                Campaign campaign = new Campaign()
                {
                    Name = campaignDto.Name,
                    EmailId = emailId,
                };

                var createdStatus = _context.CampaignStatus.FirstOrDefault(s => s.Name.Equals("Created"));
                campaign.CampaingStatusId = createdStatus.Id;

                _context.Campaign.Add(campaign);

                await _context.SaveChangesAsync();

                foreach (var item in campaignDto.ContactsEmailAdress)
                {
                    var contact = _context.Contact.FirstOrDefault(s => s.EmailAdress.Equals(item));
                    var campaignSaved = _context.Campaign.FirstOrDefault(c => c.Name.Equals(campaign.Name));
                    var campaignContact = new CampaignContact()
                    {
                        ContactId = contact.Id,
                        CampaignId = campaignSaved.Id
                    };
                    _context.CampaignContact.Add(campaignContact);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmailId"] = new SelectList(_context.Email, "Id", "Id", campaignDto.EmailId);
            return View(campaignDto);
        }

        // GET: Campaigns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaign.FindAsync(id);
            if (campaign == null)
            {
                return NotFound();
            }
            ViewData["CampaingStatusId"] = new SelectList(_context.CampaignStatus, "Id", "Id", campaign.CampaingStatusId);
            ViewData["EmailId"] = new SelectList(_context.Email, "Id", "Id", campaign.EmailId);
            return View(campaign);
        }

        // POST: Campaigns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CampaingStatusId,EmailId")] Campaign campaign)
        {
            if (id != campaign.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campaign);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampaignExists(campaign.Id))
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
            ViewData["CampaingStatusId"] = new SelectList(_context.CampaignStatus, "Id", "Id", campaign.CampaingStatusId);
            ViewData["EmailId"] = new SelectList(_context.Email, "Id", "Id", campaign.EmailId);
            return View(campaign);
        }

        // GET: Campaigns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaign
                .Include(c => c.CampaignStatus)
                .Include(c => c.Email)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campaign == null)
            {
                return NotFound();
            }

            return View(campaign);
        }

        // POST: Campaigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campaign = await _context.Campaign.FindAsync(id);
            _context.Campaign.Remove(campaign);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampaignExists(int id)
        {
            return _context.Campaign.Any(e => e.Id == id);
        }
    }
}
