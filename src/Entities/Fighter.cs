using System;
namespace ProjectRPG.src.Entities;

     public class Fighter : Form 
    {
        public Fighter(string Name, int Level, string HeroType, int Health, int StrengthAttack) : base (Name, Level, HeroType, Health, StrengthAttack) {

        this.Name = Name;

        this.Level = Level;

        this.HeroType = HeroType;

        this.Health = Health;

        this.StrengthAttack = StrengthAttack;
        }

    

        public override string Attack(int Bonus) {

            if (Bonus < 100 )
                return this.Name + " Especial Ativado: Gear Three \r\nSeu Ataque Causou: " + Bonus;
            else if (Bonus > 100)
                return this.Name + "Ataque Especial Secreto Ativado: Gear Five!! Haki do Rei Ativado!!  \r\nSeu Ataque Causou: " + Bonus;
            else {
                return this.Name + "Deu Socos  comuns no oponente capaz de derrotalo com bonus de Força de: " + Bonus;
            }
        }
     }
  




