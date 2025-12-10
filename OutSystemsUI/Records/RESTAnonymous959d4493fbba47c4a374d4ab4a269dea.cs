using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// PositionRecord
public class RESTRC_5f28219a5e30fb90023fcbc295513e7c : AbstractRESTStructure<RC_5f28219a5e30fb90023fcbc295513e7c> {
[JsonProperty("Position")]
public ssOutSystemsUI.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord AttrPosition;

public RESTRC_5f28219a5e30fb90023fcbc295513e7c() { }

public RESTRC_5f28219a5e30fb90023fcbc295513e7c (RC_5f28219a5e30fb90023fcbc295513e7c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = ConvertToRestWithoutDefaults(s.ssENPosition, new EN_5d1279724e719322292e34ef3c5500a0EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.FromStructureDelegate(config));
  } else {
AttrPosition = ssOutSystemsUI.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.FromStructure(s.ssENPosition, config);
  }
}

public static RC_5f28219a5e30fb90023fcbc295513e7c ToStructure(ssOutSystemsUI.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c obj) { 
  RC_5f28219a5e30fb90023fcbc295513e7c s = new RC_5f28219a5e30fb90023fcbc295513e7c();
  if(obj != null) {
  s.ssENPosition = ssOutSystemsUI.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.ToStructure(obj.AttrPosition);
  }
  return s;
}

public static Func<RC_5f28219a5e30fb90023fcbc295513e7c, ssOutSystemsUI.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5f28219a5e30fb90023fcbc295513e7c s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c FromStructure(RC_5f28219a5e30fb90023fcbc295513e7c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c(s, config);
}

}


