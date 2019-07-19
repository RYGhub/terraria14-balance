using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Balance
{
    class Balancing : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item == null) return;

            // Reaver Shark nerf
            if (item.type == ItemID.ReaverShark)
            {
                item.pick = 71;
                item.reuseDelay = 10;
            }

            // Drills buff
            else if (item.type == ItemID.CobaltDrill || item.type == ItemID.MythrilDrill || item.type == ItemID.AdamantiteDrill ||
                item.type == ItemID.PalladiumDrill || item.type == ItemID.OrichalcumDrill || item.type == ItemID.TitaniumDrill ||
                item.type == ItemID.Drax ||
                item.type == ItemID.SolarFlareDrill || item.type == ItemID.VortexDrill || item.type == ItemID.NebulaDrill || item.type == ItemID.StardustDrill)
            {
                item.reuseDelay = (int) (item.reuseDelay * 0.85f);
            }

            // Pickaxes buff
            else if (item.type == ItemID.CobaltPickaxe || item.type == ItemID.MythrilPickaxe || item.type == ItemID.AdamantitePickaxe ||
                item.type == ItemID.PalladiumPickaxe || item.type == ItemID.OrichalcumPickaxe || item.type == ItemID.TitaniumPickaxe ||
                item.type == ItemID.PickaxeAxe ||
                item.type == ItemID.SolarFlarePickaxe || item.type == ItemID.VortexPickaxe || item.type == ItemID.NebulaPickaxe || item.type == ItemID.StardustPickaxe)
            {
                item.pick += 9;
            }

            // Molten Armor nerf
            else if (item.type == ItemID.MoltenHelmet || item.type == ItemID.MoltenBreastplate || item.type == ItemID.MoltenGreaves)
            {
                item.defense -= 1;
            }

            // Necro Armor buff
            else if (item.type == ItemID.NecroHelmet || item.type == ItemID.NecroBreastplate || item.type == ItemID.NecroGreaves || item.type == ItemID.AncientNecroHelmet)
            {
                item.defense += 1;
            }

            // Meteor Armor buff
            else if (item.type == ItemID.MeteorHelmet || item.type == ItemID.MeteorSuit || item.type == ItemID.MeteorLeggings)
            {
                item.defense += 1;
            }

            // Pearlwood Armor buff
            else if (item.type == ItemID.PearlwoodHelmet || item.type == ItemID.PearlwoodBreastplate || item.type == ItemID.PearlwoodGreaves)
            {
                item.defense += 7;
            }

            // Wires are cheap
            else if (item.type == ItemID.Wire)
            {
                item.value = 1;
            }

            // Cutlass nerf
            else if (item.type == ItemID.Cutlass)
            {
                item.damage = 45;
            }

            // Magical Harp buff
            if (item.type == ItemID.MagicalHarp)
            {
                item.damage = 50;
            }

            // Nano bullets buff
            if (item.type == ItemID.NanoBullet)
            {
                item.damage = 15;
            }

            // High velocity bullets buff
            if (item.type == ItemID.HighVelocityBullet)
            {
                item.damage = 12;
            }

            // Luminite bullets buff
            if (item.type == ItemID.MoonlordBullet)
            {
                item.damage = 28;
            }

            // Vilethorn buff
            if (item.type == ItemID.Vilethorn)
            {
                item.damage = 14;
            }

            // Crimson Rod buff
            if (item.type == ItemID.CrimsonRod)
            {
                item.damage = 14;
            }

            // Rainbow Gun buff
            if (item.type == ItemID.RainbowGun)
            {
                item.damage = 60;
            }

            // Magnet Sphere buff
            if (item.type == ItemID.MagnetSphere)
            {
                item.damage = 60;
            }

            // Luminite Arrows buff
            if (item.type == ItemID.MoonlordArrow)
            {
                item.damage = 20;
            }

            // Daedalus Stormbow nerf
            if (item.type == ItemID.DaedalusStormbow)
            {
                item.damage = 41;
            }

            // Holy Arrows nerf
            if (item.type == ItemID.HolyArrow)
            {
                //holy cow sono dannatamente rotte comunque
                item.damage = 11;
            }
        }
    }
}
