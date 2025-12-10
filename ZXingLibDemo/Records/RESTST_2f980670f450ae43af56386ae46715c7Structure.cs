using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// ComposedName
public class RESTST_2f980670f450ae43af56386ae46715c7Structure : AbstractRESTStructure<ST_2f980670f450ae43af56386ae46715c7Structure> {
[JsonProperty("firstName")]
public string AttrfirstName;

[JsonProperty("lastName")]
public string AttrlastName;

[JsonProperty("middleNames")]
public string AttrmiddleNames;

[JsonProperty("prefix")]
public string Attrprefix;

[JsonProperty("suffix")]
public string Attrsuffix;

public RESTST_2f980670f450ae43af56386ae46715c7Structure() { }

public RESTST_2f980670f450ae43af56386ae46715c7Structure (ST_2f980670f450ae43af56386ae46715c7Structure s, IBehaviorsConfiguration config) {
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

public static ST_2f980670f450ae43af56386ae46715c7Structure ToStructure(ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure obj) { 
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

public static Func<ST_2f980670f450ae43af56386ae46715c7Structure, ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2f980670f450ae43af56386ae46715c7Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure FromStructure(ST_2f980670f450ae43af56386ae46715c7Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure(s, config);
}

}


