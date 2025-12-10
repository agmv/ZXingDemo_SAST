namespace ssOutSystemsMaps;

/// <summary>
/// User Defined Exception class: ValidationException
/// </summary>
public class Ex_ValidationExceptionUserException : UserException {

/// <summary>
/// User Defined Exception (ValidationException) constructor:
/// </summary>
public Ex_ValidationExceptionUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "OutSystemsMaps.ValidationException";
}

}
