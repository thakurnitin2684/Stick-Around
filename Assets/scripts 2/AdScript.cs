using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdScript : MonoBehaviour
{

    

    void Start()
    {
        string gameid = "ca-app-pub-9091905143657596~6643385500";
        MobileAds.Initialize(gameid);

       
        this.showBannerAd();

    }

    private void showBannerAd()
    {
        string adID = "ca-app-pub-9091905143657596/9552140940";

     
        AdRequest request = new AdRequest.Builder().Build();
       
        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
        bannerAd.LoadAd(request);
    }
  
    

   
}