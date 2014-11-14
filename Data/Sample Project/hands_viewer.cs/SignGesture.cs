using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[Serializable()]
public class SignGesture : ISerializable
{
    string GestureName = "";
    List<PXCMPoint3DF32> Data = new List<PXCMPoint3DF32>();

    public SignGesture(string GestureName)
    {
        this.GestureName = GestureName;
    }

    public void AddPXCMHandData(PXCMPoint3DF32 data)
    {
        Data.Add(data);
    }

    public SignGesture(SerializationInfo info, StreamingContext context)
    {
        this.GestureName = (string)info.GetValue("name", typeof(string));
        this.Data = (List<PXCMPoint3DF32>)info.GetValue("data", typeof(List<PXCMPoint3DF32>));
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("data", this.Data);
        info.AddValue("name", this.GestureName);
    }
}
