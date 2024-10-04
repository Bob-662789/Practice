using UnityEngine;

public class Player_Collision : MonoBehaviour
{
   public Audio_Manager audioManager;

    void OnCollisionEnter(Collision collisionInfo)
   {
     if (collisionInfo.collider.tag == "Obstacle")
     {
      //   audioSource.PlayOneShot();
      audioManager.PlaySFX(audioManager.collision);
     }
   }
}
