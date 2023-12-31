using AnyRPG;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AnyRPG {
    // NOTE: DIRECTEFFECT WILL CAST TICK AND COMPLETE, BUT NEVER HIT.  HIT MUST BE CAST BY PROJECTILE, AOE, OR CHANNELED
    [System.Serializable]
    public class DirectEffectProperties : FixedLengthEffectProperties {

        /*
        public void GetDirectEffectProperties(DirectEffect effect) {

            GetFixedLengthEffectProperties(effect);
        }
        */

        public override Dictionary<PrefabProfile, List<GameObject>> Cast(IAbilityCaster source, Interactable target, Interactable originalTarget, AbilityEffectContext abilityEffectInput) {
            //Debug.Log(DisplayName + ".DirectEffect.Cast()");
            return base.Cast(source, target, originalTarget, abilityEffectInput);
        }

        public override void CastTick(IAbilityCaster source, Interactable target, AbilityEffectContext abilityEffectContext) {
            //Debug.Log(abilityEffectName + ".DirectEffect.CastTick()");
            base.CastTick(source, target, abilityEffectContext);
            PerformAbilityTick(source, target, abilityEffectContext);
        }

        public override void CastComplete(IAbilityCaster source, Interactable target, AbilityEffectContext abilityEffectContext) {
            //Debug.Log(abilityEffectName + ".DirectEffect.CastComplete()");
            base.CastComplete(source, target, abilityEffectContext);
            PerformAbilityComplete(source, target, abilityEffectContext);
        }

    }

}