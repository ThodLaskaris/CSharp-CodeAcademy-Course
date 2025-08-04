using System;
using System.Text;
using MQTTnet;
using MQTTnet.Client;


class Program
{
  private static IMqttClient mqttClient; // Declare the mqtt client variable
  private static string brokerHost = "broker.hivemq.com"; // Public MQTT broker
  private static int brokerPort = 1883; // Default MQTT port
  private static string clientId = "TestClient_" + Guid.NewGuid().ToString(); // Unique client ID

  /*
  Guid.NewGuid() creating a unique identifier 
  To call it either ToString or ${}.
  */

  static async Task Main(string[] args)
  {
    // Creating mqtt client 

    var factory = new MqttFactory();
    mqttClient = factory.CreateMqttClient();

    // event handlers 
    mqttClient.ConnectedAsync += OnConnectedAsync; // adding event to handle the connection 
    mqttClient.DisconnectedAsync += OnDisconnectedAsync; // adding mevent to handle the disconenctino  
    mqttClient.ApplicationMessageReceivedAsync += OnMessageReceivedAsync; // adding event to handle the message received


    // adding try catch to handle exception

    try
    {
      await ConnectToBrokerAsync(); // Connecting to the broker 
                                    // debugg
      Console.WriteLine("connected to the broker.");
      Console.ReadKey();           // user input to exit the console app.
    }
    catch (Exception ex)
    {
      Console.WriteLine($"error {ex.Message}");
    }
    finally
    {
      await mqttClient.DisconnectAsync(); // disconnecting from the broker.
    }
  }

  static async Task ConnectToBrokerAsync()
  {

    // method chaining στην option.
    var options = new MqttClientOptionsBuilder()
    .WithTcpServer(brokerHost, brokerPort)
    .WithClientId(clientId)
    .Build();

    await mqttClient.ConnectAsync(options);
  }

  static Task OnConnectedAsync(MqttClientConnectedEventArgs e)
  {
    // dbugging
    System.Console.WriteLine($"Connected");
    return Task.CompletedTask;
  }
  static Task OnDisconnectedAsync(MqttClientDisconnectedEventArgs e)
  {
    // debugging
    System.Console.WriteLine($"Disconnected");
    return Task.CompletedTask;
  }

  static Task OnMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs e)
  {
    Console.WriteLine($"message recieved  {e.ApplicationMessage.Topic}");
    return Task.CompletedTask;
  }
}