using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scenario
{
    public class Entity
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

    public enum PlayerState
    { 
        NORMAL,
        BERSERK, 
        CURSED
    }

    public class Player : Entity
    {
        private PlayerState _state = PlayerState.NORMAL;

        public void Attack(Enemy enemy)
        {
            switch (_state)
            {
                case PlayerState.NORMAL:
                    {
                        enemy.Hp -= 1;
                    }break;
                case PlayerState.BERSERK:
                    {
                        enemy.Hp -= 10;
                    } break;
                case PlayerState.CURSED:
                    {
                        // Cannot attack
                    } break;
                default:
                    break;
            }
        }

        public void TakeDamage(int damagePoint)
        {
            switch (_state)
            {
                case PlayerState.NORMAL:
                    {
                        this.Hp -= damagePoint;
                    } break;
                case PlayerState.BERSERK:
                    {
                        // No damage
                    } break;
                case PlayerState.CURSED:
                    {
                        this.Hp -= damagePoint * 2;
                    } break;
                default:
                    break;
            }
        }

        public void Walk()
        {
            switch (_state)
            {
                case PlayerState.NORMAL:
                    {
                        this.PositionX += 1;
                        this.PositionY += 1;
                        // play animation normal walk
                    } break;
                case PlayerState.BERSERK:
                    {
                        this.PositionX += 10;
                        this.PositionY += 10;
                        // play animation berserk walk
                    } break;
                case PlayerState.CURSED:
                    {
                        // Cannot walk
                    } break;
                default:
                    break;
            }
        }
    }

    public class Enemy : Entity
    { 
        
    }
}
