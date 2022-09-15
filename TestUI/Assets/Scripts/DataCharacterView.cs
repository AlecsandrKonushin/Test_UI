using UnityEngine;
using Test;
using TMPro;
using UnityEngine.UI;

namespace UI.CharacterWindow
{
    public class DataCharacterView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI healthText;
        [SerializeField] private Slider healthSlider;

        [SerializeField] private TextMeshProUGUI accuracyStrengthText;
        [SerializeField] private TextMeshProUGUI accuracyDexterityText;
        [SerializeField] private TextMeshProUGUI accuracyMagicText;

        [SerializeField] private TextMeshProUGUI magicText;

        public void ShowDataCharacter(DataCharacter data)
        {

        }
    }
}