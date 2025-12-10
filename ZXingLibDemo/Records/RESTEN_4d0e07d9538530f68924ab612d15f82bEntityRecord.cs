using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// MapErrors
public class RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord : AbstractRESTStructure<EN_4d0e07d9538530f68924ab612d15f82bEntityRecord> {
[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

public RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord() { }

public RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord (EN_4d0e07d9538530f68924ab612d15f82bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = s.ssCode;
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static EN_4d0e07d9538530f68924ab612d15f82bEntityRecord ToStructure(ssZXingLibDemo.RestRecords.RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord obj) { 
  EN_4d0e07d9538530f68924ab612d15f82bEntityRecord s = new EN_4d0e07d9538530f68924ab612d15f82bEntityRecord();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_4d0e07d9538530f68924ab612d15f82bEntityRecord, ssZXingLibDemo.RestRecords.RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4d0e07d9538530f68924ab612d15f82bEntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord FromStructure(EN_4d0e07d9538530f68924ab612d15f82bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord(s, config);
}

}


