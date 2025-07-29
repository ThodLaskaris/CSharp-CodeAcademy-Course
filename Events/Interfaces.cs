using System;



public interface ISensor
{
  public event EventHandler<SensorArgs> SensorTriggered;
}

public class Sensor
{

}

public class TemperatureSensor
{

}

public class SensorArgs : EventArgs
{
  public string Name { get; }
  public double Value { get; }

  public SensorArgs(string name, double value)
  {
    Name = name;
    Value = value;
  }
}
public class SensorSubscriber
{
  public void HandleSensorTriggered(object sender, SensorArgs e)
  {
    Console.WriteLine($"Sensor {e.Name} triggered with value {e.Value}.");
  }
}

public class Program
{
  public static void Main()
  {
    var sensor = new TemperatureSensor();
    var subscriber = new SensorSubscriber();
    sensor.SensorTriggered += subscriber.HandleSensorTriggered;
    sensor.TakeReading(98.6);

  }
}