using ZooERP.Application.Services;
using ZooERP.Domain.Animals;
using ZooERP.Domain.Animals.ZooERP.Domain.Animals;

namespace ZooERP.ConsoleApp.UI
{
    public class ConsoleMenu
    {
        private readonly ZooService _zooService;

        public ConsoleMenu(ZooService zooService)
        {
            _zooService = zooService;
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddAnimal();
                        break;
                    case "2":
                        ShowTotalFood();
                        break;
                    case "3":
                        ShowContactZooAnimals();
                        break;
                    case "4":
                        ShowAllAnimals();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("\n=== Zoo ERP ===");
            Console.WriteLine("1. Добавить животное");
            Console.WriteLine("2. Показать общее потребление еды");
            Console.WriteLine("3. Контактный зоопарк");
            Console.WriteLine("4. Все животные на балансе");
            Console.WriteLine("0. Выход");
            Console.Write("Выбор: ");
        }

        private void AddAnimal()
        {
            Console.WriteLine("Выберите тип животного:");
            Console.WriteLine("1. Кролик");
            Console.WriteLine("2. Обезьяна");
            Console.WriteLine("3. Тигр");
            Console.WriteLine("4. Волк");

            var type = Console.ReadLine();

            Console.Write("Имя: ");
            var name = Console.ReadLine()!;

            Console.Write("Инвентарный номер: ");
            var number = int.Parse(Console.ReadLine()!);

            Animal animal = type switch
            {
                "1" => CreateHerbo(() => new Rabbit(name, number, ReadKindness())),
                "2" => CreateHerbo(() => new Monkey(name, number, ReadKindness())),
                "3" => new Tiger(name, number),
                "4" => new Wolf(name, number),
                _ => throw new InvalidOperationException("Неизвестный тип")
            };

            if (_zooService.TryAddAnimal(animal))
                Console.WriteLine("Животное принято в зоопарк");
            else
                Console.WriteLine("Животное НЕ прошло медосмотр");
        }

        private int ReadKindness()
        {
            Console.Write("Уровень доброты (0-10): ");
            return int.Parse(Console.ReadLine()!);
        }

        private Animal CreateHerbo(Func<Animal> factory) => factory();

        private void ShowTotalFood()
        {
            Console.WriteLine(
                $"Всего еды в сутки: {_zooService.GetTotalFoodPerDay()} кг");
        }

        private void ShowContactZooAnimals()
        {
            Console.WriteLine("Контактный зоопарк:");
            foreach (var animal in _zooService.GetContactZooAnimals())
            {
                Console.WriteLine($"{animal.Name}, доброта {animal.KindnessLevel}");
            }
        }

        private void ShowAllAnimals()
        {
            Console.WriteLine("Животные на балансе:");
            foreach (var animal in _zooService.GetAllAnimals())
            {
                Console.WriteLine($"{animal.Name}, инв. № {animal.InventoryNumber}");
            }
        }
    }
}
