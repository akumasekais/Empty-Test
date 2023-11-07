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

            // IF WE DO NTO OWN THIS GAMEOBJECT, WE DO NOT CONTROL OR EDIT IT!
            if (!IsOwner)
                return;
            
            //HANDLE MOVEMENT
            playerlocomotionManager.HandleAllMovement();
        }

        protected override void LateUpdate()
        {
            if (!IsOwner)
                return;

            base.LateUpdate();
            
            PlayerCamera.instance.HandleAllCameraActions();
        }
        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();

            // IF THIS IS THE PLAYER OBJECT OWNED BY THIS CLIENT
            if (IsOwner)
            {
                PlayerCamera.instance.player = this;
            }
        }
    }

}

