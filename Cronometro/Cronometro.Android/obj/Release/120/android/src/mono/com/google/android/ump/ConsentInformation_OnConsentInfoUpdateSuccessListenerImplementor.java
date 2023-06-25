package mono.com.google.android.ump;


public class ConsentInformation_OnConsentInfoUpdateSuccessListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.ump.ConsentInformation.OnConsentInfoUpdateSuccessListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConsentInfoUpdateSuccess:()V:GetOnConsentInfoUpdateSuccessHandler:Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker, Xamarin.Google.UserMessagingPlatform\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateSuccessListenerImplementor, Xamarin.Google.UserMessagingPlatform", ConsentInformation_OnConsentInfoUpdateSuccessListenerImplementor.class, __md_methods);
	}


	public ConsentInformation_OnConsentInfoUpdateSuccessListenerImplementor ()
	{
		super ();
		if (getClass () == ConsentInformation_OnConsentInfoUpdateSuccessListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateSuccessListenerImplementor, Xamarin.Google.UserMessagingPlatform", "", this, new java.lang.Object[] {  });
		}
	}


	public void onConsentInfoUpdateSuccess ()
	{
		n_onConsentInfoUpdateSuccess ();
	}

	private native void n_onConsentInfoUpdateSuccess ();

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
