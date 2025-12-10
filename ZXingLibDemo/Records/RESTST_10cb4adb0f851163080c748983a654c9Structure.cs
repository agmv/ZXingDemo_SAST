using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Contact
public class RESTST_10cb4adb0f851163080c748983a654c9Structure : AbstractRESTStructure<ST_10cb4adb0f851163080c748983a654c9Structure> {
[JsonProperty("formatedName")]
public string AttrformatedName;

[JsonProperty("composedName")]
public ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure AttrcomposedName;

[JsonProperty("organization")]
public string Attrorganization;

[JsonProperty("title")]
public string Attrtitle;

[JsonProperty("homePhone")]
public string AttrhomePhone;

[JsonProperty("workPhone")]
public string AttrworkPhone;

[JsonProperty("mobilePhone")]
public string AttrmobilePhone;

[JsonProperty("email")]
public string Attremail;

[JsonProperty("address")]
public string Attraddress;

[JsonProperty("website")]
public string Attrwebsite;

[JsonProperty("notes")]
public string Attrnotes;

public RESTST_10cb4adb0f851163080c748983a654c9Structure() { }

public RESTST_10cb4adb0f851163080c748983a654c9Structure (ST_10cb4adb0f851163080c748983a654c9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrformatedName = s.ssformatedName;
AttrcomposedName = ConvertToRestWithoutDefaults(s.sscomposedName, new ST_2f980670f450ae43af56386ae46715c7Structure(), ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure.FromStructureDelegate(config));
Attrorganization = ConvertToRestWithoutDefaults(s.ssorganization, "");
Attrtitle = ConvertToRestWithoutDefaults(s.sstitle, "");
AttrhomePhone = ConvertToRestWithoutDefaults(s.sshomePhone, "");
AttrworkPhone = ConvertToRestWithoutDefaults(s.ssworkPhone, "");
AttrmobilePhone = ConvertToRestWithoutDefaults(s.ssmobilePhone, "");
Attremail = ConvertToRestWithoutDefaults(s.ssemail, "");
Attraddress = ConvertToRestWithoutDefaults(s.ssaddress, "");
Attrwebsite = ConvertToRestWithoutDefaults(s.sswebsite, "");
Attrnotes = ConvertToRestWithoutDefaults(s.ssnotes, "");
  } else {
AttrformatedName = s.ssformatedName;
AttrcomposedName = ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure.FromStructure(s.sscomposedName, config);
Attrorganization = s.ssorganization;
Attrtitle = s.sstitle;
AttrhomePhone = s.sshomePhone;
AttrworkPhone = s.ssworkPhone;
AttrmobilePhone = s.ssmobilePhone;
Attremail = s.ssemail;
Attraddress = s.ssaddress;
Attrwebsite = s.sswebsite;
Attrnotes = s.ssnotes;
  }
}

public static ST_10cb4adb0f851163080c748983a654c9Structure ToStructure(ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure obj) { 
  ST_10cb4adb0f851163080c748983a654c9Structure s = new ST_10cb4adb0f851163080c748983a654c9Structure();
  if(obj != null) {
  s.ssformatedName = obj.AttrformatedName == null ? "" : obj.AttrformatedName;
  s.sscomposedName = ssZXingLibDemo.RestRecords.RESTST_2f980670f450ae43af56386ae46715c7Structure.ToStructure(obj.AttrcomposedName);
  s.ssorganization = obj.Attrorganization == null ? "" : obj.Attrorganization;
  s.sstitle = obj.Attrtitle == null ? "" : obj.Attrtitle;
  s.sshomePhone = obj.AttrhomePhone == null ? "" : obj.AttrhomePhone;
  s.ssworkPhone = obj.AttrworkPhone == null ? "" : obj.AttrworkPhone;
  s.ssmobilePhone = obj.AttrmobilePhone == null ? "" : obj.AttrmobilePhone;
  s.ssemail = obj.Attremail == null ? "" : obj.Attremail;
  s.ssaddress = obj.Attraddress == null ? "" : obj.Attraddress;
  s.sswebsite = obj.Attrwebsite == null ? "" : obj.Attrwebsite;
  s.ssnotes = obj.Attrnotes == null ? "" : obj.Attrnotes;
  }
  return s;
}

public static Func<ST_10cb4adb0f851163080c748983a654c9Structure, ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_10cb4adb0f851163080c748983a654c9Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure FromStructure(ST_10cb4adb0f851163080c748983a654c9Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure(s, config);
}

}


