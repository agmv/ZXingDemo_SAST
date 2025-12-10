using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownServerSide_InternalConfigs
public class JSONST_0d18385ed976d2d74e8cea1d77078409Structure : AbstractRESTStructure<ST_0d18385ed976d2d74e8cea1d77078409Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("AllowMultipleSelection")]
[JsonPropertyName("AllowMultipleSelection")]
public bool? AttrAllowMultipleSelection;

[JsonProperty("IsDisabled")]
[JsonPropertyName("IsDisabled")]
public bool? AttrIsDisabled;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_0d18385ed976d2d74e8cea1d77078409Structure() { }

public JSONST_0d18385ed976d2d74e8cea1d77078409Structure (ST_0d18385ed976d2d74e8cea1d77078409Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrAllowMultipleSelection = ConvertToRestWithoutDefaults(s.ssAllowMultipleSelection, false);
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, Convert.ToString(1));
  } else {
AttrUniqueId = s.ssUniqueId;
AttrAllowMultipleSelection = (bool?) s.ssAllowMultipleSelection;
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_0d18385ed976d2d74e8cea1d77078409Structure, ST_0d18385ed976d2d74e8cea1d77078409Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_0d18385ed976d2d74e8cea1d77078409Structure s) => ToStructure(s, config);
}
public static ST_0d18385ed976d2d74e8cea1d77078409Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_0d18385ed976d2d74e8cea1d77078409Structure obj, IBehaviorsConfiguration config) { 
  ST_0d18385ed976d2d74e8cea1d77078409Structure s = new ST_0d18385ed976d2d74e8cea1d77078409Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssAllowMultipleSelection = obj.AttrAllowMultipleSelection == null ? false : obj.AttrAllowMultipleSelection.Value;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? Convert.ToString(1) : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_0d18385ed976d2d74e8cea1d77078409Structure, ssOutSystemsUI.RestRecords.JSONST_0d18385ed976d2d74e8cea1d77078409Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0d18385ed976d2d74e8cea1d77078409Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_0d18385ed976d2d74e8cea1d77078409Structure FromStructure(ST_0d18385ed976d2d74e8cea1d77078409Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_0d18385ed976d2d74e8cea1d77078409Structure(s, config);
}

}


