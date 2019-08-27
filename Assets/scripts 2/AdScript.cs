using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdScript : MonoBehaviour
{

    

    void Start()
    {
        string gameid = "your-id";
        MobileAds.Initialize(gameid);

       
        this.showBannerAd();

    }

    private void showBannerAd()
    {
        string adID = "your-id";

     
        AdRequest request = new AdRequest.Builder().Build();
       
        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
        bannerAd.LoadAd(request);
    }
  
    

   
}
