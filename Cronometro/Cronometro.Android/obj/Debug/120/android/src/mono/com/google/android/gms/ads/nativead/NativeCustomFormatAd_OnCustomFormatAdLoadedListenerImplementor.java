package mono.com.google.android.gms.ads.nativead;


public class NativeCustomFormatAd_OnCustomFormatAdLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.nativead.NativeCustomFormatAd.OnCustomFormatAdLoadedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCustomFormatAdLoaded:(Lcom/google/android/gms/ads/nativead/NativeCustomFormatAd;)V:GetOnCustomFormatAdLoaded_Lcom_google_android_gms_ads_nativead_NativeCustomFormatAd_Handler:Android.Gms.Ads.NativeAd.INativeCustomFormatAdOnCustomFormatAdLoadedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.NativeAd.INativeCustomFormatAdOnCustomFormatAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", NativeCustomFormatAd_OnCustomFormatAdLoadedListenerImplementor.class, __md_methods);
	}


	public NativeCustomFormatAd_OnCustomFormatAdLoadedListenerImplementor ()
	{
		super ();
		if (getClass () == NativeCustomFormatAd_OnCustomFormatAdLoadedListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Android.Gms.Ads.NativeAd.INativeCustomFormatAdOnCustomFormatAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCustomFormatAdLoaded (com.google.android.gms.ads.nativead.NativeCustomFormatAd p0)
	{
		n_onCustomFormatAdLoaded (p0);
	}

	private native void n_onCustomFormatAdLoaded (com.google.android.gms.ads.nativead.NativeCustomFormatAd p0);

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
