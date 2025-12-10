namespace ssZXingLibDemo;

/// <summary>
/// User Defined Exception class: NotZXingLibDemo
/// </summary>
public class Ex_NotZXingLibDemoRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotZXingLibDemo) constructor:
/// </summary>
public Ex_NotZXingLibDemoRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ZXingLibDemo.NotZXingLibDemo";
}

}
