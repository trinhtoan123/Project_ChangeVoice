using Base.DesignPattern.Interface;
using UnityEngine;

namespace Base.DesignPattern
{
    public class GenericPoolableObject : MonoBehaviour, IPoolable
    {
        // Pool to return object
        public IObjectPool Origin { get; set; }
        /// <summary>
        /// Prepares instance to use.
        /// </summary>
        public virtual void PrepareToUse()
        {
            // prepare object for use
            // you can add additional code here if you want to.
        }
        /// <summary>
        /// Returns instance to pool.
        /// </summary>
        public virtual void ReturnToPool()
        {
            // prepare object for return.
            // you can add additional code here if you want to.
            if (Origin != null)
                Origin.ReturnToPool(this);
        }
    }
}