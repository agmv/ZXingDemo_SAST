using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Verbosity
public class RESTEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord : AbstractRESTStructure<EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord> {
[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord() { }

public RESTEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord (EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
AttrOrder = ConvertToRestWithoutDefaults(s.ssOrder, 0);
  } else {
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord obj) { 
  EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord s = new EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord FromStructure(EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord(s, config);
}

}


