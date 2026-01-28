using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using InventorySystem.Items.Usables;
using PlayerRoles;
using RelativePositioning;
using System.Collections.Generic;

using static PlayerStatsSystem.AhpStat;

namespace AdminTools
{
    public class Jailed
    {
        public string Name;
        public List<Item> Items;
        public List<Effect> Effects;
        public RoleTypeId Role;
        public RelativePosition RelativePosition;
        public float Health;
        public float HumeShield;
        public IEnumerable<AhpProcess> ActiveArtificialHealthProcesses;
        public List<RegenerationProcess> ActiveRegenerations;
        public Dictionary<AmmoType, ushort> Ammo;
        public bool CurrentRound;
    }
}