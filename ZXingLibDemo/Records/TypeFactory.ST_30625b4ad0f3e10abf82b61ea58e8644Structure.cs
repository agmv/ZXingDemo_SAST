namespace ssZXingLibDemo {
	public class ST_30625b4ad0f3e10abf82b61ea58e8644StructureTypeFactoryImpl : RsseSpaceOutSystemsMaps.IST_30625b4ad0f3e10abf82b61ea58e8644StructureTypeFactory {
	    private static readonly ST_30625b4ad0f3e10abf82b61ea58e8644StructureTypeFactoryImpl Instance = new();
	
	    private ST_30625b4ad0f3e10abf82b61ea58e8644StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryST_30625b4ad0f3e10abf82b61ea58e8644StructureSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsST_30625b4ad0f3e10abf82b61ea58e8644Structure() {
return new ST_30625b4ad0f3e10abf82b61ea58e8644Structure();
}

	}
}