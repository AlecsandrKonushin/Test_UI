using TMPro;
using UnityEngine;

namespace UI.CharacterWindow
{
    public class BlockParameter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI labelText;
        [SerializeField] private TextMeshProUGUI valueText;

        public void SetData(string valueText, string labelText = "")
        {
            if (labelText != "")
            {
                this.labelText.text = labelText;
            }

            this.valueText.text = valueText;
        }
    }
}