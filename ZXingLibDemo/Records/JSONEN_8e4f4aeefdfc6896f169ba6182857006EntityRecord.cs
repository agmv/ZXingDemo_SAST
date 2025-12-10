using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// CodeDefaults
public class JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord : AbstractRESTStructure<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> {
[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Sample")]
[JsonPropertyName("Sample")]
public string AttrSample;

[JsonProperty("Margin")]
[JsonPropertyName("Margin")]
public int? AttrMargin;

[JsonProperty("Width")]
[JsonPropertyName("Width")]
public int? AttrWidth;

[JsonProperty("Height")]
[JsonPropertyName("Height")]
public int? AttrHeight;

public JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord() { }

public JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord (EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
AttrSample = ConvertToRestWithoutDefaults(s.ssSample, "");
AttrMargin = ConvertToRestWithoutDefaults(s.ssMargin, 0);
AttrWidth = ConvertToRestWithoutDefaults(s.ssWidth, 0);
AttrHeight = ConvertToRestWithoutDefaults(s.ssHeight, 0);
  } else {
AttrLabel = s.ssLabel;
AttrSample = s.ssSample;
AttrMargin = (int?) s.ssMargin;
AttrWidth = (int?) s.ssWidth;
AttrHeight = (int?) s.ssHeight;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord, EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord s) => ToStructure(s, config);
}
public static EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord ToStructure(ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord s = new EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssSample = obj.AttrSample == null ? "" : obj.AttrSample;
  s.ssMargin = obj.AttrMargin == null ? 0 : obj.AttrMargin.Value;
  s.ssWidth = obj.AttrWidth == null ? 0 : obj.AttrWidth.Value;
  s.ssHeight = obj.AttrHeight == null ? 0 : obj.AttrHeight.Value;
  }
  return s;
}

public static Func<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord, ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord FromStructure(EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord(s, config);
}

}


