using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord
public class RESTRC_c3613394da5ea68f302177112ad784ed : AbstractRESTStructure<RC_c3613394da5ea68f302177112ad784ed> {
[JsonProperty("Direction")]
public string AttrDirection;

[JsonProperty("InitialValue")]
public decimal? AttrInitialValue;

[JsonProperty("MaxValue")]
public decimal? AttrMaxValue;

[JsonProperty("MinValue")]
public decimal? AttrMinValue;

[JsonProperty("Step")]
public decimal? AttrStep;

[JsonProperty("ChangeEventDuringSlide")]
public bool? AttrChangeEventDuringSlide;

[JsonProperty("IsDisabled")]
public bool? AttrIsDisabled;

[JsonProperty("IsVertical")]
public bool? AttrIsVertical;

[JsonProperty("ShowPips")]
public bool? AttrShowPips;

[JsonProperty("PipsStep")]
public int? AttrPipsStep;

[JsonProperty("VerticalHeight")]
public int? AttrVerticalHeight;

public RESTRC_c3613394da5ea68f302177112ad784ed() { }

public RESTRC_c3613394da5ea68f302177112ad784ed (RC_c3613394da5ea68f302177112ad784ed s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirection = ConvertToRestWithoutDefaults(s.ssDirection, "");
AttrInitialValue = ConvertToRestWithoutDefaults(s.ssInitialValue, 0.0M);
AttrMaxValue = ConvertToRestWithoutDefaults(s.ssMaxValue, 0.0M);
AttrMinValue = ConvertToRestWithoutDefaults(s.ssMinValue, 0.0M);
AttrStep = ConvertToRestWithoutDefaults(s.ssStep, 0.0M);
AttrChangeEventDuringSlide = ConvertToRestWithoutDefaults(s.ssChangeEventDuringSlide, false);
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrIsVertical = ConvertToRestWithoutDefaults(s.ssIsVertical, false);
AttrShowPips = ConvertToRestWithoutDefaults(s.ssShowPips, false);
AttrPipsStep = ConvertToRestWithoutDefaults(s.ssPipsStep, 0);
AttrVerticalHeight = ConvertToRestWithoutDefaults(s.ssVerticalHeight, 0);
  } else {
AttrDirection = s.ssDirection;
AttrInitialValue = (decimal?) s.ssInitialValue;
AttrMaxValue = (decimal?) s.ssMaxValue;
AttrMinValue = (decimal?) s.ssMinValue;
AttrStep = (decimal?) s.ssStep;
AttrChangeEventDuringSlide = (bool?) s.ssChangeEventDuringSlide;
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrIsVertical = (bool?) s.ssIsVertical;
AttrShowPips = (bool?) s.ssShowPips;
AttrPipsStep = (int?) s.ssPipsStep;
AttrVerticalHeight = (int?) s.ssVerticalHeight;
  }
}

public static RC_c3613394da5ea68f302177112ad784ed ToStructure(ssOutSystemsUI.RestRecords.RESTRC_c3613394da5ea68f302177112ad784ed obj) { 
  RC_c3613394da5ea68f302177112ad784ed s = new RC_c3613394da5ea68f302177112ad784ed();
  if(obj != null) {
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssInitialValue = obj.AttrInitialValue == null ? 0.0M : obj.AttrInitialValue.Value;
  s.ssMaxValue = obj.AttrMaxValue == null ? 0.0M : obj.AttrMaxValue.Value;
  s.ssMinValue = obj.AttrMinValue == null ? 0.0M : obj.AttrMinValue.Value;
  s.ssStep = obj.AttrStep == null ? 0.0M : obj.AttrStep.Value;
  s.ssChangeEventDuringSlide = obj.AttrChangeEventDuringSlide == null ? false : obj.AttrChangeEventDuringSlide.Value;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  s.ssIsVertical = obj.AttrIsVertical == null ? false : obj.AttrIsVertical.Value;
  s.ssShowPips = obj.AttrShowPips == null ? false : obj.AttrShowPips.Value;
  s.ssPipsStep = obj.AttrPipsStep == null ? 0 : obj.AttrPipsStep.Value;
  s.ssVerticalHeight = obj.AttrVerticalHeight == null ? 0 : obj.AttrVerticalHeight.Value;
  }
  return s;
}

public static Func<RC_c3613394da5ea68f302177112ad784ed, ssOutSystemsUI.RestRecords.RESTRC_c3613394da5ea68f302177112ad784ed> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c3613394da5ea68f302177112ad784ed s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_c3613394da5ea68f302177112ad784ed FromStructure(RC_c3613394da5ea68f302177112ad784ed s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_c3613394da5ea68f302177112ad784ed(s, config);
}

}


