namespace ssOutSystemsMaps {
public static class SitePropertiesModel {
private static Guid _moduleKey = Guid.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
public static SitePropertyModel spGoogleMapsServerKey = new("GoogleMapsServerKey", _moduleKey, Guid.Parse("29daf0df-08c4-4b1f-9584-816f9bbb3889"), SitePropertyType.Text, true);
public static SitePropertyModel spGoogleMapsVersion = new("GoogleMapsVersion", _moduleKey, Guid.Parse("5ca1e169-ae15-4a18-aba2-1aa63105165f"), SitePropertyType.Text, false);
}
}
