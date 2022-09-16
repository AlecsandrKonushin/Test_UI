using UnityEngine;
using Test;
using TMPro;
using UnityEngine.UI;
using NaughtyAttributes;
using UniRx;

namespace UI.CharacterWindow
{
    public class DataCharacterView : MonoBehaviour
    {
        private CompositeDisposable disposable = new CompositeDisposable();

        [BoxGroup("Health Parameters")]
        [SerializeField] private BlockParameter healthBlock;
        [BoxGroup("Health Parameters")]
        [SerializeField] private Slider healthSlider;

        [BoxGroup("Initiative Parameters")]
        [SerializeField] private BlockParameter actionPointsBlock, initiativeBlock;

        [BoxGroup("Accuracy Parameters")]
        [SerializeField] private BlockParameter accuracyStrengthText, accuracyDexterityText, accuracyMagicText;

        [BoxGroup("Damage Parameters")]
        [SerializeField] private BlockParameter damageStrengthText, damageDexterityText, damageMagicText;

        [BoxGroup("Other Parameters")]
        [SerializeField] private BlockParameter critChanceText, sprintText, expBonusText, panicResistText;

        public void ShowDataCharacter(DataCharacter data)
        {
            disposable.Clear();

            // Health

            data.Health.Subscribe(_ =>
            {
                UpdateHealthParameter(data.Health.Value, data.MaxHealth.Value, data.BonusHealth.Value);
            }).AddTo(disposable);

            data.BonusHealth.Subscribe(_ =>
            {
                UpdateHealthParameter(data.Health.Value, data.MaxHealth.Value, data.BonusHealth.Value);
            }).AddTo(disposable);

            data.MaxHealth.Subscribe(_ =>
            {
                UpdateHealthParameter(data.Health.Value, data.MaxHealth.Value, data.BonusHealth.Value);
            }).AddTo(disposable);

            // Movement 

            data.MovementPoints.Subscribe(_ =>
            {
                UpdateView(actionPointsBlock, data.MovementPoints.Value, data.BonusMovementPoints.Value);
            }).AddTo(disposable);

            data.BonusMovementPoints.Subscribe(_ =>
            {
                UpdateView(actionPointsBlock, data.MovementPoints.Value, data.BonusMovementPoints.Value);
            }).AddTo(disposable);

            // Initiative

            data.Initiative.Subscribe(_ =>
            {
                UpdateView(initiativeBlock, data.Initiative.Value, data.BonusInitiative.Value);
            }).AddTo(disposable);

            data.BonusInitiative.Subscribe(_ =>
            {
                UpdateView(initiativeBlock, data.Initiative.Value, data.BonusInitiative.Value);
            }).AddTo(disposable);

            // Accuracy strength

            data.AccuracyStrength.Subscribe(_ =>
            {
                UpdateView(accuracyStrengthText, data.AccuracyStrength.Value, data.BonusAccuracyStrength.Value);
            }).AddTo(disposable);

            data.BonusAccuracyStrength.Subscribe(_ =>
            {
                UpdateView(accuracyStrengthText, data.AccuracyStrength.Value, data.BonusAccuracyStrength.Value);
            }).AddTo(disposable);

            // Accuracy dexterity

            data.AccuracyDexterity.Subscribe(_ =>
            {
                UpdateView(accuracyDexterityText, data.AccuracyDexterity.Value, data.BonusAccuracyDexterity.Value);
            }).AddTo(disposable);

            data.BonusAccuracyDexterity.Subscribe(_ =>
            {
                UpdateView(accuracyDexterityText, data.AccuracyDexterity.Value, data.BonusAccuracyDexterity.Value);
            }).AddTo(disposable);

            // Accuracy magic

            data.AccuracyMagic.Subscribe(_ =>
            {
                UpdateView(accuracyMagicText, data.AccuracyMagic.Value, data.BonusAccuracyMagic.Value);
            }).AddTo(disposable);

            data.BonusAccuracyMagic.Subscribe(_ =>
            {
                UpdateView(accuracyMagicText, data.AccuracyMagic.Value, data.BonusAccuracyMagic.Value);
            }).AddTo(disposable);

            // Damage strength

            data.DamageStrength.Subscribe(_ =>
            {
                UpdateView(damageStrengthText, data.DamageStrength.Value, data.BonusDamageStrength.Value);
            }).AddTo(disposable);

            data.BonusDamageStrength.Subscribe(_ =>
            {
                UpdateView(damageStrengthText, data.DamageStrength.Value, data.BonusDamageStrength.Value);
            }).AddTo(disposable);

            // Damage dexterity

            data.DamageDexterity.Subscribe(_ =>
            {
                UpdateView(damageDexterityText, data.DamageDexterity.Value, data.BonusDamageDexterity.Value);
            }).AddTo(disposable);

            data.BonusDamageDexterity.Subscribe(_ =>
            {
                UpdateView(damageDexterityText, data.DamageDexterity.Value, data.BonusDamageDexterity.Value);
            }).AddTo(disposable);

            // Damage magic

            data.DamageMagic.Subscribe(_ =>
            {
                UpdateView(damageMagicText, data.DamageMagic.Value, data.BonusDamageMagic.Value);
            }).AddTo(disposable);

            data.BonusDamageMagic.Subscribe(_ =>
            {
                UpdateView(damageMagicText, data.DamageMagic.Value, data.BonusDamageMagic.Value);
            }).AddTo(disposable);

            // Crit chance

            data.CritChance.Subscribe(_ =>
            {
                UpdateView(critChanceText, data.CritChance.Value, data.BonusCritChance.Value);
            }).AddTo(disposable);

            data.BonusCritChance.Subscribe(_ =>
            {
                UpdateView(critChanceText, data.CritChance.Value, data.BonusCritChance.Value);
            }).AddTo(disposable);

            // Sprint

            data.Sprint.Subscribe(_ =>
            {
                UpdateView(sprintText, data.Sprint.Value, data.BonusSprint.Value);
            }).AddTo(disposable);

            data.BonusSprint.Subscribe(_ =>
            {
                UpdateView(sprintText, data.Sprint.Value, data.BonusSprint.Value);
            }).AddTo(disposable);

            // Exp bonus

            data.ExpBonus.Subscribe(_ =>
            {
                UpdateView(expBonusText, data.ExpBonus.Value, data.BonusExpBonus.Value);
            }).AddTo(disposable);

            data.BonusExpBonus.Subscribe(_ =>
            {
                UpdateView(expBonusText, data.ExpBonus.Value, data.BonusExpBonus.Value);
            }).AddTo(disposable);

            // Panic resist

            data.PanicResist.Subscribe(_ =>
            {
                UpdateView(panicResistText, data.PanicResist.Value, data.BonusPanicResist.Value);
            }).AddTo(disposable);

            data.BonusPanicResist.Subscribe(_ =>
            {
                UpdateView(panicResistText, data.PanicResist.Value, data.BonusPanicResist.Value);
            }).AddTo(disposable);
        }

        private void UpdateHealthParameter(int health, int maxHealth, int bonusHealth)
        {
            string healthText = $"{health + bonusHealth} / {maxHealth}";

            healthBlock.SetData(healthText, ChooseColorText(bonusHealth));

            healthSlider.maxValue = maxHealth;
            healthSlider.value = health + bonusHealth;
        }

        private void UpdateView(BlockParameter block, int baseParameter, int bonusParameter)
        {
            block.SetData((baseParameter + bonusParameter).ToString(), ChooseColorText(bonusParameter));
        }

        private Color ChooseColorText(int valueParameter)
        {
            Color colorText = Color.black;

            if (valueParameter > 0)
            {
                colorText = Color.cyan;
            }
            else if (valueParameter < 0)
            {
                colorText = Color.red;
            }

            return colorText;
        }
    }
}