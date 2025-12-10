using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ReturnMessageRecord
public class RESTRC_7511ee1a86159a139a2f21acdabfee5b : AbstractRESTStructure<RC_7511ee1a86159a139a2f21acdabfee5b> {
[JsonProperty("ReturnMessage")]
public ssOutSystemsMaps.RestRecords.RESTST_cdd94bc434e873b4d04598ac1e187543Structure AttrReturnMessage;

public RESTRC_7511ee1a86159a139a2f21acdabfee5b() { }

public RESTRC_7511ee1a86159a139a2f21acdabfee5b (RC_7511ee1a86159a139a2f21acdabfee5b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReturnMessage = ConvertToRestWithoutDefaults(s.ssSTReturnMessage, new ST_cdd94bc434e873b4d04598ac1e187543Structure(), ssOutSystemsMaps.RestRecords.RESTST_cdd94bc434e873b4d04598ac1e187543Structure.FromStructureDelegate(config));
  } else {
AttrReturnMessage = ssOutSystemsMaps.RestRecords.RESTST_cdd94bc434e873b4d04598ac1e187543Structure.FromStructure(s.ssSTReturnMessage, config);
  }
}

public static RC_7511ee1a86159a139a2f21acdabfee5b ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_7511ee1a86159a139a2f21acdabfee5b obj) { 
  RC_7511ee1a86159a139a2f21acdabfee5b s = new RC_7511ee1a86159a139a2f21acdabfee5b();
  if(obj != null) {
  s.ssSTReturnMessage = ssOutSystemsMaps.RestRecords.RESTST_cdd94bc434e873b4d04598ac1e187543Structure.ToStructure(obj.AttrReturnMessage);
  }
  return s;
}

public static Func<RC_7511ee1a86159a139a2f21acdabfee5b, ssOutSystemsMaps.RestRecords.RESTRC_7511ee1a86159a139a2f21acdabfee5b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7511ee1a86159a139a2f21acdabfee5b s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_7511ee1a86159a139a2f21acdabfee5b FromStructure(RC_7511ee1a86159a139a2f21acdabfee5b s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_7511ee1a86159a139a2f21acdabfee5b(s, config);
}

}


