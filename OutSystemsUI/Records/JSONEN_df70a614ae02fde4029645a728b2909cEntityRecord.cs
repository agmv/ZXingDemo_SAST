using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RegisteredCallbackEvents
public class JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord : AbstractRESTStructure<EN_df70a614ae02fde4029645a728b2909cEntityRecord> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord() { }

public JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord (EN_df70a614ae02fde4029645a728b2909cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = s.ssName;
  } else {
AttrName = s.ssName;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord, EN_df70a614ae02fde4029645a728b2909cEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord s) => ToStructure(s, config);
}
public static EN_df70a614ae02fde4029645a728b2909cEntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_df70a614ae02fde4029645a728b2909cEntityRecord s = new EN_df70a614ae02fde4029645a728b2909cEntityRecord();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<EN_df70a614ae02fde4029645a728b2909cEntityRecord, ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_df70a614ae02fde4029645a728b2909cEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord FromStructure(EN_df70a614ae02fde4029645a728b2909cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_df70a614ae02fde4029645a728b2909cEntityRecord(s, config);
}

}


