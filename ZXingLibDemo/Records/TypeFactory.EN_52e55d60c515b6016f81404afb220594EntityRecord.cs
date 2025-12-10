namespace ssZXingLibDemo {
	public class EN_52e55d60c515b6016f81404afb220594EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_52e55d60c515b6016f81404afb220594EntityRecordTypeFactory {
	    private static readonly EN_52e55d60c515b6016f81404afb220594EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_52e55d60c515b6016f81404afb220594EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_52e55d60c515b6016f81404afb220594EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_52e55d60c515b6016f81404afb220594EntityRecord() {
return new EN_52e55d60c515b6016f81404afb220594EntityRecord();
}

	}
}