using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AdsManager : MonoBehaviour {

#if UNITY_IOS
	const string IRONSOURCE_KEY = "7e2f58f5";
#elif UNITY_ANDROID
	const string IRONSOURCE_KEY = "7e2f927d";
#endif


	bool bannerShowing;

	// Use this for initialization
	void Start () {

		IronSource.Agent.init (IRONSOURCE_KEY);
		IronSource.Agent.validateIntegration();

		bannerShowing = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnApplicationPause(bool isPaused) {                 
  		IronSource.Agent.onApplicationPause(isPaused);
	}

	public void OpenTestSuite() {

	}

	public void ShowInterstitial() {

	}

	public void ShowVideo() {

	}

	public void ShowRewarded() {

	}

	public void ToggleBanner() {
		if (!bannerShowing) {
			bannerShowing = true;
		} else {
			bannerShowing = false;
		}
	}
}
