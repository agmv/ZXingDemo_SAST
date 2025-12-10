namespace ssZXingLibDemo {
	public class ST_b7d405ca4407e572da091e54d07e3bd1StructureTypeFactoryImpl : RsseSpaceOutSystemsUI.IST_b7d405ca4407e572da091e54d07e3bd1StructureTypeFactory {
	    private static readonly ST_b7d405ca4407e572da091e54d07e3bd1StructureTypeFactoryImpl Instance = new();
	
	    private ST_b7d405ca4407e572da091e54d07e3bd1StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryST_b7d405ca4407e572da091e54d07e3bd1StructureSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIST_b7d405ca4407e572da091e54d07e3bd1Structure() {
return new ST_b7d405ca4407e572da091e54d07e3bd1Structure();
}

	}
}