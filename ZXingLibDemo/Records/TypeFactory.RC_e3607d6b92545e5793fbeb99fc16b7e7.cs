namespace ssZXingLibDemo {
	public class RC_e3607d6b92545e5793fbeb99fc16b7e7TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_e3607d6b92545e5793fbeb99fc16b7e7TypeFactory {
	    private static readonly RC_e3607d6b92545e5793fbeb99fc16b7e7TypeFactoryImpl Instance = new();
	
	    private RC_e3607d6b92545e5793fbeb99fc16b7e7TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_e3607d6b92545e5793fbeb99fc16b7e7Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_e3607d6b92545e5793fbeb99fc16b7e7() {
return new RC_e3607d6b92545e5793fbeb99fc16b7e7();
}

	}
}