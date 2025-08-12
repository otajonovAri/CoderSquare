namespace CoderSquare.Domain.Enum;

public enum SubmissionStatus
{
    Pending, Accepted, WrongAnswer,
    TimeLimitException, CompileTimeError,
    RunTimeError
}