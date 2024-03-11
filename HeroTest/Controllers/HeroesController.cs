using HeroTest.Models;
using HeroTest.Services.HeroService;
using Microsoft.AspNetCore.Mvc;

namespace HeroTest.Controllers;
[ApiController]
//[Route("[controller]")]
[Route("Heroes")]
public class HeroesController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<HeroesController> _logger;
    private readonly IHeroService _heroService;

    public HeroesController(ILogger<HeroesController> logger,IHeroService heroService)
    {
        _logger = logger;
        _heroService = heroService;
    }

    [HttpGet("GetAllHeroes")]
    public ActionResult<List<Hero>> GetAllHeroes()
    {
        List<Hero> listofheros = _heroService.GetAllHeroes();
        return listofheros!=null? Ok(listofheros):BadRequest();
    }

    [HttpGet("GetAllBrands")]
    public ActionResult<List<Brand>> GetAllBrands()
    {
        List<Brand> listofbrands = _heroService.GetAllBrands();
        return listofbrands != null ? Ok(listofbrands) : BadRequest();
    }
    [HttpPost("AddHero")]
    public ActionResult<string> CreateHero(AddHeroDTO heroObj)
    {
       return _heroService.CreateHero(heroObj);
    }

    [HttpDelete("DeleteHero/{heroId}")]
    public ActionResult<string> DeleteHero(int heroId)
    {
       return _heroService.DeleteHero(heroId);
    }
}

