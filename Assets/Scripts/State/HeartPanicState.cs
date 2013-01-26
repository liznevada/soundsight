﻿using UnityEngine;
using System.Collections;

public class HeartPanicState : SKState<HeartModel>
{

    public override void begin()
    {
        // upon reaching this state your heart health decreases to 60
        _machine.context.HeartHealth = 40;
    }

    public override void update(float deltaTime)
    {
        // slowly deterioate your heart health based on conditions

        // if this state ever transitions to another state
        _machine.changeState<HeartDangerState>();
    }

    public override void end()
    {
        

    }
}
