namespace ssZXingLibDemo {
	public class EN_50814454e481dd1773c2250bc248da5eEntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_50814454e481dd1773c2250bc248da5eEntityRecordTypeFactory {
	    private static readonly EN_50814454e481dd1773c2250bc248da5eEntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_50814454e481dd1773c2250bc248da5eEntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_50814454e481dd1773c2250bc248da5eEntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_50814454e481dd1773c2250bc248da5eEntityRecord() {
return new EN_50814454e481dd1773c2250bc248da5eEntityRecord();
}

	}
}