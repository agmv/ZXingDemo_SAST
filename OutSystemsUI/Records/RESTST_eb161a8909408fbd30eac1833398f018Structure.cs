using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressCircleOptionalConfigs
public class RESTST_eb161a8909408fbd30eac1833398f018Structure : AbstractRESTStructure<ST_eb161a8909408fbd30eac1833398f018Structure> {
[JsonProperty("Shape")]
public string AttrShape;

[JsonProperty("AnimateInitialProgress")]
public bool? AttrAnimateInitialProgress;

public RESTST_eb161a8909408fbd30eac1833398f018Structure() { }

public RESTST_eb161a8909408fbd30eac1833398f018Structure (ST_eb161a8909408fbd30eac1833398f018Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShape = ConvertToRestWithoutDefaults(s.ssShape, (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"))).ssShape);
AttrAnimateInitialProgress = ConvertToRestWithoutDefaults(s.ssAnimateInitialProgress, true);
  } else {
AttrShape = s.ssShape;
AttrAnimateInitialProgress = (bool?) s.ssAnimateInitialProgress;
  }
}

public static ST_eb161a8909408fbd30eac1833398f018Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_eb161a8909408fbd30eac1833398f018Structure obj) { 
  ST_eb161a8909408fbd30eac1833398f018Structure s = new ST_eb161a8909408fbd30eac1833398f018Structure();
  if(obj != null) {
  s.ssShape = obj.AttrShape == null ? (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"))).ssShape : obj.AttrShape;
  s.ssAnimateInitialProgress = obj.AttrAnimateInitialProgress == null ? true : obj.AttrAnimateInitialProgress.Value;
  }
  return s;
}

public static Func<ST_eb161a8909408fbd30eac1833398f018Structure, ssOutSystemsUI.RestRecords.RESTST_eb161a8909408fbd30eac1833398f018Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_eb161a8909408fbd30eac1833398f018Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_eb161a8909408fbd30eac1833398f018Structure FromStructure(ST_eb161a8909408fbd30eac1833398f018Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_eb161a8909408fbd30eac1833398f018Structure(s, config);
}

}


