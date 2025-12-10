using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Barcode
public class JSONST_7750e71a4e018dabac19d9f560c2b017Structure : AbstractRESTStructure<ST_7750e71a4e018dabac19d9f560c2b017Structure> {
[JsonProperty("value")]
[JsonPropertyName("value")]
public string Attrvalue;

[JsonProperty("rawBytes")]
[JsonPropertyName("rawBytes")]
public byte[] AttrrawBytes;

[JsonProperty("format")]
[JsonPropertyName("format")]
public string Attrformat;

[JsonProperty("metadata")]
[JsonPropertyName("metadata")]
public ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure[] Attrmetadata;

[JsonProperty("detectedBarcode")]
[JsonPropertyName("detectedBarcode")]
public byte[] AttrdetectedBarcode;

public JSONST_7750e71a4e018dabac19d9f560c2b017Structure() { }

public JSONST_7750e71a4e018dabac19d9f560c2b017Structure (ST_7750e71a4e018dabac19d9f560c2b017Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrvalue = ConvertToRestWithoutDefaults(s.ssvalue, "");
AttrrawBytes = ConvertToRestWithoutDefaults(s.ssrawBytes);
Attrformat = ConvertToRestWithoutDefaults(s.ssformat, "");
Attrmetadata = s.ssmetadata.Length == 0 ? null : s.ssmetadata.ToArray<ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure>(ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure.FromStructureDelegate(config));
AttrdetectedBarcode = ConvertToRestWithoutDefaults(s.ssdetectedBarcode);
  } else {
Attrvalue = s.ssvalue;
AttrrawBytes = s.ssrawBytes;
Attrformat = s.ssformat;
Attrmetadata = s.ssmetadata.ToArray<ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure>(ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure.FromStructureDelegate(config));
AttrdetectedBarcode = s.ssdetectedBarcode;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONST_7750e71a4e018dabac19d9f560c2b017Structure, ST_7750e71a4e018dabac19d9f560c2b017Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONST_7750e71a4e018dabac19d9f560c2b017Structure s) => ToStructure(s, config);
}
public static ST_7750e71a4e018dabac19d9f560c2b017Structure ToStructure(ssZXingLibDemo.RestRecords.JSONST_7750e71a4e018dabac19d9f560c2b017Structure obj, IBehaviorsConfiguration config) { 
  ST_7750e71a4e018dabac19d9f560c2b017Structure s = new ST_7750e71a4e018dabac19d9f560c2b017Structure();
  if(obj != null) {
  s.ssvalue = obj.Attrvalue == null ? "" : obj.Attrvalue;
  s.ssrawBytes = obj.AttrrawBytes == null ? new byte[] {} : obj.AttrrawBytes;
  s.ssformat = obj.Attrformat == null ? "" : obj.Attrformat;
  s.ssmetadata = RL_7919f33989696cd32796fc8e261021d2.ToList(obj.Attrmetadata, ssZXingLibDemo.RestRecords.JSONST_a1f7d5fa968628cf9ed1d90efadf9506Structure.ToStructureDelegate(config));
  s.ssdetectedBarcode = obj.AttrdetectedBarcode == null ? new byte[] {} : obj.AttrdetectedBarcode;
  }
  return s;
}

public static Func<ST_7750e71a4e018dabac19d9f560c2b017Structure, ssZXingLibDemo.RestRecords.JSONST_7750e71a4e018dabac19d9f560c2b017Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7750e71a4e018dabac19d9f560c2b017Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONST_7750e71a4e018dabac19d9f560c2b017Structure FromStructure(ST_7750e71a4e018dabac19d9f560c2b017Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONST_7750e71a4e018dabac19d9f560c2b017Structure(s, config);
}

}


