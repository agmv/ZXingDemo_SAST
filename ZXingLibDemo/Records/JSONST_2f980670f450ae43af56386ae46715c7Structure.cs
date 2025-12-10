using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// ComposedName
public class JSONST_2f980670f450ae43af56386ae46715c7Structure : AbstractRESTStructure<ST_2f980670f450ae43af56386ae46715c7Structure> {
[JsonProperty("firstName")]
[JsonPropertyName("firstName")]
public string AttrfirstName;

[JsonProperty("lastName")]
[JsonPropertyName("lastName")]
public string AttrlastName;

[JsonProperty("middleNames")]
[JsonPropertyName("middleNames")]
public string AttrmiddleNames;

[JsonProperty("prefix")]
[JsonPropertyName("prefix")]
public string Attrprefix;

[JsonProperty("suffix")]
[JsonPropertyName("suffix")]
public string Attrsuffix;

public JSONST_2f980670f450ae43af56386ae46715c7Structure() { }

public JSONST_2f980670f450ae43af56386ae46715c7Structure (ST_2f980670f450ae43af56386ae46715c7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrfirstName = ConvertToRestWithoutDefaults(s.ssfirstName, "");
AttrlastName = ConvertToRestWithoutDefaults(s.sslastName, "");
AttrmiddleNames = ConvertToRestWithoutDefaults(s.ssmiddleNames, "");
Attrprefix = ConvertToRestWithoutDefaults(s.ssprefix, "");
Attrsuffix = ConvertToRestWithoutDefaults(s.sssuffix, "");
  } else {
AttrfirstName = s.ssfirstName;
AttrlastName = s.sslastName;
AttrmiddleNames = s.ssmiddleNames;
Attrprefix = s.ssprefix;
Attrsuffix = s.sssuffix;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure, ST_2f980670f450ae43af56386ae46715c7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure s) => ToStructure(s, config);
}
public static ST_2f980670f450ae43af56386ae46715c7Structure ToStructure(ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure obj, IBehaviorsConfiguration config) { 
  ST_2f980670f450ae43af56386ae46715c7Structure s = new ST_2f980670f450ae43af56386ae46715c7Structure();
  if(obj != null) {
  s.ssfirstName = obj.AttrfirstName == null ? "" : obj.AttrfirstName;
  s.sslastName = obj.AttrlastName == null ? "" : obj.AttrlastName;
  s.ssmiddleNames = obj.AttrmiddleNames == null ? "" : obj.AttrmiddleNames;
  s.ssprefix = obj.Attrprefix == null ? "" : obj.Attrprefix;
  s.sssuffix = obj.Attrsuffix == null ? "" : obj.Attrsuffix;
  }
  return s;
}

public static Func<ST_2f980670f450ae43af56386ae46715c7Structure, ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2f980670f450ae43af56386ae46715c7Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure FromStructure(ST_2f980670f450ae43af56386ae46715c7Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure(s, config);
}

}


