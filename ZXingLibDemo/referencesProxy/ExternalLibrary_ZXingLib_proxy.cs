// Proxy for reference ExternalLibrary with name ZXingLib and key islO4p9noEWLsn7krB1VIA
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssZXingLibDemo;
using ssZXingLibDemo.ReferencesProxy;
namespace ssZXingLibDemo.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssZXingLibDemo {
/// <summary>
/// Class: RssExternalLibraryZXingLib
/// </summary>
public partial class RssExternalLibraryZXingLib {
/// <summary>
/// Extension Variable: issZXingLib
/// </summary>
protected static OutSystems.NssZXingLib.IssZXingLib issZXingLib =(OutSystems.NssZXingLib.IssZXingLib)ServiceLocator.GetService<OutSystems.NssZXingLib.CssZXingLib>();
protected static readonly string extensionVersion = typeof(OutSystems.NssZXingLib.CssZXingLib).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssZXingLibDemo.RssExternalLibraryZXingLib");
public static async Task<byte[]> MssEncodeLocation(IRequestContext requestContext,string inParamlatitude,string inParamlongitude,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("EncodeLocation", "540b8674-259b-44ef-9a07-a80651c04389", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
outParamBarcodeImage = await issZXingLib.MssEncodeLocation(inParamlatitude,inParamlongitude,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBarcodeImage;
}


public static async Task<OutSystems.Application.Extensibility.DataTypes.IRecord> MssDecode(IRequestContext requestContext,byte[] inParamimage,string inParamformatHint,bool inParamdetectionImage,CancellationToken cancellationToken) {
OutSystems.Application.Extensibility.DataTypes.IRecord outParamBarcode = default;
outParamBarcode = ssZXingLibDemo.RssExternalLibraryZXingLib.Factory.FactoryST_7750e71a4e018dabac19d9f560c2b017StructureSingleton.CreateRssExternalLibraryZXingLibST_7750e71a4e018dabac19d9f560c2b017Structure();
OutSystems.NssZXingLib.ST_7750e71a4e018dabac19d9f560c2b017Structure _proxyoutParamBarcode = new OutSystems.NssZXingLib.ST_7750e71a4e018dabac19d9f560c2b017Structure();
cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("Decode", "a2212147-d3e1-4080-98af-974fcd4411b7", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
_proxyoutParamBarcode = await issZXingLib.MssDecode(inParamimage,inParamformatHint,inParamdetectionImage,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamBarcode.CopyFrom(_proxyoutParamBarcode);await Task.Yield();
return outParamBarcode;
}


public static async Task<byte[]> MssEncodeEmail(IRequestContext requestContext,string inParamemail,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("EncodeEmail", "94fc1b6b-6eef-4174-80e8-a572b5b307f5", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
outParamBarcodeImage = await issZXingLib.MssEncodeEmail(inParamemail,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBarcodeImage;
}


public static async Task<byte[]> MssEncodePhoneNumber(IRequestContext requestContext,string inParamphoneNumber,bool inParamisFacetime,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("EncodePhoneNumber", "e708245f-6eff-4e9b-8872-ca2940d0586f", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
outParamBarcodeImage = await issZXingLib.MssEncodePhoneNumber(inParamphoneNumber,inParamisFacetime,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBarcodeImage;
}


public static async Task<byte[]> MssEncode(IRequestContext requestContext,string inParamcontents,string inParamformat,int inParamwidth,int inParamheight,int inParammargin,bool inParampureBarcode,bool inParamgS1Format,bool inParamnoPadding,string inParamencoding,string inParamecl,int inParamqRCodeVersion,byte[] inParamoverlayImage,string inParamforceShape,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("Encode", "28d98690-9b0e-450d-a0bb-869afacac9c8", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
outParamBarcodeImage = await issZXingLib.MssEncode(inParamcontents,inParamformat,inParamwidth,inParamheight,inParammargin,inParampureBarcode,inParamgS1Format,inParamnoPadding,inParamencoding,inParamecl,inParamqRCodeVersion,inParamoverlayImage,inParamforceShape,inParamoutputFormat,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBarcodeImage;
}


public static async Task<byte[]> MssEncodeContact(IRequestContext requestContext,OutSystems.Application.Extensibility.DataTypes.IRecord inParamcontact,bool inParamisMeCard,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
var _proxyinParamcontact = new OutSystems.NssZXingLib.ST_10cb4adb0f851163080c748983a654c9Structure();
_proxyinParamcontact.CopyFrom(inParamcontact);cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("EncodeContact", "7aec8a6b-65cd-4952-9758-78b3dd7b69fb", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
outParamBarcodeImage = await issZXingLib.MssEncodeContact(_proxyinParamcontact,inParamisMeCard,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBarcodeImage;
}


public static async Task<OutSystems.Application.Extensibility.DataTypes.IRecordList> MssDecodeMulti(IRequestContext requestContext,byte[] inParamimage,string inParamformatHint,bool inParamdetectionImage,CancellationToken cancellationToken) {
OutSystems.Application.Extensibility.DataTypes.IRecordList outParamBarcodes = default;
outParamBarcodes = ssZXingLibDemo.RssExternalLibraryZXingLib.Factory.FactoryRL_8fdc1c2bcc6f385410bdb8a93bd26489Singleton.CreateRssExternalLibraryZXingLibRL_8fdc1c2bcc6f385410bdb8a93bd26489();
OutSystems.NssZXingLib.RL_8fdc1c2bcc6f385410bdb8a93bd26489 _proxyoutParamBarcodes = new OutSystems.NssZXingLib.RL_8fdc1c2bcc6f385410bdb8a93bd26489();
cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("DecodeMulti", "d88174e7-211a-431f-8692-48fa2eb48b9d", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
_proxyoutParamBarcodes = await issZXingLib.MssDecodeMulti(inParamimage,inParamformatHint,inParamdetectionImage,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamBarcodes.CopyFrom(_proxyoutParamBarcodes);await Task.Yield();
return outParamBarcodes;
}


public static async Task<byte[]> MssEncodeWifi(IRequestContext requestContext,OutSystems.Application.Extensibility.DataTypes.IRecord inParamwifi,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
var _proxyinParamwifi = new OutSystems.NssZXingLib.ST_af04a340a4a61afef041397e6f042234Structure();
_proxyinParamwifi.CopyFrom(inParamwifi);cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("EncodeWifi", "280b83f0-216c-4147-abfb-093720971f59", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
outParamBarcodeImage = await issZXingLib.MssEncodeWifi(_proxyinParamwifi,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBarcodeImage;
}


public static async Task<byte[]> MssEncodeCalendarEvent(IRequestContext requestContext,OutSystems.Application.Extensibility.DataTypes.IRecord inParamcalendarEvent,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
var _proxyinParamcalendarEvent = new OutSystems.NssZXingLib.ST_8738e857d4fb6695d1e17d4c03428ee2Structure();
_proxyinParamcalendarEvent.CopyFrom(inParamcalendarEvent);cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("EncodeCalendarEvent", "f7ee1e29-258d-4ff0-b36d-703e64ec5cc6", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
outParamBarcodeImage = await issZXingLib.MssEncodeCalendarEvent(_proxyinParamcalendarEvent,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBarcodeImage;
}


public static async Task<byte[]> MssEncodeSMS(IRequestContext requestContext,string inParamphoneNumber,string inParammessage,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("EncodeSMS", "945a1919-3b7d-4491-8376-554f0500df16", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
outParamBarcodeImage = await issZXingLib.MssEncodeSMS(inParamphoneNumber,inParammessage,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBarcodeImage;
}


public static async Task<BasicTypeList<string>> MssEncoders(IRequestContext requestContext,CancellationToken cancellationToken) {
BasicTypeList<string> outParamFormats = default;
outParamFormats = new BasicTypeList<string>();
BasicTypeList<string> _proxyoutParamFormats = new BasicTypeList<string>();
cancellationToken.ThrowIfCancellationRequested();
try {
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("Encoders", "0bc17901-1da2-495e-ae74-7160c903358f", "ZXingLib", "e24ec98a-679f-45a0-8bb2-7ee4ac1d5520", extensionVersion) : null){
_proxyoutParamFormats = await issZXingLib.MssEncoders(cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamFormats.FillFromOther(_proxyoutParamFormats);await Task.Yield();
return outParamFormats;
}


public interface IRC_57ba3d0d08ca4ec872815e3480261d89TypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_57ba3d0d08ca4ec872815e3480261d89();
}
public interface IST_7750e71a4e018dabac19d9f560c2b017StructureTypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_7750e71a4e018dabac19d9f560c2b017Structure();
}
public interface IRL_7919f33989696cd32796fc8e261021d2TypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecordList CreateRssExternalLibraryZXingLibRL_7919f33989696cd32796fc8e261021d2();
}
public interface IRC_7ef51ad4bf41859d359e0a9b0b3ca1b5TypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_7ef51ad4bf41859d359e0a9b0b3ca1b5();
}
public interface IST_a1f7d5fa968628cf9ed1d90efadf9506StructureTypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
}
public interface IRC_53f0d7ad72d5d8edb7688d7ec561c618TypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_53f0d7ad72d5d8edb7688d7ec561c618();
}
public interface IST_10cb4adb0f851163080c748983a654c9StructureTypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_10cb4adb0f851163080c748983a654c9Structure();
}
public interface IRC_957e93eddd28d08c07d4a328c870138aTypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_957e93eddd28d08c07d4a328c870138a();
}
public interface IST_2f980670f450ae43af56386ae46715c7StructureTypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_2f980670f450ae43af56386ae46715c7Structure();
}
public interface IRL_8fdc1c2bcc6f385410bdb8a93bd26489TypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecordList CreateRssExternalLibraryZXingLibRL_8fdc1c2bcc6f385410bdb8a93bd26489();
}
public interface IRC_df417030a22338c6546ba4bfe47f9e17TypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_df417030a22338c6546ba4bfe47f9e17();
}
public interface IST_af04a340a4a61afef041397e6f042234StructureTypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_af04a340a4a61afef041397e6f042234Structure();
}
public interface IRC_2796116ff1beb3c001fb57dc12652270TypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibRC_2796116ff1beb3c001fb57dc12652270();
}
public interface IST_8738e857d4fb6695d1e17d4c03428ee2StructureTypeFactory {
OutSystems.Application.Extensibility.DataTypes.IRecord CreateRssExternalLibraryZXingLibST_8738e857d4fb6695d1e17d4c03428ee2Structure();
}

public class Factory {
public static IST_7750e71a4e018dabac19d9f560c2b017StructureTypeFactory FactoryST_7750e71a4e018dabac19d9f560c2b017StructureSingleton;
public static IRL_8fdc1c2bcc6f385410bdb8a93bd26489TypeFactory FactoryRL_8fdc1c2bcc6f385410bdb8a93bd26489Singleton;
public static IRC_57ba3d0d08ca4ec872815e3480261d89TypeFactory FactoryRC_57ba3d0d08ca4ec872815e3480261d89Singleton;
public static IST_8738e857d4fb6695d1e17d4c03428ee2StructureTypeFactory FactoryST_8738e857d4fb6695d1e17d4c03428ee2StructureSingleton;
public static IRC_2796116ff1beb3c001fb57dc12652270TypeFactory FactoryRC_2796116ff1beb3c001fb57dc12652270Singleton;
public static IST_2f980670f450ae43af56386ae46715c7StructureTypeFactory FactoryST_2f980670f450ae43af56386ae46715c7StructureSingleton;
public static IRC_957e93eddd28d08c07d4a328c870138aTypeFactory FactoryRC_957e93eddd28d08c07d4a328c870138aSingleton;
public static IST_10cb4adb0f851163080c748983a654c9StructureTypeFactory FactoryST_10cb4adb0f851163080c748983a654c9StructureSingleton;
public static IRC_53f0d7ad72d5d8edb7688d7ec561c618TypeFactory FactoryRC_53f0d7ad72d5d8edb7688d7ec561c618Singleton;
public static IST_a1f7d5fa968628cf9ed1d90efadf9506StructureTypeFactory FactoryST_a1f7d5fa968628cf9ed1d90efadf9506StructureSingleton;
public static IRL_7919f33989696cd32796fc8e261021d2TypeFactory FactoryRL_7919f33989696cd32796fc8e261021d2Singleton;
public static IRC_7ef51ad4bf41859d359e0a9b0b3ca1b5TypeFactory FactoryRC_7ef51ad4bf41859d359e0a9b0b3ca1b5Singleton;
public static IST_af04a340a4a61afef041397e6f042234StructureTypeFactory FactoryST_af04a340a4a61afef041397e6f042234StructureSingleton;
public static IRC_df417030a22338c6546ba4bfe47f9e17TypeFactory FactoryRC_df417030a22338c6546ba4bfe47f9e17Singleton;
}
public class DefaultValues {
}
}
}
