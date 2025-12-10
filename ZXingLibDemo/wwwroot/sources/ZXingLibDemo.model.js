import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export {entities, setEntities} from "./ZXingLibDemo.entities-model.js";
export {staticEntities} from "./ZXingLibDemo.staticEntities.js";
export class EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Sample", "sampleAttr", "Sample", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Margin", "marginAttr", "Margin", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Width", "widthAttr", "Width", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Height", "heightAttr", "Height", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "CodeDefaults";
}
}



EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.init();



