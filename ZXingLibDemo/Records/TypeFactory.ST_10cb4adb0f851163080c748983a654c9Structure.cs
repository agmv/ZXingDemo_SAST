namespace ssZXingLibDemo {
	public class ST_10cb4adb0f851163080c748983a654c9StructureTypeFactoryImpl : RssExternalLibraryZXingLib.IST_10cb4adb0f851163080c748983a654c9StructureTypeFactory {
	    private static readonly ST_10cb4adb0f851163080c748983a654c9StructureTypeFactoryImpl Instance = new();
	
	    private ST_10cb4adb0f851163080c748983a654c9StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryST_10cb4adb0f851163080c748983a654c9StructureSingleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_10cb4adb0f851163080c748983a654c9Structure() {
return new ST_10cb4adb0f851163080c748983a654c9Structure();
}

	}
}