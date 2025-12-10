using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Wifi
public class JSONST_af04a340a4a61afef041397e6f042234Structure : AbstractRESTStructure<ST_af04a340a4a61afef041397e6f042234Structure> {
[JsonProperty("SSID")]
[JsonPropertyName("SSID")]
public string AttrSSID;

[JsonProperty("password")]
[JsonPropertyName("password")]
public string Attrpassword;

[JsonProperty("authentication")]
[JsonPropertyName("authentication")]
public string Attrauthentication;

[JsonProperty("isHidden")]
[JsonPropertyName("isHidden")]
public bool? AttrisHidden;

[JsonProperty("eapMethod")]
[JsonPropertyName("eapMethod")]
public string AttreapMethod;

[JsonProperty("anonymousIdentity")]
[JsonPropertyName("anonymousIdentity")]
public string AttranonymousIdentity;

[JsonProperty("identity")]
[JsonPropertyName("identity")]
public string Attridentity;

[JsonProperty("phase2Method")]
[JsonPropertyName("phase2Method")]
public string Attrphase2Method;

public JSONST_af04a340a4a61afef041397e6f042234Structure() { }

public JSONST_af04a340a4a61afef041397e6f042234Structure (ST_af04a340a4a61afef041397e6f042234Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSSID = s.ssSSID;
Attrpassword = ConvertToRestWithoutDefaults(s.sspassword, "");
Attrauthentication = s.ssauthentication;
AttrisHidden = ConvertToRestWithoutDefaults(s.ssisHidden, false);
AttreapMethod = ConvertToRestWithoutDefaults(s.sseapMethod, "");
AttranonymousIdentity = ConvertToRestWithoutDefaults(s.ssanonymousIdentity, "");
Attridentity = ConvertToRestWithoutDefaults(s.ssidentity, "");
Attrphase2Method = ConvertToRestWithoutDefaults(s.ssphase2Method, "");
  } else {
AttrSSID = s.ssSSID;
Attrpassword = s.sspassword;
Attrauthentication = s.ssauthentication;
AttrisHidden = (bool?) s.ssisHidden;
AttreapMethod = s.sseapMethod;
AttranonymousIdentity = s.ssanonymousIdentity;
Attridentity = s.ssidentity;
Attrphase2Method = s.ssphase2Method;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure, ST_af04a340a4a61afef041397e6f042234Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure s) => ToStructure(s, config);
}
public static ST_af04a340a4a61afef041397e6f042234Structure ToStructure(ssZXingLibDemo.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure obj, IBehaviorsConfiguration config) { 
  ST_af04a340a4a61afef041397e6f042234Structure s = new ST_af04a340a4a61afef041397e6f042234Structure();
  if(obj != null) {
  s.ssSSID = obj.AttrSSID == null ? "" : obj.AttrSSID;
  s.sspassword = obj.Attrpassword == null ? "" : obj.Attrpassword;
  s.ssauthentication = obj.Attrauthentication == null ? "" : obj.Attrauthentication;
  s.ssisHidden = obj.AttrisHidden == null ? false : obj.AttrisHidden.Value;
  s.sseapMethod = obj.AttreapMethod == null ? "" : obj.AttreapMethod;
  s.ssanonymousIdentity = obj.AttranonymousIdentity == null ? "" : obj.AttranonymousIdentity;
  s.ssidentity = obj.Attridentity == null ? "" : obj.Attridentity;
  s.ssphase2Method = obj.Attrphase2Method == null ? "" : obj.Attrphase2Method;
  }
  return s;
}

public static Func<ST_af04a340a4a61afef041397e6f042234Structure, ssZXingLibDemo.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_af04a340a4a61afef041397e6f042234Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure FromStructure(ST_af04a340a4a61afef041397e6f042234Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure(s, config);
}

}


