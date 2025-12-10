using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// InlineSVG_InternalConfigRecord
public class JSONRC_7c416001ce979a5857a1237e54d11a88 : AbstractRESTStructure<RC_7c416001ce979a5857a1237e54d11a88> {
[JsonProperty("InlineSVG_InternalConfig")]
[JsonPropertyName("InlineSVG_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure AttrInlineSVG_InternalConfig;

public JSONRC_7c416001ce979a5857a1237e54d11a88() { }

public JSONRC_7c416001ce979a5857a1237e54d11a88 (RC_7c416001ce979a5857a1237e54d11a88 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInlineSVG_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTInlineSVG_InternalConfig, new ST_bc9955d62033e77475d9540bd4940593Structure(), ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure.FromStructureDelegate(config));
  } else {
AttrInlineSVG_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure.FromStructure(s.ssSTInlineSVG_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_7c416001ce979a5857a1237e54d11a88, RC_7c416001ce979a5857a1237e54d11a88> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_7c416001ce979a5857a1237e54d11a88 s) => ToStructure(s, config);
}
public static RC_7c416001ce979a5857a1237e54d11a88 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_7c416001ce979a5857a1237e54d11a88 obj, IBehaviorsConfiguration config) { 
  RC_7c416001ce979a5857a1237e54d11a88 s = new RC_7c416001ce979a5857a1237e54d11a88();
  if(obj != null) {
  s.ssSTInlineSVG_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure.ToStructure(obj.AttrInlineSVG_InternalConfig, config);
  }
  return s;
}

public static Func<RC_7c416001ce979a5857a1237e54d11a88, ssOutSystemsUI.RestRecords.JSONRC_7c416001ce979a5857a1237e54d11a88> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7c416001ce979a5857a1237e54d11a88 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_7c416001ce979a5857a1237e54d11a88 FromStructure(RC_7c416001ce979a5857a1237e54d11a88 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_7c416001ce979a5857a1237e54d11a88(s, config);
}

}


