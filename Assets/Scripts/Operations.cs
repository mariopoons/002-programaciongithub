using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    // OPERACIONES ARITMETICAS
    public float x = 7f;
    public float y = 4f;
    public int a = 10;
    public int b = 4;
    public float c = 2.0f;
    public float d = 0.5f;

    // OPERACIONES CONDICIONALES
    public string name1 = "barbadox";
    public string name2 = "scalibab";
    private bool areEqual;
    private bool areDifferent;
    private bool isGreater;

    // OPERADOR DE DECISIÓN
    public bool isRaining;
    public float number;

    public float num1;
    public float num2;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Calculator(x, y);
        }
    }
    private void Calculator(float num1, float num2)
    {
        Debug.Log($"Sum: {num1}+{num2}={num1+num2}");
        Debug.Log($"Substraction: {num1}-{num2}={num1-num2}");
        Debug.Log($"Product: {num1}*{num2}={num1*num2}");
        Debug.Log($"Division: {num1}/{num2}={num1/num2}");
    }

    private void Start()
    {
        /*Debug.Log(x+y);
        Debug.Log(x-y);
        Debug.Log(x*y);
        Debug.Log(x/y);
        Debug.Log(x%y);*/

        /*areEqual = a == b;
        Debug.Log(areEqual);*/
        /*areDifferent = name1 != name2;
        Debug.Log(areDifferent);*/
        /*isGreater = c > d;
        Debug.Log(isGreater);*/

        /*if (true)
        {
            Debug.Log("La condición es verdadera");
        }
        if (isRaining == true)
        {
            Debug.Log("¡Recuerda coger el paragüas para no mojarte!");
        }
        if (number > 0)
        {
            Debug.Log($"El numero {number} es positivo");
        }
        if (number < 0)
        {
            Debug.Log($"El numero {number} es negativo");¨
        }*/
    }
}     
       
        
