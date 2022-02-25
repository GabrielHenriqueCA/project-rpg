namespace ProjectRPG.src.Entities
{
    public class Wizzard : Form
    {
        public Wizzard(string Name, int Level, string HeroType, int Health, int StrengthAttack) : base (Name,  Level, HeroType, Health, StrengthAttack)
        {

            this.Name = Name;

            this.Level = Level;

            this.HeroType = HeroType;
            
            this.Health = Health;

            this.StrengthAttack = StrengthAttack;

        }

       public override string Attack(int Bonus) {
            if (Bonus < 100)
                return this.Name + " Especial Ativado: Chuva de Meteoros!!  \r\n Seu Ataque Causou: " + Bonus;
            else if (Bonus > 100)
                return this.Name + "Ataque Especial Secreto Ativado: Rugido do Dragão!! Feitiço do Deus do Fogo!!   \r\nSeu Ataque Causou: " + Bonus;
            else {
                return this.Name + "Usou Magia Comum capaz de derrotar o Oponente  com  bonus de Força de: " + Bonus;
            }
        }
    }
}