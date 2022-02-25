using System;
namespace ProjectRPG.src.Entities
{
    public  abstract class Form
    {
        public Form(string Name, int Level, string HeroType, int Health, int StrengthAttack){

        this.Name = Name;

        this.Level = Level;

        this.HeroType = HeroType;
        
        this.Health = Health;

        this.StrengthAttack = StrengthAttack;

    }
        public string Name;
        public int Level;
        public string HeroType;
        public int Health;
        public int StrengthAttack;

        public override string ToString()
        {
            return this.Name+ " " + this.Level + " " + this.HeroType + " " + this.Health + " " + this.StrengthAttack;
        }

        public virtual string Attack(int Bonus) {
            if (Bonus < 100)
                return this.Name + "Especial Ativado:  \r\n Seu Ataque Causou: " + Bonus;
            else if (Bonus > 100)
                return this.Name + "Ataque Especial Secreto Ativado:   \r\n Seu Ataque Causou: " + Bonus;
            else {
                return this.Name + " bonus de: " + Bonus;
            }
        }

    }
}