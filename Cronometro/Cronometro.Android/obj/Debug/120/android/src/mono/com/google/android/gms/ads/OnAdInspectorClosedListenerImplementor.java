package mono.com.google.android.gms.ads;


public class OnAdInspectorClosedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.OnAdInspectorClosedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdInspectorClosed:(Lcom/google/android/gms/ads/AdInspectorError;)V:GetOnAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_Handler:Android.Gms.Ads.IOnAdInspectorClosedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.IOnAdInspectorClosedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", OnAdInspectorClosedListenerImplementor.class, __md_methods);
	}


	public OnAdInspectorClosedListenerImplementor ()
	{
		super ();
		if (getClass () == OnAdInspectorClosedListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Android.Gms.Ads.IOnAdInspectorClosedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", "", this, new java.lang.Object[] {  });
		}
	}


	public void onAdInspectorClosed (com.google.android.gms.ads.AdInspectorError p0)
	{
		n_onAdInspectorClosed (p0);
	}

	private native void n_onAdInspectorClosed (com.google.android.gms.ads.AdInspectorError p0);

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
