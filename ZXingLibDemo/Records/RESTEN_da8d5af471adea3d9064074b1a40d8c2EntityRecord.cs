using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Type
public class RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord : AbstractRESTStructure<EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord> {
[JsonProperty("MapType")]
public string AttrMapType;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord() { }

public RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord (EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMapType = s.ssMapType;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrMapType = s.ssMapType;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord ToStructure(ssZXingLibDemo.RestRecords.RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord obj) { 
  EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord s = new EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord();
  if(obj != null) {
  s.ssMapType = obj.AttrMapType == null ? "" : obj.AttrMapType;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord, ssZXingLibDemo.RestRecords.RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord FromStructure(EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord(s, config);
}

}


