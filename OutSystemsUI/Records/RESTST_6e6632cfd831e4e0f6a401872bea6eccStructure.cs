using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// OverflowMenu_InternalConfigs
public class RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure : AbstractRESTStructure<ST_6e6632cfd831e4e0f6a401872bea6eccStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("BalloonPosition")]
public string AttrBalloonPosition;

[JsonProperty("BalloonShape")]
public string AttrBalloonShape;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure() { }

public RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure (ST_6e6632cfd831e4e0f6a401872bea6eccStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrBalloonPosition = ConvertToRestWithoutDefaults(s.ssBalloonPosition, (ENFloatingPositionEntity.GetRecordByKey(ObjectKey.Parse("iXgvXFSndk6SAnThrfZKqA"))).ssPosition);
AttrBalloonShape = ConvertToRestWithoutDefaults(s.ssBalloonShape, (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("OTUJ0X3XnUONUwPS4AU6Ug"))).ssShape);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrBalloonPosition = s.ssBalloonPosition;
AttrBalloonShape = s.ssBalloonShape;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_6e6632cfd831e4e0f6a401872bea6eccStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure obj) { 
  ST_6e6632cfd831e4e0f6a401872bea6eccStructure s = new ST_6e6632cfd831e4e0f6a401872bea6eccStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssBalloonPosition = obj.AttrBalloonPosition == null ? (ENFloatingPositionEntity.GetRecordByKey(ObjectKey.Parse("iXgvXFSndk6SAnThrfZKqA"))).ssPosition : obj.AttrBalloonPosition;
  s.ssBalloonShape = obj.AttrBalloonShape == null ? (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("OTUJ0X3XnUONUwPS4AU6Ug"))).ssShape : obj.AttrBalloonShape;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_6e6632cfd831e4e0f6a401872bea6eccStructure, ssOutSystemsUI.RestRecords.RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6e6632cfd831e4e0f6a401872bea6eccStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure FromStructure(ST_6e6632cfd831e4e0f6a401872bea6eccStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure(s, config);
}

}


