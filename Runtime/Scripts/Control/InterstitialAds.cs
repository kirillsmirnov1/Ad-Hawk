using UnityEngine;
using UnityEngine.Advertisements;

namespace AdHawk.Control
{
    public class InterstitialAds : MonoBehaviour
    {
        public bool showOnStart;

        protected virtual void Start()
        {
            if(showOnStart) ShowInterstitialAd();
        }

        public virtual void ShowInterstitialAd() {
            // Check if UnityAds ready before calling Show method:
            if (Advertisement.IsReady()) {
                Advertisement.Show();
            } 
            else {
                Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
            }
        }
    }
}