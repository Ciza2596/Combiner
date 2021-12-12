
using System.Collections.Generic;
using UnityEngine;
using CizaTool2D.Combiner.Data;


namespace CizaTool2D.Combiner
{
    [CreateAssetMenu(fileName = "New Combiner", menuName = "CizaTool/Combiner/Combiner")]
    public class Combiner : ScriptableObject
    {

        [SerializeField] private List<OutsideDataArchitecture> _dataList;
        [Space]
        [SerializeField] private BodyArchitecture _body;

        private BaseCombiner _baseCombiner;

        public void Create() {
            if(_baseCombiner == null)
                _baseCombiner = new BaseCombiner();

            foreach(var data in _dataList){
                _baseCombiner.Create(data, _body);
            }
        }
    }
}
