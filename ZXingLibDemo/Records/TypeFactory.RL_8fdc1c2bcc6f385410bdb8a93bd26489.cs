namespace ssZXingLibDemo {
	public class RL_8fdc1c2bcc6f385410bdb8a93bd26489TypeFactoryImpl : RssExternalLibraryZXingLib.IRL_8fdc1c2bcc6f385410bdb8a93bd26489TypeFactory {
	    private static readonly RL_8fdc1c2bcc6f385410bdb8a93bd26489TypeFactoryImpl Instance = new();
	
	    private RL_8fdc1c2bcc6f385410bdb8a93bd26489TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryRL_8fdc1c2bcc6f385410bdb8a93bd26489Singleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecordList CreateRssExternalLibraryZXingLibRL_8fdc1c2bcc6f385410bdb8a93bd26489() {
return new RL_8fdc1c2bcc6f385410bdb8a93bd26489();
}

	}
}