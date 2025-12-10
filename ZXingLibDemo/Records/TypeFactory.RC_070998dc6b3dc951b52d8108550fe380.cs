namespace ssZXingLibDemo {
	public class RC_070998dc6b3dc951b52d8108550fe380TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_070998dc6b3dc951b52d8108550fe380TypeFactory {
	    private static readonly RC_070998dc6b3dc951b52d8108550fe380TypeFactoryImpl Instance = new();
	
	    private RC_070998dc6b3dc951b52d8108550fe380TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_070998dc6b3dc951b52d8108550fe380Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_070998dc6b3dc951b52d8108550fe380() {
return new RC_070998dc6b3dc951b52d8108550fe380();
}

	}
}