package crc645803eb4022a7c101;


public abstract class RewardedInterstitialAd
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.Hack.RewardedInterstitialAd, Plugin.MtAdmob", RewardedInterstitialAd.class, __md_methods);
	}


	public RewardedInterstitialAd ()
	{
		super ();
		if (getClass () == RewardedInterstitialAd.class) {
			mono.android.TypeManager.Activate ("Android.Gms.Ads.Hack.RewardedInterstitialAd, Plugin.MtAdmob", "", this, new java.lang.Object[] {  });
		}
	}

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
