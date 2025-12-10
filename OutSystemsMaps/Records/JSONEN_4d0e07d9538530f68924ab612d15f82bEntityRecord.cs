using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapErrors
public class JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord : AbstractRESTStructure<EN_4d0e07d9538530f68924ab612d15f82bEntityRecord> {
[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord() { }

public JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord (EN_4d0e07d9538530f68924ab612d15f82bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = s.ssCode;
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord, EN_4d0e07d9538530f68924ab612d15f82bEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord s) => ToStructure(s, config);
}
public static EN_4d0e07d9538530f68924ab612d15f82bEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_4d0e07d9538530f68924ab612d15f82bEntityRecord s = new EN_4d0e07d9538530f68924ab612d15f82bEntityRecord();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_4d0e07d9538530f68924ab612d15f82bEntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4d0e07d9538530f68924ab612d15f82bEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord FromStructure(EN_4d0e07d9538530f68924ab612d15f82bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord(s, config);
}

}


