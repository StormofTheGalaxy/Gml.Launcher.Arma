using System.Runtime.Serialization;

namespace L1.Avalonia.Gif.Decoding;

[Serializable]
public class InvalidGifStreamException : Exception
{
    public InvalidGifStreamException()
    {
    }

    public InvalidGifStreamException(string message) : base(message)
    {
    }

    public InvalidGifStreamException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidGifStreamException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
