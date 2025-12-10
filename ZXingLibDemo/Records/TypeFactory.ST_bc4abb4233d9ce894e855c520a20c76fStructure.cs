namespace ssZXingLibDemo {
	public class ST_bc4abb4233d9ce894e855c520a20c76fStructureTypeFactoryImpl : RsseSpaceOutSystemsUI.IST_bc4abb4233d9ce894e855c520a20c76fStructureTypeFactory {
	    private static readonly ST_bc4abb4233d9ce894e855c520a20c76fStructureTypeFactoryImpl Instance = new();
	
	    private ST_bc4abb4233d9ce894e855c520a20c76fStructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryST_bc4abb4233d9ce894e855c520a20c76fStructureSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIST_bc4abb4233d9ce894e855c520a20c76fStructure() {
return new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
}

	}
}