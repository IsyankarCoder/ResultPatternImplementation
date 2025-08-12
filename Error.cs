public class Error
{
    public Error(string message)
    {
        Message = message;

    }

    public string Message { get;  }


    public static Error None => new Error(string.Empty);

    public static implicit operator Error(string message)
    {
        return new Error(message);
    }

    public static implicit operator string(Error error)
    {
        return error.Message;
    }
    public override string ToString()
    {
        return Message;
    }
}