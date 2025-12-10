namespace ssZXingLibDemo {
	public class ST_0e474756a4be14d378c73cd05f602bcdStructureTypeFactoryImpl : RsseSpaceOutSystemsMaps.IST_0e474756a4be14d378c73cd05f602bcdStructureTypeFactory {
	    private static readonly ST_0e474756a4be14d378c73cd05f602bcdStructureTypeFactoryImpl Instance = new();
	
	    private ST_0e474756a4be14d378c73cd05f602bcdStructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryST_0e474756a4be14d378c73cd05f602bcdStructureSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsST_0e474756a4be14d378c73cd05f602bcdStructure() {
return new ST_0e474756a4be14d378c73cd05f602bcdStructure();
}

	}
}