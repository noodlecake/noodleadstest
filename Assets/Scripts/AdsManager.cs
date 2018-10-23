using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Heyzap;

public class AdsManager : MonoBehaviour {

	bool bannerShowing;

	// Use this for initialization
	void Start () {
        // Your Publisher ID is: 7e4482c1be37901e95ec6b42c8e14e21
        HeyzapAds.Start("7e4482c1be37901e95ec6b42c8e14e21", HeyzapAds.FLAG_NO_OPTIONS);

		HeyzapAds.ShowDebugLogs();
		HeyzapAds.ShowThirdPartyDebugLogs();

		HZVideoAd.Fetch();
		HZIncentivizedAd.Fetch();

		bannerShowing = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenTestSuite() {
		HeyzapAds.ShowMediationTestSuite();
	}

	public void ShowInterstitial() {
		HZInterstitialAd.Show();
	}

	public void ShowVideo() {
		if (HZVideoAd.IsAvailable()) {
    		HZVideoAd.Show();
		}
	}

	public void ShowRewarded() {
		if (HZIncentivizedAd.IsAvailable()) {
            HZIncentivizedAd.Show();
        }
	}

	public void ToggleBanner() {
		if (!bannerShowing) {
        	HZBannerShowOptions showOptions = new HZBannerShowOptions();
        	showOptions.Position = HZBannerShowOptions.POSITION_BOTTOM;
        	HZBannerAd.ShowWithOptions(showOptions);
			bannerShowing = true;
		} else {
        	HZBannerAd.Hide();
			HZBannerAd.Destroy();
			bannerShowing = false;
		}
	}
}
