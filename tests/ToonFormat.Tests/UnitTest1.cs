using Toon.Format;

namespace ToonFormat.Tests;

public class ToonEncoderTests
{
    [Fact]
    public void Encode_ThrowsNotImplementedException()
    {
        // Arrange
        var data = new { name = "test" };

        // Act & Assert
        Assert.Throws<NotImplementedException>(() => ToonEncoder.Encode(data));
    }
}

public class ToonDecoderTests
{
    [Fact]
    public void Decode_ThrowsNotImplementedException()
    {
        // Arrange
        var toonString = "name:test";

        // Act & Assert
        Assert.Throws<NotImplementedException>(() => ToonDecoder.Decode(toonString));
    }
}
