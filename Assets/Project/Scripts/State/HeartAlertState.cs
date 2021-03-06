﻿using Assets.Project.Scripts.Manager;
using Assets.Project.Scripts.Model;
using Assets.Scripts.Singleton;
namespace Assets.Project.Scripts.State
{
    public class HeartAlertState : SKState<HeartModel>
    {

        public override void begin()
        {
            
            // upon reaching this state your heart health decreases to 80
            //_machine.context.HeartHealth = 80; 
            Player.Instance.Sensitivity = 8;
            Player.Instance.Rate = 1.75f;

        }

        public override void update(float deltaTime)
        {
            // something will trigger the transition of states 
            //_machine.changeState<HeartAlertState>();

            // or back one state
            //_machine.changeState<HeartCalmState>();
            Common.Common.ChangeHeartState(Player.Instance.HeartHealth, _machine);
        }

        public override void end()
        {
        
        }
    }
}
