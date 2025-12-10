using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalLeafletMapConfigsRecord
public class RESTRC_708103c95439cc3f1448414527622b7c : AbstractRESTStructure<RC_708103c95439cc3f1448414527622b7c> {
[JsonProperty("OptionalLeafletMapConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_597877eac22877030461f6d98995be4aStructure AttrOptionalLeafletMapConfigs;

public RESTRC_708103c95439cc3f1448414527622b7c() { }

public RESTRC_708103c95439cc3f1448414527622b7c (RC_708103c95439cc3f1448414527622b7c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalLeafletMapConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalLeafletMapConfigs, new ST_597877eac22877030461f6d98995be4aStructure(), ssOutSystemsMaps.RestRecords.RESTST_597877eac22877030461f6d98995be4aStructure.FromStructureDelegate(config));
  } else {
AttrOptionalLeafletMapConfigs = ssOutSystemsMaps.RestRecords.RESTST_597877eac22877030461f6d98995be4aStructure.FromStructure(s.ssSTOptionalLeafletMapConfigs, config);
  }
}

public static RC_708103c95439cc3f1448414527622b7c ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_708103c95439cc3f1448414527622b7c obj) { 
  RC_708103c95439cc3f1448414527622b7c s = new RC_708103c95439cc3f1448414527622b7c();
  if(obj != null) {
  s.ssSTOptionalLeafletMapConfigs = ssOutSystemsMaps.RestRecords.RESTST_597877eac22877030461f6d98995be4aStructure.ToStructure(obj.AttrOptionalLeafletMapConfigs);
  }
  return s;
}

public static Func<RC_708103c95439cc3f1448414527622b7c, ssOutSystemsMaps.RestRecords.RESTRC_708103c95439cc3f1448414527622b7c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_708103c95439cc3f1448414527622b7c s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_708103c95439cc3f1448414527622b7c FromStructure(RC_708103c95439cc3f1448414527622b7c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_708103c95439cc3f1448414527622b7c(s, config);
}

}


