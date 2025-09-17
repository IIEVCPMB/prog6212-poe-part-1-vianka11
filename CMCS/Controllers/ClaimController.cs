using Microsoft.AspNetCore.Mvc;
using CMCS.Models;

// Controller for handling claim-related actions
public class ClaimController : Controller
{
    // GET: Display claim submission form
    public IActionResult Submit()
    {
        return View();
    }
    // POST: Handle claim submission from lecturer
    [HttpPost]
    public IActionResult Submit(ClaimViewModel model)
    {
        if (ModelState.IsValid)
        {
            
            TempData["Message"] = "Claim submitted successfully!";
        }
        return View(model);
    }
    // GET: Display list of claims submitted by lecturer
    public IActionResult MyClaims()
    {
        var dummyClaims = new List<ClaimViewModel>
        {
            new ClaimViewModel { ClaimID = 1, LecturerName = "Vianka", Month = "August", HoursWorked = 20, HourlyRate = 200, Status = "Approved" }
        };
        return View(dummyClaims);
    }

    public IActionResult Review(int id)
    {
        var claim = new ClaimViewModel { ClaimID = id, LecturerName = "Vianka", Month = "August", HoursWorked = 20, HourlyRate = 200, Status = "Pending" };
        // Pass the claim to the view for review and approval
        return View(claim);
    }
}
// Troelson, A. and Japikse P., 2022. Pro C# 10 with .NET 6. 11th ed. California: Apress.