using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Heyzap;

public class AdsManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Your Publisher ID is: 7e4482c1be37901e95ec6b42c8e14e21
        HeyzapAds.Start("7e4482c1be37901e95ec6b42c8e14e21", HeyzapAds.FLAG_NO_OPTIONS);

		HeyzapAds.ShowDebugLogs();
		HeyzapAds.ShowThirdPartyDebugLogs();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenTestSuite() {
		HeyzapAds.ShowMediationTestSuite();
	}
}
