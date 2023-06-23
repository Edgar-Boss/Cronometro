package crc64fa6bcdce5dc76621;


public class RewardInterstitialService
	extends com.google.android.gms.ads.rewardedinterstitial.RewardedInterstitialAdLoadCallback
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.OnUserEarnedRewardListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdFailedToLoad:(Lcom/google/android/gms/ads/LoadAdError;)V:GetOnAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_Handler\n" +
			"n_onAdLoaded:(Lcom/google/android/gms/ads/rewardedinterstitial/RewardedInterstitialAd;)V:GetOnAdLoadedHandler\n" +
			"n_onUserEarnedReward:(Lcom/google/android/gms/ads/rewarded/RewardItem;)V:GetOnUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_Handler:Android.Gms.Ads.IOnUserEarnedRewardListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("MarcTron.Plugin.Services.RewardInterstitialService, Plugin.MtAdmob", RewardInterstitialService.class, __md_methods);
	}


	public RewardInterstitialService ()
	{
		super ();
		if (getClass () == RewardInterstitialService.class) {
			mono.android.TypeManager.Activate ("MarcTron.Plugin.Services.RewardInterstitialService, Plugin.MtAdmob", "", this, new java.lang.Object[] {  });
		}
	}

	public RewardInterstitialService (crc643a9b29aa33f10ca3.MTAdmobImplementation p0)
	{
		super ();
		if (getClass () == RewardInterstitialService.class) {
			mono.android.TypeManager.Activate ("MarcTron.Plugin.Services.RewardInterstitialService, Plugin.MtAdmob", "MarcTron.Plugin.MTAdmobImplementation, Plugin.MtAdmob", this, new java.lang.Object[] { p0 });
		}
	}


	public void onAdFailedToLoad (com.google.android.gms.ads.LoadAdError p0)
	{
		n_onAdFailedToLoad (p0);
	}

	private native void n_onAdFailedToLoad (com.google.android.gms.ads.LoadAdError p0);


	public void onAdLoaded (com.google.android.gms.ads.rewardedinterstitial.RewardedInterstitialAd p0)
	{
		n_onAdLoaded (p0);
	}

	private native void n_onAdLoaded (com.google.android.gms.ads.rewardedinterstitial.RewardedInterstitialAd p0);


	public void onUserEarnedReward (com.google.android.gms.ads.rewarded.RewardItem p0)
	{
		n_onUserEarnedReward (p0);
	}

	private native void n_onUserEarnedReward (com.google.android.gms.ads.rewarded.RewardItem p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
