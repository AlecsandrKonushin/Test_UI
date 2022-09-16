using System.Collections.Generic;
using UnityEngine;
using Test;

namespace UI.CharacterWindow
{
    public class CharactersInfoWindow : MonoBehaviour
    {
        [SerializeField] private DataCharacterView dataCharacterView;
        [SerializeField] private CharacterButton characterButtonPrefab;
        [SerializeField] private GameObject leftParentButtons, rightParentButtons;

        private List<DataCharacter> dataCharacters;
        private List<CharacterButton> characterButtons;

        private DataCharacter currentData;
        private CharacterButton currentButton;

        private void Start()
        {
            characterButtons = new List<CharacterButton>();

            ShowDataCharacters(TestData.Characters);
        }

        public void ShowDataCharacters(List<DataCharacter> dataCharacters)
        {
            this.dataCharacters = dataCharacters;
            GameObject parent;

            if (dataCharacters.Count > 0)
            {
                for (int i = 0; i < dataCharacters.Count; i++)
                {
                    leftParentButtons.SetActive(true);

                    if (i > 9)
                    {
                        // TODO: May be slider?

                        return;
                    }

                    if (i > 4)
                    {
                        rightParentButtons.SetActive(true);

                        parent = rightParentButtons;
                    }
                    else
                    {
                        parent = leftParentButtons;
                    }

                    CharacterButton button = Instantiate(characterButtonPrefab, parent.transform);

                    button.Initialize(this);
                    button.SetInfo(i, dataCharacters[i].NameCharacter.Value);
                }
            }
        }

        public void OnClickCharacterButton(CharacterButton button)
        {
            if(currentButton != null)
            {
                currentButton.DeactivateButton();
            }

            currentButton = button;
            currentData = dataCharacters[button.GetIdButton];
            dataCharacterView.ShowDataCharacter(currentData);
        }

        public void ChangeDataCurrentCharacter()
        {
            if (currentData != null)
            {
                currentData.Health.Value = Random.Range(0, 10);
                currentData.MaxHealth.Value = Random.Range(10, 20);
                currentData.BonusHealth.Value = Random.Range(-10, 10);

                currentData.MovementPoints.Value = Random.Range(5, 10);
                currentData.BonusMovementPoints.Value = Random.Range(-5, 5);
                currentData.Initiative.Value = Random.Range(5, 10);
                currentData.BonusInitiative.Value = Random.Range(-5, 5);                
                
                currentData.AccuracyStrength.Value = Random.Range(5, 10);
                currentData.BonusAccuracyStrength.Value = Random.Range(-5, 5);
                currentData.AccuracyDexterity.Value = Random.Range(5, 10);
                currentData.BonusAccuracyDexterity.Value = Random.Range(-5, 5);
                currentData.AccuracyMagic.Value = Random.Range(5, 10);
                currentData.BonusAccuracyMagic.Value = Random.Range(-5, 5);

                currentData.DamageStrength.Value = Random.Range(5, 10);
                currentData.BonusDamageStrength.Value = Random.Range(-5, 5);
                currentData.DamageDexterity.Value = Random.Range(5, 10);
                currentData.BonusDamageDexterity.Value = Random.Range(-5, 5);
                currentData.DamageMagic.Value = Random.Range(5, 10);
                currentData.BonusDamageMagic.Value = Random.Range(-5, 5);

                currentData.CritChance.Value = Random.Range(5, 10);
                currentData.BonusCritChance.Value = Random.Range(-5, 5);
                currentData.Sprint.Value = Random.Range(5, 10);
                currentData.BonusSprint.Value = Random.Range(-5, 5);
                currentData.ExpBonus.Value = Random.Range(5, 10);
                currentData.BonusExpBonus.Value = Random.Range(-5, 5);
                currentData.PanicResist.Value = Random.Range(5, 10);
                currentData.BonusPanicResist.Value = Random.Range(-5, 5);
            }
        }
    }
}