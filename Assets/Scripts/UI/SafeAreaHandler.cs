using UnityEngine;

namespace Boyscamp.UI
{
    public class SafeAreaHandler : MonoBehaviour
    {
        public RectTransform topBar;
        public RectTransform bottomNav;

        void Start()
        {
            ApplySafeArea();
        }

        void ApplySafeArea()
        {
            Rect safe = Screen.safeArea;

            if (topBar != null)
            {
                Vector2 anchorMin = topBar.anchorMin;
                Vector2 anchorMax = topBar.anchorMax;

                anchorMin.y = safe.yMin / Screen.height;
                topBar.anchorMin = anchorMin;
            }

            if (bottomNav != null)
            {
                Vector2 anchorMin = bottomNav.anchorMin;
                Vector2 anchorMax = bottomNav.anchorMax;

                anchorMax.y = safe.yMax / Screen.height;
                bottomNav.anchorMax = anchorMax;
            }
        }
    }
}
