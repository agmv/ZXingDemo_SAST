namespace ssZXingLibDemo {
	public class RC_b32e755d03dd085a4b975b8c0c7d4454TypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_b32e755d03dd085a4b975b8c0c7d4454TypeFactory {
	    private static readonly RC_b32e755d03dd085a4b975b8c0c7d4454TypeFactoryImpl Instance = new();
	
	    private RC_b32e755d03dd085a4b975b8c0c7d4454TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_b32e755d03dd085a4b975b8c0c7d4454Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_b32e755d03dd085a4b975b8c0c7d4454() {
return new RC_b32e755d03dd085a4b975b8c0c7d4454();
}

	}
}