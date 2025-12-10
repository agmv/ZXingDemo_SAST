import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
import * as OutSystemsUIModel from "./OutSystemsUI.staticEntities.js";
export {entities, setEntities} from "./OutSystemsUI.entities-model.js";
export {staticEntities} from "./OutSystemsUI.staticEntities.js";
export class EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Space", "spaceAttr", "Space", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Space";
}
}



EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.init();

export class EN_1e2af88601c0491260411e1369eb104cEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "BooleanTypes";
}
}



EN_1e2af88601c0491260411e1369eb104cEntityRecord.init();

export class ST_0262e6910ebecc922f633b08db78d688Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("PhoneWidth", "phoneWidthAttr", "PhoneWidth", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 767;
}, true), 
this.attr("TabletWidth", "tabletWidthAttr", "TabletWidth", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 1024;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DeviceConfiguration";
}
}



ST_0262e6910ebecc922f633b08db78d688Structure.init();

export class ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ItemId", "itemIdAttr", "ItemId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsSelected", "isSelectedAttr", "IsSelected", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "1";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DropdownServerSideItem_InternalConfigs";
}
}



ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure.init();

export class EN_8d4f783227026ce93d50126c7f028443EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Orientation", "orientationAttr", "Orientation", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_8d4f783227026ce93d50126c7f028443EntityRecord(new EN_8d4f783227026ce93d50126c7f028443EntityRecord.RecordClass({
orientationAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Orientation";
}
}



EN_8d4f783227026ce93d50126c7f028443EntityRecord.init();

export class EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Type", "typeAttr", "Type", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord(new EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord.RecordClass({
typeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "CarouselDirection";
}
}



EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord.init();

export class EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("State", "stateAttr", "State", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord(new EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord.RecordClass({
stateAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "VideoState";
}
}



EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord.init();

export class EN_50814454e481dd1773c2250bc248da5eEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Direction", "directionAttr", "Direction", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Direction";
}
}



EN_50814454e481dd1773c2250bc248da5eEntityRecord.init();

export class EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("WeekDay", "weekDayAttr", "WeekDay", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord(new EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord.RecordClass({
weekDayAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DatePickerWeekDay";
}
}



EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord.init();

export class ST_e373082a732833044c6d132d736b9a20Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Submenu_InternalConfig";
}
}



ST_e373082a732833044c6d132d736b9a20Structure.init();

export class EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Type", "typeAttr", "Type", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord(new EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord.RecordClass({
typeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "ProgressType";
}
}



EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord.init();

export class ST_09173c1b0f41f719b9efd6430c2e737dStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InteractToClose", "interactToCloseAttr", "InteractToClose", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("CloseAfterTime", "closeAfterTimeAttr", "CloseAfterTime", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "NotificationOptionalConfigs";
}
}



ST_09173c1b0f41f719b9efd6430c2e737dStructure.init();

export class ST_0f0a5319963cb5bf3b0eab53b2781088Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("MultipleItems", "multipleItemsAttr", "MultipleItems", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Accordion_InternalConfigs";
}
}



ST_0f0a5319963cb5bf3b0eab53b2781088Structure.init();

export class ST_736a0a0e931f1e6cffc1de4b3ad94539Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Navigation", "navigationAttr", "Navigation", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Height", "heightAttr", "Height", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ItemsDesktop", "itemsDesktopAttr", "ItemsDesktop", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, true), 
this.attr("ItemsTablet", "itemsTabletAttr", "ItemsTablet", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, true), 
this.attr("ItemsPhone", "itemsPhoneAttr", "ItemsPhone", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, true), 
this.attr("AutoPlay", "autoPlayAttr", "AutoPlay", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("Loop", "loopAttr", "Loop", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("Padding", "paddingAttr", "Padding", false, false, OS.DataTypes.DataTypes.Text, function () {
return "0";
}, true), 
this.attr("StartingPosition", "startingPositionAttr", "StartingPosition", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("ItemsGap", "itemsGapAttr", "ItemsGap", false, false, OS.DataTypes.DataTypes.Text, function () {
return "0";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Carousel_InternalConfig";
}
}



ST_736a0a0e931f1e6cffc1de4b3ad94539Structure.init();

export class ST_0995bd60993005a912f016117c0f5fd9Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ProviderEventId", "providerEventIdAttr", "value", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsSuccess", "isSuccessAttr", "isSuccess", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Code", "codeAttr", "code", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Message", "messageAttr", "message", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProviderEventReturnMessage";
}
}



ST_0995bd60993005a912f016117c0f5fd9Structure.init();

export class ST_a783e375273068e4b8f9c122c1661a6aStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ScrollToWidgetId", "scrollToWidgetIdAttr", "ScrollToWidgetId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "SectionIndexItem_InternalConfig";
}
}



ST_a783e375273068e4b8f9c122c1661a6aStructure.init();

export class ST_3b9304e9875ccc71ec31b003d76d44c7Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("SmoothScrolling", "smoothScrollingAttr", "SmoothScrolling", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsFixed", "isFixedAttr", "IsFixed", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "SectionIndex_InternalConfig";
}
}



ST_3b9304e9875ccc71ec31b003d76d44c7Structure.init();

export class ST_69c22c095aca285f3fb706e10e473ba5Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("RatingValue", "ratingValueAttr", "RatingValue", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("RatingScale", "ratingScaleAttr", "RatingScale", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("IsEdit", "isEditAttr", "IsEdit", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Size", "sizeAttr", "Size", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Rating_InternalConfig";
}
}



ST_69c22c095aca285f3fb706e10e473ba5Structure.init();

export class EN_d11562be18a7e40ca777aa336c946163EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Shape", "shapeAttr", "Shape", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Shape";
}
}



EN_d11562be18a7e40ca777aa336c946163EntityRecord.init();

export class ST_0d18385ed976d2d74e8cea1d77078409Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("AllowMultipleSelection", "allowMultipleSelectionAttr", "AllowMultipleSelection", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "1";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DropdownServerSide_InternalConfigs";
}
}



ST_0d18385ed976d2d74e8cea1d77078409Structure.init();

export class EN_7441573ccf264d27ef548a39a846bd68EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Steps", "stepsAttr", "Steps", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_7441573ccf264d27ef548a39a846bd68EntityRecord(new EN_7441573ccf264d27ef548a39a846bd68EntityRecord.RecordClass({
stepsAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Steps";
}
}



EN_7441573ccf264d27ef548a39a846bd68EntityRecord.init();

export class ST_106b6e385f5e89b0a7d76e23b14f61a0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Shape", "shapeAttr", "Shape", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.shape.softRounded;
}, true), 
this.attr("ShowHandler", "showHandlerAttr", "ShowHandler", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "BottomSheet_InternalConfig";
}
}



ST_106b6e385f5e89b0a7d76e23b14f61a0Structure.init();

export class ST_963c357dbc45b19fade654e21b1521d0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("StartsOpen", "startsOpenAttr", "StartsOpen", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Direction", "directionAttr", "Direction", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Width", "widthAttr", "Width", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("HasOverlay", "hasOverlayAttr", "HasOverlay", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Sidebar_InternalConfig";
}
}



