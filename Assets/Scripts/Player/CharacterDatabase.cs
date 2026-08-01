using UnityEngine;
using System.Collections.Generic;

namespace Boyscamp.Player
{
    public class CharacterDatabase : MonoBehaviour
    {
        public static CharacterDatabase Instance;

        public List<CharacterData> allCharacters = new List<CharacterData>();

        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        public CharacterData GetCharacterByName(string name)
        {
            return allCharacters.Find(c => c.characterName == name);
        }

        public CharacterData GetDefaultCharacter()
        {
            // Fhish is the default
            var fhish = GetCharacterByName("Fhish");
            if (fhish != null) return fhish;

            if (allCharacters.Count > 0)
                return allCharacters[0];

            return null;
        }
    }
}
