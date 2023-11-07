using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

namespace TM
{
    public class CharacterNetworkManager : NetworkBehaviour
    {
        [Header("Position")]
        //IF YOU OWN THIS CHARACTER OBJECT, YOU ARE ABLE TO EDIT THIS POSITION AND IF YOU DONT YOU CAN ONLY READ WHAT IT IS.
        public NetworkVariable<Vector3> networkPosition = new NetworkVariable<Vector3>(Vector3.zero, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
        public NetworkVariable<Quaternion> networkRotation = new NetworkVariable<Quaternion>(Quaternion.identity, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
        public Vector3 networkPositionVelocity;
        public float networkPositionSmoothTime = 0.1f;
        public float networkRotationSmoothTime = 0.1f;


    }

}