ST_963c357dbc45b19fade654e21b1521d0Structure.init();

export class ST_b29bdecfa7956bb3d5bee97678e39fb0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Type", "typeAttr", "Type", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Progress", "progressAttr", "Progress", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("ProgressColor", "progressColorAttr", "ProgressColor", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("TrailColor", "trailColorAttr", "TrailColor", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Thickness", "thicknessAttr", "Thickness", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Shape", "shapeAttr", "Shape", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.shape.rounded;
}, true), 
this.attr("AnimateInitialProgress", "animateInitialProgressAttr", "AnimateInitialProgress", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InitialProgress", "initialProgressAttr", "InitialProgress", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProgressBar_InternalConfig";
}
}



ST_b29bdecfa7956bb3d5bee97678e39fb0Structure.init();

export class ST_2fd97622d01b72b1af62467b00f1da8eStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Type", "typeAttr", "Type", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Progress", "progressAttr", "Progress", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("ProgressColor", "progressColorAttr", "ProgressColor", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ProgressCircleSize", "progressCircleSizeAttr", "ProgressCircleSize", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("TrailColor", "trailColorAttr", "TrailColor", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Thickness", "thicknessAttr", "Thickness", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Shape", "shapeAttr", "Shape", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.shape.rounded;
}, true), 
this.attr("AnimateInitialProgress", "animateInitialProgressAttr", "AnimateInitialProgress", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InitialProgress", "initialProgressAttr", "InitialProgress", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProgressCircle_InternalConfig";
}
}



ST_2fd97622d01b72b1af62467b00f1da8eStructure.init();

export class ST_841c1f1485f51831db9f4b37a6d551d5Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("key", "keyAttr", "key", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("value", "valueAttr", "value", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "NoUiSliderConfigs_Range";
}
}



ST_841c1f1485f51831db9f4b37a6d551d5Structure.init();

export class ST_af087c80f6ec63e7de4ff7926f7da7d0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("animate", "animateAttr", "animate", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("animationDuration", "animationDurationAttr", "animationDuration", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 300;
}, true), 
this.attr("behaviour", "behaviourAttr", "behaviour", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("cssPrefix", "cssPrefixAttr", "cssPrefix", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("keyboardMultiplier", "keyboardMultiplierAttr", "keyboardMultiplier", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, true), 
this.attr("keyboardPageMultiplier", "keyboardPageMultiplierAttr", "keyboardPageMultiplier", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 5;
}, true), 
this.attr("keyboardSupport", "keyboardSupportAttr", "keyboardSupport", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("limit", "limitAttr", "limit", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("margin", "marginAttr", "margin", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("padding", "paddingAttr", "padding", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("range", "rangeAttr", "range", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_841c1f1485f51831db9f4b37a6d551d5Structure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_841c1f1485f51831db9f4b37a6d551d5Structure))), 
this.attr("snap", "snapAttr", "snap", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "NoUiSliderConfigs";
}
}



ST_af087c80f6ec63e7de4ff7926f7da7d0Structure.init();

export class ST_13c131829a33cb5bedb5c64aa6f4add2Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsSuccess", "isSuccessAttr", "isSuccess", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Code", "codeAttr", "code", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Message", "messageAttr", "message", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Value", "valueAttr", "value", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ReturnMessage";
}
}



ST_13c131829a33cb5bedb5c64aa6f4add2Structure.init();

export class EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AnimationType", "animationTypeAttr", "AnimationType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord(new EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord.RecordClass({
animationTypeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "AnimationType";
}
}



EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord.init();

export class ST_14b00646f6cd842655571448758d0a23Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("altInputClass", "altInputClassAttr", "altInputClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "undefined";
}, true), 
this.attr("allowInvalidPreload", "allowInvalidPreloadAttr", "allowInvalidPreload", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("ariaDateFormat", "ariaDateFormatAttr", "ariaDateFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "undefined";
}, true), 
this.attr("clickOpens", "clickOpensAttr", "clickOpens", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("enableSeconds", "enableSecondsAttr", "enableSeconds", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("hourIncrement", "hourIncrementAttr", "hourIncrement", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("inline", "inlineAttr", "inline", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("minuteIncrement", "minuteIncrementAttr", "minuteIncrement", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("nextArrow", "nextArrowAttr", "nextArrow", false, false, OS.DataTypes.DataTypes.Text, function () {
return "undefined";
}, true), 
this.attr("position", "positionAttr", "position", false, false, OS.DataTypes.DataTypes.Text, function () {
return "undefined";
}, true), 
this.attr("positionElement", "positionElementAttr", "positionElement", false, false, OS.DataTypes.DataTypes.Text, function () {
return "undefined";
}, true), 
this.attr("prevArrow", "prevArrowAttr", "prevArrow", false, false, OS.DataTypes.DataTypes.Text, function () {
return "undefined";
}, true), 
this.attr("shorthandCurrentMonth", "shorthandCurrentMonthAttr", "shorthandCurrentMonth", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("static", "staticAttr", "static", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("showMonths", "showMonthsAttr", "showMonths", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("wrap", "wrapAttr", "wrap", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("monthSelectorType", "monthSelectorTypeAttr", "monthSelectorType", false, false, OS.DataTypes.DataTypes.Text, function () {
return "undefined";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "FlatpickrConfigs";
}
}



ST_14b00646f6cd842655571448758d0a23Structure.init();

export class EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Type", "typeAttr", "Type", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Is_Active", "is_ActiveAttr", "Is_Active", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DeviceResponsive";
}
}



EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord.init();

export class RC_d3d7d244571ed038dbfee008e77e8c11 extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Weekday1", "weekday1Attr", "Weekday1", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Weekday2", "weekday2Attr", "Weekday2", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Weekday3", "weekday3Attr", "Weekday3", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Weekday4", "weekday4Attr", "Weekday4", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Weekday5", "weekday5Attr", "Weekday5", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Weekday6", "weekday6Attr", "Weekday6", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Weekday7", "weekday7Attr", "Weekday7", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "d3d7d244-571e-d038-dbfe-e008e77e8c11";
}
}



RC_d3d7d244571ed038dbfee008e77e8c11.init();

export class EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("BreakColumns", "breakColumnsAttr", "BreakColumns", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord(new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.RecordClass({
breakColumnsAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "BreakColumns";
}
}



EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.init();

export class EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Type", "typeAttr", "Type", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "MessageStatus";
}
}



EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord.init();

export class EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Style", "styleAttr", "Style", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord(new EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord.RecordClass({
styleAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "ScrollbarStyle";
}
}



EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord.init();

export class EN_52e55d60c515b6016f81404afb220594EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Trigger", "triggerAttr", "Trigger", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_52e55d60c515b6016f81404afb220594EntityRecord(new EN_52e55d60c515b6016f81404afb220594EntityRecord.RecordClass({
triggerAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Trigger";
}
}



EN_52e55d60c515b6016f81404afb220594EntityRecord.init();

export class EN_c3a2475ae6370a2f746040280495b4a2EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Autoplay", "autoplayAttr", "Autoplay", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_c3a2475ae6370a2f746040280495b4a2EntityRecord(new EN_c3a2475ae6370a2f746040280495b4a2EntityRecord.RecordClass({
autoplayAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Autoplay";
}
}



