using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// DirectionRecord
public class JSONRC_070998dc6b3dc951b52d8108550fe380 : AbstractRESTStructure<RC_070998dc6b3dc951b52d8108550fe380> {
[JsonProperty("Direction")]
[JsonPropertyName("Direction")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord AttrDirection;

public JSONRC_070998dc6b3dc951b52d8108550fe380() { }

public JSONRC_070998dc6b3dc951b52d8108550fe380 (RC_070998dc6b3dc951b52d8108550fe380 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirection = ConvertToRestWithoutDefaults(s.ssENDirection, new EN_50814454e481dd1773c2250bc248da5eEntityRecord(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord.FromStructureDelegate(config));
  } else {
AttrDirection = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord.FromStructure(s.ssENDirection, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380, RC_070998dc6b3dc951b52d8108550fe380> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380 s) => ToStructure(s, config);
}
public static RC_070998dc6b3dc951b52d8108550fe380 ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380 obj, IBehaviorsConfiguration config) { 
  RC_070998dc6b3dc951b52d8108550fe380 s = new RC_070998dc6b3dc951b52d8108550fe380();
  if(obj != null) {
  s.ssENDirection = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord.ToStructure(obj.AttrDirection, config);
  }
  return s;
}

public static Func<RC_070998dc6b3dc951b52d8108550fe380, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_070998dc6b3dc951b52d8108550fe380 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380 FromStructure(RC_070998dc6b3dc951b52d8108550fe380 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380(s, config);
}

}


