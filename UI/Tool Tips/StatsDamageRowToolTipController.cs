using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsDamageRowToolTipController : MonoBehaviour
{
    public RectTransform panel;

    public TextMeshProUGUI damageDescriptionText;
    
    public TextMeshProUGUI totalDamageLabelText;
    public TextMeshProUGUI totalDamageValueText;

    public TextMeshProUGUI weaponDamageLabelText;
    public TextMeshProUGUI weaponDamageValueText;

    public TextMeshProUGUI physicalDamageLabelText;
    public TextMeshProUGUI physicalDamageValueText;

    public TextMeshProUGUI fireDamageLabelText;
    public TextMeshProUGUI fireDamageValueText;

    public TextMeshProUGUI coldDamageLabelText;
    public TextMeshProUGUI coldDamageValueText;

    public TextMeshProUGUI lightningDamageLabelText;
    public TextMeshProUGUI lightningDamageValueText;

    public TextMeshProUGUI chaosDamageLabelText;
    public TextMeshProUGUI chaosDamageValueText;

    public TextMeshProUGUI arcaneDamageLabelText;
    public TextMeshProUGUI arcaneDamageValueText;

    public TextMeshProUGUI poisonDamageLabelText;
    public TextMeshProUGUI poisonDamageValueText;

    public TextMeshProUGUI holyDamageLabelText;
    public TextMeshProUGUI holyDamageValueText;

    public TextMeshProUGUI unholyDamageLabelText;
    public TextMeshProUGUI unholyDamageValueText;

    public TextMeshProUGUI shadowDamageLabelText;
    public TextMeshProUGUI shadowDamageValueText;

    public void Activate()
    {
        panel.gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        panel.gameObject.SetActive(false);
    }

    public void SetToolTip(StatsController statsController)
    {
        damageDescriptionText.text = LanguageController.GetPhrase("meleeDamage.label.description");

        totalDamageValueText.text = statsController.GetAddedWeaponDamage().ToString();
        physicalDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_PHYSICAL_DAMAGE).ToString();
        fireDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_FIRE_DAMAGE).ToString();
        coldDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_COLD_DAMAGE).ToString();
        lightningDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_LIGHTNING_DAMAGE).ToString();
        chaosDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_CHAOS_DAMAGE).ToString();
        arcaneDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_ARCANE_DAMAGE).ToString();
        poisonDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_POISON_DAMAGE).ToString();
        holyDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_HOLY_DAMAGE).ToString();
        unholyDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_UNHOLY_DAMAGE).ToString();
        shadowDamageValueText.text = statsController.GetStatValue(StatsController.StatType.MELEE_SHADOW_DAMAGE).ToString();

        string minDamage = statsController.GetStatValue(StatsController.StatType.MIN_WEAPON_DAMAGE).ToString();
        string maxDamage = statsController.GetStatValue(StatsController.StatType.MAX_WEAPON_DAMAGE).ToString();

        weaponDamageLabelText.text = LanguageController.GetPhrase("weaponDamage.label");
        weaponDamageValueText.text = minDamage + " - " + maxDamage;

    }

}
