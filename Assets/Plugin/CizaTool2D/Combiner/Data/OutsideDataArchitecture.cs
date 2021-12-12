using System.Collections.Generic;
using UnityEngine;


namespace CizaTool2D.Combiner.Data
{
    [CreateAssetMenu(fileName = "New OutsideDataArchitecture", menuName = "CizaTool/Combiner/OutsideDataArchitecture")]
    public class OutsideDataArchitecture : ScriptableObject
    {
        public string                 Name;
        public string                 SavePath;
        public List<Base.OutsideData> OutsideDataList;
    }
}
