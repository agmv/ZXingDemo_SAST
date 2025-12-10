namespace ssZXingLibDemo {
	public class RC_87351e3b0fa2ca59cf6c6749c6405006TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_87351e3b0fa2ca59cf6c6749c6405006TypeFactory {
	    private static readonly RC_87351e3b0fa2ca59cf6c6749c6405006TypeFactoryImpl Instance = new();
	
	    private RC_87351e3b0fa2ca59cf6c6749c6405006TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_87351e3b0fa2ca59cf6c6749c6405006Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_87351e3b0fa2ca59cf6c6749c6405006() {
return new RC_87351e3b0fa2ca59cf6c6749c6405006();
}

	}
}