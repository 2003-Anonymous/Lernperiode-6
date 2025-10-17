using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lernperiode_6.enemy;
using Lernperiode_6.player;

namespace Lernperiode_6.player
{
    public abstract class Typ : UserControl
    {
        protected double _health;
        protected int _damage;
        protected int _attackSpeed;
        protected double _defense;
        protected PictureBox _image;
        protected ProgressBar _healthBar;
        public System.Windows.Forms.Timer AttackTimer;
        private Enemy enemy;
        public int[] statsArray;
        protected Typ playerTyp;
        public static string[] types = { "Archer", "Berserker" };

        public abstract int HealthMax { get; }
        public abstract int DamageMax { get; }
        public abstract int AttackSpeedMax { get; }
        public abstract int DefenseMax { get; }
        public double HealthCreate
        {
            get { return _health; }
            set
            {
                _health = value > HealthMax ? HealthMax : Math.Max(0, value);
                statsArray[0] = (int)_health;
            }
        }
        public double Health
        {
            get { return _health; }
            set
            {
                _health = Math.Max(0, value);
                Stats.HealthSet = (int)_health;
            }
        }
        public int Damage
        {
            get => _damage;
            set
            {
                _damage = value > DamageMax ? DamageMax : value;
                statsArray[1] = _damage;
            }
            
        }
        public int AttackSpeed
        {
            get => _attackSpeed;
            set
            {
                _attackSpeed = value > AttackSpeedMax ? AttackSpeedMax : value;
                statsArray[2] = _attackSpeed;
            }
        }
        public double Defense
        {
            get => _defense;
            set
            {
                _defense = value > DefenseMax ? DefenseMax : value;
                statsArray[3] = (int)_defense;
            }
        }

        public StatsControl Stats { get; protected set; }
        public StatsEnter EnterStats { get; protected set; }

        protected Typ(int[] s)
        {
            statsArray = s;
            HealthCreate = s[0];
            Damage = s[1];
            AttackSpeed = s[2];
            Defense = s[3];
        }
        public Typ()
        {

        }

        public void TakeDamage(int damage)
        {
            _health = _health - (damage * (1 - (_defense / 100.0)));
            Health = Convert.ToInt32(_health);
        }

        public void Attack(Enemy target)
        {
            enemy = target;

            AttackTimer = new System.Windows.Forms.Timer();
            AttackTimer.Interval = 1000 * 25 / _attackSpeed;
            AttackTimer.Tick += DealDamage;
            AttackTimer.Start();
        }

        private void DealDamage(object sender, EventArgs e)
        {
            if(this.Health <= 0)
            {
                AttackTimer.Stop();
                this.Controls.Remove(this);
                Stats.Hide();
                return;
            }

            if(enemy != null && enemy.Health > 0)
            {
                enemy.TakeDamage(_damage);
            }
            else
            {
                AttackTimer.Stop();
                this.Controls.Remove(enemy);
                this.Controls.Remove(enemy.StatsEnemy);
            }
        }
            

            
    }
}
