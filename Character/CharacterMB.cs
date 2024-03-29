using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using System;

public abstract class CharacterMB : MonoBehaviour
{
    public long id;
    public string name;
    [HideInInspector] public string guid;
    public Transform characterModelTransform;
    public Inventory inventory;
    public Animator animator;
    public StatsController statsController;
    public AbilityController abilityController;
    public MasteryController masteryController;

    protected virtual void Awake()
    {
        statsController = GetComponent<StatsController>();
        abilityController = GetComponent<AbilityController>();
        inventory = GetComponent<Inventory>();
        masteryController = GetComponent<MasteryController>();
    }
}
