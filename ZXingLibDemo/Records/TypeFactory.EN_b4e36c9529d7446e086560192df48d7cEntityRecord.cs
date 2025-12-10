namespace ssZXingLibDemo {
	public class EN_b4e36c9529d7446e086560192df48d7cEntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_b4e36c9529d7446e086560192df48d7cEntityRecordTypeFactory {
	    private static readonly EN_b4e36c9529d7446e086560192df48d7cEntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_b4e36c9529d7446e086560192df48d7cEntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_b4e36c9529d7446e086560192df48d7cEntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_b4e36c9529d7446e086560192df48d7cEntityRecord() {
return new EN_b4e36c9529d7446e086560192df48d7cEntityRecord();
}

	}
}