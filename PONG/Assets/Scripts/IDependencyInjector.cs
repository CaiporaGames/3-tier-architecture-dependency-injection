public interface IDependencyInjector
{
   public delegate IInjectable Inject();
   public static Inject inject;
}
