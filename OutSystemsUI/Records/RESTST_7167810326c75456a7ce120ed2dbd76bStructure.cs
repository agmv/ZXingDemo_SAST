using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSliderOptionalConfigs
public class RESTST_7167810326c75456a7ce120ed2dbd76bStructure : AbstractRESTStructure<ST_7167810326c75456a7ce120ed2dbd76bStructure> {
[JsonProperty("ShowFloatingLabel")]
public bool? AttrShowFloatingLabel;

[JsonProperty("Step")]
public decimal? AttrStep;

[JsonProperty("ShowTickMarks")]
public bool? AttrShowTickMarks;

[JsonProperty("TickMarksInterval")]
public int? AttrTickMarksInterval;

[JsonProperty("IsDisabled")]
public bool? AttrIsDisabled;

public RESTST_7167810326c75456a7ce120ed2dbd76bStructure() { }

public RESTST_7167810326c75456a7ce120ed2dbd76bStructure (ST_7167810326c75456a7ce120ed2dbd76bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShowFloatingLabel = ConvertToRestWithoutDefaults(s.ssShowFloatingLabel, false);
AttrStep = ConvertToRestWithoutDefaults(s.ssStep, (((decimal)1)));
AttrShowTickMarks = ConvertToRestWithoutDefaults(s.ssShowTickMarks, true);
AttrTickMarksInterval = ConvertToRestWithoutDefaults(s.ssTickMarksInterval, 0);
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
  } else {
AttrShowFloatingLabel = (bool?) s.ssShowFloatingLabel;
AttrStep = (decimal?) s.ssStep;
AttrShowTickMarks = (bool?) s.ssShowTickMarks;
AttrTickMarksInterval = (int?) s.ssTickMarksInterval;
AttrIsDisabled = (bool?) s.ssIsDisabled;
  }
}

public static ST_7167810326c75456a7ce120ed2dbd76bStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_7167810326c75456a7ce120ed2dbd76bStructure obj) { 
  ST_7167810326c75456a7ce120ed2dbd76bStructure s = new ST_7167810326c75456a7ce120ed2dbd76bStructure();
  if(obj != null) {
  s.ssShowFloatingLabel = obj.AttrShowFloatingLabel == null ? false : obj.AttrShowFloatingLabel.Value;
  s.ssStep = obj.AttrStep == null ? (((decimal)1)) : obj.AttrStep.Value;
  s.ssShowTickMarks = obj.AttrShowTickMarks == null ? true : obj.AttrShowTickMarks.Value;
  s.ssTickMarksInterval = obj.AttrTickMarksInterval == null ? 0 : obj.AttrTickMarksInterval.Value;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  }
  return s;
}

public static Func<ST_7167810326c75456a7ce120ed2dbd76bStructure, ssOutSystemsUI.RestRecords.RESTST_7167810326c75456a7ce120ed2dbd76bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7167810326c75456a7ce120ed2dbd76bStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_7167810326c75456a7ce120ed2dbd76bStructure FromStructure(ST_7167810326c75456a7ce120ed2dbd76bStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_7167810326c75456a7ce120ed2dbd76bStructure(s, config);
}

}


