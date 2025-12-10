using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressBarOptionalConfigs
public class RESTST_8391f9d0c6b78f74493c47987669deecStructure : AbstractRESTStructure<ST_8391f9d0c6b78f74493c47987669deecStructure> {
[JsonProperty("Shape")]
public string AttrShape;

[JsonProperty("AnimateInitialProgress")]
public bool? AttrAnimateInitialProgress;

public RESTST_8391f9d0c6b78f74493c47987669deecStructure() { }

public RESTST_8391f9d0c6b78f74493c47987669deecStructure (ST_8391f9d0c6b78f74493c47987669deecStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShape = ConvertToRestWithoutDefaults(s.ssShape, (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"))).ssShape);
AttrAnimateInitialProgress = ConvertToRestWithoutDefaults(s.ssAnimateInitialProgress, true);
  } else {
AttrShape = s.ssShape;
AttrAnimateInitialProgress = (bool?) s.ssAnimateInitialProgress;
  }
}

public static ST_8391f9d0c6b78f74493c47987669deecStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_8391f9d0c6b78f74493c47987669deecStructure obj) { 
  ST_8391f9d0c6b78f74493c47987669deecStructure s = new ST_8391f9d0c6b78f74493c47987669deecStructure();
  if(obj != null) {
  s.ssShape = obj.AttrShape == null ? (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"))).ssShape : obj.AttrShape;
  s.ssAnimateInitialProgress = obj.AttrAnimateInitialProgress == null ? true : obj.AttrAnimateInitialProgress.Value;
  }
  return s;
}

public static Func<ST_8391f9d0c6b78f74493c47987669deecStructure, ssOutSystemsUI.RestRecords.RESTST_8391f9d0c6b78f74493c47987669deecStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8391f9d0c6b78f74493c47987669deecStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_8391f9d0c6b78f74493c47987669deecStructure FromStructure(ST_8391f9d0c6b78f74493c47987669deecStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_8391f9d0c6b78f74493c47987669deecStructure(s, config);
}

}


