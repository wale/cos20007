namespace SemesterTest2;

class Arena 
{
    private List<Enemy> _enemies;

    public Arena()
    {
        this._enemies = new List<Enemy>(); // Initialise an empty list.
    }

    public void AddEnemy(Enemy enemy)
    {
        _enemies.Add(enemy);
    }

    public void Attack(int damage) 
    {
        if (_enemies.Count > 0) 
        {
            Console.WriteLine("Bring it on!");

            _enemies[0].GetHit(damage);
        } 
        else 
        {
            Console.WriteLine("Not very effective...");
        }
    }

    public void AttackAll(int damage)
    {
        if (_enemies.Count > 0) 
        {
            Console.WriteLine("Charge!");
            foreach (Enemy e in _enemies) {
                e.GetHit(damage);
            }
        }
        else 
        {
            Console.WriteLine("There's nobody here...");
        }
    }
}