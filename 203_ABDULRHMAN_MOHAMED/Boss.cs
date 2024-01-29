using System;
using static System.Net.Mime.MediaTypeNames;

public class BOSS : Enemy
{

    private const int BOSSHealth = 20;

    private const int BOSSMinDamage = 3;
    private const int BOSSMaxDamage = 10;

    public BOSS()
	{
        Health = BOSSHealth;
        Damage = BOSSMaxDamage;
    }
}
