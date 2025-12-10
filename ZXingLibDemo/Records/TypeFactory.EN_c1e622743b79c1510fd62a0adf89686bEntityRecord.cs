namespace ssZXingLibDemo {
	public class EN_c1e622743b79c1510fd62a0adf89686bEntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_c1e622743b79c1510fd62a0adf89686bEntityRecordTypeFactory {
	    private static readonly EN_c1e622743b79c1510fd62a0adf89686bEntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_c1e622743b79c1510fd62a0adf89686bEntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_c1e622743b79c1510fd62a0adf89686bEntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_c1e622743b79c1510fd62a0adf89686bEntityRecord() {
return new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord();
}

	}
}