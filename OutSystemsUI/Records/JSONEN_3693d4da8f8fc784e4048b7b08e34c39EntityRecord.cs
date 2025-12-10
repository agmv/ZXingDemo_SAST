using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselProvider
public class JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord : AbstractRESTStructure<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> {
[JsonProperty("Provider")]
[JsonPropertyName("Provider")]
public string AttrProvider;

public JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord() { }

public JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProvider = s.ssProvider;
  } else {
AttrProvider = s.ssProvider;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord, EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s) => ToStructure(s, config);
}
public static EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s = new EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord();
  if(obj != null) {
  s.ssProvider = obj.AttrProvider == null ? "" : obj.AttrProvider;
  }
  return s;
}

public static Func<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord FromStructure(EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord(s, config);
}

}


