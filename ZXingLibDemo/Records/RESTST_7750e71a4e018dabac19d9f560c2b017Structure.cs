using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Barcode
public class RESTST_7750e71a4e018dabac19d9f560c2b017Structure : AbstractRESTStructure<ST_7750e71a4e018dabac19d9f560c2b017Structure> {
[JsonProperty("value")]
public string Attrvalue;

[JsonProperty("rawBytes")]
public byte[] AttrrawBytes;

[JsonProperty("format")]
public string Attrformat;

[JsonProperty("metadata")]
public RestList<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure> Attrmetadata;

[JsonProperty("detectedBarcode")]
public byte[] AttrdetectedBarcode;

public RESTST_7750e71a4e018dabac19d9f560c2b017Structure() { }

public RESTST_7750e71a4e018dabac19d9f560c2b017Structure (ST_7750e71a4e018dabac19d9f560c2b017Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrvalue = ConvertToRestWithoutDefaults(s.ssvalue, "");
AttrrawBytes = ConvertToRestWithoutDefaults(s.ssrawBytes);
Attrformat = ConvertToRestWithoutDefaults(s.ssformat, "");
Attrmetadata = s.ssmetadata.Length == 0 ? null : s.ssmetadata.ToRestList<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>(ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure.FromStructureDelegate(config));
AttrdetectedBarcode = ConvertToRestWithoutDefaults(s.ssdetectedBarcode);
  } else {
Attrvalue = s.ssvalue;
AttrrawBytes = s.ssrawBytes;
Attrformat = s.ssformat;
Attrmetadata = s.ssmetadata.ToRestList<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>(ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure.FromStructureDelegate(config));
AttrdetectedBarcode = s.ssdetectedBarcode;
  }
}

public static ST_7750e71a4e018dabac19d9f560c2b017Structure ToStructure(ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure obj) { 
  ST_7750e71a4e018dabac19d9f560c2b017Structure s = new ST_7750e71a4e018dabac19d9f560c2b017Structure();
  if(obj != null) {
  s.ssvalue = obj.Attrvalue == null ? "" : obj.Attrvalue;
  s.ssrawBytes = obj.AttrrawBytes == null ? new byte[] {} : obj.AttrrawBytes;
  s.ssformat = obj.Attrformat == null ? "" : obj.Attrformat;
  s.ssmetadata = RL_7919f33989696cd32796fc8e261021d2.FromRestList(obj.Attrmetadata, ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure.ToStructure);
  s.ssdetectedBarcode = obj.AttrdetectedBarcode == null ? new byte[] {} : obj.AttrdetectedBarcode;
  }
  return s;
}

public static Func<ST_7750e71a4e018dabac19d9f560c2b017Structure, ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7750e71a4e018dabac19d9f560c2b017Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure FromStructure(ST_7750e71a4e018dabac19d9f560c2b017Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure(s, config);
}

}


