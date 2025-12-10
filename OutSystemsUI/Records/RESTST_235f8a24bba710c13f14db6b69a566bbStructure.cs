using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Tabs_InternalConfig
public class RESTST_235f8a24bba710c13f14db6b69a566bbStructure : AbstractRESTStructure<ST_235f8a24bba710c13f14db6b69a566bbStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("StartingTab")]
public int? AttrStartingTab;

[JsonProperty("TabsOrientation")]
public string AttrTabsOrientation;

[JsonProperty("TabsVerticalPosition")]
public string AttrTabsVerticalPosition;

[JsonProperty("Height")]
public string AttrHeight;

[JsonProperty("JustifyHeaders")]
public bool? AttrJustifyHeaders;

[JsonProperty("ContentAutoHeight")]
public bool? AttrContentAutoHeight;

public RESTST_235f8a24bba710c13f14db6b69a566bbStructure() { }

public RESTST_235f8a24bba710c13f14db6b69a566bbStructure (ST_235f8a24bba710c13f14db6b69a566bbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
AttrStartingTab = ConvertToRestWithoutDefaults(s.ssStartingTab, 0);
AttrTabsOrientation = ConvertToRestWithoutDefaults(s.ssTabsOrientation, (ENOrientationEntity.GetRecordByKey(ObjectKey.Parse("FlS0fEo8eEGcW4fsz2_66A"))).ssOrientation);
AttrTabsVerticalPosition = ConvertToRestWithoutDefaults(s.ssTabsVerticalPosition, (ENDirectionEntity.GetRecordByKey(ObjectKey.Parse("dTjFZzFGd0u1v3BPY_5QaA"))).ssDirection);
AttrHeight = ConvertToRestWithoutDefaults(s.ssHeight, "auto");
AttrJustifyHeaders = ConvertToRestWithoutDefaults(s.ssJustifyHeaders, false);
AttrContentAutoHeight = ConvertToRestWithoutDefaults(s.ssContentAutoHeight, false);
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
AttrStartingTab = (int?) s.ssStartingTab;
AttrTabsOrientation = s.ssTabsOrientation;
AttrTabsVerticalPosition = s.ssTabsVerticalPosition;
AttrHeight = s.ssHeight;
AttrJustifyHeaders = (bool?) s.ssJustifyHeaders;
AttrContentAutoHeight = (bool?) s.ssContentAutoHeight;
  }
}

public static ST_235f8a24bba710c13f14db6b69a566bbStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_235f8a24bba710c13f14db6b69a566bbStructure obj) { 
  ST_235f8a24bba710c13f14db6b69a566bbStructure s = new ST_235f8a24bba710c13f14db6b69a566bbStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssStartingTab = obj.AttrStartingTab == null ? 0 : obj.AttrStartingTab.Value;
  s.ssTabsOrientation = obj.AttrTabsOrientation == null ? (ENOrientationEntity.GetRecordByKey(ObjectKey.Parse("FlS0fEo8eEGcW4fsz2_66A"))).ssOrientation : obj.AttrTabsOrientation;
  s.ssTabsVerticalPosition = obj.AttrTabsVerticalPosition == null ? (ENDirectionEntity.GetRecordByKey(ObjectKey.Parse("dTjFZzFGd0u1v3BPY_5QaA"))).ssDirection : obj.AttrTabsVerticalPosition;
  s.ssHeight = obj.AttrHeight == null ? "auto" : obj.AttrHeight;
  s.ssJustifyHeaders = obj.AttrJustifyHeaders == null ? false : obj.AttrJustifyHeaders.Value;
  s.ssContentAutoHeight = obj.AttrContentAutoHeight == null ? false : obj.AttrContentAutoHeight.Value;
  }
  return s;
}

public static Func<ST_235f8a24bba710c13f14db6b69a566bbStructure, ssOutSystemsUI.RestRecords.RESTST_235f8a24bba710c13f14db6b69a566bbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_235f8a24bba710c13f14db6b69a566bbStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_235f8a24bba710c13f14db6b69a566bbStructure FromStructure(ST_235f8a24bba710c13f14db6b69a566bbStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_235f8a24bba710c13f14db6b69a566bbStructure(s, config);
}

}


