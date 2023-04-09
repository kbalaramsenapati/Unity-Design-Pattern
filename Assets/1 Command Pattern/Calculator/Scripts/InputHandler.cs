using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    #region Decleration
    public static event Action<string> InputPass;
    #endregion

    #region System Define Function
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            InputPass?.Invoke("0");
            //Debug.Log("0");
        }
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            InputPass?.Invoke("1");
            //Debug.Log("1");
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            InputPass?.Invoke("2");
            //Debug.Log("2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            InputPass?.Invoke("3");
            //Debug.Log("3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            InputPass?.Invoke("4");
            //Debug.Log("4");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            InputPass?.Invoke("5");
            //Debug.Log("5");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            InputPass?.Invoke("6");
            //Debug.Log("6");
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            InputPass?.Invoke("7");
            //Debug.Log("7");
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            InputPass?.Invoke("8");
            //Debug.Log("8");
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            InputPass?.Invoke("9");
            //Debug.Log("9");
        }
        if (/*(((Input.GetKeyDown(KeyCode.LeftShift))||(Input.GetKeyDown(KeyCode.RightShift))) && (Input.GetKeyDown(KeyCode.Plus)))|| */Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            InputPass?.Invoke("+");
            //Debug.Log("Pluse");
        }
        if (/*Input.GetKeyDown(KeyCode.Minus) ||*/ Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            InputPass?.Invoke("-");
            //Debug.Log("Minus");
        }
        if (Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            InputPass?.Invoke("*");
            //Debug.Log("Mult");
        }
        if (Input.GetKeyDown(KeyCode.KeypadDivide))
        {
            InputPass?.Invoke("/");
            //Debug.Log("Div");
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
