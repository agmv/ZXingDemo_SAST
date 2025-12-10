using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Position
public class RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord : AbstractRESTStructure<EN_5d1279724e719322292e34ef3c5500a0EntityRecord> {
[JsonProperty("Position")]
public string AttrPosition;

public RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord() { }

public RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord (EN_5d1279724e719322292e34ef3c5500a0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = s.ssPosition;
  } else {
AttrPosition = s.ssPosition;
  }
}

public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord ToStructure(ssZXingLibDemo.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord obj) { 
  EN_5d1279724e719322292e34ef3c5500a0EntityRecord s = new EN_5d1279724e719322292e34ef3c5500a0EntityRecord();
  if(obj != null) {
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  }
  return s;
}

public static Func<EN_5d1279724e719322292e34ef3c5500a0EntityRecord, ssZXingLibDemo.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5d1279724e719322292e34ef3c5500a0EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord FromStructure(EN_5d1279724e719322292e34ef3c5500a0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord(s, config);
}

}


