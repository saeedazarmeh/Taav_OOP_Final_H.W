using Test4;

while (true)
{
    Console.WriteLine("Choose your Operation Index:\n" +
        "1-Add Champion\n" +
        "2-Add Enemi\n" +
        "3-Show Characters\n" +
        "4-Attac to Enemy\n" +
        "5-Attac to Champion\n");
    var choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter Champion Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Cahmpion Health");
                var health = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Cahmpion Power");
                var power = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Cahmpion Speed");
                var speed = int.Parse(Console.ReadLine());
                var champion = new Champion(health, power, speed, name);
                champion.SetId();
                Character.AddToList(champion);

            }
            break;
        case 2:
            {
                Console.WriteLine("Enter Enemy Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Enemy Health");
                var health = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Enemy Power");
                var power = int.Parse(Console.ReadLine());
                var enemy = new Enemy(health, power, name);
                enemy.SetId();
                Character.AddToList(enemy);

            }
            break;
        case 3:
            {
                Utility.ShowCharaters();
            }
            break;
        case 4:
            {
                Console.WriteLine("Enter Champion Id");
                var championId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Enemy Id");
                var enemyId = int.Parse(Console.ReadLine());
                var enemy=Character.characters.FirstOrDefault(c=>c.Id == enemyId);
                var champion=Character.characters.FirstOrDefault(c=>c.Id == championId);
                enemy.UnderAttacked(champion.Power);
            }
            break;
        case 5:
            {
                Console.WriteLine("Enter Champion Id");
                var championId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Enemy Id");
                var enemyId = int.Parse(Console.ReadLine());
                var enemy = Character.characters.FirstOrDefault(c => c.Id == enemyId);
                var champion = Character.characters.FirstOrDefault(c => c.Id == championId);
                champion.UnderAttacked(enemy.Power);
            }
            break;
    }
}
