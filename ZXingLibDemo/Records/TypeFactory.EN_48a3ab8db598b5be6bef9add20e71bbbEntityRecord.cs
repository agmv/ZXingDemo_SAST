namespace ssZXingLibDemo {
	public class EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecordTypeFactoryImpl : RsseSpaceOutSystemsUI.IEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecordTypeFactory {
	    private static readonly EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsUI.Factory.FactoryEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsUIEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord() {
return new EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord();
}

	}
}