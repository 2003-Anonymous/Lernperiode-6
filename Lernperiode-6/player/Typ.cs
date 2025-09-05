using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lernperiode_6.enemy;

namespace Lernperiode_6.player
{
    internal abstract class Typ : UserControl
    {
        protected double _health;
        protected int _damage;
        protected int _attackSpeed;
        protected double _defense;
        protected PictureBox _image;
        protected ProgressBar _healthBar;
        public System.Windows.Forms.Timer AttackTimer;
        private Enemy enemy;

        
        public double Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                    _health = 0;
                else if(value > _healthBar.Maximum)
                    _health = _healthBar.Maximum;
                else
                    _health = value;                
            }
        }
      

        public StatsControl Stats { get; protected set; }

        protected Typ(int health, int damage, int attackSpeed, int defense)
        {
            _damage = damage;
            _attackSpeed = attackSpeed;
            _defense = defense;
            _health = health;
        }

        public void TakeDamage(int damage)
        {
            _health = _health - (damage * (_defense / 100));
            _healthBar.Value = Convert.ToInt32(_health);
        }

        public void Attack(Enemy target)
        {
            enemy = target;

            AttackTimer = new System.Windows.Forms.Timer();
            AttackTimer.Interval = 1000 / _attackSpeed;
            AttackTimer.Tick += DealDamage;
            AttackTimer.Start();
        }

        private void DealDamage(object sender, EventArgs e)
        {
            if(enemy != null && enemy.Health > 0)
            {
                enemy.TakeDamage(_damage);
            }
        }
            

            
    }
}
