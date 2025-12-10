namespace ssZXingLibDemo {
	public class ST_8738e857d4fb6695d1e17d4c03428ee2StructureTypeFactoryImpl : RssExternalLibraryZXingLib.IST_8738e857d4fb6695d1e17d4c03428ee2StructureTypeFactory {
	    private static readonly ST_8738e857d4fb6695d1e17d4c03428ee2StructureTypeFactoryImpl Instance = new();
	
	    private ST_8738e857d4fb6695d1e17d4c03428ee2StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryST_8738e857d4fb6695d1e17d4c03428ee2StructureSingleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_8738e857d4fb6695d1e17d4c03428ee2Structure() {
return new ST_8738e857d4fb6695d1e17d4c03428ee2Structure();
}

	}
}