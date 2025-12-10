namespace ssZXingLibDemo {
	public class EN_8d4f783227026ce93d50126c7f028443EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_8d4f783227026ce93d50126c7f028443EntityRecordTypeFactory {
	    private static readonly EN_8d4f783227026ce93d50126c7f028443EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_8d4f783227026ce93d50126c7f028443EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_8d4f783227026ce93d50126c7f028443EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_8d4f783227026ce93d50126c7f028443EntityRecord() {
return new EN_8d4f783227026ce93d50126c7f028443EntityRecord();
}

	}
}