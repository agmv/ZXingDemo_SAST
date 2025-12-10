using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// GutterSizeRecord
public class JSONRC_a5018402fa6c90c5e826e54b2748cedc : AbstractRESTStructure<RC_a5018402fa6c90c5e826e54b2748cedc> {
[JsonProperty("GutterSize")]
[JsonPropertyName("GutterSize")]
public ssZXingLibDemo.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord AttrGutterSize;

public JSONRC_a5018402fa6c90c5e826e54b2748cedc() { }

public JSONRC_a5018402fa6c90c5e826e54b2748cedc (RC_a5018402fa6c90c5e826e54b2748cedc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGutterSize = ConvertToRestWithoutDefaults(s.ssENGutterSize, new EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord(), ssZXingLibDemo.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.FromStructureDelegate(config));
  } else {
AttrGutterSize = ssZXingLibDemo.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.FromStructure(s.ssENGutterSize, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc, RC_a5018402fa6c90c5e826e54b2748cedc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc s) => ToStructure(s, config);
}
public static RC_a5018402fa6c90c5e826e54b2748cedc ToStructure(ssZXingLibDemo.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc obj, IBehaviorsConfiguration config) { 
  RC_a5018402fa6c90c5e826e54b2748cedc s = new RC_a5018402fa6c90c5e826e54b2748cedc();
  if(obj != null) {
  s.ssENGutterSize = ssZXingLibDemo.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.ToStructure(obj.AttrGutterSize, config);
  }
  return s;
}

public static Func<RC_a5018402fa6c90c5e826e54b2748cedc, ssZXingLibDemo.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a5018402fa6c90c5e826e54b2748cedc s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc FromStructure(RC_a5018402fa6c90c5e826e54b2748cedc s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc(s, config);
}

}


