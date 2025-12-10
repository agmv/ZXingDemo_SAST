namespace ssZXingLibDemo {
	public class ST_a1f7d5fa968628cf9ed1d90efadf9506StructureTypeFactoryImpl : RssExternalLibraryZXingLib.IST_a1f7d5fa968628cf9ed1d90efadf9506StructureTypeFactory {
	    private static readonly ST_a1f7d5fa968628cf9ed1d90efadf9506StructureTypeFactoryImpl Instance = new();
	
	    private ST_a1f7d5fa968628cf9ed1d90efadf9506StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryST_a1f7d5fa968628cf9ed1d90efadf9506StructureSingleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_a1f7d5fa968628cf9ed1d90efadf9506Structure() {
return new ST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
}

	}
}