namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (HK3nnL3zjEa0jctziAAhAA)
///  <code>RC_4c3ee0d0ad514546e23495b0186f9086</code> that represent
/// s
///  <code>ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDial
/// og6ShortcutsDialog7ShortcutsDialog8Record</code> <p>Description: </p>
/// </summary>
// Name: ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record
public partial struct RC_4c3ee0d0ad514546e23495b0186f9086 : ITypedRecord<RC_4c3ee0d0ad514546e23495b0186f9086> {
internal static readonly GlobalObjectKey IdShortcutsDialog1 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ih6dsFRSjRuEX1tdqRJR1A");
internal static readonly GlobalObjectKey IdShortcutsDialog2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TVLo5gTDSUFSG6zmEcNvDw");
internal static readonly GlobalObjectKey IdShortcutsDialog3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fOQYUNkKQihMBjJCSYcvLA");
internal static readonly GlobalObjectKey IdShortcutsDialog4 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*JlYpXChuUDto_6FOszK+xQ");
internal static readonly GlobalObjectKey IdShortcutsDialog5 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*f7bB2fqjorJrwf+Do91FIA");
internal static readonly GlobalObjectKey IdShortcutsDialog6 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3a4RbNDV0WMaEzjvuMwIw");
internal static readonly GlobalObjectKey IdShortcutsDialog7 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4hmRYskmHS5wjcr9y2qsvw");
internal static readonly GlobalObjectKey IdShortcutsDialog8 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mxmLY0r4vT_KSBzQbNE7AA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ShortcutsDialog1")]
public string ssShortcutsDialog1;

[System.Xml.Serialization.XmlElement("ShortcutsDialog2")]
public string ssShortcutsDialog2;

[System.Xml.Serialization.XmlElement("ShortcutsDialog3")]
public string ssShortcutsDialog3;

[System.Xml.Serialization.XmlElement("ShortcutsDialog4")]
public string ssShortcutsDialog4;

[System.Xml.Serialization.XmlElement("ShortcutsDialog5")]
public string ssShortcutsDialog5;

[System.Xml.Serialization.XmlElement("ShortcutsDialog6")]
public string ssShortcutsDialog6;

[System.Xml.Serialization.XmlElement("ShortcutsDialog7")]
public string ssShortcutsDialog7;

[System.Xml.Serialization.XmlElement("ShortcutsDialog8")]
public string ssShortcutsDialog8;


public BitArray OptimizedAttributes;

public RC_4c3ee0d0ad514546e23495b0186f9086() {
OptimizedAttributes = null;
ssShortcutsDialog1 = "";
ssShortcutsDialog2 = "";
ssShortcutsDialog3 = "";
ssShortcutsDialog4 = "";
ssShortcutsDialog5 = "";
ssShortcutsDialog6 = "";
ssShortcutsDialog7 = "";
ssShortcutsDialog8 = "";
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
ssShortcutsDialog1 = r.ReadText(index++, "ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record.ShortcutsDialog1", "");
ssShortcutsDialog2 = r.ReadText(index++, "ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record.ShortcutsDialog2", "");
ssShortcutsDialog3 = r.ReadText(index++, "ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record.ShortcutsDialog3", "");
ssShortcutsDialog4 = r.ReadText(index++, "ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record.ShortcutsDialog4", "");
ssShortcutsDialog5 = r.ReadText(index++, "ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record.ShortcutsDialog5", "");
ssShortcutsDialog6 = r.ReadText(index++, "ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record.ShortcutsDialog6", "");
ssShortcutsDialog7 = r.ReadText(index++, "ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record.ShortcutsDialog7", "");
ssShortcutsDialog8 = r.ReadText(index++, "ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record.ShortcutsDialog8", "");
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
public void ReadIM(RC_4c3ee0d0ad514546e23495b0186f9086 r) {
this = r;
}


public static bool operator == (RC_4c3ee0d0ad514546e23495b0186f9086 a, RC_4c3ee0d0ad514546e23495b0186f9086 b) {
if (a.ssShortcutsDialog1 != b.ssShortcutsDialog1) return false;
if (a.ssShortcutsDialog2 != b.ssShortcutsDialog2) return false;
if (a.ssShortcutsDialog3 != b.ssShortcutsDialog3) return false;
if (a.ssShortcutsDialog4 != b.ssShortcutsDialog4) return false;
if (a.ssShortcutsDialog5 != b.ssShortcutsDialog5) return false;
if (a.ssShortcutsDialog6 != b.ssShortcutsDialog6) return false;
if (a.ssShortcutsDialog7 != b.ssShortcutsDialog7) return false;
if (a.ssShortcutsDialog8 != b.ssShortcutsDialog8) return false;
return true;
}

public static bool operator != (RC_4c3ee0d0ad514546e23495b0186f9086 a, RC_4c3ee0d0ad514546e23495b0186f9086 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4c3ee0d0ad514546e23495b0186f9086)) return false;
return (this == (RC_4c3ee0d0ad514546e23495b0186f9086)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssShortcutsDialog1.GetHashCode()
 ^ ssShortcutsDialog2.GetHashCode()
 ^ ssShortcutsDialog3.GetHashCode()
 ^ ssShortcutsDialog4.GetHashCode()
 ^ ssShortcutsDialog5.GetHashCode()
 ^ ssShortcutsDialog6.GetHashCode()
 ^ ssShortcutsDialog7.GetHashCode()
 ^ ssShortcutsDialog8.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_4c3ee0d0ad514546e23495b0186f9086 Duplicate() {
RC_4c3ee0d0ad514546e23495b0186f9086 t;
t.ssShortcutsDialog1 = this.ssShortcutsDialog1;
t.ssShortcutsDialog2 = this.ssShortcutsDialog2;
t.ssShortcutsDialog3 = this.ssShortcutsDialog3;
t.ssShortcutsDialog4 = this.ssShortcutsDialog4;
t.ssShortcutsDialog5 = this.ssShortcutsDialog5;
t.ssShortcutsDialog6 = this.ssShortcutsDialog6;
t.ssShortcutsDialog7 = this.ssShortcutsDialog7;
t.ssShortcutsDialog8 = this.ssShortcutsDialog8;
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
if (head == "shortcutsdialog1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortcutsDialog1")) variable.Value = ssShortcutsDialog1; else variable.Optimized = true;
} else if (head == "shortcutsdialog2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortcutsDialog2")) variable.Value = ssShortcutsDialog2; else variable.Optimized = true;
} else if (head == "shortcutsdialog3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortcutsDialog3")) variable.Value = ssShortcutsDialog3; else variable.Optimized = true;
} else if (head == "shortcutsdialog4") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortcutsDialog4")) variable.Value = ssShortcutsDialog4; else variable.Optimized = true;
} else if (head == "shortcutsdialog5") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortcutsDialog5")) variable.Value = ssShortcutsDialog5; else variable.Optimized = true;
} else if (head == "shortcutsdialog6") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortcutsDialog6")) variable.Value = ssShortcutsDialog6; else variable.Optimized = true;
} else if (head == "shortcutsdialog7") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortcutsDialog7")) variable.Value = ssShortcutsDialog7; else variable.Optimized = true;
} else if (head == "shortcutsdialog8") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortcutsDialog8")) variable.Value = ssShortcutsDialog8; else variable.Optimized = true;
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
if (key == IdShortcutsDialog1) {
return ssShortcutsDialog1;
}
if (key == IdShortcutsDialog2) {
return ssShortcutsDialog2;
}
if (key == IdShortcutsDialog3) {
return ssShortcutsDialog3;
}
if (key == IdShortcutsDialog4) {
return ssShortcutsDialog4;
}
if (key == IdShortcutsDialog5) {
return ssShortcutsDialog5;
}
if (key == IdShortcutsDialog6) {
return ssShortcutsDialog6;
}
if (key == IdShortcutsDialog7) {
return ssShortcutsDialog7;
}
if (key == IdShortcutsDialog8) {
return ssShortcutsDialog8;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShortcutsDialog1.Key.AsGuid) {
return ssShortcutsDialog1;
}
if (attributeKey == IdShortcutsDialog2.Key.AsGuid) {
return ssShortcutsDialog2;
}
if (attributeKey == IdShortcutsDialog3.Key.AsGuid) {
return ssShortcutsDialog3;
}
if (attributeKey == IdShortcutsDialog4.Key.AsGuid) {
return ssShortcutsDialog4;
}
if (attributeKey == IdShortcutsDialog5.Key.AsGuid) {
return ssShortcutsDialog5;
}
if (attributeKey == IdShortcutsDialog6.Key.AsGuid) {
return ssShortcutsDialog6;
}
if (attributeKey == IdShortcutsDialog7.Key.AsGuid) {
return ssShortcutsDialog7;
}
if (attributeKey == IdShortcutsDialog8.Key.AsGuid) {
return ssShortcutsDialog8;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssShortcutsDialog1 = (string) other.AttributeGet(IdShortcutsDialog1);
ssShortcutsDialog2 = (string) other.AttributeGet(IdShortcutsDialog2);
ssShortcutsDialog3 = (string) other.AttributeGet(IdShortcutsDialog3);
ssShortcutsDialog4 = (string) other.AttributeGet(IdShortcutsDialog4);
ssShortcutsDialog5 = (string) other.AttributeGet(IdShortcutsDialog5);
ssShortcutsDialog6 = (string) other.AttributeGet(IdShortcutsDialog6);
ssShortcutsDialog7 = (string) other.AttributeGet(IdShortcutsDialog7);
ssShortcutsDialog8 = (string) other.AttributeGet(IdShortcutsDialog8);
}
} // RC_4c3ee0d0ad514546e23495b0186f9086
/// <summary>
/// RecordList type
///  <code>ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDial
/// og6ShortcutsDialog7ShortcutsDialog8RecordList</code> that represents a record list of <code>Text,
///  Text, Text, Text, Text, Text, Text, Text</code>
/// </summary>
public partial class RL_52688881ccfed8dc2d89a4eb45a2498e : GenericRecordList<RC_4c3ee0d0ad514546e23495b0186f9086>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_4c3ee0d0ad514546e23495b0186f9086 GetElementDefaultValue() {
return new RC_4c3ee0d0ad514546e23495b0186f9086();
}

