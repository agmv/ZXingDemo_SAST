namespace ssZXingLibDemo {
	public class RC_e3355f6b7ba3051c4a4a9a00634d68d0TypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_e3355f6b7ba3051c4a4a9a00634d68d0TypeFactory {
	    private static readonly RC_e3355f6b7ba3051c4a4a9a00634d68d0TypeFactoryImpl Instance = new();
	
	    private RC_e3355f6b7ba3051c4a4a9a00634d68d0TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_e3355f6b7ba3051c4a4a9a00634d68d0Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_e3355f6b7ba3051c4a4a9a00634d68d0() {
return new RC_e3355f6b7ba3051c4a4a9a00634d68d0();
}

	}
}