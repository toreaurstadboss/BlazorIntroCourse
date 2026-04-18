namespace DependencyInjectionDemo.Components.Demos.BuiltInComponents.Sampledata
{
    public class Data
    {
        private List<Superhero> SuperheroList;

        public Data()
        {
            SuperheroList = Enumerable.Repeat(new SuperheroRepository().GetSuperheroes().Result, 100)
                .SelectMany(f => f).Select((s,indx) => new Superhero
                {
                    Id = indx,
                    CreationDate = s.CreationDate,
                    Name = s.Name,
                    Score = s.Score,
                    SpecialAbility = s.SpecialAbility                    
                }).ToList();
        }

        public List<Superhero> GetData()
        {
            return SuperheroList;
        }

        public int GetDataCount => SuperheroList?.Count() ?? 0;

        public Task<List<Superhero>> GetDataAsync(int startIndex, int numberOfHeroes)
        {
            var superheroes = SuperheroList.Skip(startIndex).Take(numberOfHeroes).ToList();
            return Task.FromResult(superheroes!);
        }

    }
}