EN_c3a2475ae6370a2f746040280495b4a2EntityRecord.init();

export class EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Provider", "providerAttr", "Provider", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord(new EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord.RecordClass({
providerAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DropdownProvider";
}
}



EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord.init();

export class ST_87ed820dae13f311d79f7f394fc3790aStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Autoplay", "autoplayAttr", "Autoplay", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("Captions", "captionsAttr", "Captions", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Controls", "controlsAttr", "Controls", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("Height", "heightAttr", "Height", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Loop", "loopAttr", "Loop", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Muted", "mutedAttr", "Muted", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("PosterURL", "posterURLAttr", "PosterURL", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("URL", "uRLAttr", "URL", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Width", "widthAttr", "Width", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Video_InternalConfig";
}
}



ST_87ed820dae13f311d79f7f394fc3790aStructure.init();

export class ST_256310aee13520906f2ba115af101f62Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DateFormat", "dateFormatAttr", "DateFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InitialStartDate", "initialStartDateAttr", "InitialStartDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("InitialEndDate", "initialEndDateAttr", "InitialEndDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("ShowTodayButton", "showTodayButtonAttr", "ShowTodayButton", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("FirstWeekDay", "firstWeekDayAttr", "FirstWeekDay", false, false, OS.DataTypes.DataTypes.Integer, function () {
return OutSystemsUIModel.staticEntities.datePickerWeekDay.sunday;
}, true), 
this.attr("MinDate", "minDateAttr", "MinDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MaxDate", "maxDateAttr", "MaxDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("ShowWeekNumbers", "showWeekNumbersAttr", "ShowWeekNumbers", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DatePickerRange_InternalConfig";
}
}



ST_256310aee13520906f2ba115af101f62Structure.init();

export class ST_bc9955d62033e77475d9540bd4940593Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("SVGCode", "sVGCodeAttr", "SVGCode", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "InlineSVG_InternalConfig";
}
}



ST_bc9955d62033e77475d9540bd4940593Structure.init();

export class EN_4f86046673de081f9834eb306850ab22EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Position", "positionAttr", "Position", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_4f86046673de081f9834eb306850ab22EntityRecord(new EN_4f86046673de081f9834eb306850ab22EntityRecord.RecordClass({
positionAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "FloatingPosition";
}
}



EN_4f86046673de081f9834eb306850ab22EntityRecord.init();

export class ST_28a47f2e64dd49f0d3d29e55f70be394Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Page", "pageAttr", "Page", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("StartIndex", "startIndexAttr", "StartIndex", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ListNavigation";
}
}



ST_28a47f2e64dd49f0d3d29e55f70be394Structure.init();

export class EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord(new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.RecordClass({
labelAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "AccordionIconPosition";
}
}



EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.init();

export class ST_235f8a24bba710c13f14db6b69a566bbStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("StartingTab", "startingTabAttr", "StartingTab", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("TabsOrientation", "tabsOrientationAttr", "TabsOrientation", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.orientation.horizontal;
}, true), 
this.attr("TabsVerticalPosition", "tabsVerticalPositionAttr", "TabsVerticalPosition", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.direction.left;
}, true), 
this.attr("Height", "heightAttr", "Height", false, false, OS.DataTypes.DataTypes.Text, function () {
return "auto";
}, true), 
this.attr("JustifyHeaders", "justifyHeadersAttr", "JustifyHeaders", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ContentAutoHeight", "contentAutoHeightAttr", "ContentAutoHeight", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Tabs_InternalConfig";
}
}



ST_235f8a24bba710c13f14db6b69a566bbStructure.init();

export class ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("LanguageCode", "languageCodeAttr", "LanguageCode", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("SourceFile", "sourceFileAttr", "SourceFile", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Label", "labelAttr", "Label", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "VideoCaptions";
}
}



ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure.init();

export class ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "TabsContentItem_InternalConfig";
}
}



ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure.init();

export class ST_5c08eaa15b890a2d617cabe547c34f0bStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Month", "monthAttr", "Month", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Year", "yearAttr", "Year", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "MonthYear";
}
}



ST_5c08eaa15b890a2d617cabe547c34f0bStructure.init();

export class ST_6f97d9724e66f51b47133aa003a9e610Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DateFormat", "dateFormatAttr", "DateFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("MinMonth", "minMonthAttr", "MinMonth", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_5c08eaa15b890a2d617cabe547c34f0bStructure());
}, true, ST_5c08eaa15b890a2d617cabe547c34f0bStructure), 
this.attr("InitialMonth", "initialMonthAttr", "InitialMonth", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_5c08eaa15b890a2d617cabe547c34f0bStructure());
}, true, ST_5c08eaa15b890a2d617cabe547c34f0bStructure), 
this.attr("MaxMonth", "maxMonthAttr", "MaxMonth", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_5c08eaa15b890a2d617cabe547c34f0bStructure());
}, true, ST_5c08eaa15b890a2d617cabe547c34f0bStructure), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "MonthPicker_InternalConfig";
}
}



ST_6f97d9724e66f51b47133aa003a9e610Structure.init();

export class ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("StartsExpanded", "startsExpandedAttr", "StartsExpanded", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Icon", "iconAttr", "Icon", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IconPosition", "iconPositionAttr", "IconPosition", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "AccordionItem_InternalConfigs";
}
}



ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure.init();

export class EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Size", "sizeAttr", "Size", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord(new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord.RecordClass({
sizeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Size";
}
}



EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord.init();

export class ST_27b48af5cc16a3b2165fd73e0270cad1Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Color", "colorAttr", "Color", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Percentage", "percentageAttr", "Percentage", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal((-1));
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "GradientColor";
}
}



ST_27b48af5cc16a3b2165fd73e0270cad1Structure.init();

export class ST_b7d405ca4407e572da091e54d07e3bd1Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Code", "codeAttr", "code", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Message", "messageAttr", "message", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ErrorMessage";
}
}



ST_b7d405ca4407e572da091e54d07e3bd1Structure.init();

export class ST_52888c3e6f33b11b7d6288dd268a26dcStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "AnimatedLabel_InternalConfig";
}
}



ST_52888c3e6f33b11b7d6288dd268a26dcStructure.init();

export class ST_4e53cb8815b86020ced1d2f2652c9b1dStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AllowMultipleSelection", "allowMultipleSelectionAttr", "AllowMultipleSelection", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("NoResultsText", "noResultsTextAttr", "NoResultsText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "There are no options to show.";
}, true), 
this.attr("SearchPrompt", "searchPromptAttr", "SearchPrompt", false, false, OS.DataTypes.DataTypes.Text, function () {
return "Search...";
}, true), 
this.attr("NoOptionsText", "noOptionsTextAttr", "NoOptionsText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "There are no options to show.";
}, true), 
this.attr("SanitizeDropdownValues", "sanitizeDropdownValuesAttr", "SanitizeDropdownValues", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DropdownOptionalConfigs";
}
}



