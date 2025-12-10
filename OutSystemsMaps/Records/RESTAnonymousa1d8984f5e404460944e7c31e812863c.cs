using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalCircleConfigsRecord
public class RESTRC_ba003b5de3d2da83898f81e428002fdb : AbstractRESTStructure<RC_ba003b5de3d2da83898f81e428002fdb> {
[JsonProperty("OptionalCircleConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_9a87c036f8540c84242b92bb54609014Structure AttrOptionalCircleConfigs;

public RESTRC_ba003b5de3d2da83898f81e428002fdb() { }

public RESTRC_ba003b5de3d2da83898f81e428002fdb (RC_ba003b5de3d2da83898f81e428002fdb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalCircleConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalCircleConfigs, new ST_9a87c036f8540c84242b92bb54609014Structure(), ssOutSystemsMaps.RestRecords.RESTST_9a87c036f8540c84242b92bb54609014Structure.FromStructureDelegate(config));
  } else {
AttrOptionalCircleConfigs = ssOutSystemsMaps.RestRecords.RESTST_9a87c036f8540c84242b92bb54609014Structure.FromStructure(s.ssSTOptionalCircleConfigs, config);
  }
}

public static RC_ba003b5de3d2da83898f81e428002fdb ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_ba003b5de3d2da83898f81e428002fdb obj) { 
  RC_ba003b5de3d2da83898f81e428002fdb s = new RC_ba003b5de3d2da83898f81e428002fdb();
  if(obj != null) {
  s.ssSTOptionalCircleConfigs = ssOutSystemsMaps.RestRecords.RESTST_9a87c036f8540c84242b92bb54609014Structure.ToStructure(obj.AttrOptionalCircleConfigs);
  }
  return s;
}

public static Func<RC_ba003b5de3d2da83898f81e428002fdb, ssOutSystemsMaps.RestRecords.RESTRC_ba003b5de3d2da83898f81e428002fdb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ba003b5de3d2da83898f81e428002fdb s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_ba003b5de3d2da83898f81e428002fdb FromStructure(RC_ba003b5de3d2da83898f81e428002fdb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_ba003b5de3d2da83898f81e428002fdb(s, config);
}

}


