using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselNavigation
public class RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord : AbstractRESTStructure<EN_59aacee1cb91627a0f497366b24e4500EntityRecord> {
[JsonProperty("Type")]
public string AttrType;

public RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord() { }

public RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord (EN_59aacee1cb91627a0f497366b24e4500EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
  } else {
AttrType = s.ssType;
  }
}

public static EN_59aacee1cb91627a0f497366b24e4500EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord obj) { 
  EN_59aacee1cb91627a0f497366b24e4500EntityRecord s = new EN_59aacee1cb91627a0f497366b24e4500EntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<EN_59aacee1cb91627a0f497366b24e4500EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_59aacee1cb91627a0f497366b24e4500EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord FromStructure(EN_59aacee1cb91627a0f497366b24e4500EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord(s, config);
}

}


