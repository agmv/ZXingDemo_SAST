using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Metadata
public class JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure : AbstractRESTStructure<ST_a1f7d5fa968628cf9ed1d90efadf9506Structure> {
[JsonProperty("key")]
[JsonPropertyName("key")]
public string Attrkey;

[JsonProperty("value")]
[JsonPropertyName("value")]
public string Attrvalue;

public JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure() { }

public JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure (ST_a1f7d5fa968628cf9ed1d90efadf9506Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrkey = s.sskey;
Attrvalue = ConvertToRestWithoutDefaults(s.ssvalue, "");
  } else {
Attrkey = s.sskey;
Attrvalue = s.ssvalue;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure, ST_a1f7d5fa968628cf9ed1d90efadf9506Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure s) => ToStructure(s, config);
}
public static ST_a1f7d5fa968628cf9ed1d90efadf9506Structure ToStructure(ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure obj, IBehaviorsConfiguration config) { 
  ST_a1f7d5fa968628cf9ed1d90efadf9506Structure s = new ST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
  if(obj != null) {
  s.sskey = obj.Attrkey == null ? "" : obj.Attrkey;
  s.ssvalue = obj.Attrvalue == null ? "" : obj.Attrvalue;
  }
  return s;
}

public static Func<ST_a1f7d5fa968628cf9ed1d90efadf9506Structure, ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_a1f7d5fa968628cf9ed1d90efadf9506Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure FromStructure(ST_a1f7d5fa968628cf9ed1d90efadf9506Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure(s, config);
}

}


