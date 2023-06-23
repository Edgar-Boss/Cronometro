package mono.com.google.android.gms.ads.nativead;


public class NativeCustomFormatAd_OnCustomClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.nativead.NativeCustomFormatAd.OnCustomClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCustomClick:(Lcom/google/android/gms/ads/nativead/NativeCustomFormatAd;Ljava/lang/String;)V:GetOnCustomClick_Lcom_google_android_gms_ads_nativead_NativeCustomFormatAd_Ljava_lang_String_Handler:Android.Gms.Ads.NativeAd.INativeCustomFormatAdOnCustomClickListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.NativeAd.INativeCustomFormatAdOnCustomClickListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", NativeCustomFormatAd_OnCustomClickListenerImplementor.class, __md_methods);
	}


	public NativeCustomFormatAd_OnCustomClickListenerImplementor ()
	{
		super ();
		if (getClass () == NativeCustomFormatAd_OnCustomClickListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Android.Gms.Ads.NativeAd.INativeCustomFormatAdOnCustomClickListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCustomClick (com.google.android.gms.ads.nativead.NativeCustomFormatAd p0, java.lang.String p1)
	{
		n_onCustomClick (p0, p1);
	}

	private native void n_onCustomClick (com.google.android.gms.ads.nativead.NativeCustomFormatAd p0, java.lang.String p1);

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
