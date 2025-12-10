using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TimePickerOptionalConfigsRecord
public class RESTRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 : AbstractRESTStructure<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88> {
[JsonProperty("TimePickerOptionalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_b96c67f06fdfae580256b7081d85460dStructure AttrTimePickerOptionalConfigs;

public RESTRC_bb80a04f7ea6a5bb3d33db9b2bca4c88() { }

public RESTRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 (RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTimePickerOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTTimePickerOptionalConfigs, new ST_b96c67f06fdfae580256b7081d85460dStructure(), ssOutSystemsUI.RestRecords.RESTST_b96c67f06fdfae580256b7081d85460dStructure.FromStructureDelegate(config));
  } else {
AttrTimePickerOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_b96c67f06fdfae580256b7081d85460dStructure.FromStructure(s.ssSTTimePickerOptionalConfigs, config);
  }
}

public static RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 obj) { 
  RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s = new RC_bb80a04f7ea6a5bb3d33db9b2bca4c88();
  if(obj != null) {
  s.ssSTTimePickerOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_b96c67f06fdfae580256b7081d85460dStructure.ToStructure(obj.AttrTimePickerOptionalConfigs);
  }
  return s;
}

public static Func<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88, ssOutSystemsUI.RestRecords.RESTRC_bb80a04f7ea6a5bb3d33db9b2bca4c88> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_bb80a04f7ea6a5bb3d33db9b2bca4c88 FromStructure(RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_bb80a04f7ea6a5bb3d33db9b2bca4c88(s, config);
}

}


