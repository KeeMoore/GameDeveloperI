namespace GameDeveloperI.Classes;
public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Attack> AttackList { get; set; }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public Attack? RandomAttack()
    {
        if (AttackList.Count == 0)
        {
            return null;
        }

        Random random = new Random();
        int index = random.Next(AttackList.Count);
        return AttackList[index];
    }
}


