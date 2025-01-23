/* Домашнее задание 13.2 Создать класс для нескольких зданий. Поле класса – массив на 10
зданий. В классе создать индексатор, возвращающий здание по его номеру..*/

using System;
public class Building
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Building(string name, string address)
    {
        Name = name;
        Address = address;
    }
}
public class Buildings
{
    private Building[] buildings = new Building[10];
    public Building this[int index]
    {
        get
        {
            if (index < 0 || index >= buildings.Length)
                throw new IndexOutOfRangeException("Индекс вне диапазона.");
            return buildings[index];
        }
        set
        {
            if (index < 0 || index >= buildings.Length)
                throw new IndexOutOfRangeException("Индекс вне диапазона.");
            buildings[index] = value;
        }
    }
}
