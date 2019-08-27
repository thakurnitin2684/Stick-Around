using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdScripts : MonoBehaviour
{
    private RewardBasedVideoAd rewardBasedVideo;
   
    public  InterstitialAd interstitial;
    public void Start()
    {  string appId = "ca-app-pub-9091905143657596~6643385500";
        Requestinterstitial();

        MobileAds.Initialize(appId);
        
        this.rewardBasedVideo = RewardBasedVideoAd.Instance;

        this.RequestRewardBasedVideo();
    }

   
    public void Requestinterstitial()
    {
        string adUnitId = "ca-app-pub-9091905143657596/4580043531";
        this.interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        
        this.interstitial.LoadAd(request);
    }
    public void GameOver()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
    private void RequestRewardBasedVideo()
    {

            string adUnitId = "ca-app-pub-9091905143657596/6610546164";


        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded video ad with the request.
        this.rewardBasedVideo.LoadAd(request, adUnitId);
    }
    public void UserOptToWatchAd()
    {
        if (rewardBasedVideo.IsLoaded())
        {
            rewardBasedVideo.Show();
        }
    }

}
