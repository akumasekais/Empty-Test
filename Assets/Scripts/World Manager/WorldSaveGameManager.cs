using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TM
{
    public class WorldSaveGameManager : MonoBehaviour
    {
       public static WorldSaveGameManager instance;

        [SerializeField] int WorldSceneIndex = 1;

        private void Awake()
        {
            //Only One Instance, if another exists, destory it
           if (instance == null)
            {
                instance = this;
            }
           else
            {
                Destroy(gameObject);
            }
        }
        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }
        public IEnumerator LoadNewGame()
        {
            AsyncOperation loadOperation = SceneManager.LoadSceneAsync(WorldSceneIndex);

            yield return null; //Because its a co routine
        }
        public int GetWorldSceneIndex()
        {
            return WorldSceneIndex;
        }
    }
}
