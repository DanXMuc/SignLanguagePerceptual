using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[Serializable()]
public class SignGesture : ISerializable
{
    public string GestureName = "";
    public List<NormalizedHandData> Data = new List<NormalizedHandData>();

    public SignGesture(string GestureName)
    {
        this.GestureName = GestureName;
    }

    public void AddPXCMHandData(NormalizedHandData data)
    {
        Data.Add(data);
    }

    public SignGesture(SerializationInfo info, StreamingContext context)
    {
        this.GestureName = (string)info.GetValue("name", typeof(string));
        this.Data = (List<NormalizedHandData>)info.GetValue("data", typeof(List<NormalizedHandData>));
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("data", this.Data);
        info.AddValue("name", this.GestureName);
    }
}
