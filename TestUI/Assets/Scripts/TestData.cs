using System.Collections.Generic;
using UnityEngine;

namespace Test
{
	public static class TestData
	{
		public static List<DataCharacter> Characters { get; private set; }

		static TestData()
		{
			Characters = new List<DataCharacter>();

			for (int i = 0; i < 10; i++)
			{
				Characters.Add(new DataCharacter(i + 1));
			}
		}
	}

	public class DataCharacter
	{
		public string NameCharacter { get; set; }

		public int Health { get; set; }
		public int MaxHealth { get; set; }
		public int BonusHealth { get; set; }

		//Header
		public int MovementPoints { get; set; }
		public int BonusMovementPoints { get; set; }
		public int Initiative { get; set; }
		public int BonusInitiative { get; set; }

		//Group Accuracy
		public int AccuracyStrength { get; set; }
		public int BonusAccuracyStrength { get; set; }
		public int AccuracyDexterity { get; set; }
		public int BonusAccuracyDexterity { get; set; }
		public int AccuracyMagic { get; set; }
		public int BonusAccuracyMagic { get; set; }

		//Group Damage
		public int DamageStrength { get; set; }
		public int BonusDamageStrength { get; set; }
		public int DamageDexterity { get; set; }
		public int BonusDamageDexterity { get; set; }
		public int DamageMagic { get; set; }
		public int BonusDamageMagic { get; set; }

		//No group
		public int CritChance { get; set; }
		public int BonusCritChance { get; set; }
		public int Sprint { get; set; }
		public int BonusSprint { get; set; }
		public int ExpBonus { get; set; }
		public int BonusExpBonus { get; set; }
		public int PanicResist { get; set; }
		public int BonusPanicResist { get; set; }

		public DataCharacter(int idCharacter)
		{
			NameCharacter = $"Character\n{idCharacter}";

			Health = Random.Range(5, 10);
			MaxHealth = Random.Range(10, 15);

			MovementPoints = Random.Range(5, 10);
			Initiative = Random.Range(0, 10);

			AccuracyStrength = Random.Range(0, 100);
			AccuracyDexterity = Random.Range(0, 100);
			AccuracyMagic = Random.Range(0, 100);

			DamageStrength = Random.Range(0, 100);
			DamageDexterity = Random.Range(0, 100);
			DamageMagic = Random.Range(0, 100);
			CritChance = Random.Range(0, 25);
			Sprint = Random.Range(0, 100);
			ExpBonus = Random.Range(0, 50);
			PanicResist = Random.Range(0, 5);
		}
	}
}