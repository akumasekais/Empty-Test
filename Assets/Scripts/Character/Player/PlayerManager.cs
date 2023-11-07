using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TM 
{
    public class PlayerManager : CharacterManager
    {
        PlayerLocomotionManager playerlocomotionManager;
        protected override void Awake()
        {
            base.Awake();

            // DO MORE STUFF, ONLY FOR THE PLAYER

            playerlocomotionManager = GetComponent<PlayerLocomotionManager>();
        }
        protected override void Update()
        {
            base.Update();

            //HANDLE MOVEMENT
            playerlocomotionManager.HandleAllMovement();
        }
    }

}

