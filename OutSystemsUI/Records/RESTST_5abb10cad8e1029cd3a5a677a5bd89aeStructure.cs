using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSlider_InternalConfig
public class RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure : AbstractRESTStructure<ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("MinValue")]
public decimal? AttrMinValue;

[JsonProperty("MaxValue")]
public decimal? AttrMaxValue;

[JsonProperty("StartingValueFrom")]
public decimal? AttrStartingValueFrom;

[JsonProperty("StartingValueTo")]
public decimal? AttrStartingValueTo;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("Step")]
public decimal? AttrStep;

[JsonProperty("ShowTickMarks")]
public bool? AttrShowTickMarks;

[JsonProperty("TickMarksInterval")]
public int? AttrTickMarksInterval;

[JsonProperty("IsDisabled")]
public bool? AttrIsDisabled;

[JsonProperty("Orientation")]
public string AttrOrientation;

[JsonProperty("Size")]
public string AttrSize;

[JsonProperty("ShowFloatingLabel")]
public bool? AttrShowFloatingLabel;

[JsonProperty("InitialValueFrom")]
public decimal? AttrInitialValueFrom;

[JsonProperty("InitialValueTo")]
public decimal? AttrInitialValueTo;

public RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure() { }

public RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure (ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrMinValue = ConvertToRestWithoutDefaults(s.ssMinValue, 0.0M);
AttrMaxValue = ConvertToRestWithoutDefaults(s.ssMaxValue, 0.0M);
AttrStartingValueFrom = ConvertToRestWithoutDefaults(s.ssStartingValueFrom, 0.0M);
AttrStartingValueTo = ConvertToRestWithoutDefaults(s.ssStartingValueTo, 0.0M);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
AttrStep = ConvertToRestWithoutDefaults(s.ssStep, (((decimal)1)));
AttrShowTickMarks = ConvertToRestWithoutDefaults(s.ssShowTickMarks, true);
AttrTickMarksInterval = ConvertToRestWithoutDefaults(s.ssTickMarksInterval, 0);
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrOrientation = ConvertToRestWithoutDefaults(s.ssOrientation, (ENOrientationEntity.GetRecordByKey(ObjectKey.Parse("FlS0fEo8eEGcW4fsz2_66A"))).ssOrientation);
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, "100%");
AttrShowFloatingLabel = ConvertToRestWithoutDefaults(s.ssShowFloatingLabel, false);
AttrInitialValueFrom = ConvertToRestWithoutDefaults(s.ssInitialValueFrom, 0.0M);
AttrInitialValueTo = ConvertToRestWithoutDefaults(s.ssInitialValueTo, 0.0M);
  } else {
AttrUniqueId = s.ssUniqueId;
AttrMinValue = (decimal?) s.ssMinValue;
AttrMaxValue = (decimal?) s.ssMaxValue;
AttrStartingValueFrom = (decimal?) s.ssStartingValueFrom;
AttrStartingValueTo = (decimal?) s.ssStartingValueTo;
AttrExtendedClass = s.ssExtendedClass;
AttrStep = (decimal?) s.ssStep;
AttrShowTickMarks = (bool?) s.ssShowTickMarks;
AttrTickMarksInterval = (int?) s.ssTickMarksInterval;
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrOrientation = s.ssOrientation;
AttrSize = s.ssSize;
AttrShowFloatingLabel = (bool?) s.ssShowFloatingLabel;
AttrInitialValueFrom = (decimal?) s.ssInitialValueFrom;
AttrInitialValueTo = (decimal?) s.ssInitialValueTo;
  }
}

public static ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure obj) { 
  ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure s = new ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssMinValue = obj.AttrMinValue == null ? 0.0M : obj.AttrMinValue.Value;
  s.ssMaxValue = obj.AttrMaxValue == null ? 0.0M : obj.AttrMaxValue.Value;
  s.ssStartingValueFrom = obj.AttrStartingValueFrom == null ? 0.0M : obj.AttrStartingValueFrom.Value;
  s.ssStartingValueTo = obj.AttrStartingValueTo == null ? 0.0M : obj.AttrStartingValueTo.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssStep = obj.AttrStep == null ? (((decimal)1)) : obj.AttrStep.Value;
  s.ssShowTickMarks = obj.AttrShowTickMarks == null ? true : obj.AttrShowTickMarks.Value;
  s.ssTickMarksInterval = obj.AttrTickMarksInterval == null ? 0 : obj.AttrTickMarksInterval.Value;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  s.ssOrientation = obj.AttrOrientation == null ? (ENOrientationEntity.GetRecordByKey(ObjectKey.Parse("FlS0fEo8eEGcW4fsz2_66A"))).ssOrientation : obj.AttrOrientation;
  s.ssSize = obj.AttrSize == null ? "100%" : obj.AttrSize;
  s.ssShowFloatingLabel = obj.AttrShowFloatingLabel == null ? false : obj.AttrShowFloatingLabel.Value;
  s.ssInitialValueFrom = obj.AttrInitialValueFrom == null ? 0.0M : obj.AttrInitialValueFrom.Value;
  s.ssInitialValueTo = obj.AttrInitialValueTo == null ? 0.0M : obj.AttrInitialValueTo.Value;
  }
  return s;
}

public static Func<ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure, ssOutSystemsUI.RestRecords.RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure FromStructure(ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure(s, config);
}

}


