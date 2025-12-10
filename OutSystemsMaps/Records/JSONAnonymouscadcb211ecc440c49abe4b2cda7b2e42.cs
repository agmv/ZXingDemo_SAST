using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ReturnMessageRecord
public class JSONRC_7511ee1a86159a139a2f21acdabfee5b : AbstractRESTStructure<RC_7511ee1a86159a139a2f21acdabfee5b> {
[JsonProperty("ReturnMessage")]
[JsonPropertyName("ReturnMessage")]
public ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure AttrReturnMessage;

public JSONRC_7511ee1a86159a139a2f21acdabfee5b() { }

public JSONRC_7511ee1a86159a139a2f21acdabfee5b (RC_7511ee1a86159a139a2f21acdabfee5b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReturnMessage = ConvertToRestWithoutDefaults(s.ssSTReturnMessage, new ST_cdd94bc434e873b4d04598ac1e187543Structure(), ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure.FromStructureDelegate(config));
  } else {
AttrReturnMessage = ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure.FromStructure(s.ssSTReturnMessage, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_7511ee1a86159a139a2f21acdabfee5b, RC_7511ee1a86159a139a2f21acdabfee5b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_7511ee1a86159a139a2f21acdabfee5b s) => ToStructure(s, config);
}
public static RC_7511ee1a86159a139a2f21acdabfee5b ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_7511ee1a86159a139a2f21acdabfee5b obj, IBehaviorsConfiguration config) { 
  RC_7511ee1a86159a139a2f21acdabfee5b s = new RC_7511ee1a86159a139a2f21acdabfee5b();
  if(obj != null) {
  s.ssSTReturnMessage = ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure.ToStructure(obj.AttrReturnMessage, config);
  }
  return s;
}

public static Func<RC_7511ee1a86159a139a2f21acdabfee5b, ssOutSystemsMaps.RestRecords.JSONRC_7511ee1a86159a139a2f21acdabfee5b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7511ee1a86159a139a2f21acdabfee5b s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_7511ee1a86159a139a2f21acdabfee5b FromStructure(RC_7511ee1a86159a139a2f21acdabfee5b s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_7511ee1a86159a139a2f21acdabfee5b(s, config);
}

}


