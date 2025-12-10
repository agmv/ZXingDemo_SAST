namespace ssZXingLibDemo {
	public class EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecordTypeFactory {
	    private static readonly EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord() {
return new EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord();
}

	}
}