namespace ssZXingLibDemo {
	public class ST_be62cc31fbe4705834275960beeb55e2StructureTypeFactoryImpl : RsseSpaceOutSystemsMaps.IST_be62cc31fbe4705834275960beeb55e2StructureTypeFactory {
	    private static readonly ST_be62cc31fbe4705834275960beeb55e2StructureTypeFactoryImpl Instance = new();
	
	    private ST_be62cc31fbe4705834275960beeb55e2StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryST_be62cc31fbe4705834275960beeb55e2StructureSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsST_be62cc31fbe4705834275960beeb55e2Structure() {
return new ST_be62cc31fbe4705834275960beeb55e2Structure();
}

	}
}