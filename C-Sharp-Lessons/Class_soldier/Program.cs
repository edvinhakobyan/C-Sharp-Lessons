using System;


class Soldier
{
    string name;
    string surname;
    int age;
    bool gender;       //true if man
    string nation;
    string bloodType;  //in ABO system
    string weapon;

    public Soldier() { }

    public Soldier(string name, string surname, int age, bool gender, string nation, string bloodType, string weapon)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.gender = gender;
        this.nation = nation;
        this.bloodType = bloodType;
        this.weapon = weapon;
    }

    public void SetSoldierName(string Name) { name = Name; }
    public void SetSoldierSurname(string Surname) { surname = Surname; }
    public void SetSoldierAge(int Age) { age = Age; }
    public void SetSoldierGender(bool Gender) { gender = Gender; }
    public void SetSoldierNation(string Nation) { nation = Nation; }
    public void SetSoldierBloodType(string BloodType) { bloodType = BloodType; }
    public void SetSoldierWeapon(string Weapon) { weapon = Weapon; }


    public void PrintSoldierField(SoldField fld)
    {
        switch (fld)
        {
            case SoldField.Name: Write(name); break;
            case SoldField.Surname: Write(surname); break;
            case SoldField.Age: Write(Convert.ToString(age)); break;
            case SoldField.Nation: Write(nation); break;
            case SoldField.BloodType: Write(Convert.ToString(bloodType)); break;
            case SoldField.Weapon: Write(weapon); break;
        }
    }
    void Write(string str)
    {
        Console.WriteLine(str);
    }
}

public enum SoldField
{
    Name = 1,
    Surname,
    Age,
    Gender,
    Nation,
    BloodType,
    Weapon
}



class Program
{
    static void Main(string[] args)
    {
        Soldier soldier = new Soldier();
        soldier.SetSoldierName("Jhon");
        soldier.SetSoldierSurname("Smith");
        soldier.SetSoldierAge(32);
        soldier.SetSoldierGender(true);
        soldier.SetSoldierNation("Armenian");
        soldier.SetSoldierBloodType("B_positive");
        soldier.SetSoldierWeapon("AK-74");

        soldier.PrintSoldierField(SoldField.Name);
        soldier.PrintSoldierField(SoldField.Surname);
        soldier.PrintSoldierField(SoldField.Age);
        soldier.PrintSoldierField(SoldField.Gender);
        soldier.PrintSoldierField(SoldField.Nation);
        soldier.PrintSoldierField(SoldField.BloodType);
        soldier.PrintSoldierField(SoldField.Weapon);

        Soldier anatherSolder = new Soldier("Volodia", "Ivanov", 35, true, "Rusian", "A_positive", "M4");

       anatherSolder.PrintSoldierField(SoldField.Name);
       anatherSolder.PrintSoldierField(SoldField.Surname);
       anatherSolder.PrintSoldierField(SoldField.Age);
       anatherSolder.PrintSoldierField(SoldField.Gender);
       anatherSolder.PrintSoldierField(SoldField.Nation);
       anatherSolder.PrintSoldierField(SoldField.BloodType);
       anatherSolder.PrintSoldierField(SoldField.Weapon);
    }

}









    

/*
 * 
 *

*/