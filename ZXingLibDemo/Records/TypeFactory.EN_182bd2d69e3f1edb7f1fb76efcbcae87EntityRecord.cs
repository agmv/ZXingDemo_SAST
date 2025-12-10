namespace ssZXingLibDemo {
	public class EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecordTypeFactory {
	    private static readonly EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord() {
return new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord();
}

	}
}