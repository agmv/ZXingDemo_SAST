using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// FinishResetPasswordResult
public class JSONST_f49ebf7a28f80c1411af81f260f72632Structure : AbstractRESTStructure<ST_f49ebf7a28f80c1411af81f260f72632Structure> {
[JsonProperty("Success")]
[JsonPropertyName("Success")]
public bool? AttrSuccess;

[JsonProperty("FinishResetPasswordFailureReason")]
[JsonPropertyName("FinishResetPasswordFailureReason")]
public ssZXingLibDemo.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure AttrFinishResetPasswordFailureReason;

public JSONST_f49ebf7a28f80c1411af81f260f72632Structure() { }

public JSONST_f49ebf7a28f80c1411af81f260f72632Structure (ST_f49ebf7a28f80c1411af81f260f72632Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrFinishResetPasswordFailureReason = ConvertToRestWithoutDefaults(s.ssFinishResetPasswordFailureReason, new ST_9b153b9b179efd305d9e3eb52006065fStructure(), ssZXingLibDemo.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructureDelegate(config));
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrFinishResetPasswordFailureReason = ssZXingLibDemo.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructure(s.ssFinishResetPasswordFailureReason, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure, ST_f49ebf7a28f80c1411af81f260f72632Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure s) => ToStructure(s, config);
}
public static ST_f49ebf7a28f80c1411af81f260f72632Structure ToStructure(ssZXingLibDemo.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure obj, IBehaviorsConfiguration config) { 
  ST_f49ebf7a28f80c1411af81f260f72632Structure s = new ST_f49ebf7a28f80c1411af81f260f72632Structure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssFinishResetPasswordFailureReason = ssZXingLibDemo.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.ToStructure(obj.AttrFinishResetPasswordFailureReason, config);
  }
  return s;
}

public static Func<ST_f49ebf7a28f80c1411af81f260f72632Structure, ssZXingLibDemo.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f49ebf7a28f80c1411af81f260f72632Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure FromStructure(ST_f49ebf7a28f80c1411af81f260f72632Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure(s, config);
}

}


