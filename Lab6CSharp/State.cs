using System;

namespace Lab6CSharp
{
    // Інтерфейси користувача
    public interface INameable
    {
        string Name { get; set; }
    }

    public interface IPopulation
    {
        int Population { get; set; }
    }

    public interface ICapital
    {
        string Capital { get; set; }
    }

    // Базовий клас
    public class State : INameable, IPopulation, ICapital
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string Capital { get; set; }

        // Конструктори
        public State(string name, int population, string capital)
        {
            Name = name;
            Population = population;
            Capital = capital;
        }

        public State(string name) : this(name, 0, "")
        {
        }

        public State(string name, int population) : this(name, population, "")
        {
        }

        // Метод для виведення даних про об'єкт
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("State: " + Name);
            Console.WriteLine("Population: " + Population);
            Console.WriteLine("Capital: " + Capital);
        }
    }

    // Клас Республіка
    public class Republic : State
    {
        public string President { get; set; }

        // Конструктори
        public Republic(string name, int population, string capital, string president) : base(name, population, capital)
        {
            President = president;
        }

        public Republic(string name, string president) : base(name)
        {
            President = president;
        }

        public Republic(string name, int population, string president) : base(name, population)
        {
            President = president;
        }

        // Перевизначений метод для виведення даних про об'єкт
        public new void Show()
        {
            base.Show();
            Console.WriteLine("President: " + President);
        }
    }

    // Клас Монархія
    public class Monarchy : State
    {
        public string Monarch { get; set; }

        // Конструктори
        public Monarchy(string name, int population, string capital, string monarch) : base(name, population, capital)
        {
            Monarch = monarch;
        }

        public Monarchy(string name, string monarch) : base(name)
        {
            Monarch = monarch;
        }

        public Monarchy(string name, int population, string monarch) : base(name, population)
        {
            Monarch = monarch;
        }

        // Перевизначений метод для виведення даних про об'єкт
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Monarch: " + Monarch);
        }
    }

    // Клас Королівство
    public class Kingdom : State
    {
        public string King { get; set; }

        // Конструктори
        public Kingdom(string name, int population, string capital, string king) : base(name, population, capital)
        {
            King = king;
        }

        public Kingdom(string name, string king) : base(name)
        {
            King = king;
        }

        public Kingdom(string name, int population, string king) : base(name, population)
        {
            King = king;
        }

        // Перевизначений метод для виведення даних про об'єкт
        public new void Show()
        {
            base.Show();
            Console.WriteLine("King: " + King);
        }
    }
}