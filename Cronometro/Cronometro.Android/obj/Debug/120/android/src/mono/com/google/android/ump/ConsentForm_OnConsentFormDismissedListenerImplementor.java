package mono.com.google.android.ump;


public class ConsentForm_OnConsentFormDismissedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.ump.ConsentForm.OnConsentFormDismissedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConsentFormDismissed:(Lcom/google/android/ump/FormError;)V:GetOnConsentFormDismissed_Lcom_google_android_ump_FormError_Handler:Xamarin.Google.UserMesssagingPlatform.IConsentFormOnConsentFormDismissedListenerInvoker, Xamarin.Google.UserMessagingPlatform\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Google.UserMesssagingPlatform.IConsentFormOnConsentFormDismissedListenerImplementor, Xamarin.Google.UserMessagingPlatform", ConsentForm_OnConsentFormDismissedListenerImplementor.class, __md_methods);
	}


	public ConsentForm_OnConsentFormDismissedListenerImplementor ()
	{
		super ();
		if (getClass () == ConsentForm_OnConsentFormDismissedListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Google.UserMesssagingPlatform.IConsentFormOnConsentFormDismissedListenerImplementor, Xamarin.Google.UserMessagingPlatform", "", this, new java.lang.Object[] {  });
		}
	}


	public void onConsentFormDismissed (com.google.android.ump.FormError p0)
	{
		n_onConsentFormDismissed (p0);
	}

	private native void n_onConsentFormDismissed (com.google.android.ump.FormError p0);

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
