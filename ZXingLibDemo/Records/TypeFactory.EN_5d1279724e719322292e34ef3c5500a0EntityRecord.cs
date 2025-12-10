namespace ssZXingLibDemo {
	public class EN_5d1279724e719322292e34ef3c5500a0EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_5d1279724e719322292e34ef3c5500a0EntityRecordTypeFactory {
	    private static readonly EN_5d1279724e719322292e34ef3c5500a0EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_5d1279724e719322292e34ef3c5500a0EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_5d1279724e719322292e34ef3c5500a0EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_5d1279724e719322292e34ef3c5500a0EntityRecord() {
return new EN_5d1279724e719322292e34ef3c5500a0EntityRecord();
}

	}
}