using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    #region Decleration
    public static event Action<string> InputPass;

    public bool IsshiftClick_bool;
    #endregion

    #region System Define Function
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetKey(KeyCode.RightShift));
        #region Shift
        if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {
            IsshiftClick_bool = false;
        }
        else if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            IsshiftClick_bool = true;
        }
        #endregion


        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            InputPass?.Invoke("0");
        }
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            InputPass?.Invoke("1");
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            InputPass?.Invoke("2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            InputPass?.Invoke("3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            InputPass?.Invoke("4");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            InputPass?.Invoke("5");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            InputPass?.Invoke("6");
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            InputPass?.Invoke("7");
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            InputPass?.Invoke("8");
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            InputPass?.Invoke("9");
        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            InputPass?.Invoke("+");
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            InputPass?.Invoke("-");
        }
        if (Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            InputPass?.Invoke("*");
        }
        if (Input.GetKeyDown(KeyCode.KeypadDivide))
        {
            InputPass?.Invoke("/");
        }
        if (IsshiftClick_bool)
        {
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                InputPass?.Invoke("%");
            }
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            InputPass?.Invoke("BackSpace");
        }
        if (Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            InputPass?.Invoke("Enter");
        }


        //if (Input.GetKeyDown(KeyCode.Percent))
        //{
        //    InputPass?.Invoke("%");
        //    //Debug.Log("Percen");
        //}
    }
    #endregion

    //public void Onclick_
}
