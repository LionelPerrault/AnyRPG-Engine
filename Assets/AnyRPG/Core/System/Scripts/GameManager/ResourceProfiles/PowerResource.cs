using AnyRPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AnyRPG {
    [CreateAssetMenu(fileName = "New Power Resource", menuName = "AnyRPG/PowerResource")]
    [System.Serializable]
    public class PowerResource : DescribableResource {

        [Header("Display")]

        [Tooltip("The color that will be used for text and image backgrounds when an item of this quality is displayed")]
        [SerializeField]
        private Color displayColor;

        [Header("Amounts")]

        [Tooltip("A base amount that all characters with this resource will receive")]
        [SerializeField]
        private float baseAmount = 0f;

        [Tooltip("Every character with this resource will receive this amount for every level")]
        [SerializeField]
        private float amountPerLevel = 0f;

        [Header("Regeneration")]

        [Tooltip("Every x seconds, perform the regeneration")]
        [SerializeField]
        private float tickRate = 1f;

        [Tooltip("The amount of this resource to regenerate per tick while out of combat")]
        [FormerlySerializedAs("regenPerTick")]
        [SerializeField]
        private float amountPerTick = 0f;

        [Tooltip("The percent of this resource to regenerate per tick while out of combat")]
        [SerializeField]
        private float percentPerTick = 0f;

        [Tooltip("The amount of this resource to regenerate per tick while in combat")]
        [FormerlySerializedAs("combatRegenPerTick")]
        [SerializeField]
        private float combatAmountPerTick = 0f;

        [Tooltip("The percent of this resource to regenerate per tick while in combat")]
        [SerializeField]
        private float combatPercentPerTick = 0f;

        [Header("Limits")]

        [Tooltip("If this amount is greater than zero, the resource has a maximum fixed amount")]
        [SerializeField]
        private float maximumAmount = 0f;

        [Header("Health")]

        [Tooltip("When all of a characters health resources have reached zero, they are considered to have died.  Multiple health resources are allowed.")]
        [SerializeField]
        private bool isHealth = false;

        [Header("Resets")]

        [Tooltip("If true, when the character evades, levels up, or spawns, this resource will be filled.")]
        [SerializeField]
        private bool fillOnReset = false;


        public Color DisplayColor { get => displayColor; set => displayColor = value; }
        public float AmountPerTick { get => amountPerTick; set => amountPerTick = value; }
        public float CombatAmountPerTick { get => combatAmountPerTick; set => combatAmountPerTick = value; }
        public float PercentPerTick { get => percentPerTick; set => percentPerTick = value; }
        public float CombatPercentPerTick { get => combatPercentPerTick; set => combatPercentPerTick = value; }
        public float MaximumAmount { get => maximumAmount; set => maximumAmount = value; }
        public float TickRate { get => tickRate; set => tickRate = value; }
        public bool IsHealth { get => isHealth; set => isHealth = value; }
        public bool FillOnReset { get => fillOnReset; set => fillOnReset = value; }
        public float BaseAmount { get => baseAmount; set => baseAmount = value; }
        public float AmountPerLevel { get => amountPerLevel; set => amountPerLevel = value; }
    }

}