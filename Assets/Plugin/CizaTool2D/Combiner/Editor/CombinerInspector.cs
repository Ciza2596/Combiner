

using UnityEditor;
using UnityEngine;

namespace CizaTool2D.Combiner.Editor
{
    [CustomEditor(typeof(Combiner))]
    public class CombinerInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI() {
            DrawDefaultInspector();

            var combiner = (Combiner) target;
            
            if(GUILayout.Button("Create"))
                combiner.Create();
        }
    }
}
