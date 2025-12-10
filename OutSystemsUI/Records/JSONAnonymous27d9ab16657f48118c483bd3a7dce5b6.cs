using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthPicker_InternalConfigRecord
public class JSONRC_60f7027c05b269e64f9c4c41640d4643 : AbstractRESTStructure<RC_60f7027c05b269e64f9c4c41640d4643> {
[JsonProperty("MonthPicker_InternalConfig")]
[JsonPropertyName("MonthPicker_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure AttrMonthPicker_InternalConfig;

public JSONRC_60f7027c05b269e64f9c4c41640d4643() { }

public JSONRC_60f7027c05b269e64f9c4c41640d4643 (RC_60f7027c05b269e64f9c4c41640d4643 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonthPicker_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTMonthPicker_InternalConfig, new ST_6f97d9724e66f51b47133aa003a9e610Structure(), ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure.FromStructureDelegate(config));
  } else {
AttrMonthPicker_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure.FromStructure(s.ssSTMonthPicker_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_60f7027c05b269e64f9c4c41640d4643, RC_60f7027c05b269e64f9c4c41640d4643> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_60f7027c05b269e64f9c4c41640d4643 s) => ToStructure(s, config);
}
public static RC_60f7027c05b269e64f9c4c41640d4643 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_60f7027c05b269e64f9c4c41640d4643 obj, IBehaviorsConfiguration config) { 
  RC_60f7027c05b269e64f9c4c41640d4643 s = new RC_60f7027c05b269e64f9c4c41640d4643();
  if(obj != null) {
  s.ssSTMonthPicker_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_6f97d9724e66f51b47133aa003a9e610Structure.ToStructure(obj.AttrMonthPicker_InternalConfig, config);
  }
  return s;
}

public static Func<RC_60f7027c05b269e64f9c4c41640d4643, ssOutSystemsUI.RestRecords.JSONRC_60f7027c05b269e64f9c4c41640d4643> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60f7027c05b269e64f9c4c41640d4643 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_60f7027c05b269e64f9c4c41640d4643 FromStructure(RC_60f7027c05b269e64f9c4c41640d4643 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_60f7027c05b269e64f9c4c41640d4643(s, config);
}

}


