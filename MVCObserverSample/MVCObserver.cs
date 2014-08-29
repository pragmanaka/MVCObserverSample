using System;
using System.Collections.Generic;

namespace MVCObserverSample
{
    public abstract class MVCObserver
    {
        public virtual void Init() { }
        public abstract void Update();
    }

    public class MVCSubject
    {
        private List<MVCObserver> m_Observers = new List<MVCObserver>();

        public void Attach(MVCObserver value)
        {
            m_Observers.Add(value);
        }

        public bool Detach(MVCObserver value)
        {
            return m_Observers.Remove(value);
        }

        public void DetachAll()
        {
            m_Observers.Clear();
        }

        protected enum NotifyType
        {
            NT_UPDATE,
            NT_INIT,
        };

        // オブザーバーにイベント発行
        protected virtual void Notify(NotifyType tyep)
        {
            foreach (MVCObserver observer in m_Observers)
            {
                if (observer == null)
                    continue;

                if (NotifyType.NT_UPDATE == tyep)
                    observer.Update();
                else if (NotifyType.NT_INIT == tyep)
                    observer.Init();
            }
        }

    }
}
