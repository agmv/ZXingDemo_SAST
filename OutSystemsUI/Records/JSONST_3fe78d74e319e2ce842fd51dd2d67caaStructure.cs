using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SplideConfigs
public class JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure : AbstractRESTStructure<ST_3fe78d74e319e2ce842fd51dd2d67caaStructure> {
[JsonProperty("role")]
[JsonPropertyName("role")]
public string Attrrole;

[JsonProperty("label")]
[JsonPropertyName("label")]
public string Attrlabel;

[JsonProperty("labelledby")]
[JsonPropertyName("labelledby")]
public string Attrlabelledby;

[JsonProperty("rewind")]
[JsonPropertyName("rewind")]
public string Attrrewind;

[JsonProperty("speed")]
[JsonPropertyName("speed")]
public int? Attrspeed;

[JsonProperty("rewindSpeed")]
[JsonPropertyName("rewindSpeed")]
public int? AttrrewindSpeed;

[JsonProperty("rewindByDrag")]
[JsonPropertyName("rewindByDrag")]
public string AttrrewindByDrag;

[JsonProperty("width")]
[JsonPropertyName("width")]
public string Attrwidth;

[JsonProperty("fixedWidth")]
[JsonPropertyName("fixedWidth")]
public string AttrfixedWidth;

[JsonProperty("fixedHeight")]
[JsonPropertyName("fixedHeight")]
public string AttrfixedHeight;

[JsonProperty("autoWidth")]
[JsonPropertyName("autoWidth")]
public string AttrautoWidth;

[JsonProperty("perMove")]
[JsonPropertyName("perMove")]
public int? AttrperMove;

[JsonProperty("clones")]
[JsonPropertyName("clones")]
public int? Attrclones;

[JsonProperty("cloneStatus")]
[JsonPropertyName("cloneStatus")]
public string AttrcloneStatus;

[JsonProperty("paginationDirection")]
[JsonPropertyName("paginationDirection")]
public string AttrpaginationDirection;

[JsonProperty("easing")]
[JsonPropertyName("easing")]
public string Attreasing;

[JsonProperty("noDrag")]
[JsonPropertyName("noDrag")]
public string AttrnoDrag;

[JsonProperty("flickPower")]
[JsonPropertyName("flickPower")]
public int? AttrflickPower;

[JsonProperty("flickMaxPages")]
[JsonPropertyName("flickMaxPages")]
public int? AttrflickMaxPages;

[JsonProperty("waitForTransition")]
[JsonPropertyName("waitForTransition")]
public string AttrwaitForTransition;

[JsonProperty("arrowPath")]
[JsonPropertyName("arrowPath")]
public string AttrarrowPath;

[JsonProperty("interval")]
[JsonPropertyName("interval")]
public int? Attrinterval;

[JsonProperty("pauseOnHover")]
[JsonPropertyName("pauseOnHover")]
public string AttrpauseOnHover;

[JsonProperty("pauseOnFocus")]
[JsonPropertyName("pauseOnFocus")]
public string AttrpauseOnFocus;

[JsonProperty("resetProgress")]
[JsonPropertyName("resetProgress")]
public string AttrresetProgress;

[JsonProperty("lazyLoad")]
[JsonPropertyName("lazyLoad")]
public string AttrlazyLoad;

[JsonProperty("preloadPages")]
[JsonPropertyName("preloadPages")]
public int? AttrpreloadPages;

[JsonProperty("wheel")]
[JsonPropertyName("wheel")]
public string Attrwheel;

[JsonProperty("wheelMinThreshold")]
[JsonPropertyName("wheelMinThreshold")]
public int? AttrwheelMinThreshold;

[JsonProperty("wheelSleep")]
[JsonPropertyName("wheelSleep")]
public int? AttrwheelSleep;

[JsonProperty("releaseWheel")]
[JsonPropertyName("releaseWheel")]
public string AttrreleaseWheel;

[JsonProperty("slideFocus")]
[JsonPropertyName("slideFocus")]
public string AttrslideFocus;

[JsonProperty("focusableNodes")]
[JsonPropertyName("focusableNodes")]
public string AttrfocusableNodes;

[JsonProperty("isNavigation")]
[JsonPropertyName("isNavigation")]
public string AttrisNavigation;

[JsonProperty("trimSpace")]
[JsonPropertyName("trimSpace")]
public string AttrtrimSpace;

[JsonProperty("updateOnMove")]
[JsonPropertyName("updateOnMove")]
public string AttrupdateOnMove;

[JsonProperty("mediaQuery")]
[JsonPropertyName("mediaQuery")]
public string AttrmediaQuery;

[JsonProperty("live")]
[JsonPropertyName("live")]
public string Attrlive;

[JsonProperty("destroy")]
[JsonPropertyName("destroy")]
public string Attrdestroy;

[JsonProperty("omitEnd")]
[JsonPropertyName("omitEnd")]
public string AttromitEnd;

public JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure() { }

public JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure (ST_3fe78d74e319e2ce842fd51dd2d67caaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrrole = ConvertToRestWithoutDefaults(s.ssrole, "");
Attrlabel = ConvertToRestWithoutDefaults(s.sslabel, "");
Attrlabelledby = ConvertToRestWithoutDefaults(s.sslabelledby, "");
Attrrewind = ConvertToRestWithoutDefaults(s.ssrewind, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
Attrspeed = ConvertToRestWithoutDefaults(s.ssspeed, 0);
AttrrewindSpeed = ConvertToRestWithoutDefaults(s.ssrewindSpeed, 0);
AttrrewindByDrag = ConvertToRestWithoutDefaults(s.ssrewindByDrag, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
Attrwidth = ConvertToRestWithoutDefaults(s.sswidth, "");
AttrfixedWidth = ConvertToRestWithoutDefaults(s.ssfixedWidth, "");
AttrfixedHeight = ConvertToRestWithoutDefaults(s.ssfixedHeight, "");
AttrautoWidth = ConvertToRestWithoutDefaults(s.ssautoWidth, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrperMove = ConvertToRestWithoutDefaults(s.ssperMove, 0);
Attrclones = ConvertToRestWithoutDefaults(s.ssclones, 0);
AttrcloneStatus = ConvertToRestWithoutDefaults(s.sscloneStatus, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrpaginationDirection = ConvertToRestWithoutDefaults(s.sspaginationDirection, "");
Attreasing = ConvertToRestWithoutDefaults(s.sseasing, "");
AttrnoDrag = ConvertToRestWithoutDefaults(s.ssnoDrag, "");
AttrflickPower = ConvertToRestWithoutDefaults(s.ssflickPower, 0);
AttrflickMaxPages = ConvertToRestWithoutDefaults(s.ssflickMaxPages, 0);
AttrwaitForTransition = ConvertToRestWithoutDefaults(s.sswaitForTransition, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrarrowPath = ConvertToRestWithoutDefaults(s.ssarrowPath, "");
Attrinterval = ConvertToRestWithoutDefaults(s.ssinterval, 0);
AttrpauseOnHover = ConvertToRestWithoutDefaults(s.sspauseOnHover, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrpauseOnFocus = ConvertToRestWithoutDefaults(s.sspauseOnFocus, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrresetProgress = ConvertToRestWithoutDefaults(s.ssresetProgress, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrlazyLoad = ConvertToRestWithoutDefaults(s.sslazyLoad, "");
AttrpreloadPages = ConvertToRestWithoutDefaults(s.sspreloadPages, 0);
Attrwheel = ConvertToRestWithoutDefaults(s.sswheel, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrwheelMinThreshold = ConvertToRestWithoutDefaults(s.sswheelMinThreshold, 0);
AttrwheelSleep = ConvertToRestWithoutDefaults(s.sswheelSleep, 0);
AttrreleaseWheel = ConvertToRestWithoutDefaults(s.ssreleaseWheel, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrslideFocus = ConvertToRestWithoutDefaults(s.ssslideFocus, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrfocusableNodes = ConvertToRestWithoutDefaults(s.ssfocusableNodes, "");
AttrisNavigation = ConvertToRestWithoutDefaults(s.ssisNavigation, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrtrimSpace = ConvertToRestWithoutDefaults(s.sstrimSpace, "");
AttrupdateOnMove = ConvertToRestWithoutDefaults(s.ssupdateOnMove, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrmediaQuery = ConvertToRestWithoutDefaults(s.ssmediaQuery, "");
Attrlive = ConvertToRestWithoutDefaults(s.sslive, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
Attrdestroy = ConvertToRestWithoutDefaults(s.ssdestroy, "");
AttromitEnd = ConvertToRestWithoutDefaults(s.ssomitEnd, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
  } else {
Attrrole = s.ssrole;
Attrlabel = s.sslabel;
Attrlabelledby = s.sslabelledby;
Attrrewind = s.ssrewind;
Attrspeed = (int?) s.ssspeed;
AttrrewindSpeed = (int?) s.ssrewindSpeed;
AttrrewindByDrag = s.ssrewindByDrag;
Attrwidth = s.sswidth;
AttrfixedWidth = s.ssfixedWidth;
AttrfixedHeight = s.ssfixedHeight;
AttrautoWidth = s.ssautoWidth;
AttrperMove = (int?) s.ssperMove;
Attrclones = (int?) s.ssclones;
AttrcloneStatus = s.sscloneStatus;
AttrpaginationDirection = s.sspaginationDirection;
Attreasing = s.sseasing;
AttrnoDrag = s.ssnoDrag;
AttrflickPower = (int?) s.ssflickPower;
AttrflickMaxPages = (int?) s.ssflickMaxPages;
AttrwaitForTransition = s.sswaitForTransition;
AttrarrowPath = s.ssarrowPath;
Attrinterval = (int?) s.ssinterval;
AttrpauseOnHover = s.sspauseOnHover;
AttrpauseOnFocus = s.sspauseOnFocus;
AttrresetProgress = s.ssresetProgress;
AttrlazyLoad = s.sslazyLoad;
AttrpreloadPages = (int?) s.sspreloadPages;
Attrwheel = s.sswheel;
AttrwheelMinThreshold = (int?) s.sswheelMinThreshold;
AttrwheelSleep = (int?) s.sswheelSleep;
AttrreleaseWheel = s.ssreleaseWheel;
AttrslideFocus = s.ssslideFocus;
AttrfocusableNodes = s.ssfocusableNodes;
AttrisNavigation = s.ssisNavigation;
AttrtrimSpace = s.sstrimSpace;
AttrupdateOnMove = s.ssupdateOnMove;
AttrmediaQuery = s.ssmediaQuery;
Attrlive = s.sslive;
Attrdestroy = s.ssdestroy;
AttromitEnd = s.ssomitEnd;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure, ST_3fe78d74e319e2ce842fd51dd2d67caaStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure s) => ToStructure(s, config);
}
public static ST_3fe78d74e319e2ce842fd51dd2d67caaStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure obj, IBehaviorsConfiguration config) { 
  ST_3fe78d74e319e2ce842fd51dd2d67caaStructure s = new ST_3fe78d74e319e2ce842fd51dd2d67caaStructure();
  if(obj != null) {
  s.ssrole = obj.Attrrole == null ? "" : obj.Attrrole;
  s.sslabel = obj.Attrlabel == null ? "" : obj.Attrlabel;
  s.sslabelledby = obj.Attrlabelledby == null ? "" : obj.Attrlabelledby;
  s.ssrewind = obj.Attrrewind == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrrewind;
  s.ssspeed = obj.Attrspeed == null ? 0 : obj.Attrspeed.Value;
  s.ssrewindSpeed = obj.AttrrewindSpeed == null ? 0 : obj.AttrrewindSpeed.Value;
  s.ssrewindByDrag = obj.AttrrewindByDrag == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrrewindByDrag;
  s.sswidth = obj.Attrwidth == null ? "" : obj.Attrwidth;
  s.ssfixedWidth = obj.AttrfixedWidth == null ? "" : obj.AttrfixedWidth;
  s.ssfixedHeight = obj.AttrfixedHeight == null ? "" : obj.AttrfixedHeight;
  s.ssautoWidth = obj.AttrautoWidth == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrautoWidth;
  s.ssperMove = obj.AttrperMove == null ? 0 : obj.AttrperMove.Value;
  s.ssclones = obj.Attrclones == null ? 0 : obj.Attrclones.Value;
  s.sscloneStatus = obj.AttrcloneStatus == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrcloneStatus;
  s.sspaginationDirection = obj.AttrpaginationDirection == null ? "" : obj.AttrpaginationDirection;
  s.sseasing = obj.Attreasing == null ? "" : obj.Attreasing;
  s.ssnoDrag = obj.AttrnoDrag == null ? "" : obj.AttrnoDrag;
  s.ssflickPower = obj.AttrflickPower == null ? 0 : obj.AttrflickPower.Value;
  s.ssflickMaxPages = obj.AttrflickMaxPages == null ? 0 : obj.AttrflickMaxPages.Value;
  s.sswaitForTransition = obj.AttrwaitForTransition == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrwaitForTransition;
  s.ssarrowPath = obj.AttrarrowPath == null ? "" : obj.AttrarrowPath;
  s.ssinterval = obj.Attrinterval == null ? 0 : obj.Attrinterval.Value;
  s.sspauseOnHover = obj.AttrpauseOnHover == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrpauseOnHover;
  s.sspauseOnFocus = obj.AttrpauseOnFocus == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrpauseOnFocus;
  s.ssresetProgress = obj.AttrresetProgress == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrresetProgress;
  s.sslazyLoad = obj.AttrlazyLoad == null ? "" : obj.AttrlazyLoad;
  s.sspreloadPages = obj.AttrpreloadPages == null ? 0 : obj.AttrpreloadPages.Value;
  s.sswheel = obj.Attrwheel == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrwheel;
  s.sswheelMinThreshold = obj.AttrwheelMinThreshold == null ? 0 : obj.AttrwheelMinThreshold.Value;
  s.sswheelSleep = obj.AttrwheelSleep == null ? 0 : obj.AttrwheelSleep.Value;
  s.ssreleaseWheel = obj.AttrreleaseWheel == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrreleaseWheel;
  s.ssslideFocus = obj.AttrslideFocus == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrslideFocus;
  s.ssfocusableNodes = obj.AttrfocusableNodes == null ? "" : obj.AttrfocusableNodes;
  s.ssisNavigation = obj.AttrisNavigation == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrisNavigation;
  s.sstrimSpace = obj.AttrtrimSpace == null ? "" : obj.AttrtrimSpace;
  s.ssupdateOnMove = obj.AttrupdateOnMove == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrupdateOnMove;
  s.ssmediaQuery = obj.AttrmediaQuery == null ? "" : obj.AttrmediaQuery;
  s.sslive = obj.Attrlive == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrlive;
  s.ssdestroy = obj.Attrdestroy == null ? "" : obj.Attrdestroy;
  s.ssomitEnd = obj.AttromitEnd == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttromitEnd;
  }
  return s;
}

public static Func<ST_3fe78d74e319e2ce842fd51dd2d67caaStructure, ssOutSystemsUI.RestRecords.JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3fe78d74e319e2ce842fd51dd2d67caaStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure FromStructure(ST_3fe78d74e319e2ce842fd51dd2d67caaStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_3fe78d74e319e2ce842fd51dd2d67caaStructure(s, config);
}

}


