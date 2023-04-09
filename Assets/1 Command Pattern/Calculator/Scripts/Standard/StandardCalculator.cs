using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace CommandPatterns.Calculator.Standard
{
    public class StandardCalculator : MonoBehaviour
    {
        #region Decleration
        public TMP_Text SetNumber_Text;
        public float SetNumber_float;
        #endregion
        #region System Define Function
        private void OnEnable()
        {
            InputHandler.InputPass += Onclick_SetValue;
            SetNumber_float = 0;
            SetNumber_Text.text = SetNumber_float.ToString();

        }
        private void OnDisable()
        {
            InputHandler.InputPass -= Onclick_SetValue;
        }
        private void Start()
        {
            //float a = 10;
            //float b = 5;

            //Invoker invoker = new Invoker();
            //Calculator calculator = new Calculator(a, b);
            //AddCommand addCommand = new AddCommand(calculator);
            //SubCommand substractCommand = new SubCommand(calculator);

            //Debug.Log("Add : "+ invoker.ExecuteCommand(addCommand));
            //Debug.Log("Sub : "+ invoker.ExecuteCommand(substractCommand));
        }
        private void Update()
        {
            //if (Input.GetKeyDown(KeyCode.A))
            //{

            //    Debug.Log();
            //}
        }
        #endregion

        public void Onclick_SetValue(string va)
        {
            Debug.Log(va);
        }
    }
}
