namespace ssZXingLibDemo {
	public class RC_7ef51ad4bf41859d359e0a9b0b3ca1b5TypeFactoryImpl : RssExternalLibraryZXingLib.IRC_7ef51ad4bf41859d359e0a9b0b3ca1b5TypeFactory {
	    private static readonly RC_7ef51ad4bf41859d359e0a9b0b3ca1b5TypeFactoryImpl Instance = new();
	
	    private RC_7ef51ad4bf41859d359e0a9b0b3ca1b5TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryRC_7ef51ad4bf41859d359e0a9b0b3ca1b5Singleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_7ef51ad4bf41859d359e0a9b0b3ca1b5() {
return new RC_7ef51ad4bf41859d359e0a9b0b3ca1b5();
}

	}
}