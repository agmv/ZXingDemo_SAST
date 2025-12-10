namespace ssZXingLibDemo {
public static class Images {
private static string GetString(string key, string defaultValue) {
	return AppUtils.GetStringResource(key, defaultValue);
}
public const int Logo_Height = 250;
public const int Logo_Width = 250;
public static string Logo_Source() { return "img/ZXingLibDemo.Logo.png"; }
public const int User_Height = 230;
public const int User_Width = 230;
public static string User_Source() { return "img/ZXingLibDemo.User.png"; }
}
}
