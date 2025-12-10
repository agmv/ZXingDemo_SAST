using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FlatpickrConfigs
public class RESTST_14b00646f6cd842655571448758d0a23Structure : AbstractRESTStructure<ST_14b00646f6cd842655571448758d0a23Structure> {
[JsonProperty("altInputClass")]
public string AttraltInputClass;

[JsonProperty("allowInvalidPreload")]
public string AttrallowInvalidPreload;

[JsonProperty("ariaDateFormat")]
public string AttrariaDateFormat;

[JsonProperty("clickOpens")]
public string AttrclickOpens;

[JsonProperty("enableSeconds")]
public string AttrenableSeconds;

[JsonProperty("hourIncrement")]
public int? AttrhourIncrement;

[JsonProperty("inline")]
public string Attrinline;

[JsonProperty("minuteIncrement")]
public int? AttrminuteIncrement;

[JsonProperty("nextArrow")]
public string AttrnextArrow;

[JsonProperty("position")]
public string Attrposition;

[JsonProperty("positionElement")]
public string AttrpositionElement;

[JsonProperty("prevArrow")]
public string AttrprevArrow;

[JsonProperty("shorthandCurrentMonth")]
public string AttrshorthandCurrentMonth;

[JsonProperty("static")]
public string Attrstatic;

[JsonProperty("showMonths")]
public int? AttrshowMonths;

[JsonProperty("wrap")]
public string Attrwrap;

[JsonProperty("monthSelectorType")]
public string AttrmonthSelectorType;

public RESTST_14b00646f6cd842655571448758d0a23Structure() { }

public RESTST_14b00646f6cd842655571448758d0a23Structure (ST_14b00646f6cd842655571448758d0a23Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttraltInputClass = ConvertToRestWithoutDefaults(s.ssaltInputClass, "undefined");
AttrallowInvalidPreload = ConvertToRestWithoutDefaults(s.ssallowInvalidPreload, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrariaDateFormat = ConvertToRestWithoutDefaults(s.ssariaDateFormat, "undefined");
AttrclickOpens = ConvertToRestWithoutDefaults(s.ssclickOpens, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrenableSeconds = ConvertToRestWithoutDefaults(s.ssenableSeconds, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrhourIncrement = ConvertToRestWithoutDefaults(s.sshourIncrement, 0);
Attrinline = ConvertToRestWithoutDefaults(s.ssinline, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrminuteIncrement = ConvertToRestWithoutDefaults(s.ssminuteIncrement, 0);
AttrnextArrow = ConvertToRestWithoutDefaults(s.ssnextArrow, "undefined");
Attrposition = ConvertToRestWithoutDefaults(s.ssposition, "undefined");
AttrpositionElement = ConvertToRestWithoutDefaults(s.sspositionElement, "undefined");
AttrprevArrow = ConvertToRestWithoutDefaults(s.ssprevArrow, "undefined");
AttrshorthandCurrentMonth = ConvertToRestWithoutDefaults(s.ssshorthandCurrentMonth, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
Attrstatic = ConvertToRestWithoutDefaults(s.ssstatic, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrshowMonths = ConvertToRestWithoutDefaults(s.ssshowMonths, 0);
Attrwrap = ConvertToRestWithoutDefaults(s.sswrap, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrmonthSelectorType = ConvertToRestWithoutDefaults(s.ssmonthSelectorType, "undefined");
  } else {
AttraltInputClass = s.ssaltInputClass;
AttrallowInvalidPreload = s.ssallowInvalidPreload;
AttrariaDateFormat = s.ssariaDateFormat;
AttrclickOpens = s.ssclickOpens;
AttrenableSeconds = s.ssenableSeconds;
AttrhourIncrement = (int?) s.sshourIncrement;
Attrinline = s.ssinline;
AttrminuteIncrement = (int?) s.ssminuteIncrement;
AttrnextArrow = s.ssnextArrow;
Attrposition = s.ssposition;
AttrpositionElement = s.sspositionElement;
AttrprevArrow = s.ssprevArrow;
AttrshorthandCurrentMonth = s.ssshorthandCurrentMonth;
Attrstatic = s.ssstatic;
AttrshowMonths = (int?) s.ssshowMonths;
Attrwrap = s.sswrap;
AttrmonthSelectorType = s.ssmonthSelectorType;
  }
}

public static ST_14b00646f6cd842655571448758d0a23Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_14b00646f6cd842655571448758d0a23Structure obj) { 
  ST_14b00646f6cd842655571448758d0a23Structure s = new ST_14b00646f6cd842655571448758d0a23Structure();
  if(obj != null) {
  s.ssaltInputClass = obj.AttraltInputClass == null ? "undefined" : obj.AttraltInputClass;
  s.ssallowInvalidPreload = obj.AttrallowInvalidPreload == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrallowInvalidPreload;
  s.ssariaDateFormat = obj.AttrariaDateFormat == null ? "undefined" : obj.AttrariaDateFormat;
  s.ssclickOpens = obj.AttrclickOpens == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrclickOpens;
  s.ssenableSeconds = obj.AttrenableSeconds == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrenableSeconds;
  s.sshourIncrement = obj.AttrhourIncrement == null ? 0 : obj.AttrhourIncrement.Value;
  s.ssinline = obj.Attrinline == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrinline;
  s.ssminuteIncrement = obj.AttrminuteIncrement == null ? 0 : obj.AttrminuteIncrement.Value;
  s.ssnextArrow = obj.AttrnextArrow == null ? "undefined" : obj.AttrnextArrow;
  s.ssposition = obj.Attrposition == null ? "undefined" : obj.Attrposition;
  s.sspositionElement = obj.AttrpositionElement == null ? "undefined" : obj.AttrpositionElement;
  s.ssprevArrow = obj.AttrprevArrow == null ? "undefined" : obj.AttrprevArrow;
  s.ssshorthandCurrentMonth = obj.AttrshorthandCurrentMonth == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrshorthandCurrentMonth;
  s.ssstatic = obj.Attrstatic == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrstatic;
  s.ssshowMonths = obj.AttrshowMonths == null ? 0 : obj.AttrshowMonths.Value;
  s.sswrap = obj.Attrwrap == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrwrap;
  s.ssmonthSelectorType = obj.AttrmonthSelectorType == null ? "undefined" : obj.AttrmonthSelectorType;
  }
  return s;
}

public static Func<ST_14b00646f6cd842655571448758d0a23Structure, ssOutSystemsUI.RestRecords.RESTST_14b00646f6cd842655571448758d0a23Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_14b00646f6cd842655571448758d0a23Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_14b00646f6cd842655571448758d0a23Structure FromStructure(ST_14b00646f6cd842655571448758d0a23Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_14b00646f6cd842655571448758d0a23Structure(s, config);
}

}


