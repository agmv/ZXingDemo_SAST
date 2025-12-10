using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselNavigation
public class JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord : AbstractRESTStructure<EN_59aacee1cb91627a0f497366b24e4500EntityRecord> {
[JsonProperty("Type")]
[JsonPropertyName("Type")]
public string AttrType;

public JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord() { }

public JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord (EN_59aacee1cb91627a0f497366b24e4500EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
  } else {
AttrType = s.ssType;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord, EN_59aacee1cb91627a0f497366b24e4500EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord s) => ToStructure(s, config);
}
public static EN_59aacee1cb91627a0f497366b24e4500EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_59aacee1cb91627a0f497366b24e4500EntityRecord s = new EN_59aacee1cb91627a0f497366b24e4500EntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<EN_59aacee1cb91627a0f497366b24e4500EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_59aacee1cb91627a0f497366b24e4500EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord FromStructure(EN_59aacee1cb91627a0f497366b24e4500EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_59aacee1cb91627a0f497366b24e4500EntityRecord(s, config);
}

}


