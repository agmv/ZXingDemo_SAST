using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownTagsOptionalConfigsRecord
public class JSONRC_4d01ba747615bc6dc01c586f0b43450a : AbstractRESTStructure<RC_4d01ba747615bc6dc01c586f0b43450a> {
[JsonProperty("DropdownTagsOptionalConfigs")]
[JsonPropertyName("DropdownTagsOptionalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure AttrDropdownTagsOptionalConfigs;

public JSONRC_4d01ba747615bc6dc01c586f0b43450a() { }

public JSONRC_4d01ba747615bc6dc01c586f0b43450a (RC_4d01ba747615bc6dc01c586f0b43450a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownTagsOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownTagsOptionalConfigs, new ST_34444d0742578c128ebc8b2594439346Structure(), ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure.FromStructureDelegate(config));
  } else {
AttrDropdownTagsOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure.FromStructure(s.ssSTDropdownTagsOptionalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_4d01ba747615bc6dc01c586f0b43450a, RC_4d01ba747615bc6dc01c586f0b43450a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_4d01ba747615bc6dc01c586f0b43450a s) => ToStructure(s, config);
}
public static RC_4d01ba747615bc6dc01c586f0b43450a ToStructure(ssOutSystemsUI.RestRecords.JSONRC_4d01ba747615bc6dc01c586f0b43450a obj, IBehaviorsConfiguration config) { 
  RC_4d01ba747615bc6dc01c586f0b43450a s = new RC_4d01ba747615bc6dc01c586f0b43450a();
  if(obj != null) {
  s.ssSTDropdownTagsOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure.ToStructure(obj.AttrDropdownTagsOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_4d01ba747615bc6dc01c586f0b43450a, ssOutSystemsUI.RestRecords.JSONRC_4d01ba747615bc6dc01c586f0b43450a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4d01ba747615bc6dc01c586f0b43450a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_4d01ba747615bc6dc01c586f0b43450a FromStructure(RC_4d01ba747615bc6dc01c586f0b43450a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_4d01ba747615bc6dc01c586f0b43450a(s, config);
}

}


