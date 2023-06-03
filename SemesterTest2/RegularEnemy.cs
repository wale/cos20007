namespace SemesterTest2;

class RegularEnemy : Enemy 
{
    private int _health;

    public RegularEnemy()
    {
        _health = 10;
    }

    public override void GetHit(int damage)
    {
        if (_health > 0) 
        {
            Console.WriteLine("Ow!");
            _health = _health - damage;
        }
        else 
        {
            Console.WriteLine("You already got me!");
        }
    }
}