namespace ssZXingLibDemo {
	public class RC_27b5a164e828de9b90686831c7908b4aTypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_27b5a164e828de9b90686831c7908b4aTypeFactory {
	    private static readonly RC_27b5a164e828de9b90686831c7908b4aTypeFactoryImpl Instance = new();
	
	    private RC_27b5a164e828de9b90686831c7908b4aTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_27b5a164e828de9b90686831c7908b4aSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_27b5a164e828de9b90686831c7908b4a() {
return new RC_27b5a164e828de9b90686831c7908b4a();
}

	}
}