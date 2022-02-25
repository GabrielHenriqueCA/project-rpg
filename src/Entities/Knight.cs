using System;
namespace ProjectRPG.src.Entities
{
    public class Knight : Form
    {
        public Knight (string Name, int Level, string HeroType, int Health, int StrengthAttack ) : base (Name,  Level, HeroType, Health, StrengthAttack)
        {

        this.Name = Name;

        this.Level = Level;

        this.HeroType = HeroType;
        
        this.Health = Health;

        this.StrengthAttack = StrengthAttack;
        }


        public override string Attack(int Bonus){

                if(Bonus < 100)
                return this.Name + " Especial Ativado: Santoryu!! Estilo 3 Espadas!! \r\n Seu Ataque Causou: " + Bonus;
                 else if(Bonus > 100)
                return this.Name  + "Ataque Especial Secreto Ativado: Ataque do Rei do Submundo!! Cerberus!! \r\nSeu Ataque Causou: " + Bonus;
                else{
                    return this.Name + "Usou Ataque com espada normal capaz de derrotar o oponente com Bonus de Força de: " + Bonus ;
                    }
        }
      }  
    }