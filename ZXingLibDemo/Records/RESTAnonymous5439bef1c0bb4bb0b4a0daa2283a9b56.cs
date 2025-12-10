using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// ComposedNameRecord
public class RESTRC_957e93eddd28d08c07d4a328c870138a : AbstractRESTStructure<RC_957e93eddd28d08c07d4a328c870138a> {
[JsonProperty("ComposedName")]
public ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure AttrComposedName;

public RESTRC_957e93eddd28d08c07d4a328c870138a() { }

public RESTRC_957e93eddd28d08c07d4a328c870138a (RC_957e93eddd28d08c07d4a328c870138a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrComposedName = ConvertToRestWithoutDefaults(s.ssSTComposedName, new ST_2f980670f450ae43af56386ae46715c7Structure(), ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure.FromStructureDelegate(config));
  } else {
AttrComposedName = ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure.FromStructure(s.ssSTComposedName, config);
  }
}

public static RC_957e93eddd28d08c07d4a328c870138a ToStructure(ssZXingLibDemo.RestRecords.RESTRC_957e93eddd28d08c07d4a328c870138a obj) { 
  RC_957e93eddd28d08c07d4a328c870138a s = new RC_957e93eddd28d08c07d4a328c870138a();
  if(obj != null) {
  s.ssSTComposedName = ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure.ToStructure(obj.AttrComposedName);
  }
  return s;
}

public static Func<RC_957e93eddd28d08c07d4a328c870138a, ssZXingLibDemo.RestRecords.RESTRC_957e93eddd28d08c07d4a328c870138a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_957e93eddd28d08c07d4a328c870138a s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_957e93eddd28d08c07d4a328c870138a FromStructure(RC_957e93eddd28d08c07d4a328c870138a s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_957e93eddd28d08c07d4a328c870138a(s, config);
}

}


