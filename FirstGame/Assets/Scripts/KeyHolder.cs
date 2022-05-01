using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyHolder : MonoBehaviour
{
    private List<Key.KeyType> keyList;

    private void Awake() 
    {
        keyList = new List<Key.KeyType>();
    }

    public void AddKey(Key.KeyType keyType)
    {
        Debug.Log("Added Key " + keyType);
        keyList.Add(keyType);
    }

    public void RemoveKey(Key.KeyType keyType)
    {
        keyList.Remove(keyType);
    }

    public bool ContainsKey(Key.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }


    private void OnTriggerEnter2D(Collider2D collider) {
        Key key = collider.GetComponent<Key>();
        if (key != null) {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }

        KeyDoor keyDoor = collider.GetComponent<KeyDoor>();
        if (keyDoor != null) 
        {
            if (ContainsKey(keyDoor.GetKeyType()) && SceneManager.GetActiveScene().buildIndex == 2) 
            {
                RemoveKey(keyDoor.GetKeyType());
                keyDoor.OpenDoor2();
            }

            if (ContainsKey(keyDoor.GetKeyType()) && SceneManager.GetActiveScene().buildIndex == 1) 
            {
                RemoveKey(keyDoor.GetKeyType());
                keyDoor.OpenDoor1();
            }
        }

        
    }
}
