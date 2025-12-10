using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalLeafletMapConfigsRecord
public class JSONRC_708103c95439cc3f1448414527622b7c : AbstractRESTStructure<RC_708103c95439cc3f1448414527622b7c> {
[JsonProperty("OptionalLeafletMapConfigs")]
[JsonPropertyName("OptionalLeafletMapConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure AttrOptionalLeafletMapConfigs;

public JSONRC_708103c95439cc3f1448414527622b7c() { }

public JSONRC_708103c95439cc3f1448414527622b7c (RC_708103c95439cc3f1448414527622b7c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalLeafletMapConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalLeafletMapConfigs, new ST_597877eac22877030461f6d98995be4aStructure(), ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure.FromStructureDelegate(config));
  } else {
AttrOptionalLeafletMapConfigs = ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure.FromStructure(s.ssSTOptionalLeafletMapConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_708103c95439cc3f1448414527622b7c, RC_708103c95439cc3f1448414527622b7c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_708103c95439cc3f1448414527622b7c s) => ToStructure(s, config);
}
public static RC_708103c95439cc3f1448414527622b7c ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_708103c95439cc3f1448414527622b7c obj, IBehaviorsConfiguration config) { 
  RC_708103c95439cc3f1448414527622b7c s = new RC_708103c95439cc3f1448414527622b7c();
  if(obj != null) {
  s.ssSTOptionalLeafletMapConfigs = ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure.ToStructure(obj.AttrOptionalLeafletMapConfigs, config);
  }
  return s;
}

public static Func<RC_708103c95439cc3f1448414527622b7c, ssOutSystemsMaps.RestRecords.JSONRC_708103c95439cc3f1448414527622b7c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_708103c95439cc3f1448414527622b7c s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_708103c95439cc3f1448414527622b7c FromStructure(RC_708103c95439cc3f1448414527622b7c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_708103c95439cc3f1448414527622b7c(s, config);
}

}


