using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_nelnet.Data;
using web_api_nelnet.Models;
using System.Text.RegularExpressions;

namespace web_api_nelnet.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GeneralController : ControllerBase
  {
    private readonly AppDbContext _context;

    public GeneralController(AppDbContext context)
    {
      _context = context;
    }


    // private readonly string[] routes = { "/table/dataSet1", "/table/dataSet2", "/table/dataSet4", "/table/dataSet5" };
    // private readonly Random random = new Random();


    [HttpGet("GetTableNames")]
    public IActionResult GetTableNames()
    {
      var tableNames = _context.Model.GetEntityTypes()
          .Select(t => t.GetTableName())
          .Distinct()
          .Where(name =>
              (name.StartsWith("Student") || name.StartsWith("Staff") || name.StartsWith("Missing")|| name.StartsWith("Invalid")|| name.StartsWith("Parent"))
              && !name.Contains("BP"))
          .Select(name => new
          {
            label = ConvertToSentence(name),
            route = $"/table/{name}"       
   })
          .ToList();

      return Ok(tableNames);
    }

    private string ConvertToSentence(string name)
    {
      // Insert spaces before each capital letter (except the first one) to create a sentence-like format
      return Regex.Replace(name, "([a-z])([A-Z])", "$1 $2");
    }
  }


}