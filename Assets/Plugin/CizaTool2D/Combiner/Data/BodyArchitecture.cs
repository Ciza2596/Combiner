using System.Collections.Generic;
using UnityEngine;


namespace CizaTool2D.Combiner.Data
{
    [CreateAssetMenu(fileName = "New BodyArchitecture", menuName = "CizaTool/Combiner/BodyArchitecture")]
    public class BodyArchitecture : ScriptableObject
    {
        public GameObject                   BaseArchitecture;
        public List<Base.AddComponentNames> AddComponentNamesList;
    }
}