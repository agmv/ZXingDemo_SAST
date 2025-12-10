namespace ssZXingLibDemo {
	public class RC_9589ecc0629788c2aca6b47bcbae782cTypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_9589ecc0629788c2aca6b47bcbae782cTypeFactory {
	    private static readonly RC_9589ecc0629788c2aca6b47bcbae782cTypeFactoryImpl Instance = new();
	
	    private RC_9589ecc0629788c2aca6b47bcbae782cTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_9589ecc0629788c2aca6b47bcbae782cSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_9589ecc0629788c2aca6b47bcbae782c() {
return new RC_9589ecc0629788c2aca6b47bcbae782c();
}

	}
}