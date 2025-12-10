namespace ssZXingLibDemo {
	public class EN_da8d5af471adea3d9064074b1a40d8c2EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsMaps.IEN_da8d5af471adea3d9064074b1a40d8c2EntityRecordTypeFactory {
	    private static readonly EN_da8d5af471adea3d9064074b1a40d8c2EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_da8d5af471adea3d9064074b1a40d8c2EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryEN_da8d5af471adea3d9064074b1a40d8c2EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord() {
return new EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord();
}

	}
}