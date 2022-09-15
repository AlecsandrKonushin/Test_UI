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

                    button.Initialize();
                    button.SetInfo(i, dataCharacters[i].NameCharacter);
                }
            }
        }

        public void OnClickCharacterButton(int idButton)
        {
            dataCharacterView.ShowDataCharacter(dataCharacters[idButton]);
        }
    }
}