using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Private_MarkerClusterer
public class RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure : AbstractRESTStructure<ST_9f8ac95fe4e47e327de12de1b56bed45Structure> {
[JsonProperty("Active")]
public bool? AttrActive;

[JsonProperty("MaxZoom")]
public int? AttrMaxZoom;

[JsonProperty("ZoomOnClick")]
public bool? AttrZoomOnClick;

[JsonProperty("MinClusterSize")]
public int? AttrMinClusterSize;

public RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure() { }

public RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure (ST_9f8ac95fe4e47e327de12de1b56bed45Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActive = ConvertToRestWithoutDefaults(s.ssActive, false);
AttrMaxZoom = ConvertToRestWithoutDefaults(s.ssMaxZoom, 0);
AttrZoomOnClick = ConvertToRestWithoutDefaults(s.ssZoomOnClick, true);
AttrMinClusterSize = ConvertToRestWithoutDefaults(s.ssMinClusterSize, 2);
  } else {
AttrActive = (bool?) s.ssActive;
AttrMaxZoom = (int?) s.ssMaxZoom;
AttrZoomOnClick = (bool?) s.ssZoomOnClick;
AttrMinClusterSize = (int?) s.ssMinClusterSize;
  }
}

public static ST_9f8ac95fe4e47e327de12de1b56bed45Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure obj) { 
  ST_9f8ac95fe4e47e327de12de1b56bed45Structure s = new ST_9f8ac95fe4e47e327de12de1b56bed45Structure();
  if(obj != null) {
  s.ssActive = obj.AttrActive == null ? false : obj.AttrActive.Value;
  s.ssMaxZoom = obj.AttrMaxZoom == null ? 0 : obj.AttrMaxZoom.Value;
  s.ssZoomOnClick = obj.AttrZoomOnClick == null ? true : obj.AttrZoomOnClick.Value;
  s.ssMinClusterSize = obj.AttrMinClusterSize == null ? 2 : obj.AttrMinClusterSize.Value;
  }
  return s;
}

public static Func<ST_9f8ac95fe4e47e327de12de1b56bed45Structure, ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9f8ac95fe4e47e327de12de1b56bed45Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure FromStructure(ST_9f8ac95fe4e47e327de12de1b56bed45Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure(s, config);
}

}


