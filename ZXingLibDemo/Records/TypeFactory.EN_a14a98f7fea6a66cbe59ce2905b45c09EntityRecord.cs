namespace ssZXingLibDemo {
	public class EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecordTypeFactory {
	    private static readonly EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord() {
return new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord();
}

	}
}