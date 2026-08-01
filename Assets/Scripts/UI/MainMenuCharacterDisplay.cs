using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class MainMenuCharacterDisplay : MonoBehaviour
    {
        [Header("Character Display")]
        public Image characterPortrait;          // 2D portrait fallback
        public Transform characterModelRoot;     // For 3D model if available
        public Text characterNameText;
        public Text characterTitleText;

        [Header("Default Character - Fhish")]
        public string defaultName = "Fhish";
        public string defaultTitle = "Lone Wolf";
        public Sprite defaultPortrait;

        [Header("Idle Animation")]
        public float idleSwayAmount = 3f;
        public float idleSwaySpeed = 0.8f;

        private Vector3 initialPosition;

        void Start()
        {
            SetupDefaultCharacter();

            if (characterModelRoot != null)
                initialPosition = characterModelRoot.localPosition;
            else if (characterPortrait != null)
                initialPosition = characterPortrait.rectTransform.localPosition;
        }

        void Update()
        {
            // Subtle idle sway for premium feel
            float sway = Mathf.Sin(Time.time * idleSwaySpeed) * idleSwayAmount;

            if (characterModelRoot != null)
            {
                characterModelRoot.localPosition = initialPosition + new Vector3(sway, 0f, 0f);
            }
            else if (characterPortrait != null)
            {
                characterPortrait.rectTransform.localPosition = initialPosition + new Vector3(sway, 0f, 0f);
            }
        }

        public void SetupDefaultCharacter()
        {
            if (characterNameText != null)
                characterNameText.text = defaultName;

            if (characterTitleText != null)
                characterTitleText.text = defaultTitle;

            if (characterPortrait != null && defaultPortrait != null)
                characterPortrait.sprite = defaultPortrait;
        }

        public void SetCharacter(string name, string title, Sprite portrait)
        {
            if (characterNameText != null)
                characterNameText.text = name;

            if (characterTitleText != null)
                characterTitleText.text = title;

            if (characterPortrait != null && portrait != null)
                characterPortrait.sprite = portrait;
        }
    }
}
