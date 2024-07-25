// See https://aka.ms/new-console-template for more information

 using GameDeveloperI.Classes;
 

public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of Attack
        Attack fireball = new Attack("Fireball", 20);
        Attack punch = new Attack("Punch", 10);
        Attack throwAttack = new Attack("Throw", 15);

        // Create an instance of Enemy
        Enemy bandit = new Enemy("Bandit");

        // Add attacks to the enemy's AttackList
        bandit.AttackList.Add(fireball);
        bandit.AttackList.Add(punch);
        bandit.AttackList.Add(throwAttack);

        // Test the RandomAttack method
        for (int i = 0; i < 5; i++)
        {
            Attack? randomAttack = bandit.RandomAttack();
            if (randomAttack != null)
            {
                Console.WriteLine($"Enemy: {bandit.Name}, Random Attack: {randomAttack.Name}, Damage: {randomAttack.DamageAmount}");
            }
            else
            {
                Console.WriteLine("No attacks available.");
            }
        }
    }
}


 
    
