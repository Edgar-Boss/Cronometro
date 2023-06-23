package crc643a9b29aa33f10ca3;


public class MTAdmobImplementation
	extends com.google.android.gms.ads.interstitial.InterstitialAdLoadCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MarcTron.Plugin.MTAdmobImplementation, Plugin.MtAdmob", MTAdmobImplementation.class, __md_methods);
	}


	public MTAdmobImplementation ()
	{
		super ();
		if (getClass () == MTAdmobImplementation.class) {
			mono.android.TypeManager.Activate ("MarcTron.Plugin.MTAdmobImplementation, Plugin.MtAdmob", "", this, new java.lang.Object[] {  });
		}
	}

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
