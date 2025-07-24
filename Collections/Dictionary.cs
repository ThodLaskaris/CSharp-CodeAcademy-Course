using System;

class Program
{
  //   Dictionary<TKey, TValue> is a generic collection that maps keys to values
  public static Dictionary<TKey, TValue> CreateDictionary<TKey, TValue>(TKey key, TValue value)
  {
    Dictionary<TKey, TValue> result = new();
    result.Add(key, value);
    return result;
  }
  public static example1()
  {
    Dictionary<string, int> sensorData = new();
    sensorData.Add("sensor_living_room", 10);
    sensorData.Add("sensor_bathroom", 20);
    sensorData.Add("sensor_bedroom", 30);
  }
  static void Main(string[] args)
  {
    //  Accessing the sensorData Dictionary.
    var livingRoomData = sensorData["sensor_living_room"];
    Console.WriteLine($"Living room Sensor Data: {livingRoomData}");

    // try to access a key that does not exist in dictionary.

    int bedRoomData;
    if (sensorData.TryGetValue("sensor_bedroom", out bedroomData))
    {
      Console.WriteLine($"Bedroom sensor data: {bedRoomData}");
    }
    else
    {
      Console.WriteLine("Bedroom sensor data not found.");
    }
  }
}