using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class ModeTabSystem : MonoBehaviour
    {
        public Button[] tabs;
        public Image[] tabBackgrounds;
        public Color selectedColor = new Color(1f, 0.35f, 0.1f);
        public Color unselectedColor = new Color(0.18f, 0.18f, 0.22f);

        private int currentIndex = 0;

        void Start()
        {
            for (int i = 0; i < tabs.Length; i++)
            {
                int index = i;
                if (tabs[i] != null)
                    tabs[i].onClick.AddListener(() => SelectTab(index));
            }

            SelectTab(0);
        }

        public void SelectTab(int index)
        {
            currentIndex = index;

            for (int i = 0; i < tabBackgrounds.Length; i++)
            {
                if (tabBackgrounds[i] != null)
                    tabBackgrounds[i].color = (i == index) ? selectedColor : unselectedColor;
            }

            Debug.Log("Mode selected: " + index);
        }

        public int GetSelectedIndex()
        {
            return currentIndex;
        }
    }
}
