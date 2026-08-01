using UnityEngine;

namespace Boyscamp.Mobile
{
    public class MobileInputHelper : MonoBehaviour
    {
        public static bool IsMobile
        {
            get
            {
                return Application.isMobilePlatform;
            }
        }

        public static Vector2 GetTouchDelta()
        {
            if (Input.touchCount > 0)
            {
                return Input.GetTouch(0).deltaPosition;
            }
            return Vector2.zero;
        }

        public static bool GetTouchDown()
        {
            return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
        }

        public static bool GetTouchUp()
        {
            return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended;
        }
    }
}
