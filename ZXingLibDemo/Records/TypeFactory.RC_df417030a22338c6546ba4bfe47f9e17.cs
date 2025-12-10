namespace ssZXingLibDemo {
	public class RC_df417030a22338c6546ba4bfe47f9e17TypeFactoryImpl : RssExternalLibraryZXingLib.IRC_df417030a22338c6546ba4bfe47f9e17TypeFactory {
	    private static readonly RC_df417030a22338c6546ba4bfe47f9e17TypeFactoryImpl Instance = new();
	
	    private RC_df417030a22338c6546ba4bfe47f9e17TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryRC_df417030a22338c6546ba4bfe47f9e17Singleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_df417030a22338c6546ba4bfe47f9e17() {
return new RC_df417030a22338c6546ba4bfe47f9e17();
}

	}
}