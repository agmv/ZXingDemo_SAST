namespace ssZXingLibDemo {
/// <summary>
/// [ReferenceStructure] Wifi (tMdIjxaPa0WmK1ygQloMtw)
///  <code>ST_af04a340a4a61afef041397e6f042234Structure</code> that represents <code>Wifi</code
/// > <p>Description: Defines a Wifi connection</p>
/// </summary>
// Name: Wifi
public partial struct ST_af04a340a4a61afef041397e6f042234Structure : ITypedRecord<ST_af04a340a4a61afef041397e6f042234Structure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdSSID = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*0LrnBAJsIyE2ON2gcLlitQ");
internal static readonly GlobalObjectKey Idpassword = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*_VnzyHsFd4cAK++pb+gqFA");
internal static readonly GlobalObjectKey Idauthentication = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*v9CbN4dPL9brsW7x+d_nLg");
internal static readonly GlobalObjectKey IdisHidden = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*i3Jwm5oxGZ4NrqDJoN7H9A");
internal static readonly GlobalObjectKey IdeapMethod = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*7QpXD09hOdn65Nbk8BCjFA");
internal static readonly GlobalObjectKey IdanonymousIdentity = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*gFV74zZGSyYUVzYo8LgK1A");
internal static readonly GlobalObjectKey Ididentity = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*Vi_NoUspvl3ZMu9rcq2vjw");
internal static readonly GlobalObjectKey Idphase2Method = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*SuwiI0uHkr6jRIWN661QVg");

public static void EnsureInitialized(){}

static ST_af04a340a4a61afef041397e6f042234Structure() {
ST_af04a340a4a61afef041397e6f042234StructureTypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("SSID")]
public string ssSSID;

[System.Xml.Serialization.XmlElement("password")]
public string sspassword;

[System.Xml.Serialization.XmlElement("authentication")]
public string ssauthentication;

[System.Xml.Serialization.XmlElement("isHidden")]
public bool ssisHidden;

[System.Xml.Serialization.XmlElement("eapMethod")]
public string sseapMethod;

[System.Xml.Serialization.XmlElement("anonymousIdentity")]
public string ssanonymousIdentity;

[System.Xml.Serialization.XmlElement("identity")]
public string ssidentity;

[System.Xml.Serialization.XmlElement("phase2Method")]
public string ssphase2Method;


public BitArray OptimizedAttributes;

public ST_af04a340a4a61afef041397e6f042234Structure() {
OptimizedAttributes = null;
ssSSID = "";
sspassword = "";
ssauthentication = "";
ssisHidden = false;
sseapMethod = "";
ssanonymousIdentity = "";
ssidentity = "";
ssphase2Method = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSSID = r.ReadText(index++, "Wifi.SSID", "");
sspassword = r.ReadText(index++, "Wifi.password", "");
ssauthentication = r.ReadText(index++, "Wifi.authentication", "");
ssisHidden = r.ReadBoolean(index++, "Wifi.isHidden", false);
sseapMethod = r.ReadText(index++, "Wifi.eapMethod", "");
ssanonymousIdentity = r.ReadText(index++, "Wifi.anonymousIdentity", "");
ssidentity = r.ReadText(index++, "Wifi.identity", "");
ssphase2Method = r.ReadText(index++, "Wifi.phase2Method", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_af04a340a4a61afef041397e6f042234Structure r) {
this = r;
}


public static bool operator == (ST_af04a340a4a61afef041397e6f042234Structure a, ST_af04a340a4a61afef041397e6f042234Structure b) {
if (a.ssSSID != b.ssSSID) return false;
if (a.sspassword != b.sspassword) return false;
if (a.ssauthentication != b.ssauthentication) return false;
if (a.ssisHidden != b.ssisHidden) return false;
if (a.sseapMethod != b.sseapMethod) return false;
if (a.ssanonymousIdentity != b.ssanonymousIdentity) return false;
if (a.ssidentity != b.ssidentity) return false;
if (a.ssphase2Method != b.ssphase2Method) return false;
return true;
}

public static bool operator != (ST_af04a340a4a61afef041397e6f042234Structure a, ST_af04a340a4a61afef041397e6f042234Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_af04a340a4a61afef041397e6f042234Structure)) return false;
return (this == (ST_af04a340a4a61afef041397e6f042234Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSSID.GetHashCode()
 ^ sspassword.GetHashCode()
 ^ ssauthentication.GetHashCode()
 ^ ssisHidden.GetHashCode()
 ^ sseapMethod.GetHashCode()
 ^ ssanonymousIdentity.GetHashCode()
 ^ ssidentity.GetHashCode()
 ^ ssphase2Method.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_af04a340a4a61afef041397e6f042234Structure Duplicate() {
ST_af04a340a4a61afef041397e6f042234Structure t;
t.ssSSID = this.ssSSID;
t.sspassword = this.sspassword;
t.ssauthentication = this.ssauthentication;
t.ssisHidden = this.ssisHidden;
t.sseapMethod = this.sseapMethod;
t.ssanonymousIdentity = this.ssanonymousIdentity;
t.ssidentity = this.ssidentity;
t.ssphase2Method = this.ssphase2Method;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "ssid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SSID")) variable.Value = ssSSID; else variable.Optimized = true;
} else if (head == "password") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".password")) variable.Value = sspassword; else variable.Optimized = true;
} else if (head == "authentication") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".authentication")) variable.Value = ssauthentication; else variable.Optimized = true;
} else if (head == "ishidden") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".isHidden")) variable.Value = ssisHidden; else variable.Optimized = true;
} else if (head == "eapmethod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".eapMethod")) variable.Value = sseapMethod; else variable.Optimized = true;
} else if (head == "anonymousidentity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".anonymousIdentity")) variable.Value = ssanonymousIdentity; else variable.Optimized = true;
} else if (head == "identity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".identity")) variable.Value = ssidentity; else variable.Optimized = true;
} else if (head == "phase2method") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".phase2Method")) variable.Value = ssphase2Method; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSSID) {
return ssSSID;
}
if (key == Idpassword) {
return sspassword;
}
if (key == Idauthentication) {
return ssauthentication;
}
if (key == IdisHidden) {
return ssisHidden;
}
if (key == IdeapMethod) {
return sseapMethod;
}
if (key == IdanonymousIdentity) {
return ssanonymousIdentity;
}
if (key == Ididentity) {
return ssidentity;
}
if (key == Idphase2Method) {
return ssphase2Method;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSSID.Key.AsGuid) {
return ssSSID;
}
if (attributeKey == Idpassword.Key.AsGuid) {
return sspassword;
}
if (attributeKey == Idauthentication.Key.AsGuid) {
return ssauthentication;
}
if (attributeKey == IdisHidden.Key.AsGuid) {
return ssisHidden;
}
if (attributeKey == IdeapMethod.Key.AsGuid) {
return sseapMethod;
}
if (attributeKey == IdanonymousIdentity.Key.AsGuid) {
return ssanonymousIdentity;
}
if (attributeKey == Ididentity.Key.AsGuid) {
return ssidentity;
}
if (attributeKey == Idphase2Method.Key.AsGuid) {
return ssphase2Method;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSSID = (string) other.AttributeGet(IdSSID);
sspassword = (string) other.AttributeGet(Idpassword);
ssauthentication = (string) other.AttributeGet(Idauthentication);
ssisHidden = (bool) other.AttributeGet(IdisHidden);
sseapMethod = (string) other.AttributeGet(IdeapMethod);
ssanonymousIdentity = (string) other.AttributeGet(IdanonymousIdentity);
ssidentity = (string) other.AttributeGet(Ididentity);
ssphase2Method = (string) other.AttributeGet(Idphase2Method);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSSID = (string) other.GetAttribute(IdSSID.Key.AsGuid);
sspassword = (string) other.GetAttribute(Idpassword.Key.AsGuid);
ssauthentication = (string) other.GetAttribute(Idauthentication.Key.AsGuid);
ssisHidden = (bool) other.GetAttribute(IdisHidden.Key.AsGuid);
sseapMethod = (string) other.GetAttribute(IdeapMethod.Key.AsGuid);
ssanonymousIdentity = (string) other.GetAttribute(IdanonymousIdentity.Key.AsGuid);
ssidentity = (string) other.GetAttribute(Ididentity.Key.AsGuid);
ssphase2Method = (string) other.GetAttribute(Idphase2Method.Key.AsGuid);
}
} // ST_af04a340a4a61afef041397e6f042234Structure
/// <summary>
/// RecordList type <code>WifiList</code> that represents a record list of <code>Wifi</code>
/// </summary>
public partial class RL_f2e64f914ccf6d33b759f26673529dcd : GenericRecordList<ST_af04a340a4a61afef041397e6f042234Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_af04a340a4a61afef041397e6f042234Structure GetElementDefaultValue() {
return new ST_af04a340a4a61afef041397e6f042234Structure();
}

