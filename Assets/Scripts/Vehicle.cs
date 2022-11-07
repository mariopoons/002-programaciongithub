using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // this variable tells the numbers of wheels the vehicle has
    [SerializeField] private int wheels = 4;
    [SerializeField] private string name = "";

    // this variable tells if the vehicles are on or off
    [SerializeField] private bool isOn;

    // this variable tells 
    public string sound = "";

    // this variable tells the gasofa the vehicle has
    [SerializeField] private float gasoline;

    // for changing the start position of an object
    public Vector3 initialPos = new Vector3(1, 1, 1);

    private void Start()
    {   // this tells how many wheels the object has 
        /*Debug.Log($" The {name} has {wheels} wheels."); */

        // this tells if the vehicles are on or off
        /*if (isOn == true)
        { Debug.Log($"The {name} is on"); }
        else
        { Debug.Log($"The {name} is off"); }*/

        // this tells if the car is on, off or doing brum brum
        /*if (isOn == false)
        { Debug.Log($" The {name} is off"); }
        else if (sound != "")
        { Debug.Log($" The {name} is on and is doing brum brum"); }
        else
        { Debug.Log($" The {name} is on"); }*/

        // this tells if the vehicles have gasofa, haven't gasofa or if it's off
        /*if (isOn == true)
        {
            if (gasoline < 10)
            {
                Debug.Log($" The {name} has low gasofa");
            }
            else
            {
                Debug.Log($" The {name} has gasofa :))");
            }
        }
        else
        {
            Debug.Log($"The {name} is off");
        }*/

        /*if (isOn == true && gasoline<10)
        {
            Debug.Log($"{name} has low gasofa!");
        }
        else 
        {
            Debug.Log($"{name} is off but it has gasofa");
        }*/

        /*transform.position = initialPos;*/
    }
}


