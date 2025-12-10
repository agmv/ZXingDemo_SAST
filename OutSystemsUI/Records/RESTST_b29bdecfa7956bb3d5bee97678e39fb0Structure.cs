using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressBar_InternalConfig
public class RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure : AbstractRESTStructure<ST_b29bdecfa7956bb3d5bee97678e39fb0Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("Type")]
public string AttrType;

[JsonProperty("Progress")]
public int? AttrProgress;

[JsonProperty("ProgressColor")]
public string AttrProgressColor;

[JsonProperty("TrailColor")]
public string AttrTrailColor;

[JsonProperty("Thickness")]
public int? AttrThickness;

[JsonProperty("Shape")]
public string AttrShape;

[JsonProperty("AnimateInitialProgress")]
public bool? AttrAnimateInitialProgress;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("InitialProgress")]
public int? AttrInitialProgress;

public RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure() { }

public RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure (ST_b29bdecfa7956bb3d5bee97678e39fb0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrType = ConvertToRestWithoutDefaults(s.ssType, "");
AttrProgress = ConvertToRestWithoutDefaults(s.ssProgress, 0);
AttrProgressColor = ConvertToRestWithoutDefaults(s.ssProgressColor, "");
AttrTrailColor = ConvertToRestWithoutDefaults(s.ssTrailColor, "");
AttrThickness = ConvertToRestWithoutDefaults(s.ssThickness, 0);
AttrShape = ConvertToRestWithoutDefaults(s.ssShape, (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"))).ssShape);
AttrAnimateInitialProgress = ConvertToRestWithoutDefaults(s.ssAnimateInitialProgress, true);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
AttrInitialProgress = ConvertToRestWithoutDefaults(s.ssInitialProgress, 0);
  } else {
AttrUniqueId = s.ssUniqueId;
AttrType = s.ssType;
AttrProgress = (int?) s.ssProgress;
AttrProgressColor = s.ssProgressColor;
AttrTrailColor = s.ssTrailColor;
AttrThickness = (int?) s.ssThickness;
AttrShape = s.ssShape;
AttrAnimateInitialProgress = (bool?) s.ssAnimateInitialProgress;
AttrExtendedClass = s.ssExtendedClass;
AttrInitialProgress = (int?) s.ssInitialProgress;
  }
}

public static ST_b29bdecfa7956bb3d5bee97678e39fb0Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure obj) { 
  ST_b29bdecfa7956bb3d5bee97678e39fb0Structure s = new ST_b29bdecfa7956bb3d5bee97678e39fb0Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  s.ssProgress = obj.AttrProgress == null ? 0 : obj.AttrProgress.Value;
  s.ssProgressColor = obj.AttrProgressColor == null ? "" : obj.AttrProgressColor;
  s.ssTrailColor = obj.AttrTrailColor == null ? "" : obj.AttrTrailColor;
  s.ssThickness = obj.AttrThickness == null ? 0 : obj.AttrThickness.Value;
  s.ssShape = obj.AttrShape == null ? (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"))).ssShape : obj.AttrShape;
  s.ssAnimateInitialProgress = obj.AttrAnimateInitialProgress == null ? true : obj.AttrAnimateInitialProgress.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssInitialProgress = obj.AttrInitialProgress == null ? 0 : obj.AttrInitialProgress.Value;
  }
  return s;
}

public static Func<ST_b29bdecfa7956bb3d5bee97678e39fb0Structure, ssOutSystemsUI.RestRecords.RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b29bdecfa7956bb3d5bee97678e39fb0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure FromStructure(ST_b29bdecfa7956bb3d5bee97678e39fb0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure(s, config);
}

}


