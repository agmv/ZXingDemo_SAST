namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_ClientVariables : VarsBag {

    public bool ssIsLoading;
public string ssUserPhotoURL;
public string ssLastURL;
public string ssUserName;


    public ZXingLibDemo_ClientVariables() {
}



    public ZXingLibDemo_ClientVariables(bool ssIsLoading, string ssUserPhotoURL, string ssLastURL, string ssUserName) {
Init(new string[] {"IsLoading", "UserPhotoURL", "LastURL", "UserName"}, new string[] {"ssIsLoading", "ssUserPhotoURL", "ssLastURL", "ssUserName"});
this.ssIsLoading = ssIsLoading;
this.ssUserPhotoURL = ssUserPhotoURL;
this.ssLastURL = ssLastURL;
this.ssUserName = ssUserName;
}



}
