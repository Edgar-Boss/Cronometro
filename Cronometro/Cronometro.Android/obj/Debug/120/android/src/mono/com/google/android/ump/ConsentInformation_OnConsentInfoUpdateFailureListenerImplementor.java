package mono.com.google.android.ump;


public class ConsentInformation_OnConsentInfoUpdateFailureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.ump.ConsentInformation.OnConsentInfoUpdateFailureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConsentInfoUpdateFailure:(Lcom/google/android/ump/FormError;)V:GetOnConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_Handler:Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateFailureListenerInvoker, Xamarin.Google.UserMessagingPlatform\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateFailureListenerImplementor, Xamarin.Google.UserMessagingPlatform", ConsentInformation_OnConsentInfoUpdateFailureListenerImplementor.class, __md_methods);
	}


	public ConsentInformation_OnConsentInfoUpdateFailureListenerImplementor ()
	{
		super ();
		if (getClass () == ConsentInformation_OnConsentInfoUpdateFailureListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateFailureListenerImplementor, Xamarin.Google.UserMessagingPlatform", "", this, new java.lang.Object[] {  });
		}
	}


	public void onConsentInfoUpdateFailure (com.google.android.ump.FormError p0)
	{
		n_onConsentInfoUpdateFailure (p0);
	}

	private native void n_onConsentInfoUpdateFailure (com.google.android.ump.FormError p0);

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
