﻿using StyrelDungeon.DungeonElements;
using System;

namespace StyrelDungeon
{
    public class Heros : Character
    {
        private Dungeon m_Dungeon;
        bool m_bFirstAttack = true;

        public Heros(Dungeon p_Dungeon)
        {
            m_Dungeon = p_Dungeon;
        }

        public void EnterDungeon()
        {
            m_Dungeon.EnterRoom(this, 0);
        }

        public void SelectProtection()
        {
        }

        public void DiscoverEnnemy(Monster monster)
        {

        }

        public override void Attack(Character p_CharacterToAttack)
        {

        }

        public override void ApplyDamagesToEnemy(Character p_CharacterToApplyDamge)
        {
            p_CharacterToApplyDamge.ReceiveDamage(this);
        }

        public override int ReceiveDamage(Character p_CharacterApplyingDamage)
        {
            return m_iLifePoint;
        }

        public void SelectItemsFromChest(Chest RoomChest) { }

        private void Dies(string p_sCause)
        {
            Console.WriteLine("Sorry you are dead because " + p_sCause);
        }
    }
}
