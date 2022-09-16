using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.CharacterWindow
{
    [RequireComponent(typeof(Button))]
    public class TestButton : MonoBehaviour
    {
        [SerializeField] private CharactersInfoWindow infoWindow;

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(OnClickTestButton);   
        }

        private void OnClickTestButton()
        {
            infoWindow.ChangeDataCurrentCharacter();
        }
    }
}