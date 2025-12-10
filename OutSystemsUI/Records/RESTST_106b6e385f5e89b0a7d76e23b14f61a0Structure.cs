using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// BottomSheet_InternalConfig
public class RESTST_106b6e385f5e89b0a7d76e23b14f61a0Structure : AbstractRESTStructure<ST_106b6e385f5e89b0a7d76e23b14f61a0Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("Shape")]
public string AttrShape;

[JsonProperty("ShowHandler")]
public bool? AttrShowHandler;

public RESTST_106b6e385f5e89b0a7d76e23b14f61a0Structure() { }

public RESTST_106b6e385f5e89b0a7d76e23b14f61a0Structure (ST_106b6e385f5e89b0a7d76e23b14f61a0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
AttrShape = ConvertToRestWithoutDefaults(s.ssShape, (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("OTUJ0X3XnUONUwPS4AU6Ug"))).ssShape);
AttrShowHandler = ConvertToRestWithoutDefaults(s.ssShowHandler, true);
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
AttrShape = s.ssShape;
AttrShowHandler = (bool?) s.ssShowHandler;
  }
}

public static ST_106b6e385f5e89b0a7d76e23b14f61a0Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_106b6e385f5e89b0a7d76e23b14f61a0Structure obj) { 
  ST_106b6e385f5e89b0a7d76e23b14f61a0Structure s = new ST_106b6e385f5e89b0a7d76e23b14f61a0Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssShape = obj.AttrShape == null ? (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("OTUJ0X3XnUONUwPS4AU6Ug"))).ssShape : obj.AttrShape;
  s.ssShowHandler = obj.AttrShowHandler == null ? true : obj.AttrShowHandler.Value;
  }
  return s;
}

public static Func<ST_106b6e385f5e89b0a7d76e23b14f61a0Structure, ssOutSystemsUI.RestRecords.RESTST_106b6e385f5e89b0a7d76e23b14f61a0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_106b6e385f5e89b0a7d76e23b14f61a0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_106b6e385f5e89b0a7d76e23b14f61a0Structure FromStructure(ST_106b6e385f5e89b0a7d76e23b14f61a0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_106b6e385f5e89b0a7d76e23b14f61a0Structure(s, config);
}

}


