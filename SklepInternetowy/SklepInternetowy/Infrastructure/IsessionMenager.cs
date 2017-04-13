namespace SklepInternetowy.Infrastructure
{
    public interface IsessionMenager
    {
        T Get<T>(string key);
        void Set<T>(string name, T value);
        void Abandon();
        T TryGet<T>(string key);
    }
}
