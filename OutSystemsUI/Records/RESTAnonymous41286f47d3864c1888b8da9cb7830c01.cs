using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// InlineSVG_InternalConfigRecord
public class RESTRC_7c416001ce979a5857a1237e54d11a88 : AbstractRESTStructure<RC_7c416001ce979a5857a1237e54d11a88> {
[JsonProperty("InlineSVG_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_bc9955d62033e77475d9540bd4940593Structure AttrInlineSVG_InternalConfig;

public RESTRC_7c416001ce979a5857a1237e54d11a88() { }

public RESTRC_7c416001ce979a5857a1237e54d11a88 (RC_7c416001ce979a5857a1237e54d11a88 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInlineSVG_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTInlineSVG_InternalConfig, new ST_bc9955d62033e77475d9540bd4940593Structure(), ssOutSystemsUI.RestRecords.RESTST_bc9955d62033e77475d9540bd4940593Structure.FromStructureDelegate(config));
  } else {
AttrInlineSVG_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_bc9955d62033e77475d9540bd4940593Structure.FromStructure(s.ssSTInlineSVG_InternalConfig, config);
  }
}

public static RC_7c416001ce979a5857a1237e54d11a88 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_7c416001ce979a5857a1237e54d11a88 obj) { 
  RC_7c416001ce979a5857a1237e54d11a88 s = new RC_7c416001ce979a5857a1237e54d11a88();
  if(obj != null) {
  s.ssSTInlineSVG_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_bc9955d62033e77475d9540bd4940593Structure.ToStructure(obj.AttrInlineSVG_InternalConfig);
  }
  return s;
}

public static Func<RC_7c416001ce979a5857a1237e54d11a88, ssOutSystemsUI.RestRecords.RESTRC_7c416001ce979a5857a1237e54d11a88> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7c416001ce979a5857a1237e54d11a88 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_7c416001ce979a5857a1237e54d11a88 FromStructure(RC_7c416001ce979a5857a1237e54d11a88 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_7c416001ce979a5857a1237e54d11a88(s, config);
}

}


