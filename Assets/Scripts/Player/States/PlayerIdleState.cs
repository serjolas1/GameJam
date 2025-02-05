﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : State
{
    [Header("REFERENCES")]
    private Rigidbody rig = null;

    private void Awake() {
        rig = GetComponent<Rigidbody>();
    }

    public override void Init() {
        base.Init();
    }

    public override void Tick() {
        base.Tick();
    }

    public override void FixedTick() {
        base.FixedTick();

        rig.velocity = Vector3.Lerp(rig.velocity, new Vector3(0f, rig.velocity.y, 0f), Time.fixedDeltaTime * 10);
    }

    public override void EnterState() {
        base.EnterState();
    }

    public override void ExitState() {
        base.ExitState();
    }
}
