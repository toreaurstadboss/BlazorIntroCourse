using DependencyInjectionDemo.Components.Demos.BuiltInComponents.Sampledata;

namespace DependencyInjectionDemo.Components.Demos.BuiltInComponents.Sampledata;


public class SuperheroRepository
{
    public async Task<List<Superhero>> GetSuperheroes()
    {
        var heroes = new List<Superhero>();

        var namesAndAbilities = new (string Name, string Ability)[] {
            ("Superman", "Flight, Super Strength"),
            ("Batman", "Intelligence, Martial Arts"),
            ("Wonder Woman", "Super Strength, Lasso of Truth"),
            ("Spider-Man", "Wall-Crawling, Spider Sense"),
            ("Iron Man", "Powered Armor Suit"),
            ("Captain America", "Enhanced Strength, Shield"),
            ("Thor", "God of Thunder, Mjolnir"),
            ("Hulk", "Super Strength"),
            ("Black Panther", "Enhanced Senses, Vibranium Suit"),
            ("Doctor Strange", "Mystic Arts"),
            ("Flash", "Super Speed"),
            ("Aquaman", "Underwater Breathing, Telepathy"),
            ("Green Lantern", "Power Ring Constructs"),
            ("Scarlet Witch", "Reality Manipulation"),
            ("Vision", "Density Control"),
            ("Ant-Man", "Size Manipulation"),
            ("Wasp", "Size Manipulation, Flight"),
            ("Hawkeye", "Archery"),
            ("Black Widow", "Espionage, Combat"),
            ("Star-Lord", "Expert Marksman"),
            ("Gamora", "Combat Skills"),
            ("Drax", "Super Strength"),
            ("Rocket Raccoon", "Weapons Expert"),
            ("Groot", "Regeneration"),
            ("Captain Marvel", "Energy Manipulation, Flight"),
            ("Deadpool", "Regeneration, Combat"),
            ("Wolverine", "Healing Factor, Adamantium Claws"),
            ("Cyclops", "Optic Blasts"),
            ("Storm", "Weather Control"),
            ("Jean Grey", "Telepathy, Telekinesis"),
            ("Professor X", "Telepathy"),
            ("Magneto", "Magnetism Control"),
            ("Beast", "Super Strength, Agility"),
            ("Nightcrawler", "Teleportation"),
            ("Colossus", "Metal Skin"),
            ("Rogue", "Power Absorption"),
            ("Iceman", "Cryokinesis"),
            ("Human Torch", "Pyrokinesis, Flight"),
            ("Invisible Woman", "Invisibility, Force Fields"),
            ("Mr. Fantastic", "Elasticity"),
            ("Thing", "Super Strength"),
            ("Silver Surfer", "Cosmic Power"),
            ("Blade", "Vampire Hunting"),
            ("Green Arrow", "Archery"),
            ("Shazam", "Magic Powers"),
            ("Hellboy", "Super Strength"),
            ("Spawn", "Necroplasm Powers"),
            ("Punisher", "Weapons Expert"),
            ("Moon Knight", "Combat Skills")
        };

        int id = 0;
        foreach (var hero in namesAndAbilities)
        {
            heroes.Add(new Superhero
            {
                Id = id++,
                Name = hero.Name,
                SpecialAbility = hero.Ability
            });
        }
        return await Task.FromResult(heroes);
    }

}


