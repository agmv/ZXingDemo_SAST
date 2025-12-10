import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export {entities, setEntities} from "./Extension.ZXingLib.entities-model.js";
export class ST_2f980670f450ae43af56386ae46715c7Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("firstName", "firstNameAttr", "firstName", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("lastName", "lastNameAttr", "lastName", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("middleNames", "middleNamesAttr", "middleNames", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("prefix", "prefixAttr", "prefix", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("suffix", "suffixAttr", "suffix", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ComposedName";
}
}



ST_2f980670f450ae43af56386ae46715c7Structure.init();

export class ST_10cb4adb0f851163080c748983a654c9Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("formatedName", "formatedNameAttr", "formatedName", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("composedName", "composedNameAttr", "composedName", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_2f980670f450ae43af56386ae46715c7Structure());
}, true, ST_2f980670f450ae43af56386ae46715c7Structure), 
this.attr("organization", "organizationAttr", "organization", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("title", "titleAttr", "title", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("homePhone", "homePhoneAttr", "homePhone", false, false, OS.DataTypes.DataTypes.PhoneNumber, function () {
return "";
}, true), 
this.attr("workPhone", "workPhoneAttr", "workPhone", false, false, OS.DataTypes.DataTypes.PhoneNumber, function () {
return "";
}, true), 
this.attr("mobilePhone", "mobilePhoneAttr", "mobilePhone", false, false, OS.DataTypes.DataTypes.PhoneNumber, function () {
return "";
}, true), 
this.attr("email", "emailAttr", "email", false, false, OS.DataTypes.DataTypes.Email, function () {
return "";
}, true), 
this.attr("address", "addressAttr", "address", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("website", "websiteAttr", "website", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("notes", "notesAttr", "notes", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Contact";
}
}



ST_10cb4adb0f851163080c748983a654c9Structure.init();

export class ST_8738e857d4fb6695d1e17d4c03428ee2Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("title", "titleAttr", "title", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("isAllDay", "isAllDayAttr", "isAllDay", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("startDateTime", "startDateTimeAttr", "startDateTime", true, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("endDateTime", "endDateTimeAttr", "endDateTime", true, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("location", "locationAttr", "location", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("description", "descriptionAttr", "description", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("eventClass", "eventClassAttr", "eventClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("organizer", "organizerAttr", "organizer", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("priority", "priorityAttr", "priority", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("showAsBusy", "showAsBusyAttr", "showAsBusy", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "CalendarEvent";
}
}



ST_8738e857d4fb6695d1e17d4c03428ee2Structure.init();

export class ST_a1f7d5fa968628cf9ed1d90efadf9506Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("key", "keyAttr", "key", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("value", "valueAttr", "value", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Metadata";
}
}



ST_a1f7d5fa968628cf9ed1d90efadf9506Structure.init();

export class ST_7750e71a4e018dabac19d9f560c2b017Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("value", "valueAttr", "value", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("rawBytes", "rawBytesAttr", "rawBytes", false, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, true), 
this.attr("format", "formatAttr", "format", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("metadata", "metadataAttr", "metadata", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_a1f7d5fa968628cf9ed1d90efadf9506Structure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_a1f7d5fa968628cf9ed1d90efadf9506Structure))), 
this.attr("detectedBarcode", "detectedBarcodeAttr", "detectedBarcode", false, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Barcode";
}
}



ST_7750e71a4e018dabac19d9f560c2b017Structure.init();

export class ST_af04a340a4a61afef041397e6f042234Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("SSID", "sSIDAttr", "SSID", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("password", "passwordAttr", "password", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("authentication", "authenticationAttr", "authentication", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("isHidden", "isHiddenAttr", "isHidden", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("eapMethod", "eapMethodAttr", "eapMethod", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("anonymousIdentity", "anonymousIdentityAttr", "anonymousIdentity", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("identity", "identityAttr", "identity", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("phase2Method", "phase2MethodAttr", "phase2Method", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Wifi";
}
}



ST_af04a340a4a61afef041397e6f042234Structure.init();



