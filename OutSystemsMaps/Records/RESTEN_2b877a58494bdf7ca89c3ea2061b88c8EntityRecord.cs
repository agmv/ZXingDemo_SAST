using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapEventTriggered
public class RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord : AbstractRESTStructure<EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord() { }

public RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord (EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord obj) { 
  EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s = new EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord FromStructure(EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord(s, config);
}

}


