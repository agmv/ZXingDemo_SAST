namespace ssZXingLibDemo {
	public class ST_d609eacb476c603df8b92eb374da99faStructureTypeFactoryImpl : RsseSpaceOutSystemsMaps.IST_d609eacb476c603df8b92eb374da99faStructureTypeFactory {
	    private static readonly ST_d609eacb476c603df8b92eb374da99faStructureTypeFactoryImpl Instance = new();
	
	    private ST_d609eacb476c603df8b92eb374da99faStructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryST_d609eacb476c603df8b92eb374da99faStructureSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsST_d609eacb476c603df8b92eb374da99faStructure() {
return new ST_d609eacb476c603df8b92eb374da99faStructure();
}

	}
}