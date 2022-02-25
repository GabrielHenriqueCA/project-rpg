using System;
namespace ProjectRPG.src.Entities 
{
    public class Boss : Form {
        public Boss(string Name, int Level, string HeroType, int Health, int StrengthAttack) : base (Name, Level, HeroType, Health, StrengthAttack) 
            {

            this.Name = Name;

            this.Level = Level;

            this.HeroType = HeroType;

            this.Health = Health;

            this.StrengthAttack = StrengthAttack;
            }


            public override string Attack(int Bonus) {
                if (Bonus > 6)
                    return this.Name + "Especial Ativado: Destruição Dimensional /n Seu Ataque Causou: " + Bonus;
                else if (Bonus == 100)
                    return this.Name + "Ataque Especial Secreto Ativado: Manopla do Infinito!! -Eu sou Inevitavel!  /n Seu Ataque Causou: " + Bonus;
                else {
                    return this.Name + "Soco comum com bonus de: " + Bonus;
                }
            }
        }
    }    


 