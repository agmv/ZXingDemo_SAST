using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// NoUiSliderConfigs
public class RESTST_af087c80f6ec63e7de4ff7926f7da7d0Structure : AbstractRESTStructure<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure> {
[JsonProperty("animate")]
public string Attranimate;

[JsonProperty("animationDuration")]
public int? AttranimationDuration;

[JsonProperty("behaviour")]
public string Attrbehaviour;

[JsonProperty("cssPrefix")]
public string AttrcssPrefix;

[JsonProperty("keyboardMultiplier")]
public int? AttrkeyboardMultiplier;

[JsonProperty("keyboardPageMultiplier")]
public int? AttrkeyboardPageMultiplier;

[JsonProperty("keyboardSupport")]
public string AttrkeyboardSupport;

[JsonProperty("limit")]
public int? Attrlimit;

[JsonProperty("margin")]
public int? Attrmargin;

[JsonProperty("padding")]
public int? Attrpadding;

[JsonProperty("range")]
public RestList<ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure> Attrrange;

[JsonProperty("snap")]
public bool? Attrsnap;

public RESTST_af087c80f6ec63e7de4ff7926f7da7d0Structure() { }

public RESTST_af087c80f6ec63e7de4ff7926f7da7d0Structure (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure s, IBehaviorsConfiguration config) {
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
Attrrange = s.ssrange.Length == 0 ? null : s.ssrange.ToRestList<ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure>(ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure.FromStructureDelegate(config));
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
Attrrange = s.ssrange.ToRestList<ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure>(ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure.FromStructureDelegate(config));
Attrsnap = (bool?) s.sssnap;
  }
}

public static ST_af087c80f6ec63e7de4ff7926f7da7d0Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_af087c80f6ec63e7de4ff7926f7da7d0Structure obj) { 
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
  s.ssrange = RL_b290214900b73d49f11f1fe32c57a145.FromRestList(obj.Attrrange, ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure.ToStructure);
  s.sssnap = obj.Attrsnap == null ? false : obj.Attrsnap.Value;
  }
  return s;
}

public static Func<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure, ssOutSystemsUI.RestRecords.RESTST_af087c80f6ec63e7de4ff7926f7da7d0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_af087c80f6ec63e7de4ff7926f7da7d0Structure FromStructure(ST_af087c80f6ec63e7de4ff7926f7da7d0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_af087c80f6ec63e7de4ff7926f7da7d0Structure(s, config);
}

}


