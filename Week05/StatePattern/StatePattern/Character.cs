using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StatePattern.States;

namespace StatePattern
{
    public class BaseCharacter
    {
        protected int _hp;
        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        protected int _positionX;
        public int PositionX
        {
            get { return _positionX; }
            set { _positionX = value; }
        }

        protected int _positionY;
        public int PositionY
        {
            get { return _positionY; }
            set { _positionY = value; }
        }
    }

    public class Player : BaseCharacter
    {
        private State _state;
        public State State
        {
            get { return _state; }
        }

        public Player()
        {
            _state = new NormalState(this);
        }

        public void ChangeState(State newState)
        {
            _state = newState;
        }

        public void Attack(Enemy enemy)
        {
            _state.Attack(enemy);
        }

        public void TakeDamage(int damagePoint)
        {
            _state.TakeDamage(damagePoint);
        }

        public void Walk()
        {
            _state.Walk();
        }
    }

    public class Enemy : BaseCharacter
    { 
        
    }
}
