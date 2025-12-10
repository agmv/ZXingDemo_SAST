namespace ssZXingLibDemo {
	public class RC_210f541f43ec6384ba59bfd8fe4b8837TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_210f541f43ec6384ba59bfd8fe4b8837TypeFactory {
	    private static readonly RC_210f541f43ec6384ba59bfd8fe4b8837TypeFactoryImpl Instance = new();
	
	    private RC_210f541f43ec6384ba59bfd8fe4b8837TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_210f541f43ec6384ba59bfd8fe4b8837Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_210f541f43ec6384ba59bfd8fe4b8837() {
return new RC_210f541f43ec6384ba59bfd8fe4b8837();
}

	}
}