using System.Collections.Generic;
using UniRx;
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
                Characters.Add(new DataCharacter(i));
            }
        }
    }

    public class DataCharacter
    {
        public ReactiveProperty<string> NameCharacter { get; set; }

        public ReactiveProperty<int> Health { get; set; }
        public ReactiveProperty<int> MaxHealth { get; set; }
        public ReactiveProperty<int> BonusHealth { get; set; }

        //Header
        public ReactiveProperty<int> MovementPoints { get; set; }
        public ReactiveProperty<int> BonusMovementPoints { get; set; }
        public ReactiveProperty<int> Initiative { get; set; }
        public ReactiveProperty<int> BonusInitiative { get; set; }

        //Group Accuracy
        public ReactiveProperty<int> AccuracyStrength { get; set; }
        public ReactiveProperty<int> BonusAccuracyStrength { get; set; }
        public ReactiveProperty<int> AccuracyDexterity { get; set; }
        public ReactiveProperty<int> BonusAccuracyDexterity { get; set; }
        public ReactiveProperty<int> AccuracyMagic { get; set; }
        public ReactiveProperty<int> BonusAccuracyMagic { get; set; }

        //Group Damage
        public ReactiveProperty<int> DamageStrength { get; set; }
        public ReactiveProperty<int> BonusDamageStrength { get; set; }
        public ReactiveProperty<int> DamageDexterity { get; set; }
        public ReactiveProperty<int> BonusDamageDexterity { get; set; }
        public ReactiveProperty<int> DamageMagic { get; set; }
        public ReactiveProperty<int> BonusDamageMagic { get; set; }

        //No group
        public ReactiveProperty<int> CritChance { get; set; }
        public ReactiveProperty<int> BonusCritChance { get; set; }
        public ReactiveProperty<int> Sprint { get; set; }
        public ReactiveProperty<int> BonusSprint { get; set; }
        public ReactiveProperty<int> ExpBonus { get; set; }
        public ReactiveProperty<int> BonusExpBonus { get; set; }
        public ReactiveProperty<int> PanicResist { get; set; }
        public ReactiveProperty<int> BonusPanicResist { get; set; }

        public DataCharacter(int idCharacter)
        {
            NameCharacter = new ReactiveProperty<string>($"{idCharacter}");

            Health = new ReactiveProperty<int>(Random.Range(5, 10));
            MaxHealth = new ReactiveProperty<int>(Random.Range(10, 15));

            MovementPoints = new ReactiveProperty<int>(Random.Range(5, 10));
            Initiative = new ReactiveProperty<int>(Random.Range(0, 10));

            AccuracyStrength = new ReactiveProperty<int>(Random.Range(0, 100));
            AccuracyDexterity = new ReactiveProperty<int>(Random.Range(0, 100));
            AccuracyMagic = new ReactiveProperty<int>(Random.Range(0, 100));

            DamageStrength = new ReactiveProperty<int>(Random.Range(0, 100));
            DamageDexterity = new ReactiveProperty<int>(Random.Range(0, 100));
            DamageMagic = new ReactiveProperty<int>(Random.Range(0, 100));
            CritChance = new ReactiveProperty<int>(Random.Range(0, 25));
            Sprint = new ReactiveProperty<int>(Random.Range(0, 100));
            ExpBonus = new ReactiveProperty<int>(Random.Range(0, 50));
            PanicResist = new ReactiveProperty<int>(Random.Range(0, 5));
        }
    }
}