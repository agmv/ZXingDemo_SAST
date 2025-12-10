namespace ssZXingLibDemo {
	public class EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecordTypeFactory {
	    private static readonly EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord() {
return new EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord();
}

	}
}