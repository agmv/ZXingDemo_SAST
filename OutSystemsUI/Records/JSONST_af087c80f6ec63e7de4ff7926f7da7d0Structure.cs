using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// NoUiSliderConfigs
public class JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure : AbstractRESTStructure<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure> {
[JsonProperty("animate")]
[JsonPropertyName("animate")]
public string Attranimate;

[JsonProperty("animationDuration")]
[JsonPropertyName("animationDuration")]
public int? AttranimationDuration;

[JsonProperty("behaviour")]
[JsonPropertyName("behaviour")]
public string Attrbehaviour;

[JsonProperty("cssPrefix")]
[JsonPropertyName("cssPrefix")]
public string AttrcssPrefix;

[JsonProperty("keyboardMultiplier")]
[JsonPropertyName("keyboardMultiplier")]
public int? AttrkeyboardMultiplier;

[JsonProperty("keyboardPageMultiplier")]
[JsonPropertyName("keyboardPageMultiplier")]
public int? AttrkeyboardPageMultiplier;

[JsonProperty("keyboardSupport")]
[JsonPropertyName("keyboardSupport")]
public string AttrkeyboardSupport;

[JsonProperty("limit")]
[JsonPropertyName("limit")]
public int? Attrlimit;

[JsonProperty("margin")]
[JsonPropertyName("margin")]
public int? Attrmargin;

[JsonProperty("padding")]
[JsonPropertyName("padding")]
public int? Attrpadding;

[JsonProperty("range")]
[JsonPropertyName("range")]
public ssOutSystemsUI.RestRecords.JSONST_841c1f1485f51831db9f4b37a6d551d5Structure[] Attrrange;

[JsonProperty("snap")]
[JsonPropertyName("snap")]
public bool? Attrsnap;

public JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure() { }

public JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attranimate = ConvertToRestWithoutDefaults(s.ssanimate, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttranimationDuration = ConvertToRestWithoutDefaults(s.ssanimationDuration, 300);
Attrbehaviour = ConvertToRestWithoutDefaults(s.ssbehaviour, "");
AttrcssPrefix = ConvertToRestWithoutDefaults(s.sscssPrefix, "");
AttrkeyboardMultiplier = ConvertToRestWithoutDefaults(s.sskeyboardMultiplier, 1);
AttrkeyboardPageMultiplier = ConvertToRestWithoutDefaults(s.sskeyboardPageMultiplier, 5);
AttrkeyboardSupport = ConvertToRestWithoutDefaults(s.sskeyboardSupport, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
Attrlimit = ConvertToRestWithoutDefaults(s.sslimit, 0);
Attrmargin = ConvertToRestWithoutDefaults(s.ssmargin, 0);
Attrpadding = ConvertToRestWithoutDefaults(s.sspadding, 0);
Attrrange = s.ssrange.Length == 0 ? null : s.ssrange.ToArray<ssOutSystemsUI.RestRecords.JSONST_841c1f1485f51831db9f4b37a6d551d5Structure>(ssOutSystemsUI.RestRecords.JSONST_841c1f1485f51831db9f4b37a6d551d5Structure.FromStructureDelegate(config));
Attrsnap = ConvertToRestWithoutDefaults(s.sssnap, false);
  } else {
Attranimate = s.ssanimate;
AttranimationDuration = (int?) s.ssanimationDuration;
Attrbehaviour = s.ssbehaviour;
AttrcssPrefix = s.sscssPrefix;
AttrkeyboardMultiplier = (int?) s.sskeyboardMultiplier;
AttrkeyboardPageMultiplier = (int?) s.sskeyboardPageMultiplier;
AttrkeyboardSupport = s.sskeyboardSupport;
Attrlimit = (int?) s.sslimit;
Attrmargin = (int?) s.ssmargin;
Attrpadding = (int?) s.sspadding;
Attrrange = s.ssrange.ToArray<ssOutSystemsUI.RestRecords.JSONST_841c1f1485f51831db9f4b37a6d551d5Structure>(ssOutSystemsUI.RestRecords.JSONST_841c1f1485f51831db9f4b37a6d551d5Structure.FromStructureDelegate(config));
Attrsnap = (bool?) s.sssnap;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure, ST_af087c80f6ec63e7de4ff7926f7da7d0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure s) => ToStructure(s, config);
}
public static ST_af087c80f6ec63e7de4ff7926f7da7d0Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure obj, IBehaviorsConfiguration config) { 
  ST_af087c80f6ec63e7de4ff7926f7da7d0Structure s = new ST_af087c80f6ec63e7de4ff7926f7da7d0Structure();
  if(obj != null) {
  s.ssanimate = obj.Attranimate == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attranimate;
  s.ssanimationDuration = obj.AttranimationDuration == null ? 300 : obj.AttranimationDuration.Value;
  s.ssbehaviour = obj.Attrbehaviour == null ? "" : obj.Attrbehaviour;
  s.sscssPrefix = obj.AttrcssPrefix == null ? "" : obj.AttrcssPrefix;
  s.sskeyboardMultiplier = obj.AttrkeyboardMultiplier == null ? 1 : obj.AttrkeyboardMultiplier.Value;
  s.sskeyboardPageMultiplier = obj.AttrkeyboardPageMultiplier == null ? 5 : obj.AttrkeyboardPageMultiplier.Value;
  s.sskeyboardSupport = obj.AttrkeyboardSupport == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrkeyboardSupport;
  s.sslimit = obj.Attrlimit == null ? 0 : obj.Attrlimit.Value;
  s.ssmargin = obj.Attrmargin == null ? 0 : obj.Attrmargin.Value;
  s.sspadding = obj.Attrpadding == null ? 0 : obj.Attrpadding.Value;
  s.ssrange = RL_b290214900b73d49f11f1fe32c57a145.ToList(obj.Attrrange, ssOutSystemsUI.RestRecords.JSONST_841c1f1485f51831db9f4b37a6d551d5Structure.ToStructureDelegate(config));
  s.sssnap = obj.Attrsnap == null ? false : obj.Attrsnap.Value;
  }
  return s;
}

public static Func<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure, ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure FromStructure(ST_af087c80f6ec63e7de4ff7926f7da7d0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure(s, config);
}

}


