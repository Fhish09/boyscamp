using UnityEngine;

namespace Boyscamp.Mobile
{
    public class QualityManager : MonoBehaviour
    {
        public enum QualityLevel { Low, Medium, High }

        public QualityLevel currentQuality = QualityLevel.Medium;

        void Start()
        {
            ApplyQuality(currentQuality);
        }

        public void ApplyQuality(QualityLevel level)
        {
            currentQuality = level;

            switch (level)
            {
                case QualityLevel.Low:
                    QualitySettings.SetQualityLevel(0, true);
                    Application.targetFrameRate = 30;
                    break;
                case QualityLevel.Medium:
                    QualitySettings.SetQualityLevel(2, true);
                    Application.targetFrameRate = 45;
                    break;
                case QualityLevel.High:
                    QualitySettings.SetQualityLevel(4, true);
                    Application.targetFrameRate = 60;
                    break;
            }

            Debug.Log("Quality set to: " + level);
        }

        public void SetLow() => ApplyQuality(QualityLevel.Low);
        public void SetMedium() => ApplyQuality(QualityLevel.Medium);
        public void SetHigh() => ApplyQuality(QualityLevel.High);
    }
}
