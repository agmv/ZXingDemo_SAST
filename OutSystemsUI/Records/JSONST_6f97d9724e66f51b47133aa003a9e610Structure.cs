using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthPicker_InternalConfig
public class JSONST_6f97d9724e66f51b47133aa003a9e610Structure : AbstractRESTStructure<ST_6f97d9724e66f51b47133aa003a9e610Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("DateFormat")]
[JsonPropertyName("DateFormat")]
public string AttrDateFormat;

[JsonProperty("MinMonth")]
[JsonPropertyName("MinMonth")]
public ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure AttrMinMonth;

[JsonProperty("InitialMonth")]
[JsonPropertyName("InitialMonth")]
public ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure AttrInitialMonth;

[JsonProperty("MaxMonth")]
[JsonPropertyName("MaxMonth")]
public ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure AttrMaxMonth;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_6f97d9724e66f51b47133aa003a9e610Structure() { }

public JSONST_6f97d9724e66f51b47133aa003a9e610Structure (ST_6f97d9724e66f51b47133aa003a9e610Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrDateFormat = ConvertToRestWithoutDefaults(s.ssDateFormat, "");
AttrMinMonth = ConvertToRestWithoutDefaults(s.ssMinMonth, new ST_5c08eaa15b890a2d617cabe547c34f0bStructure(), ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructureDelegate(config));
AttrInitialMonth = ConvertToRestWithoutDefaults(s.ssInitialMonth, new ST_5c08eaa15b890a2d617cabe547c34f0bStructure(), ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructureDelegate(config));
AttrMaxMonth = ConvertToRestWithoutDefaults(s.ssMaxMonth, new ST_5c08eaa15b890a2d617cabe547c34f0bStructure(), ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructureDelegate(config));
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrDateFormat = s.ssDateFormat;
AttrMinMonth = ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructure(s.ssMinMonth, config);
AttrInitialMonth = ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructure(s.ssInitialMonth, config);
AttrMaxMonth = ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructure(s.ssMaxMonth, config);
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure, ST_6f97d9724e66f51b47133aa003a9e610Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure s) => ToStructure(s, config);
}
public static ST_6f97d9724e66f51b47133aa003a9e610Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure obj, IBehaviorsConfiguration config) { 
  ST_6f97d9724e66f51b47133aa003a9e610Structure s = new ST_6f97d9724e66f51b47133aa003a9e610Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssDateFormat = obj.AttrDateFormat == null ? "" : obj.AttrDateFormat;
  s.ssMinMonth = ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.ToStructure(obj.AttrMinMonth, config);
  s.ssInitialMonth = ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.ToStructure(obj.AttrInitialMonth, config);
  s.ssMaxMonth = ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.ToStructure(obj.AttrMaxMonth, config);
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_6f97d9724e66f51b47133aa003a9e610Structure, ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6f97d9724e66f51b47133aa003a9e610Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure FromStructure(ST_6f97d9724e66f51b47133aa003a9e610Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure(s, config);
}

}


