namespace ssZXingLibDemo {
	public class ST_59c2aa6a35b14343cc78f655810f9ce8StructureTypeFactoryImpl : RsseSpaceOutSystemsMaps.IST_59c2aa6a35b14343cc78f655810f9ce8StructureTypeFactory {
	    private static readonly ST_59c2aa6a35b14343cc78f655810f9ce8StructureTypeFactoryImpl Instance = new();
	
	    private ST_59c2aa6a35b14343cc78f655810f9ce8StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryST_59c2aa6a35b14343cc78f655810f9ce8StructureSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsST_59c2aa6a35b14343cc78f655810f9ce8Structure() {
return new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
}

	}
}