using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TimePickerOptionalConfigsRecord
public class JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 : AbstractRESTStructure<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88> {
[JsonProperty("TimePickerOptionalConfigs")]
[JsonPropertyName("TimePickerOptionalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure AttrTimePickerOptionalConfigs;

public JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88() { }

public JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 (RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTimePickerOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTTimePickerOptionalConfigs, new ST_b96c67f06fdfae580256b7081d85460dStructure(), ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure.FromStructureDelegate(config));
  } else {
AttrTimePickerOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure.FromStructure(s.ssSTTimePickerOptionalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88, RC_bb80a04f7ea6a5bb3d33db9b2bca4c88> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s) => ToStructure(s, config);
}
public static RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 obj, IBehaviorsConfiguration config) { 
  RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s = new RC_bb80a04f7ea6a5bb3d33db9b2bca4c88();
  if(obj != null) {
  s.ssSTTimePickerOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure.ToStructure(obj.AttrTimePickerOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88, ssOutSystemsUI.RestRecords.JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 FromStructure(RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_bb80a04f7ea6a5bb3d33db9b2bca4c88(s, config);
}

}


