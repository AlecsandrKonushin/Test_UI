using UnityEngine;
using Test;
using TMPro;
using UnityEngine.UI;
using NaughtyAttributes;

namespace UI.CharacterWindow
{
    public class DataCharacterView : MonoBehaviour
    {
        [Label("Health Parameters")]
        [SerializeField] private TextMeshProUGUI healthText;
        [Label("Health Parameters")]
        [SerializeField] private Slider healthSlider;

        [Label("Cccuracy Parameters")]
        [SerializeField] private BlockParameter accuracyStrengthText, accuracyDexterityText, accuracyMagicText;

        [Label("Damage Parameters")]
        [SerializeField] private BlockParameter damageStrengthText, damageDexterityText, damageMagicText;

        [Label("Other Parameters")]
        [SerializeField] private BlockParameter critChanceText, sprintText, expBonusText, panicResistText;

        public void ShowDataCharacter(DataCharacter data)
        {

        }
    }
}