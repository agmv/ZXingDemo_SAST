using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIRoleRecord
public class JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 : AbstractRESTStructure<RC_ed6dfadde1ed7fb74003b4bf09b19473> {
[JsonProperty("AIRole")]
[JsonPropertyName("AIRole")]
public ssZXingLibDemo.RestRecords.JSONENAIRoleEntityRecord AttrAIRole;

public JSONRC_ed6dfadde1ed7fb74003b4bf09b19473() { }

public JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 (RC_ed6dfadde1ed7fb74003b4bf09b19473 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIRole = ConvertToRestWithoutDefaults(s.ssENAIRole, new ENAIRoleEntityRecord(), ssZXingLibDemo.RestRecords.JSONENAIRoleEntityRecord.FromStructureDelegate(config));
  } else {
AttrAIRole = ssZXingLibDemo.RestRecords.JSONENAIRoleEntityRecord.FromStructure(s.ssENAIRole, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473, RC_ed6dfadde1ed7fb74003b4bf09b19473> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 s) => ToStructure(s, config);
}
public static RC_ed6dfadde1ed7fb74003b4bf09b19473 ToStructure(ssZXingLibDemo.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 obj, IBehaviorsConfiguration config) { 
  RC_ed6dfadde1ed7fb74003b4bf09b19473 s = new RC_ed6dfadde1ed7fb74003b4bf09b19473();
  if(obj != null) {
  s.ssENAIRole = ssZXingLibDemo.RestRecords.JSONENAIRoleEntityRecord.ToStructure(obj.AttrAIRole, config);
  }
  return s;
}

public static Func<RC_ed6dfadde1ed7fb74003b4bf09b19473, ssZXingLibDemo.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ed6dfadde1ed7fb74003b4bf09b19473 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 FromStructure(RC_ed6dfadde1ed7fb74003b4bf09b19473 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473(s, config);
}

}


