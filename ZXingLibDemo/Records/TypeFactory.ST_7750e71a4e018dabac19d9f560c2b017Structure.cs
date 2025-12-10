namespace ssZXingLibDemo {
	public class ST_7750e71a4e018dabac19d9f560c2b017StructureTypeFactoryImpl : RssExternalLibraryZXingLib.IST_7750e71a4e018dabac19d9f560c2b017StructureTypeFactory {
	    private static readonly ST_7750e71a4e018dabac19d9f560c2b017StructureTypeFactoryImpl Instance = new();
	
	    private ST_7750e71a4e018dabac19d9f560c2b017StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryST_7750e71a4e018dabac19d9f560c2b017StructureSingleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_7750e71a4e018dabac19d9f560c2b017Structure() {
return new ST_7750e71a4e018dabac19d9f560c2b017Structure();
}

	}
}