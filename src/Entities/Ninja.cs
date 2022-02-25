using System;
namespace ProjectRPG.src.Entities
{
    public class Ninja: Form
    {
        public Ninja(string Name, int Level, string HeroType, int Health, int StrengthAttack): base (Name,  Level, HeroType, Health, StrengthAttack)
        {

        this.Name = Name;

        this.Level = Level;

        this.HeroType = HeroType;
        
        this.Health = Health;

        this.StrengthAttack = StrengthAttack;

        }

    
        public override string Attack(int Bonus){
            if(Bonus < 100)
            return this.Name + " Especial Ativado: Invocação da Raposa!! \r\n Seu Ataque Causou: " + Bonus;
            else if(Bonus > 100)
                return this.Name + " Ataque Especial Secreto Ativado: Sabio dos 6 Caminhos!! Super Shuriken!!  \r\nSeu Ataque Causou: " + Bonus;
            else{
                return this.Name + "Lançou uma Kunai Comum capaz de derrotar o Oponente com bonus de força de: " + Bonus ;
            }
 
       } 
    }
  }