import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
var clientVarsService;
class ClientVariables {
constructor() {
clientVarsService = OS.Injector.resolve(OS.ServiceNames.ClientVariablesService);
}

getIsLoading() {
return clientVarsService.getVariable("IsLoading", "ZXingLibDemo", OS.DataTypes.DataTypes.Boolean);
}

setIsLoading(value) {
return clientVarsService.setVariable("IsLoading", "ZXingLibDemo", OS.DataTypes.DataTypes.Boolean, value);
}

getUserPhotoURL() {
return clientVarsService.getVariable("UserPhotoURL", "ZXingLibDemo", OS.DataTypes.DataTypes.Text);
}

setUserPhotoURL(value) {
return clientVarsService.setVariable("UserPhotoURL", "ZXingLibDemo", OS.DataTypes.DataTypes.Text, value);
}

getLastURL() {
return clientVarsService.getVariable("LastURL", "ZXingLibDemo", OS.DataTypes.DataTypes.Text);
}

setLastURL(value) {
return clientVarsService.setVariable("LastURL", "ZXingLibDemo", OS.DataTypes.DataTypes.Text, value);
}

getUserName() {
return clientVarsService.getVariable("UserName", "ZXingLibDemo", OS.DataTypes.DataTypes.Text);
}

setUserName(value) {
return clientVarsService.setVariable("UserName", "ZXingLibDemo", OS.DataTypes.DataTypes.Text, value);
}

serialize() {
return {
IsLoading: OS.DataConversion.ServerDataConverter.to(this.getIsLoading(), OS.DataTypes.DataTypes.Boolean),
UserPhotoURL: OS.DataConversion.ServerDataConverter.to(this.getUserPhotoURL(), OS.DataTypes.DataTypes.Text),
LastURL: OS.DataConversion.ServerDataConverter.to(this.getLastURL(), OS.DataTypes.DataTypes.Text),
UserName: OS.DataConversion.ServerDataConverter.to(this.getUserName(), OS.DataTypes.DataTypes.Text)
};
}

}

export default new ClientVariables();




