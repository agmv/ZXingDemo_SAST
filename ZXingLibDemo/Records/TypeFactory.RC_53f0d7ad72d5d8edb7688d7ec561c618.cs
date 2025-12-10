namespace ssZXingLibDemo {
	public class RC_53f0d7ad72d5d8edb7688d7ec561c618TypeFactoryImpl : RssExternalLibraryZXingLib.IRC_53f0d7ad72d5d8edb7688d7ec561c618TypeFactory {
	    private static readonly RC_53f0d7ad72d5d8edb7688d7ec561c618TypeFactoryImpl Instance = new();
	
	    private RC_53f0d7ad72d5d8edb7688d7ec561c618TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryRC_53f0d7ad72d5d8edb7688d7ec561c618Singleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_53f0d7ad72d5d8edb7688d7ec561c618() {
return new RC_53f0d7ad72d5d8edb7688d7ec561c618();
}

	}
}