using HeroTest.Models;

namespace HeroTest.Services.HeroService
{
    public class HeroService : IHeroService
    {
        private readonly SampleContext _sampleContext;
        public HeroService(SampleContext sampleContext)
        {

            _sampleContext = sampleContext;

        }
        public string CreateHero(AddHeroDTO heroObj)
        {
            try
            {
                if (heroObj != null)
                {
                    Hero hero = new Hero
                    {
                        Name = heroObj.Name,
                        Alias = heroObj.Alias,
                        BrandId = heroObj.Brand,
                        CreatedOn = DateTime.Now,
                        IsActive = true,
                    };
                    _sampleContext.Heroes.Add(hero);
                    _sampleContext.SaveChanges();
                    return "Hero Added Successfully";
                }
                return "Hero Cannot be Null";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteHero(int heroId)
        {
            try
            {
                if (heroId != 0)
                {
                    Hero hero = _sampleContext.Heroes.Find(heroId);
                    if (hero != null)
                    {
                        hero.IsActive = false;
                        _sampleContext.Update(hero);
                        _sampleContext.SaveChanges();
                        return "Hero Deleted Successfully";
                    }
                    return "Hero Not Found Against this Id";
                }
                return "Hero Id can not be Null";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Brand> GetAllBrands()
        {
            try
            {
                List<Brand> listofbrands = _sampleContext.Brands.Where(x => x.IsActive == true).ToList();
                if (listofbrands.Any())
                {
                    return listofbrands;
                }
                return null;
            }
            catch 
            {
                return null;
            }
        }

        public List<Hero> GetAllHeroes()
        {
            try
            {
                List<Hero> listOfheroes = _sampleContext.Heroes.Where(x => x.IsActive == true).ToList();
                if(listOfheroes.Any())
                {
                    return listOfheroes;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
