import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import ZXingLibDemo_Layouts_LayoutTopMenu_mvcModel from "./ZXingLibDemo.Layouts.LayoutTopMenu.mvc$model.js";
import ZXingLibDemo_Common_Menu_mvcModel from "./ZXingLibDemo.Common.Menu.mvc$model.js";
import OutSystemsUI_Content_Card_mvcModel from "./OutSystemsUI.Content.Card.mvc$model.js";

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
Model._hasValidationWidgetsValue = ((ZXingLibDemo_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || ZXingLibDemo_Common_Menu_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Card_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




