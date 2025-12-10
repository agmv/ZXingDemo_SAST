using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DEPRECATED_Color
public class JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord : AbstractRESTStructure<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord> {
[JsonProperty("Color")]
[JsonPropertyName("Color")]
public string AttrColor;

public JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord() { }

public JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = s.ssColor;
  } else {
AttrColor = s.ssColor;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord, EN_d383eada98ae47b51248dfe934bb4fabEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord s) => ToStructure(s, config);
}
public static EN_d383eada98ae47b51248dfe934bb4fabEntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d383eada98ae47b51248dfe934bb4fabEntityRecord s = new EN_d383eada98ae47b51248dfe934bb4fabEntityRecord();
  if(obj != null) {
  s.ssColor = obj.AttrColor == null ? "" : obj.AttrColor;
  }
  return s;
}

public static Func<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord, ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord FromStructure(EN_d383eada98ae47b51248dfe934bb4fabEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord(s, config);
}

}


