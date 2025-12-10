namespace ssZXingLibDemo {
	public class RC_a3e0d02178b078a960ae427dd1751cbcTypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_a3e0d02178b078a960ae427dd1751cbcTypeFactory {
	    private static readonly RC_a3e0d02178b078a960ae427dd1751cbcTypeFactoryImpl Instance = new();
	
	    private RC_a3e0d02178b078a960ae427dd1751cbcTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_a3e0d02178b078a960ae427dd1751cbcSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_a3e0d02178b078a960ae427dd1751cbc() {
return new RC_a3e0d02178b078a960ae427dd1751cbc();
}

	}
}