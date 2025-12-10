namespace ssZXingLibDemo {
	public class EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecordTypeFactory {
	    private static readonly EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord() {
return new EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord();
}

	}
}