namespace ssZXingLibDemo {
	public class RC_ab84a98a3ac9de80e9278e5b21681a23TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_ab84a98a3ac9de80e9278e5b21681a23TypeFactory {
	    private static readonly RC_ab84a98a3ac9de80e9278e5b21681a23TypeFactoryImpl Instance = new();
	
	    private RC_ab84a98a3ac9de80e9278e5b21681a23TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_ab84a98a3ac9de80e9278e5b21681a23Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_ab84a98a3ac9de80e9278e5b21681a23() {
return new RC_ab84a98a3ac9de80e9278e5b21681a23();
}

	}
}