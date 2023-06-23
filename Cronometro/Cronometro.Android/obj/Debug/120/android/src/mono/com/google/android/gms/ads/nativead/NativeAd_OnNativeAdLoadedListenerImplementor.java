package mono.com.google.android.gms.ads.nativead;


public class NativeAd_OnNativeAdLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.nativead.NativeAd.OnNativeAdLoadedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onNativeAdLoaded:(Lcom/google/android/gms/ads/nativead/NativeAd;)V:GetOnNativeAdLoaded_Lcom_google_android_gms_ads_nativead_NativeAd_Handler:Android.Gms.Ads.NativeAd.NativeAd/IOnNativeAdLoadedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.NativeAd.NativeAd+IOnNativeAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", NativeAd_OnNativeAdLoadedListenerImplementor.class, __md_methods);
	}


	public NativeAd_OnNativeAdLoadedListenerImplementor ()
	{
		super ();
		if (getClass () == NativeAd_OnNativeAdLoadedListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Android.Gms.Ads.NativeAd.NativeAd+IOnNativeAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", "", this, new java.lang.Object[] {  });
		}
	}


	public void onNativeAdLoaded (com.google.android.gms.ads.nativead.NativeAd p0)
	{
		n_onNativeAdLoaded (p0);
	}

	private native void n_onNativeAdLoaded (com.google.android.gms.ads.nativead.NativeAd p0);

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
