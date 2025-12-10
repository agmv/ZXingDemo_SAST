using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSliderType
public class RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord : AbstractRESTStructure<EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord> {
[JsonProperty("Mode")]
public string AttrMode;

public RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord() { }

public RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord (EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMode = s.ssMode;
  } else {
AttrMode = s.ssMode;
  }
}

public static EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord obj) { 
  EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord s = new EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord();
  if(obj != null) {
  s.ssMode = obj.AttrMode == null ? "" : obj.AttrMode;
  }
  return s;
}

public static Func<EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord FromStructure(EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord(s, config);
}

}


