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
            disposable.Clear();

            data.Health.Subscribe(_ =>
            {
                healthText.text = data.Health.Value.ToString();
            }).AddTo(disposable);
        }
    }
}