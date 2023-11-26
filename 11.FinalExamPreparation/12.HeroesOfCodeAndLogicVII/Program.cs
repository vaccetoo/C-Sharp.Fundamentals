List<Hero> heroes = CreateHeroes();

ManipulateHeroes(heroes);

PrintAllHeroes(heroes);

static List<Hero> CreateHeroes()
{
    int heroesCount = int.Parse(Console.ReadLine());

    List<Hero> heroes = new List<Hero>();

    for (int i = 0; i < heroesCount; i++)
    {
        string[] currentHeroInfo = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string heroName = currentHeroInfo[0];
        int heroHp = int.Parse(currentHeroInfo[1]);
        int heroMp = int.Parse(currentHeroInfo[2]);

        Hero hero = new Hero(heroName, heroHp, heroMp);

        heroes.Add(hero);
    }

    return heroes;
}

static void ManipulateHeroes(List<Hero> heroes)
{
    string command = string.Empty;

    while ((command = Console.ReadLine()) != "End")
    {
        string[] commandInfo = command
            .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

        string commandName = commandInfo[0];
        string heroName = commandInfo[1];

        if (commandName == "CastSpell")
        {
            int manaPointsNeeded = int.Parse(commandInfo[2]);
            string spellName = commandInfo[3];

            foreach (Hero hero in heroes)
            {
                if (hero.Name == heroName)
                {
                    if (hero.ManaPoints >= manaPointsNeeded)
                    {
                        hero.ManaPoints -= manaPointsNeeded;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                    break;
                }
            }
        }
        else if (commandName == "TakeDamage")
        {
            int damage = int.Parse(commandInfo[2]);
            string attackerName = commandInfo[3];

            foreach (Hero hero in heroes)
            {
                if (hero.Name == heroName)
                {
                    hero.HealthPoints -= damage;

                    if (hero.HealthPoints > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attackerName} and now has {hero.HealthPoints} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attackerName}!");
                    }

                    break;
                }
            }
        }
        else if (commandName == "Recharge")
        {
            int addAmmountMp = int.Parse(commandInfo[2]);

            foreach (Hero hero in heroes)
            {
                if (hero.Name == heroName)
                {
                    if (hero.ManaPoints + addAmmountMp > 200)
                    {
                        addAmmountMp = 200 - hero.ManaPoints;
                        hero.ManaPoints = 200;
                    }
                    else
                    {
                        hero.ManaPoints += addAmmountMp;
                    }

                    Console.WriteLine($"{heroName} recharged for {addAmmountMp} MP!");
                    break;
                }
            }
        }
        else if (commandName == "Heal")
        {
            int addAmmountHp = int.Parse(commandInfo[2]);

            foreach (Hero hero in heroes)
            {
                if (hero.Name == heroName)
                {
                    if (hero.HealthPoints + addAmmountHp > 100)
                    {
                        addAmmountHp = 100 - hero.HealthPoints;
                        hero.HealthPoints = 100;
                    }
                    else
                    {
                        hero.HealthPoints += addAmmountHp;
                    }

                    Console.WriteLine($"{heroName} healed for {addAmmountHp} HP!");
                    break;
                }
            }
        }
    }
}

static void PrintAllHeroes(List<Hero> heroes)
{
    // TODO: Remove all heroes with health < 1 !!!
    heroes.RemoveAll(x => x.HealthPoints < 1);

    foreach (Hero hero in heroes)
    {
        Console.WriteLine(hero.Name);
        Console.WriteLine($"  HP: {hero.HealthPoints}");
        Console.WriteLine($"  MP: {hero.ManaPoints}");
    }
}

public class Hero
{
    public Hero(string name, int healthPoints, int manaPoints)
    {
        Name = name;
        HealthPoints = healthPoints;
        ManaPoints = manaPoints;
    }

    public string Name { get; set; }

    public int HealthPoints { get; set; }

    public int ManaPoints { get; set; }
}