using HeroTest.Models;

namespace HeroTest.Services.HeroService
{
    public interface IHeroService
    {
        public List<Hero> GetAllHeroes();
        public string CreateHero(AddHeroDTO heroObj);
        public string DeleteHero(int heroId);
        public List<Brand> GetAllBrands();
    }
}
