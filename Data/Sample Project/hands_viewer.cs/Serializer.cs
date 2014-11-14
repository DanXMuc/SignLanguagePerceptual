using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Serializer
{
    public Serializer()
    {
    }

    public void SerializeObject(string filename, SignGesture objectToSerialize)
    {
        Stream stream = File.Open(filename, FileMode.Create);
        BinaryFormatter bFormatter = new BinaryFormatter();
        bFormatter.Serialize(stream, objectToSerialize);
        stream.Close();
    }

    public SignGesture DeSerializeObject(string filename)
    {
        SignGesture objectToSerialize;
        Stream stream = File.Open(filename, FileMode.Open);
        BinaryFormatter bFormatter = new BinaryFormatter();
        objectToSerialize = (SignGesture)bFormatter.Deserialize(stream);
        stream.Close();
        return objectToSerialize;
    }
}