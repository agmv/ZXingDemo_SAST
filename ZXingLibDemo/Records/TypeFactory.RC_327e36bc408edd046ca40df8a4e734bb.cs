namespace ssZXingLibDemo {
	public class RC_327e36bc408edd046ca40df8a4e734bbTypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_327e36bc408edd046ca40df8a4e734bbTypeFactory {
	    private static readonly RC_327e36bc408edd046ca40df8a4e734bbTypeFactoryImpl Instance = new();
	
	    private RC_327e36bc408edd046ca40df8a4e734bbTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_327e36bc408edd046ca40df8a4e734bbSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_327e36bc408edd046ca40df8a4e734bb() {
return new RC_327e36bc408edd046ca40df8a4e734bb();
}

	}
}