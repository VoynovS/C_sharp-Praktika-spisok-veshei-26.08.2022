using System;

public class Spisok {
    string enterThing(string text) {
        Console.WriteLine(text);
        return Console.ReadLine();
    }

    public static int vvod(string text) {
        Console.Write(text);
        return int.Parse(Console.ReadLine());
    }

    public Spisok(int id, string name) {
        id_ = id;
        name_ = name;
    }

    public Spisok(int id) {
        id_ = id;
        name_ = enterThing("Введите наименование вещи: ");
    }

    public int id_ { get; set; }

    public string name_ { get; set; }

    public override string ToString() {
        return $"Наименование: {name_}";
    }
}
