namespace ssZXingLibDemo {
	public class ST_af04a340a4a61afef041397e6f042234StructureTypeFactoryImpl : RssExternalLibraryZXingLib.IST_af04a340a4a61afef041397e6f042234StructureTypeFactory {
	    private static readonly ST_af04a340a4a61afef041397e6f042234StructureTypeFactoryImpl Instance = new();
	
	    private ST_af04a340a4a61afef041397e6f042234StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryST_af04a340a4a61afef041397e6f042234StructureSingleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_af04a340a4a61afef041397e6f042234Structure() {
return new ST_af04a340a4a61afef041397e6f042234Structure();
}

	}
}