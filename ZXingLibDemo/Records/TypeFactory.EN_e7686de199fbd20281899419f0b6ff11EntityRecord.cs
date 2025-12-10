namespace ssZXingLibDemo {
	public class EN_e7686de199fbd20281899419f0b6ff11EntityRecordTypeFactoryImpl : RsseSpaceOutSystemsMaps.IEN_e7686de199fbd20281899419f0b6ff11EntityRecordTypeFactory {
	    private static readonly EN_e7686de199fbd20281899419f0b6ff11EntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_e7686de199fbd20281899419f0b6ff11EntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryEN_e7686de199fbd20281899419f0b6ff11EntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsEN_e7686de199fbd20281899419f0b6ff11EntityRecord() {
return new EN_e7686de199fbd20281899419f0b6ff11EntityRecord();
}

	}
}