namespace ssZXingLibDemo {
	public class RC_a5018402fa6c90c5e826e54b2748cedcTypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_a5018402fa6c90c5e826e54b2748cedcTypeFactory {
	    private static readonly RC_a5018402fa6c90c5e826e54b2748cedcTypeFactoryImpl Instance = new();
	
	    private RC_a5018402fa6c90c5e826e54b2748cedcTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_a5018402fa6c90c5e826e54b2748cedcSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_a5018402fa6c90c5e826e54b2748cedc() {
return new RC_a5018402fa6c90c5e826e54b2748cedc();
}

	}
}