namespace Scenario2_4
{
    public delegate void SampleDelegate();
    public interface ISampleEvents
    {
        event SampleDelegate SampleEvent;
        void Invoke();
    }
    public class SampleClass : ISampleEvents
    {
        public event SampleDelegate SampleEvent;

        public void Invoke()
        {
            if (SampleEvent != null)
            {
                SampleEvent();
            }
        }
    }
}