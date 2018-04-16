package md55b2fef69e45d7590415b102c49c6eed5;


public abstract class BaseActivity_1
	extends md589a2cbaf5c4ccffb10ba6137c86da2d7.MvxAppCompatActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MvvmCrossAppNative.Droid.Views.BaseActivity`1, MvvmCrossAppNative.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaseActivity_1.class, __md_methods);
	}


	public BaseActivity_1 ()
	{
		super ();
		if (getClass () == BaseActivity_1.class)
			mono.android.TypeManager.Activate ("MvvmCrossAppNative.Droid.Views.BaseActivity`1, MvvmCrossAppNative.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
