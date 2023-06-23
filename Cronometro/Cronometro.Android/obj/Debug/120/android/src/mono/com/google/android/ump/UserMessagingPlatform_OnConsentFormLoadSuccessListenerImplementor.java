package mono.com.google.android.ump;


public class UserMessagingPlatform_OnConsentFormLoadSuccessListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.ump.UserMessagingPlatform.OnConsentFormLoadSuccessListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConsentFormLoadSuccess:(Lcom/google/android/ump/ConsentForm;)V:GetOnConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_Handler:Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform/IOnConsentFormLoadSuccessListenerInvoker, Xamarin.Google.UserMessagingPlatform\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform+IOnConsentFormLoadSuccessListenerImplementor, Xamarin.Google.UserMessagingPlatform", UserMessagingPlatform_OnConsentFormLoadSuccessListenerImplementor.class, __md_methods);
	}


	public UserMessagingPlatform_OnConsentFormLoadSuccessListenerImplementor ()
	{
		super ();
		if (getClass () == UserMessagingPlatform_OnConsentFormLoadSuccessListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform+IOnConsentFormLoadSuccessListenerImplementor, Xamarin.Google.UserMessagingPlatform", "", this, new java.lang.Object[] {  });
		}
	}


	public void onConsentFormLoadSuccess (com.google.android.ump.ConsentForm p0)
	{
		n_onConsentFormLoadSuccess (p0);
	}

	private native void n_onConsentFormLoadSuccess (com.google.android.ump.ConsentForm p0);

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
