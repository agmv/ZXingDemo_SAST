using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DEPRECATED_Color
public class RESTEN_d383eada98ae47b51248dfe934bb4fabEntityRecord : AbstractRESTStructure<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord> {
[JsonProperty("Color")]
public string AttrColor;

public RESTEN_d383eada98ae47b51248dfe934bb4fabEntityRecord() { }

public RESTEN_d383eada98ae47b51248dfe934bb4fabEntityRecord (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = s.ssColor;
  } else {
AttrColor = s.ssColor;
  }
}

public static EN_d383eada98ae47b51248dfe934bb4fabEntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_d383eada98ae47b51248dfe934bb4fabEntityRecord obj) { 
  EN_d383eada98ae47b51248dfe934bb4fabEntityRecord s = new EN_d383eada98ae47b51248dfe934bb4fabEntityRecord();
  if(obj != null) {
  s.ssColor = obj.AttrColor == null ? "" : obj.AttrColor;
  }
  return s;
}

public static Func<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord, ssOutSystemsUI.RestRecords.RESTEN_d383eada98ae47b51248dfe934bb4fabEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_d383eada98ae47b51248dfe934bb4fabEntityRecord FromStructure(EN_d383eada98ae47b51248dfe934bb4fabEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_d383eada98ae47b51248dfe934bb4fabEntityRecord(s, config);
}

}