public T[] ToArray<T>(Func<RC_4c3ee0d0ad514546e23495b0186f9086, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_52688881ccfed8dc2d89a4eb45a2498e recordList, Func<RC_4c3ee0d0ad514546e23495b0186f9086, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_52688881ccfed8dc2d89a4eb45a2498e(RC_4c3ee0d0ad514546e23495b0186f9086[] array) {
  RL_52688881ccfed8dc2d89a4eb45a2498e result = new RL_52688881ccfed8dc2d89a4eb45a2498e();
result.InnerFromArray(array);
    return result;
}

public static RL_52688881ccfed8dc2d89a4eb45a2498e ToList<T>(T[] array, Func <T, RC_4c3ee0d0ad514546e23495b0186f9086> converter) {
  RL_52688881ccfed8dc2d89a4eb45a2498e result = new RL_52688881ccfed8dc2d89a4eb45a2498e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_52688881ccfed8dc2d89a4eb45a2498e FromRestList<T>(RestList<T> restList, Func <T, RC_4c3ee0d0ad514546e23495b0186f9086> converter) {
  RL_52688881ccfed8dc2d89a4eb45a2498e result = new RL_52688881ccfed8dc2d89a4eb45a2498e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_52688881ccfed8dc2d89a4eb45a2498e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4c3ee0d0ad514546e23495b0186f9086> NewList() {
return new RL_52688881ccfed8dc2d89a4eb45a2498e();
}


} // RL_52688881ccfed8dc2d89a4eb45a2498e
}

