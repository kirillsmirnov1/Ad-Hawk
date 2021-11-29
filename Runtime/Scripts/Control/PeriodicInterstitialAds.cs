using UnityEngine;
using UnityEngine.Advertisements;

namespace AdHawk.Control
{
    public class PeriodicInterstitialAds : InterstitialAds
    {
#pragma warning disable 0649
        [SerializeField] protected float periodSeconds = 5;
#pragma warning restore 0649

        protected static float ShownLastTime = float.NegativeInfinity;
        protected bool PeriodPassed => ShownLastTime + periodSeconds < Time.time;
        
        public override void ShowInterstitialAd()
        {
            if (!(PeriodPassed && Advertisement.IsReady())) return;
            ShownLastTime = Time.time;
            Advertisement.Show();
        }

    }
}