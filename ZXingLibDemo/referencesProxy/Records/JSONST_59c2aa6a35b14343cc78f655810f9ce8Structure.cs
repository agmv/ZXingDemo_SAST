using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// Localization
public class JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure : AbstractRESTStructure<ST_59c2aa6a35b14343cc78f655810f9ce8Structure> {
[JsonProperty("language")]
[JsonPropertyName("language")]
public string AttrLanguage;

[JsonProperty("region")]
[JsonPropertyName("region")]
public string AttrRegion;

public JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure() { }

public JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure (ST_59c2aa6a35b14343cc78f655810f9ce8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLanguage = ConvertToRestWithoutDefaults(s.ssLanguage, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
  } else {
AttrLanguage = s.ssLanguage;
AttrRegion = s.ssRegion;
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure, ST_59c2aa6a35b14343cc78f655810f9ce8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure s) => ToStructure(s, config);
}
public static ST_59c2aa6a35b14343cc78f655810f9ce8Structure ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure obj, IBehaviorsConfiguration config) { 
  ST_59c2aa6a35b14343cc78f655810f9ce8Structure s = new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
  if(obj != null) {
  s.ssLanguage = obj.AttrLanguage == null ? "" : obj.AttrLanguage;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  }
  return s;
}

public static Func<ST_59c2aa6a35b14343cc78f655810f9ce8Structure, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_59c2aa6a35b14343cc78f655810f9ce8Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure FromStructure(ST_59c2aa6a35b14343cc78f655810f9ce8Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure(s, config);
}

}


