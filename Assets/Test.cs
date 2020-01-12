using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

        
        void Start () {
                
                int[] allay = {10, 20, 30, 40, 50};
                
                
                for (int i = 0; i < allay.Length; i++) 
                {
                        Debug.Log (allay [i]);
                }
                for (int i = allay.Length -1; 0 <= i; i--) 
                {
                        Debug.Log (allay [i]);
                }
        }
        
        // Update is called once per frame
        void Update () {
        
        }
}