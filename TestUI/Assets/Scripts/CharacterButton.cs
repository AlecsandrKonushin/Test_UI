using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.CharacterWindow
{
    [RequireComponent(typeof(Button))]
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class CharacterButton : MonoBehaviour
    {
        private CharactersInfoWindow infoWindow;
        private int idButton;
        private TextMeshProUGUI characterNameText;

        private bool isActive;
        private Button button;
        private Color myColor;

        public int GetIdButton { get => idButton; }

        public void Initialize(CharactersInfoWindow infoWindow)
        {
            this.infoWindow = infoWindow;
            button = GetComponent<Button>();
            button.onClick.AddListener(OnClickButton);

            characterNameText = GetComponentInChildren<TextMeshProUGUI>();
            myColor = button.image.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.3f);
        }

        public void SetInfo(int id, string characterName)
        {
            idButton = id;
            characterNameText.text = characterName;
        }

        public void DeactivateButton()
        {
            if (isActive)
            {
                isActive = false;

                Color newColor = myColor;
                newColor.a = 0.3f;
                button.image.color = newColor;
            }
        }

        private void OnClickButton()
        {
            if (infoWindow && !isActive)
            {
                isActive = true;

                Color newColor = myColor;
                newColor.a = 1;
                button.image.color = newColor;

                infoWindow.OnClickCharacterButton(this);
            }
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveListener(OnClickButton);
        }
    }
}
