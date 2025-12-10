import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import ZXingLibDemo_Layouts_LayoutTopMenu_mvcModel from "./ZXingLibDemo.Layouts.LayoutTopMenu.mvc$model.js";
import ZXingLibDemo_Common_Menu_mvcModel from "./ZXingLibDemo.Common.Menu.mvc$model.js";
import OutSystemsUI_Navigation_Tabs_mvcModel from "./OutSystemsUI.Navigation.Tabs.mvc$model.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvcModel from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$model.js";
import OutSystemsUI_Navigation_TabsContentItem_mvcModel from "./OutSystemsUI.Navigation.TabsContentItem.mvc$model.js";
import ZXingLibDemo_MainFlow_Encode_mvcModel from "./ZXingLibDemo.MainFlow.Encode.mvc$model.js";
import ZXingLibDemo_MainFlow_EncodeCalendar_mvcModel from "./ZXingLibDemo.MainFlow.EncodeCalendar.mvc$model.js";
import ZXingLibDemo_MainFlow_EncodeContact_mvcModel from "./ZXingLibDemo.MainFlow.EncodeContact.mvc$model.js";
import ZXingLibDemo_MainFlow_EncodeWifi_mvcModel from "./ZXingLibDemo.MainFlow.EncodeWifi.mvc$model.js";
import ZXingLibDemo_MainFlow_EncodeMessageVoice_mvcModel from "./ZXingLibDemo.MainFlow.EncodeMessageVoice.mvc$model.js";
import ZXingLibDemo_MainFlow_EncodeGeoLocation_mvcModel from "./ZXingLibDemo.MainFlow.EncodeGeoLocation.mvc$model.js";
import ZXingLibDemo_MainFlow_Decode_mvcModel from "./ZXingLibDemo.MainFlow.Decode.mvc$model.js";
import OutSystemsUI_Utilities_CenterContent_mvcModel from "./OutSystemsUI.Utilities.CenterContent.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
}

}

class Model extends 
OS.Model.VariablelessViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = ((((((((((((ZXingLibDemo_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || ZXingLibDemo_Common_Menu_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_Tabs_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsHeaderItem_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsContentItem_mvcModel.hasValidationWidgets) || ZXingLibDemo_MainFlow_Encode_mvcModel.hasValidationWidgets) || ZXingLibDemo_MainFlow_EncodeCalendar_mvcModel.hasValidationWidgets) || ZXingLibDemo_MainFlow_EncodeContact_mvcModel.hasValidationWidgets) || ZXingLibDemo_MainFlow_EncodeWifi_mvcModel.hasValidationWidgets) || ZXingLibDemo_MainFlow_EncodeMessageVoice_mvcModel.hasValidationWidgets) || ZXingLibDemo_MainFlow_EncodeGeoLocation_mvcModel.hasValidationWidgets) || ZXingLibDemo_MainFlow_Decode_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_CenterContent_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




