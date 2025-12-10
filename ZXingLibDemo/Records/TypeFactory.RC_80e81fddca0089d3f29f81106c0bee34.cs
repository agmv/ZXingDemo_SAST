namespace ssZXingLibDemo {
	public class RC_80e81fddca0089d3f29f81106c0bee34TypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_80e81fddca0089d3f29f81106c0bee34TypeFactory {
	    private static readonly RC_80e81fddca0089d3f29f81106c0bee34TypeFactoryImpl Instance = new();
	
	    private RC_80e81fddca0089d3f29f81106c0bee34TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_80e81fddca0089d3f29f81106c0bee34Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_80e81fddca0089d3f29f81106c0bee34() {
return new RC_80e81fddca0089d3f29f81106c0bee34();
}

	}
}