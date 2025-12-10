namespace ssZXingLibDemo {
	public class EN_480235a969b3f42eac91ad5813fe9bf9EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsMaps.IEN_480235a969b3f42eac91ad5813fe9bf9EntityRecordTypeFactory {
	    private static readonly EN_480235a969b3f42eac91ad5813fe9bf9EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_480235a969b3f42eac91ad5813fe9bf9EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryEN_480235a969b3f42eac91ad5813fe9bf9EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord() {
return new EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord();
}

	}
}