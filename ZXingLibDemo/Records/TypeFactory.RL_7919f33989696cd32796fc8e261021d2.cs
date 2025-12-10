namespace ssZXingLibDemo {
	public class RL_7919f33989696cd32796fc8e261021d2TypeFactoryImpl : RssExternalLibraryZXingLib.IRL_7919f33989696cd32796fc8e261021d2TypeFactory {
	    private static readonly RL_7919f33989696cd32796fc8e261021d2TypeFactoryImpl Instance = new();
	
	    private RL_7919f33989696cd32796fc8e261021d2TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RssExternalLibraryZXingLib.Factory.FactoryRL_7919f33989696cd32796fc8e261021d2Singleton = Instance;

		}
		
		public OutSystems.Application.Extensibility.DataTypes.IRecordList CreateRssExternalLibraryZXingLibRL_7919f33989696cd32796fc8e261021d2() {
return new RL_7919f33989696cd32796fc8e261021d2();
}

	}
}