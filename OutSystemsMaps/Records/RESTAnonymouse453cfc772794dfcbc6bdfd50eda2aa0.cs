using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchTypesRecord
public class RESTRC_d186ae1becb56f86c126b4768e3f70d2 : AbstractRESTStructure<RC_d186ae1becb56f86c126b4768e3f70d2> {
[JsonProperty("SearchTypes")]
public ssOutSystemsMaps.RestRecords.RESTEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord AttrSearchTypes;

public RESTRC_d186ae1becb56f86c126b4768e3f70d2() { }

public RESTRC_d186ae1becb56f86c126b4768e3f70d2 (RC_d186ae1becb56f86c126b4768e3f70d2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSearchTypes = ConvertToRestWithoutDefaults(s.ssENSearchTypes, new EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord.FromStructureDelegate(config));
  } else {
AttrSearchTypes = ssOutSystemsMaps.RestRecords.RESTEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord.FromStructure(s.ssENSearchTypes, config);
  }
}

public static RC_d186ae1becb56f86c126b4768e3f70d2 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_d186ae1becb56f86c126b4768e3f70d2 obj) { 
  RC_d186ae1becb56f86c126b4768e3f70d2 s = new RC_d186ae1becb56f86c126b4768e3f70d2();
  if(obj != null) {
  s.ssENSearchTypes = ssOutSystemsMaps.RestRecords.RESTEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord.ToStructure(obj.AttrSearchTypes);
  }
  return s;
}

public static Func<RC_d186ae1becb56f86c126b4768e3f70d2, ssOutSystemsMaps.RestRecords.RESTRC_d186ae1becb56f86c126b4768e3f70d2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d186ae1becb56f86c126b4768e3f70d2 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_d186ae1becb56f86c126b4768e3f70d2 FromStructure(RC_d186ae1becb56f86c126b4768e3f70d2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_d186ae1becb56f86c126b4768e3f70d2(s, config);
}

}


