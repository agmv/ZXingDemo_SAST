using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_drawingTools_configs
public class RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure : AbstractRESTStructure<ST_3f16cd459ccd861deffd4483bc1bbac3Structure> {
[JsonProperty("position")]
public string Attrposition;

public RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure() { }

public RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure (ST_3f16cd459ccd861deffd4483bc1bbac3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrposition = ConvertToRestWithoutDefaults(s.ssposition, (ENDrawingToolsPositionEntity.GetRecordByKey(ObjectKey.Parse("jXpYIpUqhU62k_i9ABfxVQ"))).ssId);
  } else {
Attrposition = s.ssposition;
  }
}

public static ST_3f16cd459ccd861deffd4483bc1bbac3Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure obj) { 
  ST_3f16cd459ccd861deffd4483bc1bbac3Structure s = new ST_3f16cd459ccd861deffd4483bc1bbac3Structure();
  if(obj != null) {
  s.ssposition = obj.Attrposition == null ? (ENDrawingToolsPositionEntity.GetRecordByKey(ObjectKey.Parse("jXpYIpUqhU62k_i9ABfxVQ"))).ssId : obj.Attrposition;
  }
  return s;
}

public static Func<ST_3f16cd459ccd861deffd4483bc1bbac3Structure, ssOutSystemsMaps.RestRecords.RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3f16cd459ccd861deffd4483bc1bbac3Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure FromStructure(ST_3f16cd459ccd861deffd4483bc1bbac3Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure(s, config);
}

}


