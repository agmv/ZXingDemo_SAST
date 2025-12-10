using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthPicker_InternalConfig
public class RESTST_6f97d9724e66f51b47133aa003a9e610Structure : AbstractRESTStructure<ST_6f97d9724e66f51b47133aa003a9e610Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("DateFormat")]
public string AttrDateFormat;

[JsonProperty("MinMonth")]
public ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure AttrMinMonth;

[JsonProperty("InitialMonth")]
public ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure AttrInitialMonth;

[JsonProperty("MaxMonth")]
public ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure AttrMaxMonth;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_6f97d9724e66f51b47133aa003a9e610Structure() { }

public RESTST_6f97d9724e66f51b47133aa003a9e610Structure (ST_6f97d9724e66f51b47133aa003a9e610Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrDateFormat = ConvertToRestWithoutDefaults(s.ssDateFormat, "");
AttrMinMonth = ConvertToRestWithoutDefaults(s.ssMinMonth, new ST_5c08eaa15b890a2d617cabe547c34f0bStructure(), ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructureDelegate(config));
AttrInitialMonth = ConvertToRestWithoutDefaults(s.ssInitialMonth, new ST_5c08eaa15b890a2d617cabe547c34f0bStructure(), ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructureDelegate(config));
AttrMaxMonth = ConvertToRestWithoutDefaults(s.ssMaxMonth, new ST_5c08eaa15b890a2d617cabe547c34f0bStructure(), ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructureDelegate(config));
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrDateFormat = s.ssDateFormat;
AttrMinMonth = ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructure(s.ssMinMonth, config);
AttrInitialMonth = ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructure(s.ssInitialMonth, config);
AttrMaxMonth = ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructure(s.ssMaxMonth, config);
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_6f97d9724e66f51b47133aa003a9e610Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_6f97d9724e66f51b47133aa003a9e610Structure obj) { 
  ST_6f97d9724e66f51b47133aa003a9e610Structure s = new ST_6f97d9724e66f51b47133aa003a9e610Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssDateFormat = obj.AttrDateFormat == null ? "" : obj.AttrDateFormat;
  s.ssMinMonth = ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.ToStructure(obj.AttrMinMonth);
  s.ssInitialMonth = ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.ToStructure(obj.AttrInitialMonth);
  s.ssMaxMonth = ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure.ToStructure(obj.AttrMaxMonth);
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_6f97d9724e66f51b47133aa003a9e610Structure, ssOutSystemsUI.RestRecords.RESTST_6f97d9724e66f51b47133aa003a9e610Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6f97d9724e66f51b47133aa003a9e610Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_6f97d9724e66f51b47133aa003a9e610Structure FromStructure(ST_6f97d9724e66f51b47133aa003a9e610Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_6f97d9724e66f51b47133aa003a9e610Structure(s, config);
}

}


