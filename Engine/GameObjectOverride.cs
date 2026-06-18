using Microsoft.Xna.Framework;
using SpaceDefence.Collision;

namespace SpaceDefence;

public class GameObjectOverride : GameObject, IHasCollision
{
    public Collider collider { get; set; }
    public CollisionType CollisionType { get; set; }

    /// <summary>
    /// Used to set the collider used for object collision.
    /// </summary>
    /// <param name="collider"> The collider to be used. </param>
    public void SetCollider(Collider collider)
    {
        this.collider = collider;
    }

    /// <summary>
    /// Checks if this GameObject collides with the other GameObject
    /// </summary>
    /// <param name="other"> The GameObject to check collision with. </param>
    /// <returns></returns>
    public bool CheckCollision(GameObjectOverride other)
    {
        if (collider == null)
            return false;
        return collider.CheckIntersection(other.collider);
    }

    /// <summary>
    /// Override this if you want the GameObject to respond to collision events.
    /// Keep in mind that OnCollision will be called once on both Objects.
    /// </summary>
    /// <param name="other"> The GameObject with which it collided. </param>
    public virtual void OnCollision(GameObjectOverride other) { }

    public Rectangle GetPosition()
    {
        return collider.GetBoundingBox();
    }
}
