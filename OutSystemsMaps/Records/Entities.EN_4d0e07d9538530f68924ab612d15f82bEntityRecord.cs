using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENMapErrorsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMapErrorsEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"code", "code"}, {"message", "message"}};
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return entityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
entityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(long? tenant, string locale) {
return ViewName(null,locale);
}
public static string ViewName(long? tenant, string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
} // ENMapErrorsEntity
partial class ENMapErrorsEntity : InMemoryStaticEntityRuntime<EN_4d0e07d9538530f68924ab612d15f82bEntityRecord, string> {
    

    private static ENMapErrorsEntity instance = new();
    public static ENMapErrorsEntity GetInstance() => instance;

    public static EN_4d0e07d9538530f68924ab612d15f82bEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_4d0e07d9538530f68924ab612d15f82bEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("nTrQCekfoUeclq5JX8LqHA"), "MAPS-CFG-02002" },
{ ObjectKey.Parse("quNADvN3kUq_UYydwdtCAg"), "MAPS-GEN-06004" },
{ ObjectKey.Parse("a5DyDoo8nkWcahLPBR7aCA"), "MAPS-API-05004" },
{ ObjectKey.Parse("lQRCD2S66U6d10XpXCBbMA"), "MAPS-LIB-05002" },
{ ObjectKey.Parse("S9syEFfqDEuxREy_tRlMwg"), "MAPS-LIB-04001" },
{ ObjectKey.Parse("WLPUEiTPE0eMlosnSn78WQ"), "MAPS-API-09006" },
{ ObjectKey.Parse("DpZJFKoG8kSa9h2E5oirDA"), "MAPS-CFG-10005" },
{ ObjectKey.Parse("yMkaGVLhsUe36LkWihNDfg"), "MAPS-LIB-03001" },
{ ObjectKey.Parse("FAYYHZnIt02g8cSlOfyqUQ"), "MAPS-API-04003" },
{ ObjectKey.Parse("ax4CIEgK2U2IjR8UwEvrDw"), "MAPS-CFG-02001" },
{ ObjectKey.Parse("NrgKMjU1vkqeh8dn+XMrgQ"), "MAPS-CFG-01002" },
{ ObjectKey.Parse("pNQjOYCjRUKdvIRDSKB2QA"), "MAPS-API-09002" },
{ ObjectKey.Parse("gkiBRFVuyEux3xA7rTsffQ"), "MAPS-LIB-02001" },
{ ObjectKey.Parse("tVJ0STO7dESd7jBV5A8GXA"), "MAPS-API-01001" },
{ ObjectKey.Parse("Dtt5Six0ukC5ItDiTzX+SA"), "MAPS-LIB-03002" },
{ ObjectKey.Parse("jBDYTeYvfkOATgRgUsnaHw"), "MAPS-CFG-02003" },
{ ObjectKey.Parse("iNvkUjiBZ0C35ySFC+QrHQ"), "MAPS-GEN-05001" },
{ ObjectKey.Parse("K_toW7VSJ0CpLIl6yhXmCw"), "MAPS-GEN-05002" },
{ ObjectKey.Parse("WB5XZIS1_EWetUFODwsX7A"), "MAPS-GEN-01002" },
{ ObjectKey.Parse("EGfddNSsfk2TiqWr8jsmUQ"), "MAPS-GEN-06003" },
{ ObjectKey.Parse("GAatfgwH0kGdIKu5NJaMRg"), "MAPS-GEN-01001" },
{ ObjectKey.Parse("PnjBhIkSTUCoblhs_gOn0g"), "MAPS-CFG-05003" },
{ ObjectKey.Parse("AWQeiZv3CUKTR90J5MS6cg"), "MAPS-GEN-06001" },
{ ObjectKey.Parse("v6osi1AjVUGzNUs+5P6Gvg"), "MAPS-GEN-06006" },
{ ObjectKey.Parse("RtI7jODdE0SrkURoBwylwA"), "MAPS-GEN-08001" },
{ ObjectKey.Parse("2kk4kfbre0eitx7jJqJDgQ"), "MAPS-GEN-03001" },
{ ObjectKey.Parse("UxCqkljd0kSHZy+jG6L4DA"), "MAPS-CFG-05001" },
{ ObjectKey.Parse("N9L4l+XHHUeMPgi7x9I5CA"), "MAPS-GEN-06005" },
{ ObjectKey.Parse("oCMHphZWKUmClDs8IIc6Bg"), "MAPS-API-03001" },
{ ObjectKey.Parse("SMBPp6XZ1UilE0v2F_9Bug"), "MAPS-CFG-05004" },
{ ObjectKey.Parse("+21aqd4CEEaei+qq_hyobA"), "MAPS-LIB-05001" },
{ ObjectKey.Parse("SKtRrGEBHE+OBIDv32wYQw"), "MAPS-API-05001" },
{ ObjectKey.Parse("aVAarhencUylEONHwSc0ng"), "MAPS-GEN-06002" },
{ ObjectKey.Parse("Y0a1rsLwB0q2X5IkB4PnPg"), "MAPS-GEN-01003" },
{ ObjectKey.Parse("ayQLsqi2X0Gtq8piuHEKYQ"), "MAPS-API-05003" },
{ ObjectKey.Parse("d8o7s8mk7k+8DvOu+gawdA"), "MAPS-CFG-01003" },
{ ObjectKey.Parse("pd5OtJgglkCgFNRXm1N+xw"), "MAPS-CFG-01001" },
{ ObjectKey.Parse("KeHwvPJ50k+CyBOYSIBpEQ"), "MAPS-CFG-06001" },
{ ObjectKey.Parse("uFPjwiPdx0iNoTB3Ibm22w"), "MAPS-GEN-03002" },
{ ObjectKey.Parse("rUn3woYwH0ilIMIb6A3jYw"), "MAPS-API-05002" },
{ ObjectKey.Parse("JJ5qyCTSd0qEfKfxSSSj+A"), "MAPS-GEN-09001" },
{ ObjectKey.Parse("ucB6yosKe0+XWYfRGqYz3w"), "MAPS-GEN-04001" },
{ ObjectKey.Parse("os4ezNArD0GIOmtyNYD97g"), "MAPS-API-09005" },
{ ObjectKey.Parse("Cupn1Owq8Uul5IpZ+MoflA"), "MAPS-API-09003" },
{ ObjectKey.Parse("Skhu1VDiWkyAOLQFDIyYFA"), "MAPS-CFG-05002" },
{ ObjectKey.Parse("1n7y1VgFtkSkVHEExUdACA"), "MAPS-LIB-01001" },
{ ObjectKey.Parse("8cPk1jNr2E6zA_HnRohEaw"), "MAPS-API-05005" },
{ ObjectKey.Parse("sZ4z3HCsuU+hec7dSJuPGw"), "MAPS-LIB-01002" },
{ ObjectKey.Parse("by3E5HiBj0yNT91AEvMu6Q"), "MAPS-CFG-04001" },
{ ObjectKey.Parse("UslM6baxT0mQjFsTeQao0g"), "MAPS-LIB-11001" },
{ ObjectKey.Parse("EWvb7xjEAEuXAiSknaCOrQ"), "MAPS-GEN-07001" },
{ ObjectKey.Parse("xYsX_y4RO0eRf7PLfhSU0Q"), "MAPS-API-09004" },
{ ObjectKey.Parse("+qA+_0UZzEaP_nh2BUvpMA"), "MAPS-API-04002" },

    };

    protected override Dictionary<string, EN_4d0e07d9538530f68924ab612d15f82bEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"MAPS-CFG-02002", new() {
ssCode = "MAPS-CFG-02002",
ssMessage = "Properties from StaticMaps can't be changed",
}},
{"MAPS-GEN-06004", new() {
ssCode = "MAPS-GEN-06004",
ssMessage = "There is already a Tool on the DrawingTools registered on the specified Map under the same type: ",
}},
{"MAPS-API-05004", new() {
ssCode = "MAPS-API-05004",
ssMessage = "It was not possible to get the shape radius",
}},
{"MAPS-LIB-05002", new() {
ssCode = "MAPS-LIB-05002",
ssMessage = "Please provide a set of valid coordinates for the Shape Locations.",
}},
{"MAPS-LIB-04001", new() {
ssCode = "MAPS-LIB-04001",
ssMessage = "Failed setting directions from the Map due to: ",
}},
{"MAPS-API-09006", new() {
ssCode = "MAPS-API-09006",
ssMessage = "It was not possible to remove event to the marker",
}},
{"MAPS-CFG-10005", new() {
ssCode = "MAPS-CFG-10005",
ssMessage = "The Map with the ID provided was not found or is invalid",
}},
{"MAPS-LIB-03001", new() {
ssCode = "MAPS-LIB-03001",
ssMessage = "Failed Geocoding the Marker Position due to: ",
}},
{"MAPS-API-04003", new() {
ssCode = "MAPS-API-04003",
ssMessage = "Please ensure to load a plugin before making Direction requests for Leaflet Maps. Use the LoadLeafletDirectionsPlugin client action.",
}},
{"MAPS-CFG-02001", new() {
ssCode = "MAPS-CFG-02001",
ssMessage = "APIKey can only be set one time on the StaticMap",
}},
{"MAPS-CFG-01002", new() {
ssCode = "MAPS-CFG-01002",
ssMessage = "The APIKey from Google Places and Google Maps must be equal.",
}},
{"MAPS-API-09002", new() {
ssCode = "MAPS-API-09002",
ssMessage = "It was not possible to add the marker to the map",
}},
{"MAPS-LIB-02001", new() {
ssCode = "MAPS-LIB-02001",
ssMessage = "The APIKey set on the StaticMap is invalid for GoogleMaps API",
}},
{"MAPS-API-01001", new() {
ssCode = "MAPS-API-01001",
ssMessage = "It was not possible to get the center coordinates of the given map.",
}},
{"MAPS-LIB-03002", new() {
ssCode = "MAPS-LIB-03002",
ssMessage = "Please provide a set of valid coordinates for the Marker Position.",
}},
{"MAPS-CFG-02003", new() {
ssCode = "MAPS-CFG-02003",
ssMessage = "Localization, Language and/or Region, can only be set one time on the StaticMap",
}},
{"MAPS-GEN-05001", new() {
ssCode = "MAPS-GEN-05001",
ssMessage = "The specified Shape property is not supported: ",
}},
{"MAPS-GEN-05002", new() {
ssCode = "MAPS-GEN-05002",
ssMessage = "The specified Shape event is not supported: ",
}},
{"MAPS-GEN-01002", new() {
ssCode = "MAPS-GEN-01002",
ssMessage = "The specified Map event is not supported: ",
}},
{"MAPS-GEN-06003", new() {
ssCode = "MAPS-GEN-06003",
ssMessage = "The specified Drawing Tools event is not supported: ",
}},
{"MAPS-GEN-01001", new() {
ssCode = "MAPS-GEN-01001",
ssMessage = "The specified Map property is not supported: ",
}},
{"MAPS-CFG-05003", new() {
ssCode = "MAPS-CFG-05003",
ssMessage = "The Circle center needs to be a valid address/coordinates",
}},
{"MAPS-GEN-06001", new() {
ssCode = "MAPS-GEN-06001",
ssMessage = "The specified Drawing Tools property is not supported: ",
}},
{"MAPS-GEN-06006", new() {
ssCode = "MAPS-GEN-06006",
ssMessage = "The 'MapStyleId' Map property cannot be changed after map initialization",
}},
{"MAPS-GEN-08001", new() {
ssCode = "MAPS-GEN-08001",
ssMessage = "The specified Heatmap Layer property is not supported: ",
}},
{"MAPS-GEN-03001", new() {
ssCode = "MAPS-GEN-03001",
ssMessage = "The specified Marker property is not supported: ",
}},
{"MAPS-CFG-05001", new() {
ssCode = "MAPS-CFG-05001",
ssMessage = "The Polyline needs at least 2 valid addresses/coordinates",
}},
{"MAPS-GEN-06005", new() {
ssCode = "MAPS-GEN-06005",
ssMessage = "The 'UseAdvancedMarkers' Map property cannot be changed after map initialization",
}},
{"MAPS-API-03001", new() {
ssCode = "MAPS-API-03001",
ssMessage = "An error occurred while removing the Directions from the Map",
}},
{"MAPS-CFG-05004", new() {
ssCode = "MAPS-CFG-05004",
ssMessage = "The Rectangle needs to have 4 valid locations.",
}},
{"MAPS-LIB-05001", new() {
ssCode = "MAPS-LIB-05001",
ssMessage = "Failed Geocoding one or more locations of the Shape due to: ",
}},
{"MAPS-API-05001", new() {
ssCode = "MAPS-API-05001",
ssMessage = "It was not possible to get the path from the Shape",
}},
{"MAPS-GEN-06002", new() {
ssCode = "MAPS-GEN-06002",
ssMessage = "The specified Tool property is not supported: ",
}},
{"MAPS-GEN-01003", new() {
ssCode = "MAPS-GEN-01003",
ssMessage = "The action ContainsLocation can’t verify if a given marker is inside a Polyline shape. Please, change the ShapeWidgetId parameter to a Circle, Rectangle, or Polygon.",
}},
{"MAPS-API-05003", new() {
ssCode = "MAPS-API-05003",
ssMessage = "It was not possible to get the shape center",
}},
{"MAPS-CFG-01003", new() {
ssCode = "MAPS-CFG-01003",
ssMessage = "Localization, Language and/or Region, can only be set one time on the Map",
}},
{"MAPS-CFG-01001", new() {
ssCode = "MAPS-CFG-01001",
ssMessage = "APIKey can only be set one time on the Map",
}},
{"MAPS-CFG-06001", new() {
ssCode = "MAPS-CFG-06001",
ssMessage = "The Drawing tools are placed in the wrong area.",
}},
{"MAPS-GEN-03002", new() {
ssCode = "MAPS-GEN-03002",
ssMessage = "The specified Marker event is not supported: ",
}},
{"MAPS-API-05002", new() {
ssCode = "MAPS-API-05002",
ssMessage = "It was not possible to get the circle Shape",
}},
{"MAPS-GEN-09001", new() {
ssCode = "MAPS-GEN-09001",
ssMessage = "The specified MarkerClusterer property is not supported: ",
}},
{"MAPS-GEN-04001", new() {
ssCode = "MAPS-GEN-04001",
ssMessage = "Google Maps' Directions API doesn't need a plugin to return the directions",
}},
{"MAPS-API-09005", new() {
ssCode = "MAPS-API-09005",
ssMessage = "It was not possible to add event to the marker",
}},
{"MAPS-API-09003", new() {
ssCode = "MAPS-API-09003",
ssMessage = "An error occured while trying to the marker from the map",
}},
{"MAPS-CFG-05002", new() {
ssCode = "MAPS-CFG-05002",
ssMessage = "The Polygon needs at least 3 valid addresses/coordinates",
}},
{"MAPS-LIB-01001", new() {
ssCode = "MAPS-LIB-01001",
ssMessage = "The APIKey set on the Map is invalid for GoogleMaps API",
}},
{"MAPS-API-05005", new() {
ssCode = "MAPS-API-05005",
ssMessage = "It was not possible to get the shape and compare if the marker is inside",
}},
{"MAPS-LIB-01002", new() {
ssCode = "MAPS-LIB-01002",
ssMessage = "Failed Geocoding the Map Location due to: ",
}},
{"MAPS-CFG-04001", new() {
ssCode = "MAPS-CFG-04001",
ssMessage = "The Travel Mode is not recognized by the routing services",
}},
{"MAPS-LIB-11001", new() {
ssCode = "MAPS-LIB-11001",
ssMessage = "Please provide a set of valid coordinates for the Map Center.",
}},
{"MAPS-GEN-07001", new() {
ssCode = "MAPS-GEN-07001",
ssMessage = "The specified File Layer property is not supported: ",
}},
{"MAPS-API-09004", new() {
ssCode = "MAPS-API-09004",
ssMessage = "An error occured while trying to remove all markers from the map",
}},
{"MAPS-API-04002", new() {
ssCode = "MAPS-API-04002",
ssMessage = "There was a problem while loading the plugin",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_4d0e07d9538530f68924ab612d15f82bEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

