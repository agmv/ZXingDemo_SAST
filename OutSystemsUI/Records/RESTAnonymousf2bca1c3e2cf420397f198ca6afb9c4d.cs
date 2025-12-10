using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownTagsOptionalConfigsRecord
public class RESTRC_4d01ba747615bc6dc01c586f0b43450a : AbstractRESTStructure<RC_4d01ba747615bc6dc01c586f0b43450a> {
[JsonProperty("DropdownTagsOptionalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_34444d0742578c128ebc8b2594439346Structure AttrDropdownTagsOptionalConfigs;

public RESTRC_4d01ba747615bc6dc01c586f0b43450a() { }

public RESTRC_4d01ba747615bc6dc01c586f0b43450a (RC_4d01ba747615bc6dc01c586f0b43450a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownTagsOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownTagsOptionalConfigs, new ST_34444d0742578c128ebc8b2594439346Structure(), ssOutSystemsUI.RestRecords.RESTST_34444d0742578c128ebc8b2594439346Structure.FromStructureDelegate(config));
  } else {
AttrDropdownTagsOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_34444d0742578c128ebc8b2594439346Structure.FromStructure(s.ssSTDropdownTagsOptionalConfigs, config);
  }
}

public static RC_4d01ba747615bc6dc01c586f0b43450a ToStructure(ssOutSystemsUI.RestRecords.RESTRC_4d01ba747615bc6dc01c586f0b43450a obj) { 
  RC_4d01ba747615bc6dc01c586f0b43450a s = new RC_4d01ba747615bc6dc01c586f0b43450a();
  if(obj != null) {
  s.ssSTDropdownTagsOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_34444d0742578c128ebc8b2594439346Structure.ToStructure(obj.AttrDropdownTagsOptionalConfigs);
  }
  return s;
}

public static Func<RC_4d01ba747615bc6dc01c586f0b43450a, ssOutSystemsUI.RestRecords.RESTRC_4d01ba747615bc6dc01c586f0b43450a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4d01ba747615bc6dc01c586f0b43450a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_4d01ba747615bc6dc01c586f0b43450a FromStructure(RC_4d01ba747615bc6dc01c586f0b43450a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_4d01ba747615bc6dc01c586f0b43450a(s, config);
}

}


