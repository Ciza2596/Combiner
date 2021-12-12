
namespace CizaTool2D.Combiner.Attribute
{
    public class InsideInjectAttribute : System.Attribute
    {
        public string GameObjectName { get; }

        public InsideInjectAttribute(string gameObjectName) {
            GameObjectName = gameObjectName;
        }
    }
}
