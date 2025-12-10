using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Wifi
public class RESTST_af04a340a4a61afef041397e6f042234Structure : AbstractRESTStructure<ST_af04a340a4a61afef041397e6f042234Structure> {
[JsonProperty("SSID")]
public string AttrSSID;

[JsonProperty("password")]
public string Attrpassword;

[JsonProperty("authentication")]
public string Attrauthentication;

[JsonProperty("isHidden")]
public bool? AttrisHidden;

[JsonProperty("eapMethod")]
public string AttreapMethod;

[JsonProperty("anonymousIdentity")]
public string AttranonymousIdentity;

[JsonProperty("identity")]
public string Attridentity;

[JsonProperty("phase2Method")]
public string Attrphase2Method;

public RESTST_af04a340a4a61afef041397e6f042234Structure() { }

public RESTST_af04a340a4a61afef041397e6f042234Structure (ST_af04a340a4a61afef041397e6f042234Structure s, IBehaviorsConfiguration config) {
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

public static ST_af04a340a4a61afef041397e6f042234Structure ToStructure(ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure obj) { 
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

public static Func<ST_af04a340a4a61afef041397e6f042234Structure, ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_af04a340a4a61afef041397e6f042234Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure FromStructure(ST_af04a340a4a61afef041397e6f042234Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure(s, config);
}

}


