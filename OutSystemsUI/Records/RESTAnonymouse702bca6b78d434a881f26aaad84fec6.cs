using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// GutterSizeRecord
public class RESTRC_a5018402fa6c90c5e826e54b2748cedc : AbstractRESTStructure<RC_a5018402fa6c90c5e826e54b2748cedc> {
[JsonProperty("GutterSize")]
public ssOutSystemsUI.RestRecords.RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord AttrGutterSize;

public RESTRC_a5018402fa6c90c5e826e54b2748cedc() { }

public RESTRC_a5018402fa6c90c5e826e54b2748cedc (RC_a5018402fa6c90c5e826e54b2748cedc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGutterSize = ConvertToRestWithoutDefaults(s.ssENGutterSize, new EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.FromStructureDelegate(config));
  } else {
AttrGutterSize = ssOutSystemsUI.RestRecords.RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.FromStructure(s.ssENGutterSize, config);
  }
}

public static RC_a5018402fa6c90c5e826e54b2748cedc ToStructure(ssOutSystemsUI.RestRecords.RESTRC_a5018402fa6c90c5e826e54b2748cedc obj) { 
  RC_a5018402fa6c90c5e826e54b2748cedc s = new RC_a5018402fa6c90c5e826e54b2748cedc();
  if(obj != null) {
  s.ssENGutterSize = ssOutSystemsUI.RestRecords.RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.ToStructure(obj.AttrGutterSize);
  }
  return s;
}

public static Func<RC_a5018402fa6c90c5e826e54b2748cedc, ssOutSystemsUI.RestRecords.RESTRC_a5018402fa6c90c5e826e54b2748cedc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a5018402fa6c90c5e826e54b2748cedc s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_a5018402fa6c90c5e826e54b2748cedc FromStructure(RC_a5018402fa6c90c5e826e54b2748cedc s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_a5018402fa6c90c5e826e54b2748cedc(s, config);
}

}


