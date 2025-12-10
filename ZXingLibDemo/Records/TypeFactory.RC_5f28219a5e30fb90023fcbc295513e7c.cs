namespace ssZXingLibDemo {
	public class RC_5f28219a5e30fb90023fcbc295513e7cTypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_5f28219a5e30fb90023fcbc295513e7cTypeFactory {
	    private static readonly RC_5f28219a5e30fb90023fcbc295513e7cTypeFactoryImpl Instance = new();
	
	    private RC_5f28219a5e30fb90023fcbc295513e7cTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_5f28219a5e30fb90023fcbc295513e7cSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_5f28219a5e30fb90023fcbc295513e7c() {
return new RC_5f28219a5e30fb90023fcbc295513e7c();
}

	}
}