using SpaceDefence.Collision;

namespace SpaceDefence;

interface IHasCollision
{
    public Collider collider { get; set; }
    public CollisionType CollisionType { get; set; }
}
