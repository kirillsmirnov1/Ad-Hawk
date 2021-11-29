using UnityEngine;
using UnityEngine.Advertisements;

#if UNITY_EDITOR
using UnityEditor.Advertisements;
#endif

namespace AdHawk.Control
{
    public class InitAds : MonoBehaviour
    {
#pragma warning disable 0649
        [SerializeField] private string gameIdApple;
        [SerializeField] private string gameIdGoogle;
#pragma warning restore 0649

#if UNITY_EDITOR
        private void OnValidate()
        {
            gameIdGoogle = AdvertisementSettings.GetGameId(RuntimePlatform.Android);
            gameIdApple = AdvertisementSettings.GetGameId(RuntimePlatform.IPhonePlayer);
        }
#endif

        protected virtual void Start()
        {
#if UNITY_IOS
            Advertisement.Initialize(gameIdApple);
#else
            Advertisement.Initialize(gameIdGoogle);
#endif
        }
    }
}