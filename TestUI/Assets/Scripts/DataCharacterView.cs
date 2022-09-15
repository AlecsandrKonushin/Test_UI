using UnityEngine;
using Test;
using TMPro;
using UnityEngine.UI;
using NaughtyAttributes;

namespace UI.CharacterWindow
{
    public class DataCharacterView : MonoBehaviour
    {
        [BoxGroup("Health Parameters")]
        [SerializeField] private TextMeshProUGUI healthText;
        [BoxGroup("Health Parameters")]
        [SerializeField] private Slider healthSlider;

        [BoxGroup("initiative Parameters")]
        [SerializeField] private BlockParameter actionPointsBlock, initiativeBlock;

        [BoxGroup("Accuracy Parameters")]
        [SerializeField] private BlockParameter accuracyStrengthText, accuracyDexterityText, accuracyMagicText;

        [BoxGroup("Damage Parameters")]
        [SerializeField] private BlockParameter damageStrengthText, damageDexterityText, damageMagicText;

        [BoxGroup("Other Parameters")]
        [SerializeField] private BlockParameter critChanceText, sprintText, expBonusText, panicResistText;

        public void ShowDataCharacter(DataCharacter data)
        {

        }
    }
}