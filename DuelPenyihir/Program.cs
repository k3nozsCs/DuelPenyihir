wizard wizarda = new wizard("Heru", 10, 100);
wizard wizardb = new wizard("Joko", 12, 100);

Console.WriteLine("Permainan Dimulai\n");
wizarda.showStat();
wizardb.showStat();

wizarda.attack(wizardb);
wizardb.attack(wizarda);
wizarda.attack(wizardb);

Console.WriteLine("Permainan Berakhir\n");
wizarda.showStat();
wizardb.showStat();

public class wizard
{
    //field
    public string name;
    public int energi;
    public int damage;

    //constructor
    public wizard(string name, int damage, int energi)
    {
        this.name = name;       
        this.damage = damage;
        this.energi = energi;
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


}