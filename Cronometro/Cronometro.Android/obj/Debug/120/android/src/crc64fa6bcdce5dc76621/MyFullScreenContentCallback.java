package crc64fa6bcdce5dc76621;


public class MyFullScreenContentCallback
	extends com.google.android.gms.ads.FullScreenContentCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdDismissedFullScreenContent:()V:GetOnAdDismissedFullScreenContentHandler\n" +
			"n_onAdFailedToShowFullScreenContent:(Lcom/google/android/gms/ads/AdError;)V:GetOnAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_Handler\n" +
			"n_onAdShowedFullScreenContent:()V:GetOnAdShowedFullScreenContentHandler\n" +
			"n_onAdImpression:()V:GetOnAdImpressionHandler\n" +
			"";
		mono.android.Runtime.register ("MarcTron.Plugin.Services.MyFullScreenContentCallback, Plugin.MtAdmob", MyFullScreenContentCallback.class, __md_methods);
	}


	public MyFullScreenContentCallback ()
	{
		super ();
		if (getClass () == MyFullScreenContentCallback.class) {
			mono.android.TypeManager.Activate ("MarcTron.Plugin.Services.MyFullScreenContentCallback, Plugin.MtAdmob", "", this, new java.lang.Object[] {  });
		}
	}

	public MyFullScreenContentCallback (crc643a9b29aa33f10ca3.MTAdmobImplementation p0, boolean p1)
	{
		super ();
		if (getClass () == MyFullScreenContentCallback.class) {
			mono.android.TypeManager.Activate ("MarcTron.Plugin.Services.MyFullScreenContentCallback, Plugin.MtAdmob", "MarcTron.Plugin.MTAdmobImplementation, Plugin.MtAdmob:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public void onAdDismissedFullScreenContent ()
	{
		n_onAdDismissedFullScreenContent ();
	}

	private native void n_onAdDismissedFullScreenContent ();


	public void onAdFailedToShowFullScreenContent (com.google.android.gms.ads.AdError p0)
	{
		n_onAdFailedToShowFullScreenContent (p0);
	}

	private native void n_onAdFailedToShowFullScreenContent (com.google.android.gms.ads.AdError p0);


	public void onAdShowedFullScreenContent ()
	{
		n_onAdShowedFullScreenContent ();
	}

	private native void n_onAdShowedFullScreenContent ();


	public void onAdImpression ()
	{
		n_onAdImpression ();
	}

	private native void n_onAdImpression ();

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
