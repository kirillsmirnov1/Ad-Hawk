using UnityEngine;

namespace AdHawk.Model
{
    [CreateAssetMenu(fileName = "AdParams", menuName = "AdHawk/AdParams", order = 0)]
    public class AdParams : ScriptableObject
    {
        public string gameIdGoogle;
        public string gameIdApple;
        public bool testMode;
    }
}