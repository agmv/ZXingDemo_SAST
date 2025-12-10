using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalCircleConfigs
public class RESTST_9a87c036f8540c84242b92bb54609014Structure : AbstractRESTStructure<ST_9a87c036f8540c84242b92bb54609014Structure> {
[JsonProperty("AllowDrag")]
public bool? AttrAllowDrag;

[JsonProperty("AllowEdit")]
public bool? AttrAllowEdit;

[JsonProperty("Stroke")]
public ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure AttrStroke;

[JsonProperty("Fill")]
public ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure AttrFill;

public RESTST_9a87c036f8540c84242b92bb54609014Structure() { }

public RESTST_9a87c036f8540c84242b92bb54609014Structure (ST_9a87c036f8540c84242b92bb54609014Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAllowDrag = ConvertToRestWithoutDefaults(s.ssAllowDrag, false);
AttrAllowEdit = ConvertToRestWithoutDefaults(s.ssAllowEdit, false);
AttrStroke = ConvertToRestWithoutDefaults(s.ssStroke, new ST_c2a46cf64d2acc4b38d805712495224cStructure(), ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructureDelegate(config));
AttrFill = ConvertToRestWithoutDefaults(s.ssFill, new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure(), ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructureDelegate(config));
  } else {
AttrAllowDrag = (bool?) s.ssAllowDrag;
AttrAllowEdit = (bool?) s.ssAllowEdit;
AttrStroke = ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructure(s.ssStroke, config);
AttrFill = ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructure(s.ssFill, config);
  }
}

public static ST_9a87c036f8540c84242b92bb54609014Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_9a87c036f8540c84242b92bb54609014Structure obj) { 
  ST_9a87c036f8540c84242b92bb54609014Structure s = new ST_9a87c036f8540c84242b92bb54609014Structure();
  if(obj != null) {
  s.ssAllowDrag = obj.AttrAllowDrag == null ? false : obj.AttrAllowDrag.Value;
  s.ssAllowEdit = obj.AttrAllowEdit == null ? false : obj.AttrAllowEdit.Value;
  s.ssStroke = ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.ToStructure(obj.AttrStroke);
  s.ssFill = ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.ToStructure(obj.AttrFill);
  }
  return s;
}

public static Func<ST_9a87c036f8540c84242b92bb54609014Structure, ssOutSystemsMaps.RestRecords.RESTST_9a87c036f8540c84242b92bb54609014Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9a87c036f8540c84242b92bb54609014Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_9a87c036f8540c84242b92bb54609014Structure FromStructure(ST_9a87c036f8540c84242b92bb54609014Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_9a87c036f8540c84242b92bb54609014Structure(s, config);
}

}


