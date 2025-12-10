import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as System_Model from "./System_.model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("NewPassword", "newPasswordVar", "NewPassword", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ConfirmPassword", "confirmPasswordVar", "ConfirmPassword", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsPasswordVisible", "isPasswordVisibleVar", "IsPasswordVisible", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsConfirmPasswordVisible", "isConfirmPasswordVisibleVar", "IsConfirmPasswordVisible", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsButtonEnabled", "isButtonEnabledVar", "IsButtonEnabled", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsNewPasswordCompliant", "isNewPasswordCompliantVar", "IsNewPasswordCompliant", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Email", "emailIn", "Email", true, false, OS.DataTypes.DataTypes.Email, function () {
return "";
}, false), 
this.attr("_emailInDataFetchStatus", "_emailInDataFetchStatus", "_emailInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("VerificationCode", "verificationCodeIn", "VerificationCode", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_verificationCodeInDataFetchStatus", "_verificationCodeInDataFetchStatus", "_verificationCodeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
PasswordResetForm: OS.Model.ValidationWidgetRecord,
Input_Email: OS.Model.ValidationWidgetRecord,
Input_Code: OS.Model.ValidationWidgetRecord,
Input_NewPassword: OS.Model.ValidationWidgetRecord,
Input_ConfirmPassword: OS.Model.ValidationWidgetRecord
};
}

}

class Model extends 
OS.Model.BaseViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
if("Email" in inputs) {
this.variables.emailIn = OS.DataConversion.ServerDataConverter.from(inputs.Email, OS.DataTypes.DataTypes.Email);
}

if("VerificationCode" in inputs) {
this.variables.verificationCodeIn = OS.DataConversion.ServerDataConverter.from(inputs.VerificationCode, OS.DataTypes.DataTypes.Text);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




