using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// BottomSheet_InternalConfigRecord
public class JSONRC_a2f63a3e27000ea7c800cf727f8ecfba : AbstractRESTStructure<RC_a2f63a3e27000ea7c800cf727f8ecfba> {
[JsonProperty("BottomSheet_InternalConfig")]
[JsonPropertyName("BottomSheet_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_106b6e385f5e89b0a7d76e23b14f61a0Structure AttrBottomSheet_InternalConfig;

public JSONRC_a2f63a3e27000ea7c800cf727f8ecfba() { }

public JSONRC_a2f63a3e27000ea7c800cf727f8ecfba (RC_a2f63a3e27000ea7c800cf727f8ecfba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBottomSheet_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTBottomSheet_InternalConfig, new ST_106b6e385f5e89b0a7d76e23b14f61a0Structure(), ssOutSystemsUI.RestRecords.JSONST_106b6e385f5e89b0a7d76e23b14f61a0Structure.FromStructureDelegate(config));
  } else {
AttrBottomSheet_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_106b6e385f5e89b0a7d76e23b14f61a0Structure.FromStructure(s.ssSTBottomSheet_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_a2f63a3e27000ea7c800cf727f8ecfba, RC_a2f63a3e27000ea7c800cf727f8ecfba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_a2f63a3e27000ea7c800cf727f8ecfba s) => ToStructure(s, config);
}
public static RC_a2f63a3e27000ea7c800cf727f8ecfba ToStructure(ssOutSystemsUI.RestRecords.JSONRC_a2f63a3e27000ea7c800cf727f8ecfba obj, IBehaviorsConfiguration config) { 
  RC_a2f63a3e27000ea7c800cf727f8ecfba s = new RC_a2f63a3e27000ea7c800cf727f8ecfba();
  if(obj != null) {
  s.ssSTBottomSheet_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_106b6e385f5e89b0a7d76e23b14f61a0Structure.ToStructure(obj.AttrBottomSheet_InternalConfig, config);
  }
  return s;
}

public static Func<RC_a2f63a3e27000ea7c800cf727f8ecfba, ssOutSystemsUI.RestRecords.JSONRC_a2f63a3e27000ea7c800cf727f8ecfba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a2f63a3e27000ea7c800cf727f8ecfba s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_a2f63a3e27000ea7c800cf727f8ecfba FromStructure(RC_a2f63a3e27000ea7c800cf727f8ecfba s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_a2f63a3e27000ea7c800cf727f8ecfba(s, config);
}

}


