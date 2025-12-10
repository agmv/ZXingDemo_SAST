using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProviderEventReturnMessageRecord
public class RESTRC_dae4b4e9efc938bf677d8f92dec29722 : AbstractRESTStructure<RC_dae4b4e9efc938bf677d8f92dec29722> {
[JsonProperty("ProviderEventReturnMessage")]
public ssOutSystemsUI.RestRecords.RESTST_0995bd60993005a912f016117c0f5fd9Structure AttrProviderEventReturnMessage;

public RESTRC_dae4b4e9efc938bf677d8f92dec29722() { }

public RESTRC_dae4b4e9efc938bf677d8f92dec29722 (RC_dae4b4e9efc938bf677d8f92dec29722 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProviderEventReturnMessage = ConvertToRestWithoutDefaults(s.ssSTProviderEventReturnMessage, new ST_0995bd60993005a912f016117c0f5fd9Structure(), ssOutSystemsUI.RestRecords.RESTST_0995bd60993005a912f016117c0f5fd9Structure.FromStructureDelegate(config));
  } else {
AttrProviderEventReturnMessage = ssOutSystemsUI.RestRecords.RESTST_0995bd60993005a912f016117c0f5fd9Structure.FromStructure(s.ssSTProviderEventReturnMessage, config);
  }
}

public static RC_dae4b4e9efc938bf677d8f92dec29722 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_dae4b4e9efc938bf677d8f92dec29722 obj) { 
  RC_dae4b4e9efc938bf677d8f92dec29722 s = new RC_dae4b4e9efc938bf677d8f92dec29722();
  if(obj != null) {
  s.ssSTProviderEventReturnMessage = ssOutSystemsUI.RestRecords.RESTST_0995bd60993005a912f016117c0f5fd9Structure.ToStructure(obj.AttrProviderEventReturnMessage);
  }
  return s;
}

public static Func<RC_dae4b4e9efc938bf677d8f92dec29722, ssOutSystemsUI.RestRecords.RESTRC_dae4b4e9efc938bf677d8f92dec29722> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dae4b4e9efc938bf677d8f92dec29722 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_dae4b4e9efc938bf677d8f92dec29722 FromStructure(RC_dae4b4e9efc938bf677d8f92dec29722 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_dae4b4e9efc938bf677d8f92dec29722(s, config);
}

}


