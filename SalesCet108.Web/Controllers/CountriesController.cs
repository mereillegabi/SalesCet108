
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesCet108.Web.Data.Entities;
using SalesCet108.Web.Data;

public class CountriesController : Controller
{
    private readonly ICountryRepository _countryRepository;

    public CountriesController(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    // GET: COUNTRYS
    public IActionResult Index()    
    {
        return View( _countryRepository.GetAll().OrderBy(c => c.Name));
    }

    // GET: COUNTRYS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var country = await _countryRepository.GetByIdAsync(id.Value);
        if (country == null)
        {
            return NotFound();
        }

        return View(country);
    }

    // GET: COUNTRYS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: COUNTRYS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name")] Country country)
    {
        if (ModelState.IsValid)
        {
            if(await _countryRepository.CountryExistsByNameAsync(country))
            {
                ModelState.AddModelError(nameof(Country.Name), "Já existe um país com este nome");
                return View(country);
            }

            await _countryRepository.CreateAsync(country);

            return RedirectToAction(nameof(Index));
        }
        return View(country);
    }

    // GET: COUNTRYS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var country = await _countryRepository.GetByIdAsync(id.Value);
        if (country == null)
        {
            return NotFound();
        }
        return View(country);
    }

    // POST: COUNTRYS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id,Country country)
    {
        if (id != country.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                if(await _countryRepository.CountryExistsByNameAsync(country))
                {
                    ModelState.AddModelError(nameof(Country.Name), "Já existe um país com este nome");
                    return View(country);
                }
                await _countryRepository.UpdateAsync(country);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _countryRepository.ExistsAsync(country.Id))
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
        return View(country);
    }

    // GET: COUNTRYS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var country = await _countryRepository.GetByIdAsync(id.Value);
        if (country == null)
        {
            return NotFound();
        }

        return View(country);
    }

    // POST: COUNTRYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        
        if (id == null)
        {
            return NotFound();
        }

        var country = await _countryRepository.GetByIdAsync(id.Value);
        if(country != null)
        {
            await _countryRepository.DeleteAsync(country);
        }
        return RedirectToAction(nameof(Index));
    }
}
