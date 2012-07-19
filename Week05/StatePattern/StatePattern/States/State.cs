using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.States
{
    public class State
    {
        protected Player _player;

        public State(Player player)
        {
            _player = player;
        }

        public virtual void Attack(Enemy enemy)
        { 
        }

        public virtual void TakeDamage(int damagePoint)
        { 
        }

        public virtual void Walk()
        { 
        }
    }

    public class NormalState : State
    {
        public NormalState(Player player)
            : base(player)
        {
        }

        public override void Attack(Enemy enemy)
        {
            enemy.Hp -= 1;
        }

        public override void TakeDamage(int damagePoint)
        {
            _player.Hp -= 1;
        }

        public override void Walk()
        {
            _player.PositionX += 1;
            _player.PositionY += 1;
        }
    }

    public class BerserkState : State
    {
        public BerserkState(Player player)
            : base(player)
        {
        }
    }

    public class CursedState : State
    {
        public CursedState(Player player)
            : base(player)
        { 
        }
    }
}
