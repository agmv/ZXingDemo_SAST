using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerEventTriggeredRecord
public class RESTRC_d18425d8035234c443ecbdefa0da8210 : AbstractRESTStructure<RC_d18425d8035234c443ecbdefa0da8210> {
[JsonProperty("MarkerEventTriggered")]
public ssOutSystemsMaps.RestRecords.RESTEN_d9c97e718205f8627d74b06df54e3543EntityRecord AttrMarkerEventTriggered;

public RESTRC_d18425d8035234c443ecbdefa0da8210() { }

public RESTRC_d18425d8035234c443ecbdefa0da8210 (RC_d18425d8035234c443ecbdefa0da8210 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarkerEventTriggered = ConvertToRestWithoutDefaults(s.ssENMarkerEventTriggered, new EN_d9c97e718205f8627d74b06df54e3543EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_d9c97e718205f8627d74b06df54e3543EntityRecord.FromStructureDelegate(config));
  } else {
AttrMarkerEventTriggered = ssOutSystemsMaps.RestRecords.RESTEN_d9c97e718205f8627d74b06df54e3543EntityRecord.FromStructure(s.ssENMarkerEventTriggered, config);
  }
}

public static RC_d18425d8035234c443ecbdefa0da8210 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_d18425d8035234c443ecbdefa0da8210 obj) { 
  RC_d18425d8035234c443ecbdefa0da8210 s = new RC_d18425d8035234c443ecbdefa0da8210();
  if(obj != null) {
  s.ssENMarkerEventTriggered = ssOutSystemsMaps.RestRecords.RESTEN_d9c97e718205f8627d74b06df54e3543EntityRecord.ToStructure(obj.AttrMarkerEventTriggered);
  }
  return s;
}

public static Func<RC_d18425d8035234c443ecbdefa0da8210, ssOutSystemsMaps.RestRecords.RESTRC_d18425d8035234c443ecbdefa0da8210> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d18425d8035234c443ecbdefa0da8210 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_d18425d8035234c443ecbdefa0da8210 FromStructure(RC_d18425d8035234c443ecbdefa0da8210 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_d18425d8035234c443ecbdefa0da8210(s, config);
}

}


