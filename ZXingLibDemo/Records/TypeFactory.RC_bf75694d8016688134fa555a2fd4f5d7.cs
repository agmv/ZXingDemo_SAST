namespace ssZXingLibDemo {
	public class RC_bf75694d8016688134fa555a2fd4f5d7TypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_bf75694d8016688134fa555a2fd4f5d7TypeFactory {
	    private static readonly RC_bf75694d8016688134fa555a2fd4f5d7TypeFactoryImpl Instance = new();
	
	    private RC_bf75694d8016688134fa555a2fd4f5d7TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_bf75694d8016688134fa555a2fd4f5d7Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_bf75694d8016688134fa555a2fd4f5d7() {
return new RC_bf75694d8016688134fa555a2fd4f5d7();
}

	}
}