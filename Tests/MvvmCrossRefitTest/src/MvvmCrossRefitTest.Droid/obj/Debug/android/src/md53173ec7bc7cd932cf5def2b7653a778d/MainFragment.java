package md53173ec7bc7cd932cf5def2b7653a778d;


public class MainFragment
	extends md5ba8878c1bffdd26ca725dc34dd471379.BaseFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCrossRefitTest.Droid.Views.Main.MainFragment, MvvmCrossRefitTest.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainFragment.class, __md_methods);
	}


	public MainFragment ()
	{
		super ();
		if (getClass () == MainFragment.class)
			mono.android.TypeManager.Activate ("MvvmCrossRefitTest.Droid.Views.Main.MainFragment, MvvmCrossRefitTest.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
