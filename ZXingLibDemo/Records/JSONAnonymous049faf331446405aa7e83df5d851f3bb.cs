using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// MarkerClustererRecord
public class JSONRC_d687bfbe104d17346737149645109738 : AbstractRESTStructure<RC_d687bfbe104d17346737149645109738> {
[JsonProperty("MarkerClusterer")]
[JsonPropertyName("MarkerClusterer")]
public ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure AttrMarkerClusterer;

public JSONRC_d687bfbe104d17346737149645109738() { }

public JSONRC_d687bfbe104d17346737149645109738 (RC_d687bfbe104d17346737149645109738 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarkerClusterer = ConvertToRestWithoutDefaults(s.ssSTMarkerClusterer, new ST_30625b4ad0f3e10abf82b61ea58e8644Structure(), ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure.FromStructureDelegate(config));
  } else {
AttrMarkerClusterer = ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure.FromStructure(s.ssSTMarkerClusterer, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_d687bfbe104d17346737149645109738, RC_d687bfbe104d17346737149645109738> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_d687bfbe104d17346737149645109738 s) => ToStructure(s, config);
}
public static RC_d687bfbe104d17346737149645109738 ToStructure(ssZXingLibDemo.RestRecords.JSONRC_d687bfbe104d17346737149645109738 obj, IBehaviorsConfiguration config) { 
  RC_d687bfbe104d17346737149645109738 s = new RC_d687bfbe104d17346737149645109738();
  if(obj != null) {
  s.ssSTMarkerClusterer = ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure.ToStructure(obj.AttrMarkerClusterer, config);
  }
  return s;
}

public static Func<RC_d687bfbe104d17346737149645109738, ssZXingLibDemo.RestRecords.JSONRC_d687bfbe104d17346737149645109738> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d687bfbe104d17346737149645109738 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_d687bfbe104d17346737149645109738 FromStructure(RC_d687bfbe104d17346737149645109738 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_d687bfbe104d17346737149645109738(s, config);
}

}