public T[] ToArray<T>(Func<ST_af04a340a4a61afef041397e6f042234Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f2e64f914ccf6d33b759f26673529dcd recordList, Func<ST_af04a340a4a61afef041397e6f042234Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f2e64f914ccf6d33b759f26673529dcd(ST_af04a340a4a61afef041397e6f042234Structure[] array) {
  RL_f2e64f914ccf6d33b759f26673529dcd result = new RL_f2e64f914ccf6d33b759f26673529dcd();
result.InnerFromArray(array);
    return result;
}

public static RL_f2e64f914ccf6d33b759f26673529dcd ToList<T>(T[] array, Func <T, ST_af04a340a4a61afef041397e6f042234Structure> converter) {
  RL_f2e64f914ccf6d33b759f26673529dcd result = new RL_f2e64f914ccf6d33b759f26673529dcd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f2e64f914ccf6d33b759f26673529dcd FromRestList<T>(RestList<T> restList, Func <T, ST_af04a340a4a61afef041397e6f042234Structure> converter) {
  RL_f2e64f914ccf6d33b759f26673529dcd result = new RL_f2e64f914ccf6d33b759f26673529dcd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f2e64f914ccf6d33b759f26673529dcd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_af04a340a4a61afef041397e6f042234Structure> NewList() {
return new RL_f2e64f914ccf6d33b759f26673529dcd();
}


} // RL_f2e64f914ccf6d33b759f26673529dcd
}

