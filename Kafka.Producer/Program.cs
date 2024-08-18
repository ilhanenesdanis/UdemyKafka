using Kafka.Producer;


string topicName = "topic_one";

KafkaService service = new KafkaService();

await service.CrateTopic(topicName);
