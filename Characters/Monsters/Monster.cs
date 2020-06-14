using StyrelDungeon.DungeonElements.Items;
using System;
using System.Collections.Generic;
using System.Timers;

namespace StyrelDungeon
{
    public enum MONSTER_TYPE
    {
        SORCERER,
        THIEF,
        BARBARIAN
    }

    public abstract class Monster : Character
    {
        protected string m_sMessageToPlayer;

        override public void Attack(Character heros)
        {
            Console.WriteLine(m_sMessageToPlayer);
        }
        override public int ReceiveDamage(Character character) { return 0; }
        override public void ApplyDamagesToEnemy(Character heros) { }
    }
}
