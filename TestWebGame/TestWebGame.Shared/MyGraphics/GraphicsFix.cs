using System;
using System.Collections.Generic;
using System.Text;

namespace TestWebGame.MyGraphics
{
    public class GraphicsFix
    {
        private readonly object _resourcesLock = new object();

        private readonly List<WeakReference> _resources = new List<WeakReference>();
        internal void AddResourceReference(WeakReference resourceReference)
        {
            lock (_resourcesLock)
            {
                _resources.Add(resourceReference);
            }
        }

        internal void RemoveResourceReference(WeakReference resourceReference)
        {
            lock (_resourcesLock)
            {
                _resources.Remove(resourceReference);
            }
        }
    }
}
