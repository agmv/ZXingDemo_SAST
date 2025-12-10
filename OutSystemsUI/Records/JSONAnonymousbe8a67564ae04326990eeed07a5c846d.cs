using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RegisteredCallbackEventsRecord
public class JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f : AbstractRESTStructure<RC_b2eeb8f69cd26079c0c421f6fd8d6d1f> {
[JsonProperty("RegisteredCallbackEvents")]
[JsonPropertyName("RegisteredCallbackEvents")]
public ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord AttrRegisteredCallbackEvents;

public JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f() { }

public JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f (RC_b2eeb8f69cd26079c0c421f6fd8d6d1f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRegisteredCallbackEvents = ConvertToRestWithoutDefaults(s.ssENRegisteredCallbackEvents, new EN_df70a614ae02fde4029645a728b2909cEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord.FromStructureDelegate(config));
  } else {
AttrRegisteredCallbackEvents = ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord.FromStructure(s.ssENRegisteredCallbackEvents, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f, RC_b2eeb8f69cd26079c0c421f6fd8d6d1f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f s) => ToStructure(s, config);
}
public static RC_b2eeb8f69cd26079c0c421f6fd8d6d1f ToStructure(ssOutSystemsUI.RestRecords.JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f obj, IBehaviorsConfiguration config) { 
  RC_b2eeb8f69cd26079c0c421f6fd8d6d1f s = new RC_b2eeb8f69cd26079c0c421f6fd8d6d1f();
  if(obj != null) {
  s.ssENRegisteredCallbackEvents = ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord.ToStructure(obj.AttrRegisteredCallbackEvents, config);
  }
  return s;
}

public static Func<RC_b2eeb8f69cd26079c0c421f6fd8d6d1f, ssOutSystemsUI.RestRecords.JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b2eeb8f69cd26079c0c421f6fd8d6d1f s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f FromStructure(RC_b2eeb8f69cd26079c0c421f6fd8d6d1f s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_b2eeb8f69cd26079c0c421f6fd8d6d1f(s, config);
}

}


