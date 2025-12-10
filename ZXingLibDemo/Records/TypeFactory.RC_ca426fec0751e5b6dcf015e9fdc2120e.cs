namespace ssZXingLibDemo {
	public class RC_ca426fec0751e5b6dcf015e9fdc2120eTypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_ca426fec0751e5b6dcf015e9fdc2120eTypeFactory {
	    private static readonly RC_ca426fec0751e5b6dcf015e9fdc2120eTypeFactoryImpl Instance = new();
	
	    private RC_ca426fec0751e5b6dcf015e9fdc2120eTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_ca426fec0751e5b6dcf015e9fdc2120eSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_ca426fec0751e5b6dcf015e9fdc2120e() {
return new RC_ca426fec0751e5b6dcf015e9fdc2120e();
}

	}
}