namespace ssZXingLibDemo {
	public class RC_d761bc5f1b0fe2debf1c3edffd0efd3cTypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_d761bc5f1b0fe2debf1c3edffd0efd3cTypeFactory {
	    private static readonly RC_d761bc5f1b0fe2debf1c3edffd0efd3cTypeFactoryImpl Instance = new();
	
	    private RC_d761bc5f1b0fe2debf1c3edffd0efd3cTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_d761bc5f1b0fe2debf1c3edffd0efd3cSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_d761bc5f1b0fe2debf1c3edffd0efd3c() {
return new RC_d761bc5f1b0fe2debf1c3edffd0efd3c();
}

	}
}