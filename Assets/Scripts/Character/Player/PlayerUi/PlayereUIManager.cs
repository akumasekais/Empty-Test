using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

namespace TM
{
    public class PlayereUIManager : MonoBehaviour
    {
        public static PlayereUIManager instance;

        [Header("NETWORK JOIN")]
        [SerializeField] bool startGameAsClient;


        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        private void Update()
        {
            if (startGameAsClient)
            {
                startGameAsClient = false;
                // WE MUST FIRST SHUR DOWN, BECAUSE WE HAVE STARTED AS A HOT DURING THE TITLE SCREEN
                NetworkManager.Singleton.Shutdown();
                // WE THEN RESTART, AS A CLIENT
                NetworkManager.Singleton.StartClient();
            }
        }
    }
}

