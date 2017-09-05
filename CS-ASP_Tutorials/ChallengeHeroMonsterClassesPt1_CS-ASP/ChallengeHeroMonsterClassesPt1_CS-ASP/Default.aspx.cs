using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPt1_CS_ASP
{
    
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();

            hero.Name = "Kung Fury";
            hero.Health = 110;
            hero.MaxDmg = 75;
            hero.AtkBonus = false;


            Character monster = new Character();

            monster.Name = "Arcade Machine";
            monster.Health = 90;
            monster.MaxDmg = 100;
            monster.AtkBonus = false;

            //hero attacks first:
            int damage = hero.Attack();
            monster.Defend(damage);

            //then monster attacks:
            damage = monster.Attack();
            hero.Defend(damage);

            printStats(hero);
            printStats(monster);

        }

        private void printStats(Character character)
        {
            resultLabel.Text += String.Format("Name: {0}<br />Health: {1}<br/ >Max Damage: {2}<br />Attack Bonus: {3}<br /><br />", 
                character.Name, 
                character.Health, 
                character.MaxDmg, 
                character.AtkBonus);
        }
    }
    
    class Character
    {
        Random random = new Random();

        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxDmg { get; set; }
        public bool AtkBonus { get; set; }

        public int Attack()
        {
            int damage = random.Next(this.MaxDmg);
            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
}