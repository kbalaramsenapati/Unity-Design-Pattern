using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
namespace CommandPatterns.Calculator
{
    public class InputSystem : MonoBehaviour
    {
        [System.Serializable]
        public class InputEvents
        {
            public string InputName;
            public Button InputButton;
            public KeyCode keycode;
            //public KeyCode keycode2;
            public UnityEvent unityEvent;
        }
        public InputEvents[] inputEvents_class;


        //private void Update()
        //{
        //    if(Input.GetKeyDown(KeyCode.Plus)||Input.GetKeyDown(KeyCode.KeypadPlus))
        //    {
        //        Debug.Log("Clicking");
        //    }
        //}

        public void Onclick_Button(int id)
        {
            Debug.Log(id);
        }
    }
}
