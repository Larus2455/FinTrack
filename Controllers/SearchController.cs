using FinTrack.Models;
using Microsoft.AspNetCore.Mvc;

public class SearchController : Controller
{
    private readonly ApplicationDbContext _context;
    public SearchController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return View();

        // Пример поиска по категориям и транзакциям
        var categories = _context.Categories
            .Where(c => c.Title.Contains(query))
            .ToList();

        var transactions = _context.Transactions
            .Where(t => t.Note.Contains(query))
            .ToList();

        ViewBag.Categories = categories;
        ViewBag.Transactions = transactions;
        ViewBag.Query = query;
        return View();
    }
}
