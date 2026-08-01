using UnityEngine;
using UnityEngine.UI;

namespace Boyscamp.UI
{
    public class ClanPreview : MonoBehaviour
    {
        public Text clanNameText;
        public Text clanTagText;
        public Text memberCountText;
        public Image clanIcon;

        // Temporary mock data
        public string clanName = "Shadow Wolves";
        public string clanTag = "[SW]";
        public int members = 28;

        void Start()
        {
            Refresh();
        }

        public void Refresh()
        {
            if (clanNameText != null)
                clanNameText.text = clanName;

            if (clanTagText != null)
                clanTagText.text = clanTag;

            if (memberCountText != null)
                memberCountText.text = members + " Members";
        }

        public void OnClanClicked()
        {
            Debug.Log("Open Clan Screen");
            if (NotificationToast.Instance != null)
                NotificationToast.Instance.Show("Opening Clan...");
        }
    }
}
