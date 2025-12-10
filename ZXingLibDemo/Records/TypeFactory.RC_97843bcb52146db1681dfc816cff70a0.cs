namespace ssZXingLibDemo {
	public class RC_97843bcb52146db1681dfc816cff70a0TypeFactoryImpl : RsseSpaceOutSystemsMaps.IRC_97843bcb52146db1681dfc816cff70a0TypeFactory {
	    private static readonly RC_97843bcb52146db1681dfc816cff70a0TypeFactoryImpl Instance = new();
	
	    private RC_97843bcb52146db1681dfc816cff70a0TypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceOutSystemsMaps.Factory.FactoryRC_97843bcb52146db1681dfc816cff70a0Singleton = Instance;

		}
		
		public IRecord CreateRsseSpaceOutSystemsMapsRC_97843bcb52146db1681dfc816cff70a0() {
return new RC_97843bcb52146db1681dfc816cff70a0();
}

	}
}