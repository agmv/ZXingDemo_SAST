using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// FeatureData
public class JSONST_87d89cf32a40d309845674355a1bd4e1Structure : AbstractRESTStructure<ST_87d89cf32a40d309845674355a1bd4e1Structure> {
[JsonProperty("id")]
[JsonPropertyName("id")]
public string AttrId;

[JsonProperty("name")]
[JsonPropertyName("name")]
public string AttrName;

[JsonProperty("author")]
[JsonPropertyName("author")]
public ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure AttrAuthor;

[JsonProperty("description")]
[JsonPropertyName("description")]
public string AttrDescription;

[JsonProperty("infoWindowHtml")]
[JsonPropertyName("infoWindowHtml")]
public string AttrInfoWindowHtml;

[JsonProperty("Snippet")]
[JsonPropertyName("Snippet")]
public string AttrSnippet;

public JSONST_87d89cf32a40d309845674355a1bd4e1Structure() { }

public JSONST_87d89cf32a40d309845674355a1bd4e1Structure (ST_87d89cf32a40d309845674355a1bd4e1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrAuthor = ConvertToRestWithoutDefaults(s.ssAuthor, new ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure(), ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure.FromStructureDelegate(config));
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrInfoWindowHtml = ConvertToRestWithoutDefaults(s.ssInfoWindowHtml, "");
AttrSnippet = ConvertToRestWithoutDefaults(s.ssSnippet, "");
  } else {
AttrId = s.ssId;
AttrName = s.ssName;
AttrAuthor = ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure.FromStructure(s.ssAuthor, config);
AttrDescription = s.ssDescription;
AttrInfoWindowHtml = s.ssInfoWindowHtml;
AttrSnippet = s.ssSnippet;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_87d89cf32a40d309845674355a1bd4e1Structure, ST_87d89cf32a40d309845674355a1bd4e1Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_87d89cf32a40d309845674355a1bd4e1Structure s) => ToStructure(s, config);
}
public static ST_87d89cf32a40d309845674355a1bd4e1Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_87d89cf32a40d309845674355a1bd4e1Structure obj, IBehaviorsConfiguration config) { 
  ST_87d89cf32a40d309845674355a1bd4e1Structure s = new ST_87d89cf32a40d309845674355a1bd4e1Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssAuthor = ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure.ToStructure(obj.AttrAuthor, config);
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssInfoWindowHtml = obj.AttrInfoWindowHtml == null ? "" : obj.AttrInfoWindowHtml;
  s.ssSnippet = obj.AttrSnippet == null ? "" : obj.AttrSnippet;
  }
  return s;
}

public static Func<ST_87d89cf32a40d309845674355a1bd4e1Structure, ssOutSystemsMaps.RestRecords.JSONST_87d89cf32a40d309845674355a1bd4e1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_87d89cf32a40d309845674355a1bd4e1Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_87d89cf32a40d309845674355a1bd4e1Structure FromStructure(ST_87d89cf32a40d309845674355a1bd4e1Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_87d89cf32a40d309845674355a1bd4e1Structure(s, config);
}

}


