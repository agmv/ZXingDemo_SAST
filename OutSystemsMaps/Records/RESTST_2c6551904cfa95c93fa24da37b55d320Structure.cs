using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionLegs
public class RESTST_2c6551904cfa95c93fa24da37b55d320Structure : AbstractRESTStructure<ST_2c6551904cfa95c93fa24da37b55d320Structure> {
[JsonProperty("Origin")]
public ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure AttrOrigin;

[JsonProperty("Destination")]
public ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure AttrDestination;

[JsonProperty("Distance")]
public int? AttrDistance;

[JsonProperty("Duration")]
public int? AttrDuration;

public RESTST_2c6551904cfa95c93fa24da37b55d320Structure() { }

public RESTST_2c6551904cfa95c93fa24da37b55d320Structure (ST_2c6551904cfa95c93fa24da37b55d320Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrigin = ConvertToRestWithoutDefaults(s.ssOrigin, new ST_0e474756a4be14d378c73cd05f602bcdStructure(), ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructureDelegate(config));
AttrDestination = ConvertToRestWithoutDefaults(s.ssDestination, new ST_0e474756a4be14d378c73cd05f602bcdStructure(), ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructureDelegate(config));
AttrDistance = ConvertToRestWithoutDefaults(s.ssDistance, 0);
AttrDuration = ConvertToRestWithoutDefaults(s.ssDuration, 0);
  } else {
AttrOrigin = ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructure(s.ssOrigin, config);
AttrDestination = ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructure(s.ssDestination, config);
AttrDistance = (int?) s.ssDistance;
AttrDuration = (int?) s.ssDuration;
  }
}

public static ST_2c6551904cfa95c93fa24da37b55d320Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_2c6551904cfa95c93fa24da37b55d320Structure obj) { 
  ST_2c6551904cfa95c93fa24da37b55d320Structure s = new ST_2c6551904cfa95c93fa24da37b55d320Structure();
  if(obj != null) {
  s.ssOrigin = ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.ToStructure(obj.AttrOrigin);
  s.ssDestination = ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.ToStructure(obj.AttrDestination);
  s.ssDistance = obj.AttrDistance == null ? 0 : obj.AttrDistance.Value;
  s.ssDuration = obj.AttrDuration == null ? 0 : obj.AttrDuration.Value;
  }
  return s;
}

public static Func<ST_2c6551904cfa95c93fa24da37b55d320Structure, ssOutSystemsMaps.RestRecords.RESTST_2c6551904cfa95c93fa24da37b55d320Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2c6551904cfa95c93fa24da37b55d320Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_2c6551904cfa95c93fa24da37b55d320Structure FromStructure(ST_2c6551904cfa95c93fa24da37b55d320Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_2c6551904cfa95c93fa24da37b55d320Structure(s, config);
}

}


