package mono.com.google.android.ump;


public class UserMessagingPlatform_OnConsentFormLoadFailureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.ump.UserMessagingPlatform.OnConsentFormLoadFailureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConsentFormLoadFailure:(Lcom/google/android/ump/FormError;)V:GetOnConsentFormLoadFailure_Lcom_google_android_ump_FormError_Handler:Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform/IOnConsentFormLoadFailureListenerInvoker, Xamarin.Google.UserMessagingPlatform\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform+IOnConsentFormLoadFailureListenerImplementor, Xamarin.Google.UserMessagingPlatform", UserMessagingPlatform_OnConsentFormLoadFailureListenerImplementor.class, __md_methods);
	}


	public UserMessagingPlatform_OnConsentFormLoadFailureListenerImplementor ()
	{
		super ();
		if (getClass () == UserMessagingPlatform_OnConsentFormLoadFailureListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform+IOnConsentFormLoadFailureListenerImplementor, Xamarin.Google.UserMessagingPlatform", "", this, new java.lang.Object[] {  });
		}
	}


	public void onConsentFormLoadFailure (com.google.android.ump.FormError p0)
	{
		n_onConsentFormLoadFailure (p0);
	}

	private native void n_onConsentFormLoadFailure (com.google.android.ump.FormError p0);

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