ST_4e53cb8815b86020ced1d2f2652c9b1dStructure.init();

export class ST_2b510eefd88959a00bf486cfc856fa96Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsLoading", "isLoadingAttr", "IsLoading", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ShowLoadingAndLabel", "showLoadingAndLabelAttr", "ShowLoadingAndLabel", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ButtonLoading_InternalConfig";
}
}



ST_2b510eefd88959a00bf486cfc856fa96Structure.init();

export class EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Speed", "speedAttr", "Speed", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord(new EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord.RecordClass({
speedAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Speed";
}
}



EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord.init();

export class EN_f43f179caddf7f7b68b18272d67285d6EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("MenuAction", "menuActionAttr", "MenuAction", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_f43f179caddf7f7b68b18272d67285d6EntityRecord(new EN_f43f179caddf7f7b68b18272d67285d6EntityRecord.RecordClass({
menuActionAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "MenuAction";
}
}



EN_f43f179caddf7f7b68b18272d67285d6EntityRecord.init();

export class EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Provider", "providerAttr", "Provider", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord(new EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord.RecordClass({
providerAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "RangeSliderProvider";
}
}



EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord.init();

export class ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InitialStartDate", "initialStartDateAttr", "InitialStartDate", false, false, OS.DataTypes.DataTypes.Date, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("InitialEndDate", "initialEndDateAttr", "InitialEndDate", false, false, OS.DataTypes.DataTypes.Date, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MinDate", "minDateAttr", "MinDate", false, false, OS.DataTypes.DataTypes.Date, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MaxDate", "maxDateAttr", "MaxDate", false, false, OS.DataTypes.DataTypes.Date, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("FirstWeekDay", "firstWeekDayAttr", "FirstWeekDay", false, false, OS.DataTypes.DataTypes.Integer, function () {
return OutSystemsUIModel.staticEntities.datePickerWeekDay.sunday;
}, true), 
this.attr("ShowWeekNumbers", "showWeekNumbersAttr", "ShowWeekNumbers", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DatePickerRangeOptionalConfigs";
}
}



ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure.init();

export class ST_34444d0742578c128ebc8b2594439346Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("NoResultsText", "noResultsTextAttr", "NoResultsText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "There are no options to show.";
}, true), 
this.attr("SearchPrompt", "searchPromptAttr", "SearchPrompt", false, false, OS.DataTypes.DataTypes.Text, function () {
return "Search...";
}, true), 
this.attr("NoOptionsText", "noOptionsTextAttr", "NoOptionsText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "There are no options to show.";
}, true), 
this.attr("SanitizeDropdownValues", "sanitizeDropdownValuesAttr", "SanitizeDropdownValues", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DropdownTagsOptionalConfigs";
}
}



ST_34444d0742578c128ebc8b2594439346Structure.init();

export class ST_bc4abb4233d9ce894e855c520a20c76fStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InitialDate", "initialDateAttr", "InitialDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MinDate", "minDateAttr", "MinDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MaxDate", "maxDateAttr", "MaxDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("FirstWeekDay", "firstWeekDayAttr", "FirstWeekDay", false, false, OS.DataTypes.DataTypes.Integer, function () {
return OutSystemsUIModel.staticEntities.datePickerWeekDay.sunday;
}, true), 
this.attr("ShowWeekNumbers", "showWeekNumbersAttr", "ShowWeekNumbers", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DatePickerOptionalConfigs";
}
}



ST_bc4abb4233d9ce894e855c520a20c76fStructure.init();

export class ST_6e6632cfd831e4e0f6a401872bea6eccStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("BalloonPosition", "balloonPositionAttr", "Position", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.floatingPosition.auto;
}, true), 
this.attr("BalloonShape", "balloonShapeAttr", "Shape", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.shape.softRounded;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OverflowMenu_InternalConfigs";
}
}



ST_6e6632cfd831e4e0f6a401872bea6eccStructure.init();

export class EN_92679525739afa328c09890d25f5ac45EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_92679525739afa328c09890d25f5ac45EntityRecord(new EN_92679525739afa328c09890d25f5ac45EntityRecord.RecordClass({
labelAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "StackedCardsPosition";
}
}



EN_92679525739afa328c09890d25f5ac45EntityRecord.init();

export class ST_8391f9d0c6b78f74493c47987669deecStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Shape", "shapeAttr", "Shape", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.shape.rounded;
}, true), 
this.attr("AnimateInitialProgress", "animateInitialProgressAttr", "AnimateInitialProgress", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProgressBarOptionalConfigs";
}
}



ST_8391f9d0c6b78f74493c47987669deecStructure.init();

export class RC_35ce9df1ad7a89533b2e8a49a8413520 extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Month1", "month1Attr", "Month1", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month10", "month10Attr", "Month10", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month11", "month11Attr", "Month11", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month12", "month12Attr", "Month12", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month2", "month2Attr", "Month2", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month3", "month3Attr", "Month3", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month4", "month4Attr", "Month4", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month5", "month5Attr", "Month5", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month6", "month6Attr", "Month6", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month7", "month7Attr", "Month7", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month8", "month8Attr", "Month8", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month9", "month9Attr", "Month9", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "35ce9df1-ad7a-8953-3b2e-8a49a8413520";
}
}



RC_35ce9df1ad7a89533b2e8a49a8413520.init();

export class EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ColumnBreak", "columnBreakAttr", "ColumnBreak", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord(new EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord.RecordClass({
columnBreakAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "ColumnBreak";
}
}



EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord.init();

export class EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Provider", "providerAttr", "Provider", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord(new EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord.RecordClass({
providerAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "CarouselProvider";
}
}



EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord.init();

export class EN_59aacee1cb91627a0f497366b24e4500EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Type", "typeAttr", "Type", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_59aacee1cb91627a0f497366b24e4500EntityRecord(new EN_59aacee1cb91627a0f497366b24e4500EntityRecord.RecordClass({
typeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "CarouselNavigation";
}
}



EN_59aacee1cb91627a0f497366b24e4500EntityRecord.init();

export class EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Provider", "providerAttr", "Provider", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord(new EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord.RecordClass({
providerAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DatePickerProvider";
}
}



EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord.init();

export class ST_cd3e064c4ee8b37ab96945c09d5d2155Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DateFormat", "dateFormatAttr", "DateFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InitialDate", "initialDateAttr", "InitialDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("TimeFormat", "timeFormatAttr", "TimeFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.datePickerTimeFormat.disabled;
}, true), 
this.attr("ShowTodayButton", "showTodayButtonAttr", "ShowTodayButton", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("FirstWeekDay", "firstWeekDayAttr", "FirstWeekDay", false, false, OS.DataTypes.DataTypes.Integer, function () {
return OutSystemsUIModel.staticEntities.datePickerWeekDay.sunday;
}, true), 
this.attr("MinDate", "minDateAttr", "MinDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MaxDate", "maxDateAttr", "MaxDate", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("ShowWeekNumbers", "showWeekNumbersAttr", "ShowWeekNumbers", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DatePicker_InternalConfig";
}
}



ST_cd3e064c4ee8b37ab96945c09d5d2155Structure.init();

export class EN_f9178b4aae1879ea388b92402c64db4cEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Provider", "providerAttr", "Provider", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_f9178b4aae1879ea388b92402c64db4cEntityRecord(new EN_f9178b4aae1879ea388b92402c64db4cEntityRecord.RecordClass({
providerAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "IdentityProvider";
}
}



