using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Contact
public class JSONST_10cb4adb0f851163080c748983a654c9Structure : AbstractRESTStructure<ST_10cb4adb0f851163080c748983a654c9Structure> {
[JsonProperty("formatedName")]
[JsonPropertyName("formatedName")]
public string AttrformatedName;

[JsonProperty("composedName")]
[JsonPropertyName("composedName")]
public ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure AttrcomposedName;

[JsonProperty("organization")]
[JsonPropertyName("organization")]
public string Attrorganization;

[JsonProperty("title")]
[JsonPropertyName("title")]
public string Attrtitle;

[JsonProperty("homePhone")]
[JsonPropertyName("homePhone")]
public string AttrhomePhone;

[JsonProperty("workPhone")]
[JsonPropertyName("workPhone")]
public string AttrworkPhone;

[JsonProperty("mobilePhone")]
[JsonPropertyName("mobilePhone")]
public string AttrmobilePhone;

[JsonProperty("email")]
[JsonPropertyName("email")]
public string Attremail;

[JsonProperty("address")]
[JsonPropertyName("address")]
public string Attraddress;

[JsonProperty("website")]
[JsonPropertyName("website")]
public string Attrwebsite;

[JsonProperty("notes")]
[JsonPropertyName("notes")]
public string Attrnotes;

public JSONST_10cb4adb0f851163080c748983a654c9Structure() { }

public JSONST_10cb4adb0f851163080c748983a654c9Structure (ST_10cb4adb0f851163080c748983a654c9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrformatedName = s.ssformatedName;
AttrcomposedName = ConvertToRestWithoutDefaults(s.sscomposedName, new ST_2f980670f450ae43af56386ae46715c7Structure(), ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure.FromStructureDelegate(config));
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
AttrcomposedName = ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure.FromStructure(s.sscomposedName, config);
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

public static Func<ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure, ST_10cb4adb0f851163080c748983a654c9Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure s) => ToStructure(s, config);
}
public static ST_10cb4adb0f851163080c748983a654c9Structure ToStructure(ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure obj, IBehaviorsConfiguration config) { 
  ST_10cb4adb0f851163080c748983a654c9Structure s = new ST_10cb4adb0f851163080c748983a654c9Structure();
  if(obj != null) {
  s.ssformatedName = obj.AttrformatedName == null ? "" : obj.AttrformatedName;
  s.sscomposedName = ssZXingLibDemo.RestRecords.JSONST_2f980670f450ae43af56386ae46715c7Structure.ToStructure(obj.AttrcomposedName, config);
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

public static Func<ST_10cb4adb0f851163080c748983a654c9Structure, ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_10cb4adb0f851163080c748983a654c9Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure FromStructure(ST_10cb4adb0f851163080c748983a654c9Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure(s, config);
}

}


