namespace ssZXingLibDemo {
	public class ST_e3f9af4171d5e4a41700770295d05c77StructureTypeFactoryImpl : RsseSpaceOutSystemsUI.IST_e3f9af4171d5e4a41700770295d05c77StructureTypeFactory {
	    private static readonly ST_e3f9af4171d5e4a41700770295d05c77StructureTypeFactoryImpl Instance = new();
	
	    private ST_e3f9af4171d5e4a41700770295d05c77StructureTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryST_e3f9af4171d5e4a41700770295d05c77StructureSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIST_e3f9af4171d5e4a41700770295d05c77Structure() {
return new ST_e3f9af4171d5e4a41700770295d05c77Structure();
}

	}
}