using System;

public class Yokai : Enemy
{

	private const int yokaiHealth = 20;

	private const int yokaiMinDamage = 3;
	private const int yokaiMaxDamage = 10;

	/*
	public int Damage
	{
		get
		{
			return yokaiMaxDamage;
			//Random newRandom = new Random();
			//return newRandom.Next(yokaiMinDamage, yokaiMaxDamage + 1);
		} protected set
		{
			Damage = value;
		}
	}
	*/

	public Yokai()
	{
		Health = yokaiHealth;
		Damage = yokaiMaxDamage;
	}


}
