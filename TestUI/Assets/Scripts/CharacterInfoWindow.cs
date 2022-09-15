using System.Collections.Generic;
using UnityEngine;
using Test;

namespace UI.CharacterWindow
{
    public class CharacterInfoWindow : MonoBehaviour
    {
        [SerializeField] private DataCharacterView dataView;
        [SerializeField] private CharacterButton characterButtonPrefab;
        [SerializeField] private GameObject parentCharacterButtons;

        private List<DataCharacter> dataCharacters;
        private List<CharacterButton> characterButtons;

        private void Start()
        {
            characterButtons = new List<CharacterButton>();

            SetDataCharacters(TestData.Characters);
        }

        public void SetDataCharacters(List<DataCharacter> dataCharacters)
        {
            this.dataCharacters = dataCharacters;

            for (int i = 0; i < dataCharacters.Count; i++)
            {
                CharacterButton button = Instantiate(characterButtonPrefab);

                button.gameObject.transform.SetParent(parentCharacterButtons.transform);
                button.SetInfo(i, dataCharacters[i].NameCharacter);
            }
        }

        public void OnClickCharacterButton(int idButton)
        {
            dataView.ShowDataCharacter(dataCharacters[idButton]);
        }
    }
}