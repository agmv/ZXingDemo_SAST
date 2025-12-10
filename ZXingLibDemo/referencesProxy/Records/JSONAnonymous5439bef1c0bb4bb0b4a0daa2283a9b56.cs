using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// ComposedNameRecord
public class JSONRC_957e93eddd28d08c07d4a328c870138a : AbstractRESTStructure<RC_957e93eddd28d08c07d4a328c870138a> {
[JsonProperty("ComposedName")]
[JsonPropertyName("ComposedName")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure AttrComposedName;

public JSONRC_957e93eddd28d08c07d4a328c870138a() { }

public JSONRC_957e93eddd28d08c07d4a328c870138a (RC_957e93eddd28d08c07d4a328c870138a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrComposedName = ConvertToRestWithoutDefaults(s.ssSTComposedName, new ST_2f980670f450ae43af56386ae46715c7Structure(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure.FromStructureDelegate(config));
  } else {
AttrComposedName = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure.FromStructure(s.ssSTComposedName, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_957e93eddd28d08c07d4a328c870138a, RC_957e93eddd28d08c07d4a328c870138a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_957e93eddd28d08c07d4a328c870138a s) => ToStructure(s, config);
}
public static RC_957e93eddd28d08c07d4a328c870138a ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_957e93eddd28d08c07d4a328c870138a obj, IBehaviorsConfiguration config) { 
  RC_957e93eddd28d08c07d4a328c870138a s = new RC_957e93eddd28d08c07d4a328c870138a();
  if(obj != null) {
  s.ssSTComposedName = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure.ToStructure(obj.AttrComposedName, config);
  }
  return s;
}

public static Func<RC_957e93eddd28d08c07d4a328c870138a, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_957e93eddd28d08c07d4a328c870138a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_957e93eddd28d08c07d4a328c870138a s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_957e93eddd28d08c07d4a328c870138a FromStructure(RC_957e93eddd28d08c07d4a328c870138a s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_957e93eddd28d08c07d4a328c870138a(s, config);
}

}


