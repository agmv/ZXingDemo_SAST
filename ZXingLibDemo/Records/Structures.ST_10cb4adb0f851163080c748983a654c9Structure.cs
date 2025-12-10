namespace ssZXingLibDemo {
/// <summary>
/// [ReferenceStructure] Contact (X25P0XAr+EKvWhCXUooWkA)
///  <code>ST_10cb4adb0f851163080c748983a654c9Structure</code> that represents <code>Contact</code
/// > <p>Description: Defines a this to be shared as a QR code</p>
/// </summary>
// Name: Contact
public partial struct ST_10cb4adb0f851163080c748983a654c9Structure : ITypedRecord<ST_10cb4adb0f851163080c748983a654c9Structure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdformatedName = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*PfwD0wkOQaRV7b25dZqLcg");
internal static readonly GlobalObjectKey IdcomposedName = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*kZr7g9bjx+RAF233KvibHA");
internal static readonly GlobalObjectKey Idorganization = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*W8GtY6bMIAPJdrLOHwWjtw");
internal static readonly GlobalObjectKey Idtitle = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*bVYt9hg4dfa88Q2CFgx3eg");
internal static readonly GlobalObjectKey IdhomePhone = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*_4e17DaqKWOJQS+A7_t+7w");
internal static readonly GlobalObjectKey IdworkPhone = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*dVetxl+X3Sg+lgA9+kgJtQ");
internal static readonly GlobalObjectKey IdmobilePhone = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*9_RXGfrcw3k+VzEi7iLYIQ");
internal static readonly GlobalObjectKey Idemail = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*fTllraTqn5gk3lLrfJTZ+g");
internal static readonly GlobalObjectKey Idaddress = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*LKog7zb_YPoJ3cwyp8S7VQ");
internal static readonly GlobalObjectKey Idwebsite = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*ZqF8IS4inKFBpRr8a5f0nQ");
internal static readonly GlobalObjectKey Idnotes = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*L8Pm30E+31cQ33lH5fTzqA");

public static void EnsureInitialized(){}

static ST_10cb4adb0f851163080c748983a654c9Structure() {
ST_10cb4adb0f851163080c748983a654c9StructureTypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("formatedName")]
public string ssformatedName;

[System.Xml.Serialization.XmlElement("composedName")]
public ST_2f980670f450ae43af56386ae46715c7Structure sscomposedName;

[System.Xml.Serialization.XmlElement("organization")]
public string ssorganization;

[System.Xml.Serialization.XmlElement("title")]
public string sstitle;

[System.Xml.Serialization.XmlElement("homePhone")]
public string sshomePhone;

[System.Xml.Serialization.XmlElement("workPhone")]
public string ssworkPhone;

[System.Xml.Serialization.XmlElement("mobilePhone")]
public string ssmobilePhone;

[System.Xml.Serialization.XmlElement("email")]
public string ssemail;

[System.Xml.Serialization.XmlElement("address")]
public string ssaddress;

[System.Xml.Serialization.XmlElement("website")]
public string sswebsite;

[System.Xml.Serialization.XmlElement("notes")]
public string ssnotes;


public BitArray OptimizedAttributes;

public ST_10cb4adb0f851163080c748983a654c9Structure() {
OptimizedAttributes = null;
ssformatedName = "";
sscomposedName = new ST_2f980670f450ae43af56386ae46715c7Structure();
ssorganization = "";
sstitle = "";
sshomePhone = "";
ssworkPhone = "";
ssmobilePhone = "";
ssemail = "";
ssaddress = "";
sswebsite = "";
ssnotes = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    sscomposedName.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssformatedName = r.ReadText(index++, "Contact.formatedName", "");
ssorganization = r.ReadText(index++, "Contact.organization", "");
sstitle = r.ReadText(index++, "Contact.title", "");
sshomePhone = r.ReadPhoneNumber(index++, "Contact.homePhone", "");
ssworkPhone = r.ReadPhoneNumber(index++, "Contact.workPhone", "");
ssmobilePhone = r.ReadPhoneNumber(index++, "Contact.mobilePhone", "");
ssemail = r.ReadEmail(index++, "Contact.email", "");
ssaddress = r.ReadText(index++, "Contact.address", "");
sswebsite = r.ReadText(index++, "Contact.website", "");
ssnotes = r.ReadText(index++, "Contact.notes", "");
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
public void ReadIM(ST_10cb4adb0f851163080c748983a654c9Structure r) {
this = r;
}


public static bool operator == (ST_10cb4adb0f851163080c748983a654c9Structure a, ST_10cb4adb0f851163080c748983a654c9Structure b) {
if (a.ssformatedName != b.ssformatedName) return false;
if (a.sscomposedName != b.sscomposedName) return false;
if (a.ssorganization != b.ssorganization) return false;
if (a.sstitle != b.sstitle) return false;
if (a.sshomePhone != b.sshomePhone) return false;
if (a.ssworkPhone != b.ssworkPhone) return false;
if (a.ssmobilePhone != b.ssmobilePhone) return false;
if (a.ssemail != b.ssemail) return false;
if (a.ssaddress != b.ssaddress) return false;
if (a.sswebsite != b.sswebsite) return false;
if (a.ssnotes != b.ssnotes) return false;
return true;
}

public static bool operator != (ST_10cb4adb0f851163080c748983a654c9Structure a, ST_10cb4adb0f851163080c748983a654c9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_10cb4adb0f851163080c748983a654c9Structure)) return false;
return (this == (ST_10cb4adb0f851163080c748983a654c9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssformatedName.GetHashCode()
 ^ sscomposedName.GetHashCode()
 ^ ssorganization.GetHashCode()
 ^ sstitle.GetHashCode()
 ^ sshomePhone.GetHashCode()
 ^ ssworkPhone.GetHashCode()
 ^ ssmobilePhone.GetHashCode()
 ^ ssemail.GetHashCode()
 ^ ssaddress.GetHashCode()
 ^ sswebsite.GetHashCode()
 ^ ssnotes.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
sscomposedName.RecursiveReset();
}

public void InternalRecursiveSave() {
sscomposedName.InternalRecursiveSave();
}


public ST_10cb4adb0f851163080c748983a654c9Structure Duplicate() {
ST_10cb4adb0f851163080c748983a654c9Structure t;
t.ssformatedName = this.ssformatedName;
t.sscomposedName = (ST_2f980670f450ae43af56386ae46715c7Structure)this.sscomposedName.Duplicate();
t.ssorganization = this.ssorganization;
t.sstitle = this.sstitle;
t.sshomePhone = this.sshomePhone;
t.ssworkPhone = this.ssworkPhone;
t.ssmobilePhone = this.ssmobilePhone;
t.ssemail = this.ssemail;
t.ssaddress = this.ssaddress;
t.sswebsite = this.sswebsite;
t.ssnotes = this.ssnotes;
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
if (head == "formatedname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".formatedName")) variable.Value = ssformatedName; else variable.Optimized = true;
} else if (head == "composedname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".composedName")) variable.Value = sscomposedName; else variable.Optimized = true;
variable.SetFieldName("composedname");
} else if (head == "organization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".organization")) variable.Value = ssorganization; else variable.Optimized = true;
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".title")) variable.Value = sstitle; else variable.Optimized = true;
} else if (head == "homephone") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".homePhone")) variable.Value = sshomePhone; else variable.Optimized = true;
} else if (head == "workphone") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".workPhone")) variable.Value = ssworkPhone; else variable.Optimized = true;
} else if (head == "mobilephone") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".mobilePhone")) variable.Value = ssmobilePhone; else variable.Optimized = true;
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".email")) variable.Value = ssemail; else variable.Optimized = true;
} else if (head == "address") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".address")) variable.Value = ssaddress; else variable.Optimized = true;
} else if (head == "website") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".website")) variable.Value = sswebsite; else variable.Optimized = true;
} else if (head == "notes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".notes")) variable.Value = ssnotes; else variable.Optimized = true;
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
if (key == IdformatedName) {
return ssformatedName;
}
if (key == IdcomposedName) {
return sscomposedName;
}
if (key == Idorganization) {
return ssorganization;
}
if (key == Idtitle) {
return sstitle;
}
if (key == IdhomePhone) {
return sshomePhone;
}
if (key == IdworkPhone) {
return ssworkPhone;
}
if (key == IdmobilePhone) {
return ssmobilePhone;
}
if (key == Idemail) {
return ssemail;
}
if (key == Idaddress) {
return ssaddress;
}
if (key == Idwebsite) {
return sswebsite;
}
if (key == Idnotes) {
return ssnotes;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdformatedName.Key.AsGuid) {
return ssformatedName;
}
if (attributeKey == IdcomposedName.Key.AsGuid) {
return sscomposedName;
}
if (attributeKey == Idorganization.Key.AsGuid) {
return ssorganization;
}
if (attributeKey == Idtitle.Key.AsGuid) {
return sstitle;
}
if (attributeKey == IdhomePhone.Key.AsGuid) {
return sshomePhone;
}
if (attributeKey == IdworkPhone.Key.AsGuid) {
return ssworkPhone;
}
if (attributeKey == IdmobilePhone.Key.AsGuid) {
return ssmobilePhone;
}
if (attributeKey == Idemail.Key.AsGuid) {
return ssemail;
}
if (attributeKey == Idaddress.Key.AsGuid) {
return ssaddress;
}
if (attributeKey == Idwebsite.Key.AsGuid) {
return sswebsite;
}
if (attributeKey == Idnotes.Key.AsGuid) {
return ssnotes;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssformatedName = (string) other.AttributeGet(IdformatedName);
sscomposedName.FillFromOther((IRecord) other.AttributeGet(IdcomposedName));
ssorganization = (string) other.AttributeGet(Idorganization);
sstitle = (string) other.AttributeGet(Idtitle);
sshomePhone = (string) other.AttributeGet(IdhomePhone);
ssworkPhone = (string) other.AttributeGet(IdworkPhone);
ssmobilePhone = (string) other.AttributeGet(IdmobilePhone);
ssemail = (string) other.AttributeGet(Idemail);
ssaddress = (string) other.AttributeGet(Idaddress);
sswebsite = (string) other.AttributeGet(Idwebsite);
ssnotes = (string) other.AttributeGet(Idnotes);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssformatedName = (string) other.GetAttribute(IdformatedName.Key.AsGuid);
sscomposedName.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdcomposedName.Key.AsGuid));
ssorganization = (string) other.GetAttribute(Idorganization.Key.AsGuid);
sstitle = (string) other.GetAttribute(Idtitle.Key.AsGuid);
sshomePhone = (string) other.GetAttribute(IdhomePhone.Key.AsGuid);
ssworkPhone = (string) other.GetAttribute(IdworkPhone.Key.AsGuid);
ssmobilePhone = (string) other.GetAttribute(IdmobilePhone.Key.AsGuid);
ssemail = (string) other.GetAttribute(Idemail.Key.AsGuid);
ssaddress = (string) other.GetAttribute(Idaddress.Key.AsGuid);
sswebsite = (string) other.GetAttribute(Idwebsite.Key.AsGuid);
ssnotes = (string) other.GetAttribute(Idnotes.Key.AsGuid);
}
} // ST_10cb4adb0f851163080c748983a654c9Structure
/// <summary>
/// RecordList type <code>ContactList</code> that represents a record list of <code>Contact</code>
/// </summary>
public partial class RL_e2b3063d0c170c1b294da280e286abd6 : GenericRecordList<ST_10cb4adb0f851163080c748983a654c9Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_10cb4adb0f851163080c748983a654c9Structure GetElementDefaultValue() {
return new ST_10cb4adb0f851163080c748983a654c9Structure();
}

