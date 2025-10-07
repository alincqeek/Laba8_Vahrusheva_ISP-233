using System;
class Hero
{
    public string Name { get; set; }
    public int Mana { get; set; }

    public int Level { get; set; }
    private int heatalth;
    public int maxHealth;
    public Hero(string name, int maxHealt)
    {
        Name = name;
        maxHealt = maxHealt;
        Mana = 100;
        Level = 1;
    }

    public int Health
    {
        get => heatalth;
        set
        {
            if (value < 0)
            {
                heatalth = 0;
            }
            else if (value > maxHealth) { heatalth = maxHealth; }
            else { heatalth = value; }
        }
    }
    public string Status
    {
        get
        {
            if (heatalth > 0) return "Жив";
            else return "Погиб";
        }
    }

    public void TakeDamage(int damage)
    {
        if (heatalth <= 0) { Console.WriteLine($"{Name} уже погиб и не может получить рон "); return; }
        heatalth -= damage;
        Console.WriteLine($"{Name} получил {damage} урона. HP: {heatalth}| Статус: {Status}");
    }
    public void Heal(int amount)
    {
        if (heatalth <= 0) { Console.WriteLine($"{Name} уже погиб и не может быть исцелен "); return; }
        heatalth += amount;
        Console.WriteLine($"{Name} исцелен на {amount}. HP: {heatalth}| Статус: {Status}");
    }


}
