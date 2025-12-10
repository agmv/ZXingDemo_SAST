using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// OptionalMapConfigsRecord
public class RESTRC_d761bc5f1b0fe2debf1c3edffd0efd3c : AbstractRESTStructure<RC_d761bc5f1b0fe2debf1c3edffd0efd3c> {
[JsonProperty("OptionalMapConfigs")]
public ssZXingLibDemo.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure AttrOptionalMapConfigs;

public RESTRC_d761bc5f1b0fe2debf1c3edffd0efd3c() { }

public RESTRC_d761bc5f1b0fe2debf1c3edffd0efd3c (RC_d761bc5f1b0fe2debf1c3edffd0efd3c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalMapConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalMapConfigs, new ST_d609eacb476c603df8b92eb374da99faStructure(), ssZXingLibDemo.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure.FromStructureDelegate(config));
  } else {
AttrOptionalMapConfigs = ssZXingLibDemo.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure.FromStructure(s.ssSTOptionalMapConfigs, config);
  }
}

public static RC_d761bc5f1b0fe2debf1c3edffd0efd3c ToStructure(ssZXingLibDemo.RestRecords.RESTRC_d761bc5f1b0fe2debf1c3edffd0efd3c obj) { 
  RC_d761bc5f1b0fe2debf1c3edffd0efd3c s = new RC_d761bc5f1b0fe2debf1c3edffd0efd3c();
  if(obj != null) {
  s.ssSTOptionalMapConfigs = ssZXingLibDemo.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure.ToStructure(obj.AttrOptionalMapConfigs);
  }
  return s;
}

public static Func<RC_d761bc5f1b0fe2debf1c3edffd0efd3c, ssZXingLibDemo.RestRecords.RESTRC_d761bc5f1b0fe2debf1c3edffd0efd3c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d761bc5f1b0fe2debf1c3edffd0efd3c s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_d761bc5f1b0fe2debf1c3edffd0efd3c FromStructure(RC_d761bc5f1b0fe2debf1c3edffd0efd3c s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_d761bc5f1b0fe2debf1c3edffd0efd3c(s, config);
}

}


