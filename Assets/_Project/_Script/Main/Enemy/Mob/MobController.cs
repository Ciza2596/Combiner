using CizaTool2D.Combiner.Attribute;
using UnityEngine;

namespace Main.Enemy.Mob{

      public class MobController : MonoBehaviour
      {
          [SerializeField] 
          private OSData.MobOSData _osData;
          
          [SerializeField]
          private Animator _animator;

          [SerializeField] 
          [InsideInject("Skin")]
          private GameObject _skin;
      }
}
