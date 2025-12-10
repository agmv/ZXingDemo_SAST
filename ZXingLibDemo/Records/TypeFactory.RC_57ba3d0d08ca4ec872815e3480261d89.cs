namespace ssZXingLibDemo {
	public class RC_57ba3d0d08ca4ec872815e3480261d89TypeFactoryImpl : RssExternalLibraryZXingLib.IRC_57ba3d0d08ca4ec872815e3480261d89TypeFactory {
	    private static readonly RC_57ba3d0d08ca4ec872815e3480261d89TypeFactoryImpl Instance = new();
	
	    private RC_57ba3d0d08ca4ec872815e3480261d89TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryRC_57ba3d0d08ca4ec872815e3480261d89Singleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_57ba3d0d08ca4ec872815e3480261d89() {
return new RC_57ba3d0d08ca4ec872815e3480261d89();
}

	}
}