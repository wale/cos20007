namespace SemesterTest2;

class Program 
{
    static void Main(string[] args) 
    {
        Arena arena = new Arena();
        arena.Attack(5);
        arena.AttackAll(3);
        
        RegularEnemy reg1 = new RegularEnemy();
        RegularEnemy reg2 = new RegularEnemy();
        RegularEnemy reg3 = new RegularEnemy();

        arena.AddEnemy(reg1);
        arena.AddEnemy(reg2);
        arena.AddEnemy(reg3);

        InvincibleEnemy invincible = new InvincibleEnemy();
        arena.AddEnemy(invincible);

        arena.Attack(10);
        arena.AttackAll(1);
    }
}