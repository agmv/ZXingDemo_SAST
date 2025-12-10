namespace ssZXingLibDemo {
	public class RC_2796116ff1beb3c001fb57dc12652270TypeFactoryImpl : RssExternalLibraryZXingLib.IRC_2796116ff1beb3c001fb57dc12652270TypeFactory {
	    private static readonly RC_2796116ff1beb3c001fb57dc12652270TypeFactoryImpl Instance = new();
	
	    private RC_2796116ff1beb3c001fb57dc12652270TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryRC_2796116ff1beb3c001fb57dc12652270Singleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_2796116ff1beb3c001fb57dc12652270() {
return new RC_2796116ff1beb3c001fb57dc12652270();
}

	}
}