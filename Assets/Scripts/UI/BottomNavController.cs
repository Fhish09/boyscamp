using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class BottomNavController : MonoBehaviour
    {
        public Button[] navButtons;
        public Image[] navIcons;
        public Color selectedColor = new Color(1f, 0.35f, 0.1f);
        public Color normalColor = new Color(0.7f, 0.7f, 0.75f);

        private int currentIndex = -1;

        void Start()
        {
            for (int i = 0; i < navButtons.Length; i++)
            {
                int index = i;
                if (navButtons[i] != null)
                    navButtons[i].onClick.AddListener(() => Select(index));
            }
        }

        public void Select(int index)
        {
            currentIndex = index;

            for (int i = 0; i < navIcons.Length; i++)
            {
                if (navIcons[i] != null)
                    navIcons[i].color = (i == index) ? selectedColor : normalColor;
            }

            // Call the corresponding action through MainMenuManager
            if (MainMenuManager.Instance != null)
            {
                switch (index)
                {
                    case 0: MainMenuManager.Instance.OpenLoadout(); break;
                    case 1: MainMenuManager.Instance.OpenStore(); break;
                    case 2: MainMenuManager.Instance.OpenSocial(); break;
                    case 3: MainMenuManager.Instance.OpenEvents(); break;
                    case 4: MainMenuManager.Instance.OpenSettings(); break;
                }
            }
        }
    }
}
