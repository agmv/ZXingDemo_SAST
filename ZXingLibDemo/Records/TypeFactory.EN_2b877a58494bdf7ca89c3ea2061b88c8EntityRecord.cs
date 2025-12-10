namespace ssZXingLibDemo {
	public class EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsMaps.IEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordTypeFactory {
	    private static readonly EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord() {
return new EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord();
}

	}
}