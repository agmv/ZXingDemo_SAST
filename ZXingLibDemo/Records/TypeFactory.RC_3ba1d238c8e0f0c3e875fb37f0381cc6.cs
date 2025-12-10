namespace ssZXingLibDemo {
	public class RC_3ba1d238c8e0f0c3e875fb37f0381cc6TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_3ba1d238c8e0f0c3e875fb37f0381cc6TypeFactory {
	    private static readonly RC_3ba1d238c8e0f0c3e875fb37f0381cc6TypeFactoryImpl Instance = new();
	
	    private RC_3ba1d238c8e0f0c3e875fb37f0381cc6TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_3ba1d238c8e0f0c3e875fb37f0381cc6Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_3ba1d238c8e0f0c3e875fb37f0381cc6() {
return new RC_3ba1d238c8e0f0c3e875fb37f0381cc6();
}

	}
}