EN_f9178b4aae1879ea388b92402c64db4cEntityRecord.init();

export class EN_d383eada98ae47b51248dfe934bb4fabEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Color", "colorAttr", "Color", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_d383eada98ae47b51248dfe934bb4fabEntityRecord(new EN_d383eada98ae47b51248dfe934bb4fabEntityRecord.RecordClass({
colorAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DEPRECATED_Color";
}
}



EN_d383eada98ae47b51248dfe934bb4fabEntityRecord.init();

export class ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Value", "valueAttr", "Value", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Text", "textAttr", "Text", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DropdownItem";
}
}



ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure.init();

export class ST_8ccec918bf91fdb79e42a7e1e178b4beStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Search_InternalConfig";
}
}



ST_8ccec918bf91fdb79e42a7e1e178b4beStructure.init();

export class EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Type", "typeAttr", "Type", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord(new EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord.RecordClass({
typeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Gradient";
}
}



EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord.init();

export class ST_3fe78d74e319e2ce842fd51dd2d67caaStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("role", "roleAttr", "role", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("label", "labelAttr", "label", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("labelledby", "labelledbyAttr", "labelledby", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("rewind", "rewindAttr", "rewind", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("speed", "speedAttr", "speed", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("rewindSpeed", "rewindSpeedAttr", "rewindSpeed", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("rewindByDrag", "rewindByDragAttr", "rewindByDrag", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("width", "widthAttr", "width", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("fixedWidth", "fixedWidthAttr", "fixedWidth", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("fixedHeight", "fixedHeightAttr", "fixedHeight", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("autoWidth", "autoWidthAttr", "autoWidth", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("perMove", "perMoveAttr", "perMove", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("clones", "clonesAttr", "clones", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("cloneStatus", "cloneStatusAttr", "cloneStatus", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("paginationDirection", "paginationDirectionAttr", "paginationDirection", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("easing", "easingAttr", "easing", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("noDrag", "noDragAttr", "noDrag", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("flickPower", "flickPowerAttr", "flickPower", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("flickMaxPages", "flickMaxPagesAttr", "flickMaxPages", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("waitForTransition", "waitForTransitionAttr", "waitForTransition", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("arrowPath", "arrowPathAttr", "arrowPath", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("interval", "intervalAttr", "interval", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("pauseOnHover", "pauseOnHoverAttr", "pauseOnHover", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("pauseOnFocus", "pauseOnFocusAttr", "pauseOnFocus", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("resetProgress", "resetProgressAttr", "resetProgress", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("lazyLoad", "lazyLoadAttr", "lazyLoad", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("preloadPages", "preloadPagesAttr", "preloadPages", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("wheel", "wheelAttr", "wheel", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("wheelMinThreshold", "wheelMinThresholdAttr", "wheelMinThreshold", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("wheelSleep", "wheelSleepAttr", "wheelSleep", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("releaseWheel", "releaseWheelAttr", "releaseWheel", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("slideFocus", "slideFocusAttr", "slideFocus", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("focusableNodes", "focusableNodesAttr", "focusableNodes", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("isNavigation", "isNavigationAttr", "isNavigation", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("trimSpace", "trimSpaceAttr", "trimSpace", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("updateOnMove", "updateOnMoveAttr", "updateOnMove", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("mediaQuery", "mediaQueryAttr", "mediaQuery", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("live", "liveAttr", "live", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("destroy", "destroyAttr", "destroy", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("omitEnd", "omitEndAttr", "omitEnd", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "SplideConfigs";
}
}



ST_3fe78d74e319e2ce842fd51dd2d67caaStructure.init();

export class ST_7d99fd1de65649f174aff6854b052539Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AutoPlay", "autoPlayAttr", "AutoPlay", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("Loop", "loopAttr", "Loop", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("Padding", "paddingAttr", "Padding", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ItemsGap", "itemsGapAttr", "ItemsGap", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("StartingPosition", "startingPositionAttr", "StartingPosition", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "CarouselOptionalConfigs";
}
}



ST_7d99fd1de65649f174aff6854b052539Structure.init();

export class RC_bbab5f70da1d7251909f44ce9efe20fa extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("WeekdayShort1", "weekdayShort1Attr", "WeekdayShort1", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("WeekdayShort2", "weekdayShort2Attr", "WeekdayShort2", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("WeekdayShort3", "weekdayShort3Attr", "WeekdayShort3", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("WeekdayShort4", "weekdayShort4Attr", "WeekdayShort4", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("WeekdayShort5", "weekdayShort5Attr", "WeekdayShort5", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("WeekdayShort6", "weekdayShort6Attr", "WeekdayShort6", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("WeekdayShort7", "weekdayShort7Attr", "WeekdayShort7", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "bbab5f70-da1d-7251-909f-44ce9efe20fa";
}
}



RC_bbab5f70da1d7251909f44ce9efe20fa.init();

export class EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord(new EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "AccordionIconType";
}
}



EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord.init();

export class ST_46bd5f77d899939eaf145ae01d3efd6bStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("StartsOpen", "startsOpenAttr", "StartsOpen", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Position", "positionAttr", "Position", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Width", "widthAttr", "Width", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("CloseAfterTime", "closeAfterTimeAttr", "CloseAfterTime", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("InteractToClose", "interactToCloseAttr", "InteractToClose", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Notification_InternalConfig";
}
}



ST_46bd5f77d899939eaf145ae01d3efd6bStructure.init();

export class EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("GutterSize", "gutterSizeAttr", "GutterSize", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "GutterSize";
}
}



EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.init();

export class EN_b4e36c9529d7446e086560192df48d7cEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Timeformat", "timeformatAttr", "Timeformat", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_b4e36c9529d7446e086560192df48d7cEntityRecord(new EN_b4e36c9529d7446e086560192df48d7cEntityRecord.RecordClass({
timeformatAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DatePickerTimeFormat";
}
}



EN_b4e36c9529d7446e086560192df48d7cEntityRecord.init();

export class RC_4c3ee0d0ad514546e23495b0186f9086 extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ShortcutsDialog1", "shortcutsDialog1Attr", "ShortcutsDialog1", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ShortcutsDialog2", "shortcutsDialog2Attr", "ShortcutsDialog2", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ShortcutsDialog3", "shortcutsDialog3Attr", "ShortcutsDialog3", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ShortcutsDialog4", "shortcutsDialog4Attr", "ShortcutsDialog4", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ShortcutsDialog5", "shortcutsDialog5Attr", "ShortcutsDialog5", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ShortcutsDialog6", "shortcutsDialog6Attr", "ShortcutsDialog6", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ShortcutsDialog7", "shortcutsDialog7Attr", "ShortcutsDialog7", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ShortcutsDialog8", "shortcutsDialog8Attr", "ShortcutsDialog8", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "4c3ee0d0-ad51-4546-e234-95b0186f9086";
}
}



RC_4c3ee0d0ad514546e23495b0186f9086.init();

export class ST_4f70c42b393d853a53e093e196f4b683Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "TabsHeaderItem_InternalConfig";
}
}



ST_4f70c42b393d853a53e093e196f4b683Structure.init();

export class ST_7167810326c75456a7ce120ed2dbd76bStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ShowFloatingLabel", "showFloatingLabelAttr", "ShowFloatingLabel", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Step", "stepAttr", "Step", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true), 
this.attr("ShowTickMarks", "showTickMarksAttr", "ShowTickMarks", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("TickMarksInterval", "tickMarksIntervalAttr", "TickMarksInterval", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "RangeSliderOptionalConfigs";
}
}



ST_7167810326c75456a7ce120ed2dbd76bStructure.init();

export class ST_9cac82fc47e32e1503b2dbc00140aa98Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Position", "positionAttr", "Position", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("StartVisible", "startVisibleAttr", "StartVisible", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsHover", "isHoverAttr", "IsHover", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Tooltip_InternalConfig";
}
}



ST_9cac82fc47e32e1503b2dbc00140aa98Structure.init();

export class ST_e828cdbd51e0c1ef095bd323f6e2875aStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsFlipped", "isFlippedAttr", "IsFlipped", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("FlipSelf", "flipSelfAttr", "FlipSelf", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "FlipContent_InternalConfig";
}
}



ST_e828cdbd51e0c1ef095bd323f6e2875aStructure.init();

export class ST_546a3060996e070a522a708cd2d94c23Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("RowItemsPhone", "rowItemsPhoneAttr", "RowItemsPhone", false, false, OS.DataTypes.DataTypes.PhoneNumber, function () {
return "";
}, true), 
this.attr("RowItemsTablet", "rowItemsTabletAttr", "RowItemsTablet", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("RowItemsDesktop", "rowItemsDesktopAttr", "RowItemsDesktop", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ItemsGap", "itemsGapAttr", "ItemsGap", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Gallery_InternalConfig";
}
}



ST_546a3060996e070a522a708cd2d94c23Structure.init();

export class ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("MinValue", "minValueAttr", "MinValue", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("MaxValue", "maxValueAttr", "MaxValue", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("StartingValueFrom", "startingValueFromAttr", "StartingValueFrom", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("StartingValueTo", "startingValueToAttr", "StartingValueTo", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Step", "stepAttr", "Step", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true), 
this.attr("ShowTickMarks", "showTickMarksAttr", "ShowTickMarks", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("TickMarksInterval", "tickMarksIntervalAttr", "TickMarksInterval", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Orientation", "orientationAttr", "Orientation", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.orientation.horizontal;
}, true), 
this.attr("Size", "sizeAttr", "Size", false, false, OS.DataTypes.DataTypes.Text, function () {
return "100%";
}, true), 
this.attr("ShowFloatingLabel", "showFloatingLabelAttr", "ShowFloatingLabel", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("InitialValueFrom", "initialValueFromAttr", "InitialValueFrom", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("InitialValueTo", "initialValueToAttr", "InitialValueTo", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "RangeSlider_InternalConfig";
}
}



ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure.init();

export class EN_5d1279724e719322292e34ef3c5500a0EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Position", "positionAttr", "Position", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_5d1279724e719322292e34ef3c5500a0EntityRecord(new EN_5d1279724e719322292e34ef3c5500a0EntityRecord.RecordClass({
positionAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Position";
}
}



EN_5d1279724e719322292e34ef3c5500a0EntityRecord.init();

export class EN_5be8b31925746693c09b3f64c4898006EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Month", "monthAttr", "Month", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Month";
}
}



EN_5be8b31925746693c09b3f64c4898006EntityRecord.init();

export class ST_b96c67f06fdfae580256b7081d85460dStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("MinTime", "minTimeAttr", "MinTime", false, false, OS.DataTypes.DataTypes.Time, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MaxTime", "maxTimeAttr", "MaxTime", false, false, OS.DataTypes.DataTypes.Time, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "TimePickerOptionalConfigs";
}
}



ST_b96c67f06fdfae580256b7081d85460dStructure.init();

export class ST_60f22bd2e9b10a22278b8afe6d7f601aStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Value", "valueAttr", "value", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Label", "labelAttr", "label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ImageUrlOrIconClass", "imageUrlOrIconClassAttr", "image_url_or_class", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("GroupName", "groupNameAttr", "group_name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Description", "descriptionAttr", "description", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DropdownOption";
}
}



ST_60f22bd2e9b10a22278b8afe6d7f601aStructure.init();

export class ST_613242ff7dd22d356200cb1f89298a39Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("TimeFormat", "timeFormatAttr", "TimeFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Is24Hours", "is24HoursAttr", "Is24Hours", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("InitialTime", "initialTimeAttr", "InitialTime", false, false, OS.DataTypes.DataTypes.Time, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MinTime", "minTimeAttr", "MinTime", false, false, OS.DataTypes.DataTypes.Time, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("MaxTime", "maxTimeAttr", "MaxTime", false, false, OS.DataTypes.DataTypes.Time, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "TimePicker_InternalConfig";
}
}



ST_613242ff7dd22d356200cb1f89298a39Structure.init();

export class ST_eb161a8909408fbd30eac1833398f018Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Shape", "shapeAttr", "Shape", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.shape.rounded;
}, true), 
this.attr("AnimateInitialProgress", "animateInitialProgressAttr", "AnimateInitialProgress", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProgressCircleOptionalConfigs";
}
}



ST_eb161a8909408fbd30eac1833398f018Structure.init();

export class ST_6510d2524fe77fcc6c285159d4000cfbStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Autoplay", "autoplayAttr", "Autoplay", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Loop", "loopAttr", "Loop", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Muted", "mutedAttr", "Muted", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("PosterURL", "posterURLAttr", "PosterURL", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "VideoOptionalConfigs";
}
}



ST_6510d2524fe77fcc6c285159d4000cfbStructure.init();

export class ST_660adb7a9db48bff1b12c6e03515b415Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Desktop", "desktopAttr", "Desktop", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, true), 
this.attr("Tablet", "tabletAttr", "Tablet", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, true), 
this.attr("Phone", "phoneAttr", "Phone", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "CarouselItems";
}
}



ST_660adb7a9db48bff1b12c6e03515b415Structure.init();

export class EN_ac6f62956e278d5390a5f27c607338d0EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Alpha2Code", "alpha2CodeAttr", "Alpha2Code", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("LanguageName", "languageNameAttr", "LanguageName", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DatePickerLanguage";
}
}



EN_ac6f62956e278d5390a5f27c607338d0EntityRecord.init();

export class RC_f01d650db89cbacd8f4a32786da5428e extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Direction", "directionAttr", "Direction", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InitialIntervalEnd", "initialIntervalEndAttr", "InitialIntervalEnd", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("InitialIntervalStart", "initialIntervalStartAttr", "InitialIntervalStart", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("MaxValue", "maxValueAttr", "MaxValue", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("MinValue", "minValueAttr", "MinValue", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("Step", "stepAttr", "Step", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("ChangeEventDuringSlide", "changeEventDuringSlideAttr", "ChangeEventDuringSlide", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsVertical", "isVerticalAttr", "IsVertical", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ShowPips", "showPipsAttr", "ShowPips", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("PipsStep", "pipsStepAttr", "PipsStep", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("VerticalHeight", "verticalHeightAttr", "VerticalHeight", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "f01d650d-b89c-bacd-8f4a-32786da5428e";
}
}



RC_f01d650db89cbacd8f4a32786da5428e.init();

export class EN_df70a614ae02fde4029645a728b2909cEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_df70a614ae02fde4029645a728b2909cEntityRecord(new EN_df70a614ae02fde4029645a728b2909cEntityRecord.RecordClass({
nameAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "RegisteredCallbackEvents";
}
}



EN_df70a614ae02fde4029645a728b2909cEntityRecord.init();

export class ST_71bc196daedd9ac0648bfd56a713859dStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Month", "monthAttr", "Month", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("MonthOrder", "monthOrderAttr", "MonthOrder", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Year", "yearAttr", "Year", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "MonthOrderYear";
}
}



ST_71bc196daedd9ac0648bfd56a713859dStructure.init();

export class ST_936f99e69df60f5aa2563bbd38e49c98Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("OptionsList", "optionsListAttr", "OptionsList", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))), 
this.attr("StartingSelection", "startingSelectionAttr", "StartingSelection", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))), 
this.attr("Prompt", "promptAttr", "Prompt", false, false, OS.DataTypes.DataTypes.Text, function () {
return "Select an item";
}, true), 
this.attr("AllowMultipleSelection", "allowMultipleSelectionAttr", "AllowMultipleSelection", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("NoOptionsText", "noOptionsTextAttr", "NoOptionsText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "0";
}, true), 
this.attr("NoResultsText", "noResultsTextAttr", "NoResultsText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "0";
}, true), 
this.attr("SearchPrompt", "searchPromptAttr", "SearchPrompt", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("SanitizeDropdownValues", "sanitizeDropdownValuesAttr", "SanitizeDropdownValues", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "1";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DropdownSearch_InternalConfigs";
}
}



ST_936f99e69df60f5aa2563bbd38e49c98Structure.init();

export class EN_79dd905420a035342bdbafd506073863EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "LogType";
}
}



EN_79dd905420a035342bdbafd506073863EntityRecord.init();

export class EN_7a28bfa00272cf999603d060780d47ecEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Mode", "modeAttr", "Mode", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_7a28bfa00272cf999603d060780d47ecEntityRecord(new EN_7a28bfa00272cf999603d060780d47ecEntityRecord.RecordClass({
modeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DropdownType";
}
}



EN_7a28bfa00272cf999603d060780d47ecEntityRecord.init();

export class EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Mode", "modeAttr", "Mode", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord(new EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord.RecordClass({
modeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DatePickerCalendarType";
}
}



EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord.init();

export class EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Mode", "modeAttr", "Mode", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord(new EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord.RecordClass({
modeAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "RangeSliderType";
}
}



EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord.init();

export class EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Color", "colorAttr", "Color", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Color";
}
}



EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord.init();

export class RC_98ce383abd92f0f4c51d49a4fcc3bfcc extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsDisable", "isDisableAttr", "IsDisable", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsRemoveItems", "isRemoveItemsAttr", "IsRemoveItems", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "98ce383a-bd92-f0f4-c51d-49a4fcc3bfcc";
}
}



RC_98ce383abd92f0f4c51d49a4fcc3bfcc.init();

export class RC_c3613394da5ea68f302177112ad784ed extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Direction", "directionAttr", "Direction", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InitialValue", "initialValueAttr", "InitialValue", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("MaxValue", "maxValueAttr", "MaxValue", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("MinValue", "minValueAttr", "MinValue", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("Step", "stepAttr", "Step", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("ChangeEventDuringSlide", "changeEventDuringSlideAttr", "ChangeEventDuringSlide", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsVertical", "isVerticalAttr", "IsVertical", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ShowPips", "showPipsAttr", "ShowPips", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("PipsStep", "pipsStepAttr", "PipsStep", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("VerticalHeight", "verticalHeightAttr", "VerticalHeight", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "c3613394-da5e-a68f-3021-77112ad784ed";
}
}



RC_c3613394da5ea68f302177112ad784ed.init();

export class EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Alert", "alertAttr", "Alert", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord(new EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord.RecordClass({
alertAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Alert";
}
}



EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord.init();

export class ST_e3f9af4171d5e4a41700770295d05c77Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ContentAutoHeight", "contentAutoHeightAttr", "ContentAutoHeight", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("JustifyHeaders", "justifyHeadersAttr", "JustifyHeaders", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "TabsOptionalConfigs";
}
}



ST_e3f9af4171d5e4a41700770295d05c77Structure.init();

export class ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("additionalClasses", "additionalClassesAttr", "additionalClasses", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("aliasKey", "aliasKeyAttr", "aliasKey", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("allOptionsSelectedText", "allOptionsSelectedTextAttr", "allOptionsSelectedText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("allowNewOption", "allowNewOptionAttr", "allowNewOption", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("alwaysShowSelectedOptionsCount", "alwaysShowSelectedOptionsCountAttr", "alwaysShowSelectedOptionsCount", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("alwaysShowSelectedOptionsLabel", "alwaysShowSelectedOptionsLabelAttr", "alwaysShowSelectedOptionsLabel", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.false;
}, true), 
this.attr("ariaLabelClearButtonText", "ariaLabelClearButtonTextAttr", "ariaLabelClearButtonText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ariaLabelledby", "ariaLabelledbyAttr", "ariaLabelledby", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ariaLabelSearchClearButtonText", "ariaLabelSearchClearButtonTextAttr", "ariaLabelSearchClearButtonText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ariaLabelTagClearButtonText", "ariaLabelTagClearButtonTextAttr", "ariaLabelTagClearButtonText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ariaLabelText", "ariaLabelTextAttr", "ariaLabelText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("autofocus", "autofocusAttr", "autofocus", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("autoSelectFirstOption", "autoSelectFirstOptionAttr", "autoSelectFirstOption", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("descriptionKey", "descriptionKeyAttr", "descriptionKey", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("disableSelectAll", "disableSelectAllAttr", "disableSelectAll", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("disableAllOptionsSelectedText", "disableAllOptionsSelectedTextAttr", "disableAllOptionsSelectedText", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("disabledOptions", "disabledOptionsAttr", "disabledOptions", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.TextList());
}, true, OS.DataTypes.TextList), 
this.attr("disableOptionGroupCheckbox", "disableOptionGroupCheckboxAttr", "disableOptionGroupCheckbox", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("disableValidation", "disableValidationAttr", "disableValidation", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("dropboxWidth", "dropboxWidthAttr", "dropboxWidth", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("emptyValue", "emptyValueAttr", "emptyValue", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("enableSecureText", "enableSecureTextAttr", "enableSecureText", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("focusSelectedOptionOnOpen", "focusSelectedOptionOnOpenAttr", "focusSelectedOptionOnOpen", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("hideClearButton", "hideClearButtonAttr", "hideClearButton", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("markSearchResults", "markSearchResultsAttr", "markSearchResults", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("keepAlwaysOpen", "keepAlwaysOpenAttr", "keepAlwaysOpen", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("labelKey", "labelKeyAttr", "labelKey", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("maxValues", "maxValuesAttr", "maxValues", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("maxWidth", "maxWidthAttr", "maxWidth", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("minValues", "minValuesAttr", "minValues", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("moreText", "moreTextAttr", "moreText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("noOfDisplayValues", "noOfDisplayValuesAttr", "noOfDisplayValues", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("optionsCount", "optionsCountAttr", "optionsCount", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("optionHeight", "optionHeightAttr", "optionHeight", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("optionSelectedText", "optionSelectedTextAttr", "optionSelectedText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("optionsSelectedText", "optionsSelectedTextAttr", "optionsSelectedText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("popupDropboxBreakpoint", "popupDropboxBreakpointAttr", "popupDropboxBreakpoint", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("popupPosition", "popupPositionAttr", "popupPosition", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("position", "positionAttr", "position", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("required", "requiredAttr", "required", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("search", "searchAttr", "search", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("searchByStartsWith", "searchByStartsWithAttr", "searchByStartsWith", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("searchFormLabel", "searchFormLabelAttr", "searchFormLabel", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("searchGroup", "searchGroupAttr", "searchGroup", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("searchNormalize", "searchNormalizeAttr", "searchNormalize", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("selectAllOnlyVisible", "selectAllOnlyVisibleAttr", "selectAllOnlyVisible", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("selectAllText", "selectAllTextAttr", "selectAllText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("showDropboxAsPopup", "showDropboxAsPopupAttr", "showDropboxAsPopup", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("showOptionsOnlyOnSearch", "showOptionsOnlyOnSearchAttr", "showOptionsOnlyOnSearch", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("showDuration", "showDurationAttr", "showDuration", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("showSelectedOptionsFirst", "showSelectedOptionsFirstAttr", "showSelectedOptionsFirst", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.booleanTypes.unset;
}, true), 
this.attr("textDirection", "textDirectionAttr", "textDirection", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("valueKey", "valueKeyAttr", "valueKey", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("zIndex", "zIndexAttr", "zIndex", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("hideDuration", "hideDurationAttr", "hideDuration", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "VirtualSelectConfigs";
}
}



ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure.init();

export class ST_f2d4817754eec123207470e41d7a01d7Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("OptionsList", "optionsListAttr", "OptionsList", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))), 
this.attr("StartingSelection", "startingSelectionAttr", "StartingSelection", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))), 
this.attr("Prompt", "promptAttr", "Prompt", false, false, OS.DataTypes.DataTypes.Text, function () {
return "Select an item";
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("NoOptionsText", "noOptionsTextAttr", "NoOptionsText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "0";
}, true), 
this.attr("NoResultsText", "noResultsTextAttr", "NoResultsText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "0";
}, true), 
this.attr("SearchPrompt", "searchPromptAttr", "SearchPrompt", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("SanitizeDropdownValues", "sanitizeDropdownValuesAttr", "SanitizeDropdownValues", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "1";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DropdownTags_InternalConfigs";
}
}



ST_f2d4817754eec123207470e41d7a01d7Structure.init();

export class RC_aa6f2a469018f20449b52bedd4074e46 extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Calendar", "calendarAttr", "Calendar", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("CalendarDates", "calendarDatesAttr", "CalendarDates", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("CloseCalendar", "closeCalendarAttr", "CloseCalendar", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DateSelected", "dateSelectedAttr", "DateSelected", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DaySelected", "daySelectedAttr", "DaySelected", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DaysInRange", "daysInRangeAttr", "DaysInRange", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DialogButton", "dialogButtonAttr", "DialogButton", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("EndRange", "endRangeAttr", "EndRange", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("EnterCalendar", "enterCalendarAttr", "EnterCalendar", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("GoToToday", "goToTodayAttr", "GoToToday", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("HasEvent", "hasEventAttr", "HasEvent", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsDisabled", "isDisabledAttr", "IsDisabled", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsToday", "isTodayAttr", "IsToday", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("KeyboardShortcuts", "keyboardShortcutsAttr", "KeyboardShortcuts", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Month", "monthAttr", "Month", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("MonthNext", "monthNextAttr", "MonthNext", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("MonthPrevious", "monthPreviousAttr", "MonthPrevious", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Navigation", "navigationAttr", "Navigation", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("OpenCalendar", "openCalendarAttr", "OpenCalendar", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("StartRange", "startRangeAttr", "StartRange", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Year", "yearAttr", "Year", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ShortcutsDialog", "shortcutsDialogAttr", "ShortcutsDialog", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(RC_4c3ee0d0ad514546e23495b0186f9086))());
}, true, (OS.GenericTypeCache.getGenericList(RC_4c3ee0d0ad514546e23495b0186f9086)))
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "aa6f2a46-9018-f204-49b5-2bedd4074e46";
}
}



RC_aa6f2a469018f20449b52bedd4074e46.init();

export class EN_c1e622743b79c1510fd62a0adf89686bEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("SideMenuBehavior", "sideMenuBehaviorAttr", "SideMenuBehavior", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord(new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord.RecordClass({
sideMenuBehaviorAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "SideMenuBehavior";
}
}



EN_c1e622743b79c1510fd62a0adf89686bEntityRecord.init();

export class RC_edb482045d64b0cbbcbf62278fb73c32 extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Midnight", "midnightAttr", "Midnight", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("NextMonth", "nextMonthAttr", "NextMonth", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Noon", "noonAttr", "Noon", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("PreviousMonth", "previousMonthAttr", "PreviousMonth", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("TodayButton", "todayButtonAttr", "TodayButton", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Weekdays", "weekdaysAttr", "Weekdays", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(RC_d3d7d244571ed038dbfee008e77e8c11))());
}, true, (OS.GenericTypeCache.getGenericList(RC_d3d7d244571ed038dbfee008e77e8c11))), 
this.attr("WeekdaysShort", "weekdaysShortAttr", "WeekdaysShort", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(RC_bbab5f70da1d7251909f44ce9efe20fa))());
}, true, (OS.GenericTypeCache.getGenericList(RC_bbab5f70da1d7251909f44ce9efe20fa))), 
this.attr("Months", "monthsAttr", "Months", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(RC_35ce9df1ad7a89533b2e8a49a8413520))());
}, true, (OS.GenericTypeCache.getGenericList(RC_35ce9df1ad7a89533b2e8a49a8413520)))
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "edb48204-5d64-b0cb-bcbf-62278fb73c32";
}
}



RC_edb482045d64b0cbbcbf62278fb73c32.init();



