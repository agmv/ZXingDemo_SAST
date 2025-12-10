using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ListNavigation
public class JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure : AbstractRESTStructure<ST_28a47f2e64dd49f0d3d29e55f70be394Structure> {
[JsonProperty("Page")]
[JsonPropertyName("Page")]
public int? AttrPage;

[JsonProperty("StartIndex")]
[JsonPropertyName("StartIndex")]
public int? AttrStartIndex;

public JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure() { }

public JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure (ST_28a47f2e64dd49f0d3d29e55f70be394Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPage = (int?) s.ssPage;
AttrStartIndex = ConvertToRestWithoutDefaults(s.ssStartIndex, 0);
  } else {
AttrPage = (int?) s.ssPage;
AttrStartIndex = (int?) s.ssStartIndex;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure, ST_28a47f2e64dd49f0d3d29e55f70be394Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure s) => ToStructure(s, config);
}
public static ST_28a47f2e64dd49f0d3d29e55f70be394Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure obj, IBehaviorsConfiguration config) { 
  ST_28a47f2e64dd49f0d3d29e55f70be394Structure s = new ST_28a47f2e64dd49f0d3d29e55f70be394Structure();
  if(obj != null) {
  s.ssPage = obj.AttrPage == null ? 0 : obj.AttrPage.Value;
  s.ssStartIndex = obj.AttrStartIndex == null ? 0 : obj.AttrStartIndex.Value;
  }
  return s;
}

public static Func<ST_28a47f2e64dd49f0d3d29e55f70be394Structure, ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_28a47f2e64dd49f0d3d29e55f70be394Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure FromStructure(ST_28a47f2e64dd49f0d3d29e55f70be394Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure(s, config);
}

}


