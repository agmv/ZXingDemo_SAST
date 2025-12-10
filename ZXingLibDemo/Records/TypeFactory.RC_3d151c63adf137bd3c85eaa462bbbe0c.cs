namespace ssZXingLibDemo {
	public class RC_3d151c63adf137bd3c85eaa462bbbe0cTypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_3d151c63adf137bd3c85eaa462bbbe0cTypeFactory {
	    private static readonly RC_3d151c63adf137bd3c85eaa462bbbe0cTypeFactoryImpl Instance = new();
	
	    private RC_3d151c63adf137bd3c85eaa462bbbe0cTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_3d151c63adf137bd3c85eaa462bbbe0cSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_3d151c63adf137bd3c85eaa462bbbe0c() {
return new RC_3d151c63adf137bd3c85eaa462bbbe0c();
}

	}
}