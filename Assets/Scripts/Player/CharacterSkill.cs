using UnityEngine;
using System.Collections;

namespace Boyscamp.Player
{
    public abstract class CharacterSkill : MonoBehaviour
    {
        public string skillName;
        public float cooldown = 25f;
        protected float lastUsedTime = -999f;

        public bool IsReady => Time.time >= lastUsedTime + cooldown;

        public float CooldownRemaining => Mathf.Max(0f, (lastUsedTime + cooldown) - Time.time);

        public virtual void Activate()
        {
            if (!IsReady) return;

            lastUsedTime = Time.time;
            OnActivate();
        }

        protected abstract void OnActivate();
    }
}
