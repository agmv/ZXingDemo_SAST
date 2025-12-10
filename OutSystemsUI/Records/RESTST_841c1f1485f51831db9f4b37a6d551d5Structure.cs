using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// NoUiSliderConfigs_Range
public class RESTST_841c1f1485f51831db9f4b37a6d551d5Structure : AbstractRESTStructure<ST_841c1f1485f51831db9f4b37a6d551d5Structure> {
[JsonProperty("key")]
public string Attrkey;

[JsonProperty("value")]
public int? Attrvalue;

public RESTST_841c1f1485f51831db9f4b37a6d551d5Structure() { }

public RESTST_841c1f1485f51831db9f4b37a6d551d5Structure (ST_841c1f1485f51831db9f4b37a6d551d5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrkey = ConvertToRestWithoutDefaults(s.sskey, "");
Attrvalue = ConvertToRestWithoutDefaults(s.ssvalue, 0);
  } else {
Attrkey = s.sskey;
Attrvalue = (int?) s.ssvalue;
  }
}

public static ST_841c1f1485f51831db9f4b37a6d551d5Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure obj) { 
  ST_841c1f1485f51831db9f4b37a6d551d5Structure s = new ST_841c1f1485f51831db9f4b37a6d551d5Structure();
  if(obj != null) {
  s.sskey = obj.Attrkey == null ? "" : obj.Attrkey;
  s.ssvalue = obj.Attrvalue == null ? 0 : obj.Attrvalue.Value;
  }
  return s;
}

public static Func<ST_841c1f1485f51831db9f4b37a6d551d5Structure, ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_841c1f1485f51831db9f4b37a6d551d5Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure FromStructure(ST_841c1f1485f51831db9f4b37a6d551d5Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure(s, config);
}

}


