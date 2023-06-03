namespace SemesterTest2;

class InvincibleEnemy : Enemy
{
    public override void GetHit(int damage)
    {
        Console.WriteLine("Ha! Nice try!");
    }
}