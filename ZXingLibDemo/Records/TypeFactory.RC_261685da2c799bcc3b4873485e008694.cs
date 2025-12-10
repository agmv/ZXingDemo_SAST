namespace ssZXingLibDemo {
	public class RC_261685da2c799bcc3b4873485e008694TypeFactoryImpl : RsseSpaceOutSystemsUI.IRC_261685da2c799bcc3b4873485e008694TypeFactory {
	    private static readonly RC_261685da2c799bcc3b4873485e008694TypeFactoryImpl Instance = new();
	
	    private RC_261685da2c799bcc3b4873485e008694TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryRC_261685da2c799bcc3b4873485e008694Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIRC_261685da2c799bcc3b4873485e008694() {
return new RC_261685da2c799bcc3b4873485e008694();
}

	}
}