namespace ssZXingLibDemo {
	public class EN_d11562be18a7e40ca777aa336c946163EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_d11562be18a7e40ca777aa336c946163EntityRecordTypeFactory {
	    private static readonly EN_d11562be18a7e40ca777aa336c946163EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_d11562be18a7e40ca777aa336c946163EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_d11562be18a7e40ca777aa336c946163EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_d11562be18a7e40ca777aa336c946163EntityRecord() {
return new EN_d11562be18a7e40ca777aa336c946163EntityRecord();
}

	}
}