# Dsze Core
An Outward mod that sets up commonly used effects required by my other mods.

## Feature List
 - SideLoader Extensions
    - ApplyEnchantment Effect
 - Patches
    - StatusEffect End Effects

### SideLoader Extensions
Extra effects, conditions, and other components that add new functionality for SideLoader definitions to use.

#### ApplyEnchantment Effect
Applies an enchantment to an equipped item. Each time the effect is applied, if the enchanted item is no longer in it's slot the enchantment is removed, and if another item is in it's slot the enchantment is applied to that item instead. When the effect is unapplied, for example because it ended, the enchantment is removed. If used in such a way that the effect never re-runs or is unapplied, the enchantment will be permanent.

### Patches
Patches that open up new options for using existing assets in cleaner ways.

#### StatusEffect End Effects
Patches the StatusEffect class to apply Effects of category "Referenced" exactly once when the status ends. The effect is applied and then immediately unapplied if supported.