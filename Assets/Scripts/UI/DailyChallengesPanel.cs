using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class DailyChallengesPanel : MonoBehaviour
    {
        [System.Serializable]
        public class Challenge
        {
            public string description;
            public int current;
            public int target;
            public int rewardXP;
        }

        public Challenge[] challenges = new Challenge[]
        {
            new Challenge { description = "Get 15 Kills", current = 7, target = 15, rewardXP = 500 },
            new Challenge { description = "Win 1 Match", current = 0, target = 1, rewardXP = 800 },
            new Challenge { description = "Deal 2000 Damage", current = 1250, target = 2000, rewardXP = 400 }
        };

        public Text[] challengeTexts;
        public Image[] progressFills;
        public Text[] progressLabels;

        void Start()
        {
            Refresh();
        }

        public void Refresh()
        {
            for (int i = 0; i < challenges.Length; i++)
            {
                if (challengeTexts != null && i < challengeTexts.Length && challengeTexts[i] != null)
                    challengeTexts[i].text = challenges[i].description;

                if (progressFills != null && i < progressFills.Length && progressFills[i] != null)
                    progressFills[i].fillAmount = (float)challenges[i].current / challenges[i].target;

                if (progressLabels != null && i < progressLabels.Length && progressLabels[i] != null)
                    progressLabels[i].text = challenges[i].current + "/" + challenges[i].target;
            }
        }
    }
}
