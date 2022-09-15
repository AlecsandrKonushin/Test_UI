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

        public void Initialize()
        {
            if (TryGetComponent(out CharactersInfoWindow window))
            {
                infoWindow = window;

                GetComponent<Button>().onClick.AddListener(OnClickButton);
            }
            else
            {
                Debug.Log($"<color=red>Not found CharactersInfoWindow in parent!</color>");
            }

            characterNameText = GetComponentInChildren<TextMeshProUGUI>();
            GetComponent<Button>().image.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
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
