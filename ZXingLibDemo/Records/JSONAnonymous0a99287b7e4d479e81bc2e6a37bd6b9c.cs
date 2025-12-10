using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// MapErrorsRecord
public class JSONRC_3d151c63adf137bd3c85eaa462bbbe0c : AbstractRESTStructure<RC_3d151c63adf137bd3c85eaa462bbbe0c> {
[JsonProperty("MapErrors")]
[JsonPropertyName("MapErrors")]
public ssZXingLibDemo.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord AttrMapErrors;

public JSONRC_3d151c63adf137bd3c85eaa462bbbe0c() { }

public JSONRC_3d151c63adf137bd3c85eaa462bbbe0c (RC_3d151c63adf137bd3c85eaa462bbbe0c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMapErrors = ConvertToRestWithoutDefaults(s.ssENMapErrors, new EN_4d0e07d9538530f68924ab612d15f82bEntityRecord(), ssZXingLibDemo.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord.FromStructureDelegate(config));
  } else {
AttrMapErrors = ssZXingLibDemo.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord.FromStructure(s.ssENMapErrors, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_3d151c63adf137bd3c85eaa462bbbe0c, RC_3d151c63adf137bd3c85eaa462bbbe0c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_3d151c63adf137bd3c85eaa462bbbe0c s) => ToStructure(s, config);
}
public static RC_3d151c63adf137bd3c85eaa462bbbe0c ToStructure(ssZXingLibDemo.RestRecords.JSONRC_3d151c63adf137bd3c85eaa462bbbe0c obj, IBehaviorsConfiguration config) { 
  RC_3d151c63adf137bd3c85eaa462bbbe0c s = new RC_3d151c63adf137bd3c85eaa462bbbe0c();
  if(obj != null) {
  s.ssENMapErrors = ssZXingLibDemo.RestRecords.JSONEN_4d0e07d9538530f68924ab612d15f82bEntityRecord.ToStructure(obj.AttrMapErrors, config);
  }
  return s;
}

public static Func<RC_3d151c63adf137bd3c85eaa462bbbe0c, ssZXingLibDemo.RestRecords.JSONRC_3d151c63adf137bd3c85eaa462bbbe0c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3d151c63adf137bd3c85eaa462bbbe0c s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_3d151c63adf137bd3c85eaa462bbbe0c FromStructure(RC_3d151c63adf137bd3c85eaa462bbbe0c s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_3d151c63adf137bd3c85eaa462bbbe0c(s, config);
}

}


