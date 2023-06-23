package mono.com.google.android.gms.ads.h5;


public class OnH5AdsEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.h5.OnH5AdsEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onH5AdsEvent:(Ljava/lang/String;)V:GetOnH5AdsEvent_Ljava_lang_String_Handler:Android.Gms.Ads.H5.IOnH5AdsEventListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.H5.IOnH5AdsEventListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", OnH5AdsEventListenerImplementor.class, __md_methods);
	}


	public OnH5AdsEventListenerImplementor ()
	{
		super ();
		if (getClass () == OnH5AdsEventListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Android.Gms.Ads.H5.IOnH5AdsEventListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite", "", this, new java.lang.Object[] {  });
		}
	}


	public void onH5AdsEvent (java.lang.String p0)
	{
		n_onH5AdsEvent (p0);
	}

	private native void n_onH5AdsEvent (java.lang.String p0);

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
