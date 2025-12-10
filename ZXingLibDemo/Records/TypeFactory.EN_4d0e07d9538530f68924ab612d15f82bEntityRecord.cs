namespace ssZXingLibDemo {
	public class EN_4d0e07d9538530f68924ab612d15f82bEntityRecordTypeFactoryImpl : RsseSpaceOutSystemsMaps.IEN_4d0e07d9538530f68924ab612d15f82bEntityRecordTypeFactory {
	    private static readonly EN_4d0e07d9538530f68924ab612d15f82bEntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_4d0e07d9538530f68924ab612d15f82bEntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryEN_4d0e07d9538530f68924ab612d15f82bEntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsEN_4d0e07d9538530f68924ab612d15f82bEntityRecord() {
return new EN_4d0e07d9538530f68924ab612d15f82bEntityRecord();
}

	}
}