using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// MarkerClustererRecord
public class RESTRC_d687bfbe104d17346737149645109738 : AbstractRESTStructure<RC_d687bfbe104d17346737149645109738> {
[JsonProperty("MarkerClusterer")]
public ssZXingLibDemo.RestRecords.RESTST_30625b4ad0f3e10abf82b61ea58e8644Structure AttrMarkerClusterer;

public RESTRC_d687bfbe104d17346737149645109738() { }

public RESTRC_d687bfbe104d17346737149645109738 (RC_d687bfbe104d17346737149645109738 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarkerClusterer = ConvertToRestWithoutDefaults(s.ssSTMarkerClusterer, new ST_30625b4ad0f3e10abf82b61ea58e8644Structure(), ssZXingLibDemo.RestRecords.RESTST_30625b4ad0f3e10abf82b61ea58e8644Structure.FromStructureDelegate(config));
  } else {
AttrMarkerClusterer = ssZXingLibDemo.RestRecords.RESTST_30625b4ad0f3e10abf82b61ea58e8644Structure.FromStructure(s.ssSTMarkerClusterer, config);
  }
}

public static RC_d687bfbe104d17346737149645109738 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_d687bfbe104d17346737149645109738 obj) { 
  RC_d687bfbe104d17346737149645109738 s = new RC_d687bfbe104d17346737149645109738();
  if(obj != null) {
  s.ssSTMarkerClusterer = ssZXingLibDemo.RestRecords.RESTST_30625b4ad0f3e10abf82b61ea58e8644Structure.ToStructure(obj.AttrMarkerClusterer);
  }
  return s;
}

public static Func<RC_d687bfbe104d17346737149645109738, ssZXingLibDemo.RestRecords.RESTRC_d687bfbe104d17346737149645109738> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d687bfbe104d17346737149645109738 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_d687bfbe104d17346737149645109738 FromStructure(RC_d687bfbe104d17346737149645109738 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_d687bfbe104d17346737149645109738(s, config);
}

}


