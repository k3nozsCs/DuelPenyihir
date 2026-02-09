wizard wizarda = new wizard("Heru", 10);
wizard wizardb = new wizard("Joko", 12);
string pilihan;

Console.WriteLine("Permainan Dimulai\n");
wizarda.showStat();
wizardb.showStat();

while (wizarda.energi > 0 && wizardb.energi > 0)
{
    Console.WriteLine($"1. {wizarda.name} Menyerang {wizardb.name}");
    Console.WriteLine($"2. {wizardb.name} Menyerang {wizarda.name}");
    Console.WriteLine($"3. {wizarda.name} Melakukan Heal");
    Console.WriteLine($"4. {wizardb.name} Melakukan Heal");

    Console.Write("\nMasukkan Pilihan (1/2/3/4) : ");
    pilihan = Console.ReadLine();

    switch(pilihan)
    {
        case "1":
            wizarda.attack(wizardb);
            break;
        case "2":
            wizardb.attack(wizarda);
            break;
        case "3":
            wizarda.heal();
            break;
        case "4":
            wizardb.heal();
            break;
        default:
            Console.WriteLine("Pilihan Tidak Valid\n");
            break;
    }
}

Console.WriteLine("Permainan Berakhir\n");
wizarda.showStat();
wizardb.showStat();

if (wizarda.energi >wizardb.energi)
{
    Console.WriteLine($"{wizarda.name} Menang!");
}
else
{
    Console.WriteLine($"{wizardb.name} Menang!");
}

public class wizard
{
    //field
    public string name;
    public int energi;
    public int damage;

    //constructor
    public wizard(string nama, int Damage)
    {
       name = nama;
        damage = Damage;
        energi = 50;
    }

    public void showStat()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama : {name}, Enegi : {energi}\n");
    }      

    public void attack(wizard lawan)
    {
        lawan.energi -= damage;
        Console.WriteLine($"{name} menyerang {lawan.name} dengan damage {damage}");
        Console.WriteLine($"Sisa Energi {lawan.name} Adalah {lawan.energi}\n");
    }

    public void heal()
    {
        energi += 5;
        if (energi < 100)
        {
            
            Console.WriteLine($"{name} Melakukan Heal, Energi Meningkat Menjadi {energi} ");
        }
        else
        {
            energi = 100;
            Console.WriteLine("Energi Sudah Penuh");
        }
    }
}