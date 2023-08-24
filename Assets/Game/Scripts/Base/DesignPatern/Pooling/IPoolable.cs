namespace Base.DesignPattern.Interface
{
    public interface IPoolable
    {
        IObjectPool Origin { get; set; }
        void PrepareToUse();
        void ReturnToPool();
    }
}