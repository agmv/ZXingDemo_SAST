namespace ssZXingLibDemo {
	public class RC_d687bfbe104d17346737149645109738TypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_d687bfbe104d17346737149645109738TypeFactory {
	    private static readonly RC_d687bfbe104d17346737149645109738TypeFactoryImpl Instance = new();
	
	    private RC_d687bfbe104d17346737149645109738TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_d687bfbe104d17346737149645109738Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_d687bfbe104d17346737149645109738() {
return new RC_d687bfbe104d17346737149645109738();
}

	}
}