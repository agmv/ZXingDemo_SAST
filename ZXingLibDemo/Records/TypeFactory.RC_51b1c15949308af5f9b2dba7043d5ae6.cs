namespace ssZXingLibDemo {
	public class RC_51b1c15949308af5f9b2dba7043d5ae6TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_51b1c15949308af5f9b2dba7043d5ae6TypeFactory {
	    private static readonly RC_51b1c15949308af5f9b2dba7043d5ae6TypeFactoryImpl Instance = new();
	
	    private RC_51b1c15949308af5f9b2dba7043d5ae6TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_51b1c15949308af5f9b2dba7043d5ae6Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_51b1c15949308af5f9b2dba7043d5ae6() {
return new RC_51b1c15949308af5f9b2dba7043d5ae6();
}

	}
}