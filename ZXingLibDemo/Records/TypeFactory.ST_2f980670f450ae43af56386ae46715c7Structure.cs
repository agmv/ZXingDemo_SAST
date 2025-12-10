namespace ssZXingLibDemo {
	public class ST_2f980670f450ae43af56386ae46715c7StructureTypeFactoryImpl : RssExternalLibraryZXingLib.IST_2f980670f450ae43af56386ae46715c7StructureTypeFactory {
	    private static readonly ST_2f980670f450ae43af56386ae46715c7StructureTypeFactoryImpl Instance = new();
	
	    private ST_2f980670f450ae43af56386ae46715c7StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryST_2f980670f450ae43af56386ae46715c7StructureSingleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_2f980670f450ae43af56386ae46715c7Structure() {
return new ST_2f980670f450ae43af56386ae46715c7Structure();
}

	}
}