namespace ssZXingLibDemo {
	public class RC_957e93eddd28d08c07d4a328c870138aTypeFactoryImpl : RssExternalLibraryZXingLib.IRC_957e93eddd28d08c07d4a328c870138aTypeFactory {
	    private static readonly RC_957e93eddd28d08c07d4a328c870138aTypeFactoryImpl Instance = new();
	
	    private RC_957e93eddd28d08c07d4a328c870138aTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryRC_957e93eddd28d08c07d4a328c870138aSingleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_957e93eddd28d08c07d4a328c870138a() {
return new RC_957e93eddd28d08c07d4a328c870138a();
}

	}
}