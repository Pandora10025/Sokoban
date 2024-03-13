
using UnityEngine;

public abstract class BaseState 
{
   public abstract void Movement();
   public abstract void UpdateState();

   public abstract void DetectWall();

    public abstract void DetectSticky();

    public abstract void DetectClingy();

    public abstract void DetectSlick();
}