public T[] ToArray<T>(Func<ST_10cb4adb0f851163080c748983a654c9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e2b3063d0c170c1b294da280e286abd6 recordList, Func<ST_10cb4adb0f851163080c748983a654c9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e2b3063d0c170c1b294da280e286abd6(ST_10cb4adb0f851163080c748983a654c9Structure[] array) {
  RL_e2b3063d0c170c1b294da280e286abd6 result = new RL_e2b3063d0c170c1b294da280e286abd6();
result.InnerFromArray(array);
    return result;
}

public static RL_e2b3063d0c170c1b294da280e286abd6 ToList<T>(T[] array, Func <T, ST_10cb4adb0f851163080c748983a654c9Structure> converter) {
  RL_e2b3063d0c170c1b294da280e286abd6 result = new RL_e2b3063d0c170c1b294da280e286abd6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e2b3063d0c170c1b294da280e286abd6 FromRestList<T>(RestList<T> restList, Func <T, ST_10cb4adb0f851163080c748983a654c9Structure> converter) {
  RL_e2b3063d0c170c1b294da280e286abd6 result = new RL_e2b3063d0c170c1b294da280e286abd6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e2b3063d0c170c1b294da280e286abd6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_10cb4adb0f851163080c748983a654c9Structure> NewList() {
return new RL_e2b3063d0c170c1b294da280e286abd6();
}


} // RL_e2b3063d0c170c1b294da280e286abd6
}

