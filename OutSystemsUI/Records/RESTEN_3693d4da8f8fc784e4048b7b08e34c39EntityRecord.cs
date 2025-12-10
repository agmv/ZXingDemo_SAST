using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselProvider
public class RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord : AbstractRESTStructure<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> {
[JsonProperty("Provider")]
public string AttrProvider;

public RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord() { }

public RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProvider = s.ssProvider;
  } else {
AttrProvider = s.ssProvider;
  }
}

public static EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord obj) { 
  EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s = new EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord();
  if(obj != null) {
  s.ssProvider = obj.AttrProvider == null ? "" : obj.AttrProvider;
  }
  return s;
}

public static Func<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord FromStructure(EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord(s, config);
}

}


