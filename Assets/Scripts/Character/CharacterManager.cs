using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TM
{
    public class CharacterManager : MonoBehaviour
    {
        protected virtual void Awake()
        {
            DontDestroyOnLoad(this);
        }
        protected virtual void Update()
        {
           
        }
    }
}

