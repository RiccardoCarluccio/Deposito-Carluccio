using Es_3_Dependency_Injection_Singleton;
using Es_3_Dependency_Injection_Singleton.Singleton;

var instance = AppConfig.Instance;

instance.NomeApp = "App";
instance.Valuta = "Euro";
instance.AliquotaIva = 21;

ILogger logger = new LoggerService(instance);
var orderService = new OrderService(logger);

orderService.CreateOrder("Pair of shoes", "completed");