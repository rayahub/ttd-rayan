using UnityEditor;
using UnityEngine;

public class MainTower : MonoBehaviour
{
    public int health = 100;
   
    
    public void getDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
         
            
          Destroy(gameObject);


#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#endif

        }


    }
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
