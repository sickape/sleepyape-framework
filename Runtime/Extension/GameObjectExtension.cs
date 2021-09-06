using UnityEngine;

namespace SleepyApe
{
    public static class GameObjectExtension
    {
        public static void Disable(this GameObject target)
        {
            target.SetActive(false);
        }

        public static void Enable(this GameObject target)
        {
            target.SetActive(true);
        }

        public static void Destroy(this GameObject target)
        {
            GameObject.Destroy(target);
        }
    }
}