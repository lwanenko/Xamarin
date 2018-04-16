package md55d7f22554a10ccddc8889e3edf27d2c0;


public class MainContainerActivity
	extends md55b2fef69e45d7590415b102c49c6eed5.BaseActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCrossAppNative.Droid.Views.Main.MainContainerActivity, MvvmCrossAppNative.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainContainerActivity.class, __md_methods);
	}


	public MainContainerActivity ()
	{
		super ();
		if (getClass () == MainContainerActivity.class)
			mono.android.TypeManager.Activate ("MvvmCrossAppNative.Droid.Views.Main.MainContainerActivity, MvvmCrossAppNative.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
