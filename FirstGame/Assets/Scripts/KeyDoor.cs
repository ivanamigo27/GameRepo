using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDoor : MonoBehaviour
{
   [SerializeField] private Key.KeyType keyType;

   public Key.KeyType GetKeyType()
   {
       return keyType;
   }

   public void OpenDoor1()
   {
       SceneManager.LoadScene(2);
   }

   
   public void OpenDoor2() 
   {
        SceneManager.LoadScene(3);
   }
}
