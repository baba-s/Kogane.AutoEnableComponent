using UnityEngine;

namespace Kogane.Internal
{
    [DefaultExecutionOrder( -1000 )]
    internal sealed class AutoEnableComponent : MonoBehaviour
    {
        [SerializeField]                  private MonoBehaviour m_monoBehaviour;
        [SerializeField][HideInInspector] private bool          m_isExecuted;

        private void Awake()
        {
            if ( m_isExecuted ) return;
            m_monoBehaviour.enabled = true;
            m_isExecuted            = true;
        }
    }
}