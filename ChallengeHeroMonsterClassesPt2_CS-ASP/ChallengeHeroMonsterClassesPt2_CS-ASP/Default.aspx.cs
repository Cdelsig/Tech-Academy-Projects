using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPt2_CS_ASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();

            hero.Name = "Kung Fury";
            hero.Health = 110;
            hero.MaxDmg = 40;
            hero.AtkBonus = false; //Atk bonus = another turn
            hero.DamageDealt = 0;
            
            Character monster = new Character();

            monster.Name = "Arcade Machine";
            monster.Health = 90;
            monster.MaxDmg = 30;
            monster.AtkBonus = false;
            monster.DamageDealt = 0;

            Dice dice = new Dice();

            while (hero.Health > 0 && monster.Health > 0)
            {

                //hero attacks first:
                int damage = hero.Attack(dice);
                hero.DamageDealt = damage;
                monster.Defend(damage);
                hero.GetBonus();
                printStats(hero);
                
                if (hero.AtkBonus == true)
                {
                    damage = hero.Attack(dice);
                    hero.DamageDealt = damage;
                    monster.Defend(damage);
                    printStats(hero);
                }

                //then monster attacks:
                damage = monster.Attack(dice);
                monster.DamageDealt = damage;
                hero.Defend(damage);
                monster.GetBonus();
                printStats(monster);

                if (monster.AtkBonus == true)
                {
                    damage = monster.Attack(dice);
                    monster.DamageDealt = damage;
                    hero.Defend(damage);
                    printStats(monster);
                }
            }

            showWinner(hero, monster);    
        }

        private void printStats(Character character)
        {
            resultLabel.Text += String.Format("Name: {0}<br />Health: {1}<br/ >Damage Dealt: {2}<br />Attack Bonus: {3}<br /><br />",
                character.Name,
                character.Health,
                character.DamageDealt,
                character.AtkBonus);
        }

        private void showWinner(Character hero, Character monster)
        {
            if (hero.Health <= 0 && monster.Health <= 0)
                resultLabel.Text += String.Format("<strong>Both {0} and {1} have destroyed each other. :'(</strong>", hero.Name, monster.Name);

            else if (hero.Health > 0 && monster.Health <= 0)
                resultLabel.Text += String.Format("<strong>{0} is victorious and has saved the day again!! :D {1}, your reign of terror has ended!</strong>", hero.Name, monster.Name);
            else
                resultLabel.Text += String.Format("<strong>{0} has been defeated by the evil {1}. :'(  Hacker Man, we need your help to set this right!</strong>", hero.Name, monster.Name);
        }
    }

    class Character
    {
        Random random = new Random();

        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxDmg { get; set; }
        public bool AtkBonus { get; set; }
        public int DamageDealt { get; set; }

        public int Attack(Dice dice)
        {
            dice.Sides = this.MaxDmg;
            return dice.Roll();
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }

        public void GetBonus()
        {
            int bonus = random.Next(0, 2);

            if (bonus == 1)
            {
                this.AtkBonus = true;
            }
            else
                this.AtkBonus = false;
        }
    }

    class Dice
    {
        Random random = new Random();

        public int Sides { get; set; }

        public int Roll()
        {
            return random.Next(this.Sides);

        }


    }
}
