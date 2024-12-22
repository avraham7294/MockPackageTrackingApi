using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockPackageTrackingApi.Data;
using MockPackageTrackingApi.Models;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class PackageTrackingController : ControllerBase
{
    private readonly MockPackageTrackingContext _context;

    public PackageTrackingController(MockPackageTrackingContext context)
    {
        _context = context;
    }

    // GET: api/PackageTracking/{trackingNumber}
    [HttpGet("{trackingNumber}")]
    public async Task<ActionResult<PackageTracking>> GetPackage(string trackingNumber)
    {
        var package = await _context.Packages
            .FirstOrDefaultAsync(p => p.TrackingNumber == trackingNumber);

        if (package == null)
        {
            return NotFound();
        }

        return package;
    }
}
