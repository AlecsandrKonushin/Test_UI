using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.CharacterWindow
{
    public class CharacterButton : MonoBehaviour
    {
        private CharacterInfoWindow infoWindow;
        private int idButton;
        private TextMeshProUGUI characterNameText;

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(OnClickButton);
            infoWindow = GetComponentInParent<CharacterInfoWindow>();
        }

        public void SetInfo(int id, string characterName)
        {
            idButton = id;
            characterNameText.text = characterName;
        }

        private void OnClickButton()
        {
            if (infoWindow)
            {
                infoWindow.OnClickCharacterButton(idButton);
            }
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveListener(OnClickButton);
        }
    }
}
