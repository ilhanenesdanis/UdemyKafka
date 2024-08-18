using Confluent.Kafka.Admin;
using Confluent.Kafka;

namespace Kafka.Producer
{
    public class KafkaService
    {
        public async Task CrateTopic(string topicName)
        {

            using var adminClient = new AdminClientBuilder(new AdminClientConfig()
            {
                BootstrapServers = "localhost:9094"
            }).Build();

            try
            {
                await adminClient.CreateTopicsAsync(new[]
                {
                   new TopicSpecification(){Name=topicName,NumPartitions=3,ReplicationFactor=1}
 
                });
                Console.WriteLine($"{topicName} is created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }




        }
    }
}
