using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIContentTypeRecord
public class JSONRC_331ddee75740189a809db62f762472bd : AbstractRESTStructure<RC_331ddee75740189a809db62f762472bd> {
[JsonProperty("AIContentType")]
[JsonPropertyName("AIContentType")]
public ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord AttrAIContentType;

public JSONRC_331ddee75740189a809db62f762472bd() { }

public JSONRC_331ddee75740189a809db62f762472bd (RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIContentType = ConvertToRestWithoutDefaults(s.ssENAIContentType, new ENAIContentTypeEntityRecord(), ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord.FromStructureDelegate(config));
  } else {
AttrAIContentType = ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord.FromStructure(s.ssENAIContentType, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_331ddee75740189a809db62f762472bd, RC_331ddee75740189a809db62f762472bd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_331ddee75740189a809db62f762472bd s) => ToStructure(s, config);
}
public static RC_331ddee75740189a809db62f762472bd ToStructure(ssZXingLibDemo.RestRecords.JSONRC_331ddee75740189a809db62f762472bd obj, IBehaviorsConfiguration config) { 
  RC_331ddee75740189a809db62f762472bd s = new RC_331ddee75740189a809db62f762472bd();
  if(obj != null) {
  s.ssENAIContentType = ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord.ToStructure(obj.AttrAIContentType, config);
  }
  return s;
}

public static Func<RC_331ddee75740189a809db62f762472bd, ssZXingLibDemo.RestRecords.JSONRC_331ddee75740189a809db62f762472bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_331ddee75740189a809db62f762472bd s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_331ddee75740189a809db62f762472bd FromStructure(RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_331ddee75740189a809db62f762472bd(s, config);
}

}


