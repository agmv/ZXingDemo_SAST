namespace ssZXingLibDemo {
	public class RC_0a89eeb60fa1f44b6316ca69b462007bTypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_0a89eeb60fa1f44b6316ca69b462007bTypeFactory {
	    private static readonly RC_0a89eeb60fa1f44b6316ca69b462007bTypeFactoryImpl Instance = new();
	
	    private RC_0a89eeb60fa1f44b6316ca69b462007bTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_0a89eeb60fa1f44b6316ca69b462007bSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_0a89eeb60fa1f44b6316ca69b462007b() {
return new RC_0a89eeb60fa1f44b6316ca69b462007b();
}

	}
}