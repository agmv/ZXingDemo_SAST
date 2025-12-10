namespace ssZXingLibDemo {
	public class RC_9b61cb371b118ff2b906c01399dcb602TypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_9b61cb371b118ff2b906c01399dcb602TypeFactory {
	    private static readonly RC_9b61cb371b118ff2b906c01399dcb602TypeFactoryImpl Instance = new();
	
	    private RC_9b61cb371b118ff2b906c01399dcb602TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_9b61cb371b118ff2b906c01399dcb602Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_9b61cb371b118ff2b906c01399dcb602() {
return new RC_9b61cb371b118ff2b906c01399dcb602();
}

	}
}