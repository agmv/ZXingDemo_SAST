using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RegisteredCallbackEvents
public class RESTEN_df70a614ae02fde4029645a728b2909cEntityRecord : AbstractRESTStructure<EN_df70a614ae02fde4029645a728b2909cEntityRecord> {
[JsonProperty("Name")]
public string AttrName;

public RESTEN_df70a614ae02fde4029645a728b2909cEntityRecord() { }

public RESTEN_df70a614ae02fde4029645a728b2909cEntityRecord (EN_df70a614ae02fde4029645a728b2909cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = s.ssName;
  } else {
AttrName = s.ssName;
  }
}

public static EN_df70a614ae02fde4029645a728b2909cEntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_df70a614ae02fde4029645a728b2909cEntityRecord obj) { 
  EN_df70a614ae02fde4029645a728b2909cEntityRecord s = new EN_df70a614ae02fde4029645a728b2909cEntityRecord();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<EN_df70a614ae02fde4029645a728b2909cEntityRecord, ssOutSystemsUI.RestRecords.RESTEN_df70a614ae02fde4029645a728b2909cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_df70a614ae02fde4029645a728b2909cEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_df70a614ae02fde4029645a728b2909cEntityRecord FromStructure(EN_df70a614ae02fde4029645a728b2909cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_df70a614ae02fde4029645a728b2909cEntityRecord(s, config);
}

}


