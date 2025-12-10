namespace ssZXingLibDemo {
	public class RC_b7283e2c6e9c6bcb5286d1ae04959554TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_b7283e2c6e9c6bcb5286d1ae04959554TypeFactory {
	    private static readonly RC_b7283e2c6e9c6bcb5286d1ae04959554TypeFactoryImpl Instance = new();
	
	    private RC_b7283e2c6e9c6bcb5286d1ae04959554TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_b7283e2c6e9c6bcb5286d1ae04959554Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_b7283e2c6e9c6bcb5286d1ae04959554() {
return new RC_b7283e2c6e9c6bcb5286d1ae04959554();
}

	}
}