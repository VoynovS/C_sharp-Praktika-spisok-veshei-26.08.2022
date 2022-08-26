// See https://aka.ms/new-console-template for more information

FileInfo file = new FileInfo(@"C:\Users\З - 11\Documents\Войнов Сергей\Save\Osnovnoyspisok.txt");


int count = Spisok.vvod("Введите количество вещей: ");

List<Spisok> osnovnoi = new List<Spisok>();

for (int i = 0; i < count; i++) {
    osnovnoi.Add(new Spisok(i + 1));
}

using (StreamWriter writer = new(@"C:\Users\З - 11\Documents\Войнов Сергей\Save\Osnovnoyspisok.txt", true)) {
    foreach(var item in osnovnoi) { 
    writer.WriteLine(item.ToString());
    }
}

void showSpisok() {
Console.WriteLine("Все вещи:");
string s = " ";
foreach (var item in osnovnoi) {
    Console.WriteLine(item.ToString());
    s = item.ToString();
   }
}


Console.WriteLine();
showSpisok();
Console.WriteLine();
//Console.WriteLine("Добавить список? Да/Нет");
//string yesNo = Console.ReadLine(); 
int num = 0;
List<string> spisokSpiskov = new List<string>();

Console.WriteLine("[1] Добавить список.");
Console.WriteLine("[2] Удалить список.");
Console.WriteLine("[3] Вывести все списки.");
int num1 = int.Parse(Console.ReadLine());
switch (num1) {
    case 1:
        Console.WriteLine("Введите название списка: ");
        List<Spisok> osnovnoi1 = new List<Spisok>();
        string spisok = Console.ReadLine();
        spisokSpiskov.Add(spisok);
        using (StreamWriter writer2 = new(@"C:\Users\З - 11\Documents\Войнов Сергей\Save\spisokSpiskov.txt", true)) {
             writer2.WriteLine(spisok);
            
        }

        using (StreamWriter writer1 = new(@"C:\Users\З - 11\Documents\Войнов Сергей\Save\" + spisok + ".txt", true)) {
            foreach (var item in osnovnoi1) {
                writer1.WriteLine(item.ToString());
            }
        }
        break;
     case 2:
        Console.WriteLine("Введите название списка: ");
        string delSpisok = Console.ReadLine();
        
        break;
     default:
        break;

}

//if (yesNo == "Да") {



/*while (num == 0) {
    Console.WriteLine("Введите название списка: ");
    List<Spisok> osnovnoi1 = new List<Spisok>();
    string spisok = Console.ReadLine();
    using (StreamWriter writer1 = new(@"C:\Users\З - 11\Documents\Войнов Сергей\Save\" + spisok + ".txt", true)) {
        foreach (var item in osnovnoi1) {
            writer1.WriteLine(item.ToString());
        }
    }

}*/
//}




